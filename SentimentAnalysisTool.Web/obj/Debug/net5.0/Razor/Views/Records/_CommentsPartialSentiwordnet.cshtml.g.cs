#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68beca536e7d8696887bf6307b57552cdd5ea570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Records__CommentsPartialSentiwordnet), @"mvc.1.0.view", @"/Views/Records/_CommentsPartialSentiwordnet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68beca536e7d8696887bf6307b57552cdd5ea570", @"/Views/Records/_CommentsPartialSentiwordnet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Records__CommentsPartialSentiwordnet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SentimentAnalysisTool.Web.Models.CommentViewModels.CommentSentiWordNetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
  
    bool isModelEmpty = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
 if (Model.Count == 0)
{
    isModelEmpty = true;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card shadow-sm card-height\">\r\n    <div class=\"card-header\">\r\n        Comments <br />\r\n");
#nullable restore
#line 12 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
         if (isModelEmpty)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Showing empty results</p>\r\n");
#nullable restore
#line 15 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Showing ");
#nullable restore
#line 18 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                  Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" results</p>\r\n");
#nullable restore
#line 19 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 22 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
         if (isModelEmpty)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No results found!</p>\r\n");
#nullable restore
#line 25 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-responsive table-height table-hover"">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">Comment Id</th>
                        <th scope=""col"">Comment </th>
                        <th scope=""col"">Score </th>
                        <th scope=""col"">Sentiment </th>
                        <th scope=""col"">Date </th>
                        <th scope=""col"">Action </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 40 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 43 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                       Write(Model[i].CommentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 44 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                           Write(Model[i].CommentDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                             if (Model[i].CommentScore >= 1 && Model[i].CommentScore <= 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"badge badge-pill badge-danger\">");
#nullable restore
#line 47 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                                           Write(Model[i].CommentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</span></td>\r\n");
#nullable restore
#line 48 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                            }
                            else if (Model[i].CommentScore >= 4 && Model[i].CommentScore <= 5)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"badge badge-pill badge-success\">");
#nullable restore
#line 51 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                                            Write(Model[i].CommentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</span></td>\r\n");
#nullable restore
#line 52 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"badge badge-pill badge-dark\">");
#nullable restore
#line 55 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                                         Write(Model[i].CommentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</span></td>\r\n");
#nullable restore
#line 56 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                             if (Model[i].CommentPolarity == SentimentAnalysisTool.Web.Enums.SentimentType.Positive)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"badge badge-success\">");
#nullable restore
#line 60 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                                 Write(Model[i].CommentPolarity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 61 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                            }
                            else if (Model[i].CommentPolarity == SentimentAnalysisTool.Web.Enums.SentimentType.Negative)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"badge badge-danger\">");
#nullable restore
#line 64 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                                Write(Model[i].CommentPolarity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 65 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"badge badge-dark\">");
#nullable restore
#line 68 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                              Write(Model[i].CommentPolarity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 69 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td>");
#nullable restore
#line 71 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                           Write(Model[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <!-- Button trigger modal -->\r\n                                <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#resultModal_");
#nullable restore
#line 74 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    View computed results
                                </button>
                            </td>
                        </tr>
                        <!-- Modal -->
                        <div class=""modal fade""");
            BeginWriteAttribute("id", " id=\"", 3507, "\"", 3526, 2);
            WriteAttributeValue("", 3512, "resultModal_", 3512, 12, true);
#nullable restore
#line 80 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
WriteAttributeValue("", 3524, i, 3524, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title"" id=""exampleModalLabel"">SentiWordNet Computed Results</h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    <div class=""modal-body"">
                                        <p><b>Negative Score: </b>");
#nullable restore
#line 90 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                             Write(Model[i].SentiWordNetGrade.NegativeScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p><b>Polarity Score: </b>");
#nullable restore
#line 91 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                             Write(Model[i].SentiWordNetGrade.PolarityScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p><b>Positive Score: </b>");
#nullable restore
#line 92 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                             Write(Model[i].SentiWordNetGrade.PositiveScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p><b>Sentiment Score: </b>");
#nullable restore
#line 93 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                              Write(Model[i].SentiWordNetGrade.SentimentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 101 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
            <nav aria-label=""Page navigation example"">
                <ul class=""pagination"">
                    <li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
                </ul>
            </nav>
");
#nullable restore
#line 113 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SentimentAnalysisTool.Web.Models.CommentViewModels.CommentSentiWordNetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
