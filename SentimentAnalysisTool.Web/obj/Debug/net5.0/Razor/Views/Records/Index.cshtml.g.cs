#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a83e24a202ea8844233d76aa994afb57cfd13d97"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83e24a202ea8844233d76aa994afb57cfd13d97", @"/Views/Records/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Records_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SentimentAnalysisTool.Web.Models.CommentViewModels.UploadCsvCommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Records", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadCsvFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#commentsPartial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-loading", new global::Microsoft.AspNetCore.Html.HtmlString("#spinner-upload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("promptNoNetwork"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card mb-2 shadow-sm\">\r\n            <div class=\"card-body\">\r\n\r\n                <div class=\"row\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a83e24a202ea8844233d76aa994afb57cfd13d976681", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <div class=""custom-file"">
                                <input type=""file"" class=""custom-file-input"" name=""file"" id=""customfile"" required />
                                <label class=""custom-file-label"" for=""customfile"">Choose file</label>
                            </div>
                        </div>
                        <div class=""form-check form-check-inline mt-2"">
                            <input class=""form-check-input"" type=""radio"" name=""algorithmnType""");
                BeginWriteAttribute("value", " value=\"", 1219, "\"", 1281, 1);
#nullable restore
#line 22 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
WriteAttributeValue("", 1227, SentimentAnalysisTool.Web.Enums.AlgorithmnType.Hybrid, 1227, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <label class=\"form-check-label\">");
#nullable restore
#line 23 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
                                                       Write(nameof(SentimentAnalysisTool.Web.Enums.AlgorithmnType.Hybrid));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"form-check form-check-inline\">\r\n                            <input class=\"form-check-input\" type=\"radio\" name=\"algorithmnType\"");
                BeginWriteAttribute("value", " value=\"", 1611, "\"", 1679, 1);
#nullable restore
#line 26 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
WriteAttributeValue("", 1619, SentimentAnalysisTool.Web.Enums.AlgorithmnType.SentiWordNet, 1619, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <label class=\"form-check-label\">");
#nullable restore
#line 27 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
                                                       Write(nameof(SentimentAnalysisTool.Web.Enums.AlgorithmnType.SentiWordNet));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"form-check form-check-inline\">\r\n                            <input class=\"form-check-input\" type=\"radio\" name=\"algorithmnType\"");
                BeginWriteAttribute("value", " value=\"", 2015, "\"", 2076, 1);
#nullable restore
#line 30 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
WriteAttributeValue("", 2023, SentimentAnalysisTool.Web.Enums.AlgorithmnType.Vader, 2023, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <label class=\"form-check-label\">");
#nullable restore
#line 31 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
                                                       Write(nameof(SentimentAnalysisTool.Web.Enums.AlgorithmnType.Vader));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        </div>\r\n\r\n                        <input id=\"formSubmit\" type=\"submit\" class=\"btn btn-dark\" value=\"Submit file\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""spinner-border ml-1 mt-1"" role=""status"" id=""spinner-upload"" style=""display:none;"">
                        <span class=""sr-only"">Loading...</span>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""alert alert-danger"" id=""warningMessage"" role=""alert"" style=""display:none;"">
                        Please upload csv files only
                    </div>
                    <div class=""alert alert-warning"" id=""errorNetwork"" role=""alert"" style=""display:none;"">
                        No network connection! Please try again later.
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-6"">
        <div class=""card shadow-sm card-height"">
            <div class=""card-header"">
                Comments <br />
            </div>
            <div class=""card-body"" id=""commentsPartial"">
");
#nullable restore
#line 59 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
                 if (Model.Hybrid == null || Model.SentiWordNet == null || Model.Vader == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>No results found!</p>\r\n");
#nullable restore
#line 62 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
               Write(await Html.PartialAsync("_CommentsPartialVader", Model.Vader));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
               Write(await Html.PartialAsync("_CommentsPartialSentiwordnet", Model.SentiWordNet));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
               Write(await Html.PartialAsync("_CommentsPartialHybrid", Model.Hybrid));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\Index.cshtml"
                                                                                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""col-6"">
        <div class=""row"">
            <div class=""col-6"">
                <div class=""card mb-2 shadow-sm card-chart-height"">
                    <div class=""card-body"">
                        This is some text within a card body.
                    </div>
                </div>
            </div>

            <div class=""col-6"">
                <div class=""card mb-2 shadow-sm card-chart-height"">
                    <div class=""card-body"">
                        This is some text within a card body.
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-6"">
                <div class=""card mb-2 shadow-sm card-chart-height"">
                    <div class=""card-body"">
                        This is some text within a card body.
                    </div>
                </div>
            </div>

            <div class=""col-6"">");
            WriteLiteral(@"
                <div class=""card mb-2 shadow-sm card-chart-height"">
                    <div class=""card-body"">
                        This is some text within a card body.
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card mb-2 shadow-sm card-chart-height-2"">
                    <div class=""card-body"">
                        This is some text within a card body.
                    </div>
                </div>
            </div>
        </div>
    </div>

</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#customfile').on('change', function () {
            console.log(""I am inside upload event"");
            files = $(this)[0].files;
            name = '';
            for (var i = 0; i < files.length; i++) {
                name += '\""' + files[i].name + '\""' + (i != files.length - 1 ? "", "" : """");
            }
            $("".custom-file-label"").html(name);
        });
        $('#customfile').change(function () {
            var fileExtension = ['xlsx', 'csv'];
            if ($.inArray($(this).val().split('.').pop().toLowerCase(), fileExtension) == -1) {
                $('#warningMessage').show();
                $('#customfile').val("""");
            } else {
                $('#warningMessage').hide();
            }
        });
        promptNoNetwork = function () {
            $('errorNetwork').show();
        }
    </script>    
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SentimentAnalysisTool.Web.Models.CommentViewModels.UploadCsvCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
