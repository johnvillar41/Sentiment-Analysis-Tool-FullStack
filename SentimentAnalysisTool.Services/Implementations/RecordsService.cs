﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Implementations
{
    public class RecordsService : IRecordsService
    {
        private readonly HttpClient _httpClient;
        public RecordsService()
        {
            _httpClient = new HttpClient();
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
                return jsonModel;
            }
            catch (HttpRequestException)
            {
                throw new HttpRequestException("Not connected from server!");
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
                form.Add(new StringContent(file.Algorithmn), "\"algorithmn\"");
                form.Add(new StringContent(file.ShouldConvertAbbreviations.ToString()), "\"shouldConvertAbbreviations\"");
                form.Add(new StringContent(file.CorpusType.ToString()), "\"corpusType\"");
                form.Add(new StringContent(file.MaxNumberOfChars.ToString()), "\"maxNumberOfChars\"");
                return form;
            });

            return task;
        }
    }
}
