#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f53ba934c478ec058ed7279e389f387e8396dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Records_Index), @"mvc.1.0.view", @"/Views/Records/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f53ba934c478ec058ed7279e389f387e8396dd8", @"/Views/Records/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Records_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SentimentAnalysisTool.Web.Models.RecordDisplayViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/records-index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card mb-2 shadow-sm"">
            <div class=""card-header"">
                Settings
            </div>
            <div class=""card-body"">
                <div class=""d-flex"">
                    <div class=""mr-auto"">
                        <button type=""button"" class=""btn btn-dark"" data-toggle=""modal"" data-target=""#upload-modal"">
                            Upload File <i class=""fas fa-paper-plane""></i>
                        </button>
                    </div>
                    <div class=""ml-auto"">
                        <button type=""button"" id=""btnConfusionMatrixProcess"" class=""btn btn-dark"" style=""display:none;"" data-toggle=""modal"">
                            Confusion Matrix TextProcessing <i class=""fas fa-robot""></i>
                        </button>
                        <button type=""button"" id=""btnConfusionMatrixAlgo"" class=""btn btn-dark"" style=""display:none;"" data-toggle=""modal"">
                          ");
            WriteLiteral(@"  Confusion Matrix Algorithmn <i class=""fas fa-robot""></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div id=""spinner-upload"" class=""overlayDiv"" style=""display:none;"">
    <lottie-player src=""https://assets6.lottiefiles.com/datafiles/bEYvzB8QfV3EM9a/data.json"" background=""transparent"" speed=""1"" style=""width: 300px; height: 300px;"" loop autoplay></lottie-player>
</div>
<div class=""row"" id=""record-display"">
    ");
#nullable restore
#line 33 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
Write(await Html.PartialAsync("_RecordDisplayPartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
Write(await Html.PartialAsync("_UploadFileFormPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('form#formUpload').submit(function (event) {
                event.preventDefault();
                var formData = new FormData(this);
                $.ajax({
                    type: 'POST',
                    url: '");
#nullable restore
#line 46 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
                     Write(Url.Action("UploadCsvFile","Records"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    data: formData,
                    beforeSend: function () {
                        $(""#upload-modal"").modal('hide');
                        $('#spinner-upload').show();
                    },
                    complete: function () {
                        $('#spinner-upload').hide();
                    },
                    contentType: false,
                    processData: false,
                    success: function (response) {
                        $(""#btnConfusionMatrixProcess"").show();
                        $(""#btnConfusionMatrixAlgo"").show();

                        promptHasNetwork(response);
                        $(""#btnConfusionMatrixProcess"").on(""click"", function () {
                            Swal.fire({
                                title: '<strong>Confusion Matrix</strong>',
                                icon: 'info',
                                html:
                                    '<b>Confusion Matrix results for Text");
                WriteLiteral(@"Processing</b> <br/>' +
                                    '<p>' + response.textProcessingConfusionMatrix + '</p>',
                                showCloseButton: true,
                                showCancelButton: true,
                                focusConfirm: false,
                                confirmButtonText:
                                    '<i class=""fa fa-thumbs-up""></i> Great!',
                                confirmButtonAriaLabel: 'Thumbs up, great!',
                                cancelButtonText:
                                    '<i class=""fa fa-thumbs-down""></i>',
                                cancelButtonAriaLabel: 'Thumbs down'
                            });
                        });
                        $(""#btnConfusionMatrixAlgo"").on(""click"", function () {
                            Swal.fire({
                                title: '<strong>Confusion Matrix</strong>',
                                icon: 'info',
                           ");
                WriteLiteral(@"     html:
                                    '<b>Confusion Matrix results for TODO </b> <br/>' +
                                    '<p>' + response.algorithmnConfusionMatrix + '</p>',
                                showCloseButton: true,
                                showCancelButton: true,
                                focusConfirm: false,
                                confirmButtonText:
                                    '<i class=""fa fa-thumbs-up""></i> Great!',
                                confirmButtonAriaLabel: 'Thumbs up, great!',
                                cancelButtonText:
                                    '<i class=""fa fa-thumbs-down""></i>',
                                cancelButtonAriaLabel: 'Thumbs down'
                            });
                        });
                    },
                    error: function (response) { promptNoNetwork(response) },
                    failure: function (response) { promptNoNetwork(response) },
                ");
                WriteLiteral("}).done(function (response) {\r\n                    $(\'#record-display\').html(response.html);\r\n                    renderReviewClassification(response);\r\n                });\r\n            });\r\n        });\r\n\r\n\r\n\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f53ba934c478ec058ed7279e389f387e8396dd89977", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SentimentAnalysisTool.Web.Models.RecordDisplayViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
