#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d019c5398a9c5e51409b58d7d82fd997addd5302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Records__UploadFileFormPartial), @"mvc.1.0.view", @"/Views/Records/_UploadFileFormPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\_ViewImports.cshtml"
using SentimentAnalysisTool.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\_ViewImports.cshtml"
using SentimentAnalysisTool.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d019c5398a9c5e51409b58d7d82fd997addd5302", @"/Views/Records/_UploadFileFormPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Records__UploadFileFormPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formUpload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""upload-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel""><b>File Upload</b></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d019c5398a9c5e51409b58d7d82fd997addd53025051", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" name=""file"" id=""customfile"" required />
                            <label class=""custom-file-label"" for=""customfile"">Choose file</label>
                        </div>
                    </div>
                    <hr />
                    <h6><b>Select Algorithmn</b></h6>
                    <div class=""form-check form-check-inline mt-2"">
                        <input class=""form-check-input"" type=""radio"" name=""algorithmnType""");
                BeginWriteAttribute("value", " value=\"", 1277, "\"", 1339, 1);
#nullable restore
#line 21 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml"
WriteAttributeValue("", 1285, SentimentAnalysisTool.Web.Enums.AlgorithmnType.Hybrid, 1285, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        <label class=\"form-check-label\">");
#nullable restore
#line 22 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml"
                                                   Write(nameof(SentimentAnalysisTool.Web.Enums.AlgorithmnType.Hybrid));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"form-check form-check-inline\">\r\n                        <input class=\"form-check-input\" type=\"radio\" name=\"algorithmnType\"");
                BeginWriteAttribute("value", " value=\"", 1662, "\"", 1730, 1);
#nullable restore
#line 25 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml"
WriteAttributeValue("", 1670, SentimentAnalysisTool.Web.Enums.AlgorithmnType.SentiWordNet, 1670, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        <label class=\"form-check-label\">");
#nullable restore
#line 26 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml"
                                                   Write(nameof(SentimentAnalysisTool.Web.Enums.AlgorithmnType.SentiWordNet));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"form-check form-check-inline\">\r\n                        <input class=\"form-check-input\" type=\"radio\" name=\"algorithmnType\"");
                BeginWriteAttribute("value", " value=\"", 2059, "\"", 2120, 1);
#nullable restore
#line 29 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml"
WriteAttributeValue("", 2067, SentimentAnalysisTool.Web.Enums.AlgorithmnType.Vader, 2067, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        <label class=\"form-check-label\">");
#nullable restore
#line 30 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml"
                                                   Write(nameof(SentimentAnalysisTool.Web.Enums.AlgorithmnType.Vader));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                    </div>
                    <hr />
                    <h6><b>Select CorpusType</b></h6>
                    <div class=""row"">
                        <div class=""col-6"">
                            <input type=""text"" class=""form-control"" id=""corpus-type"" name=""corpusType"" readonly value=""FilmReview"" required />
                        </div>
                        <div class=""col-6"">
                            <div class=""dropdown mb-1"">
                                <button class=""btn btn-secondary dropdown-toggle btn-block"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    CorpusType
                                </button>
                                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                    <a class=""dropdown-item"" id=""drop-down-env"">");
#nullable restore
#line 44 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml"
                                                                           Write(nameof(SentimentAnalysisTool.Web.Enums.DataCorpusType.EnvironmentReview));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                    <a class=\"dropdown-item\" id=\"drop-down-film\">");
#nullable restore
#line 45 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml"
                                                                            Write(nameof(SentimentAnalysisTool.Web.Enums.DataCorpusType.FilmReview));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                    <a class=\"dropdown-item\" id=\"drop-down-prod\">");
#nullable restore
#line 46 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_UploadFileFormPartial.cshtml"
                                                                            Write(nameof(SentimentAnalysisTool.Web.Enums.DataCorpusType.ProductReview));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <hr />
                    <h6><b>Select Preprocessing techniques</b></h6>
                    <p>Delete Slang Words? </p>
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""shouldDeleteSlangs"" value=""true"" required>
                        <label class=""form-check-label"">True</label>
                    </div>
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""shouldDeleteSlangs"" value=""false"" required>
                        <label class=""form-check-label"">False</label>
                    </div>
                    <p class=""mt-3"">Convert Abbreviations? </p>
                    <div class=""form-check form-check-inline"">
                        <input class=""form-");
                WriteLiteral(@"check-input"" type=""radio"" name=""shouldConvertAbbreviations"" value=""true"" required>
                        <label class=""form-check-label"">True</label>
                    </div>
                    <div class=""form-check form-check-inline"">
                        <input class=""form-check-input"" type=""radio"" name=""shouldConvertAbbreviations"" value=""false"" required>
                        <label class=""form-check-label"">False</label>
                    </div>
                    <p class=""mt-3"">Maximum number of characters</p>
                    <input type=""number"" class=""form-control"" name=""maxNumberOfChars"" min=""1"" max=""250"" value=""250"" required/>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close <i class=""fas fa-times-circle""></i></button>
                <button type=""submit"" id=""formFileSubmit"" class=""btn btn-dark"" form=""formUpload"">Upload File <i class=""fas fa-file-upload""></i></button>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
