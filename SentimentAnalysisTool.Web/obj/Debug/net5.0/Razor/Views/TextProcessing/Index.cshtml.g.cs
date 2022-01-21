#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d275ea928f07edf19561095b67e1b50a1f3a318b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TextProcessing_Index), @"mvc.1.0.view", @"/Views/TextProcessing/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d275ea928f07edf19561095b67e1b50a1f3a318b", @"/Views/TextProcessing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_TextProcessing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SentimentAnalysisTool.Web.Models.TextProcessingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card mb-2 shadow-sm"">
            <div class=""card-header"">
                Corpus Types
            </div>
            <div class=""card-body"">
                <div class=""d-flex"">
                    <div class=""mr-auto"">
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#upload-modal"">
                            Upload File <i class=""fas fa-paper-plane""></i>
                        </button>
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"">
                            Accuracy TextProcessing <i class=""fas fa-robot""></i>
                        </button>
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"">
                            Confusion Matrix Algorithmn <i class=""fas fa-robot""></i>
                        </button>
                    </div>
                </div>
            </di");
            WriteLiteral(@"v>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-12"">
        <div class=""card mb-2 shadow-sm"">
            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#slang"" role=""tab"" aria-selected=""true"">Slang Records</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#abbrevs"" role=""tab"" aria-selected=""false"">Abbreviations</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#corpus-words"" role=""tab"" aria-selected=""false"">Corpus</a>
                </li>
            </ul>
            <div class=""tab-content mt-1"" id=""myTabContent"">
                <div class=""tab-pane fade show active"" id=""slang"" role=""tabpanel"" aria-labelledby=""home-tab"">
                    <butt");
            WriteLiteral(@"on type=""button"" class=""btn btn-secondary mb-1"">Add Slang words <i class=""fas fa-plus-circle""></i></button>
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">CorpusType Id</th>
                                <th scope=""col"">SlangRecord Id</th>
                                <th scope=""col"">SlangWord</th>
                                <th scope=""col"">Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 54 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                             foreach (var item in Model.SlangRecords)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n");
#nullable restore
#line 57 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                     if (item.CorpusType != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 59 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                       Write(item.CorpusType.CorpusTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 60 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Not loaded</td>\r\n");
#nullable restore
#line 64 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 65 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                   Write(item.SlangRecordsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 66 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                   Write(item.SlangName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <button class=""btn btn-secondary"">Update</button>
                                        <button class=""btn btn-secondary"">Delete</button>
                                    </td>
                                </tr>
");
#nullable restore
#line 72 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <div class=""tab-pane fade"" id=""abbrevs"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                    <button type=""button"" class=""btn btn-secondary mb-1"">Add Abbreviations <i class=""fas fa-plus-circle""></i></button>
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">CorpusType Id</th>
                                <th scope=""col"">Abbreviation Id</th>
                                <th scope=""col"">Abbreviation</th>
                                <th scope=""col"">Abbreviation word</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 88 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                             foreach (var item in Model.Abbreviations)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n");
#nullable restore
#line 91 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                     if (item.CorpusType != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 93 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                       Write(item.CorpusType.CorpusTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 94 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Not loaded</td>\r\n");
#nullable restore
#line 98 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 99 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                   Write(item.AbbreviationsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 100 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                   Write(item.Abbreviation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 101 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                   Write(item.AbbreviationWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 103 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <div class=""tab-pane fade"" id=""corpus-words"" role=""tabpanel"" aria-labelledby=""home-tab"">
                    <button type=""button"" class=""btn btn-secondary mb-1"">Add Corpus words <i class=""fas fa-plus-circle""></i></button>
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">CorpusType Id</th>
                                <th scope=""col"">Corpus Word Id</th>
                                <th scope=""col"">Corpus Word</th>
                                <th scope=""col"">Synonym Word</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 119 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                             foreach (var item in Model.Corpuses)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n");
#nullable restore
#line 122 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                     if (item.CorpusType != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 124 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                       Write(item.CorpusType.CorpusTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 125 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Not loaded</td>\r\n");
#nullable restore
#line 129 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 130 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                   Write(item.CorpusWordId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 131 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                   Write(item.CorpusWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 132 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                                   Write(item.SynonymWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 134 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SentimentAnalysisTool.Web.Models.TextProcessingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
