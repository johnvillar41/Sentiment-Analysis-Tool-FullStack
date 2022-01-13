using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Implementations
{
    public class RecordsService : IRecordsService
    {
        private readonly HttpClient _httpClient;
        public RecordsService()
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromMinutes(15);
        }
        public async Task<RecordModel<T>> AddRecordAsync<T>(UploadCsvFileModel file, string baseUrl)
        {
            try
            {
                var form = await ParseFile(file);
                var genericType = typeof(T);
                HttpResponseMessage response = null;
                RecordModel<T> jsonModel = null;
                response = await _httpClient.PostAsync($"{baseUrl}/api/Records/Upload", form);
                response.EnsureSuccessStatusCode();
                jsonModel = await response.Content.ReadAsAsync<RecordModel<T>>();

                if (((List<CommentModel<T>>)jsonModel.CommentModels).Count == 0)
                {
                    throw new HttpRequestException("Empty results computed from file!");
                }

                return jsonModel;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<bool> DeleteRecordAsync(int recordId, string baseUrl)
        {
            var response = await _httpClient.DeleteAsync($"{baseUrl}/api/Records/{recordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<RecordModel<T>> FetchRecordsAsync<T>(int recordId, string baseUrl)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/api/Records/{recordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return await response.Content.ReadAsAsync<RecordModel<T>>();

            return null;
        }
        private async Task<MultipartFormDataContent> ParseFile(UploadCsvFileModel file)
        {
            var task = await Task.Run(() =>
            {
                _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
                var form = new MultipartFormDataContent();
                var ms = new MemoryStream();
                file.File.CopyTo(ms);
                var fileBytes = ms.ToArray();
                form.Add(new ByteArrayContent(fileBytes, 0, fileBytes.Length), "file", file.File.FileName);
                form.Add(new StringContent(file.ShouldDeleteSlangs.ToString()), "\"shouldDeleteSlangs\"");
                form.Add(new StringContent(file.Algorithmn.ToString()), "\"algorithmn\"");
                form.Add(new StringContent(file.ShouldConvertAbbreviations.ToString()), "\"shouldConvertAbbreviations\"");
                form.Add(new StringContent(file.ShouldConvertSynonyms.ToString()), "\"shouldConvertSynonyms\"");
                form.Add(new StringContent(file.CorpusType.ToString()), "\"corpusType\"");
                form.Add(new StringContent(file.MaxNumberOfChars.ToString()), "\"maxNumberOfChars\"");
                if (file.SubjectMatter == null)
                    file.SubjectMatter = string.Empty;
                form.Add(new StringContent(file.SubjectMatter), "\"subjectMatter\"");
                return form;
            });

            return task;
        }
    }
}
