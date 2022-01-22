#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b8f47a91486d8adb59a06f179090b263e388152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TextProcessing__CorpusDataPartial), @"mvc.1.0.view", @"/Views/TextProcessing/_CorpusDataPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8f47a91486d8adb59a06f179090b263e388152", @"/Views/TextProcessing/_CorpusDataPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_TextProcessing__CorpusDataPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SentimentAnalysisTool.Web.Models.TextProcessingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tab-content mt-1\" id=\"myTabContent\">\r\n    <div class=\"tab-pane fade show active\" id=\"slang\" role=\"tabpanel\" aria-labelledby=\"home-tab\">\r\n        ");
#nullable restore
#line 4 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
   Write(await Html.PartialAsync("_SlangRecordPartial", Model.SlangRecords));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
                    <th scope=""col"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                 foreach (var item in Model.Abbreviations)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 22 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                         if (item.CorpusType != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 24 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                           Write(item.CorpusType.CorpusTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 25 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Not loaded</td>\r\n");
#nullable restore
#line 29 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 30 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                       Write(item.AbbreviationsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                       Write(item.Abbreviation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                       Write(item.AbbreviationWord);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <button class=""btn btn-secondary"">Update <i class=""fas fa-edit""></i></button>
                            <button class=""btn btn-secondary"">Delete <i class=""fas fa-trash-alt""></i></button>
                        </td>
                    </tr>
");
#nullable restore
#line 38 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
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
                    <th scope=""col"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 55 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                 foreach (var item in Model.Corpuses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 58 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                         if (item.CorpusType != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 60 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                           Write(item.CorpusType.CorpusTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 61 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Not loaded</td>\r\n");
#nullable restore
#line 65 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 66 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                       Write(item.CorpusWordId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 67 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                       Write(item.CorpusWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 68 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                       Write(item.SynonymWord);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <button class=""btn btn-secondary"">Update <i class=""fas fa-edit""></i></button>
                            <button class=""btn btn-secondary"">Delete <i class=""fas fa-trash-alt""></i></button>
                        </td>
                    </tr>
");
#nullable restore
#line 74 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\_CorpusDataPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
