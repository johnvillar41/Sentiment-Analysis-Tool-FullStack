#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb72abe24d2c062019342ba31b277157618df492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Records__RecordDisplayPartial), @"mvc.1.0.view", @"/Views/Records/_RecordDisplayPartial.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
using SentimentAnalysisTool.Web.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
using SentimentAnalysisTool.Web.Models.CommentViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb72abe24d2c062019342ba31b277157618df492", @"/Views/Records/_RecordDisplayPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Records__RecordDisplayPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SentimentAnalysisTool.Web.Models.RecordDisplayViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-6\">\r\n    <div class=\"card shadow-sm card-height d-flex\">\r\n        <div class=\"card-header\">\r\n            <b>Comments</b> <i class=\"fas fa-comments\"></i><br />\r\n            Total number of rows: ");
#nullable restore
#line 8 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                             Write(Model.TotalNumberOfCommentRows);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n            Total number of accepted rows: ");
#nullable restore
#line 9 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                                      Write(Model.TotalNumberOfAcceptedCommentRows);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-body align-items-center d-flex justify-content-center\">\r\n");
#nullable restore
#line 12 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
             if (Model.Algorithmn == AlgorithmnType.Vader)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
           Write(await Html.PartialAsync("_CommentsPartial", (List<CommentVaderViewModel>)Model.CommentVaderViewModels.ToList()));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                                                                                                                                
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
             if (Model.Algorithmn == AlgorithmnType.SentiWordNet)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
           Write(await Html.PartialAsync("_CommentsPartial", (List<CommentSentiWordNetViewModel>)Model.CommentSentiwordModels.ToList()));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                                                                                                                                       
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
             if (Model.Algorithmn == AlgorithmnType.Hybrid)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
           Write(await Html.PartialAsync("_CommentsPartial", (List<CommentHybridViewModel>)Model.CommentHybridViewModels.ToList()));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                                                                                                                                  ;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
             if (Model.Algorithmn == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <lottie-player src=\"https://assets8.lottiefiles.com/packages/lf20_oga1x3jk.json\" background=\"transparent\" speed=\"1\" style=\"width: 600px; height: 600px;\" loop autoplay></lottie-player>\r\n");
#nullable restore
#line 27 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<div class=""col-6"">
    <div class=""row"">
        <div class=""col-6"">
            <div class=""card mb-2 shadow-sm card-chart-height d-flex"">
                <div class=""card-header"">
                    <b>Word Frequencies</b> <i class=""fas fa-wave-square""></i>
                </div>
                <div class=""card-body align-items-center d-flex justify-content-center"">
");
#nullable restore
#line 39 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                     if (Model.WordFrequencyViewModels == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <lottie-player src=\"https://assets8.lottiefiles.com/packages/lf20_oga1x3jk.json\" background=\"transparent\" speed=\"1\" style=\"width: 300px; height: 300px;\" loop autoplay></lottie-player>\r\n");
#nullable restore
#line 42 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                   Write(await Html.PartialAsync("_WordFrequencyPartial", Model.WordFrequencyViewModels));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                                                                                                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>

        <div class=""col-6"">
            <div class=""card mb-2 shadow-sm card-chart-height d-flex"">
                <div class=""card-header"">
                    <b>Review Classification</b> <i class=""fas fa-percentage""></i>
                </div>
                <div class=""card-body align-items-center d-flex justify-content-center"">
");
#nullable restore
#line 57 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                     if (Model.ReviewClassification == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <lottie-player src=\"https://assets8.lottiefiles.com/packages/lf20_oga1x3jk.json\" background=\"transparent\" speed=\"1\" style=\"width: 300px; height: 300px;\" loop autoplay></lottie-player>\r\n");
#nullable restore
#line 60 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                   Write(await Html.PartialAsync("_ReviewClassificationPartial", Model.ReviewClassification));

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                                                                                                            
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-6"">
            <div class=""card mb-2 shadow-sm card-chart-height"">
                <div class=""card-header"">
                    <b>Sentiment over time</b>
                </div>
                <div class=""card-body align-items-center d-flex justify-content-center"">
                    This is some text within a card body.
                </div>
            </div>
        </div>

        <div class=""col-6"">
            <div class=""card mb-2 shadow-sm card-chart-height"">
                <div class=""card-header"">
                    <b>Keyword cloud</b>
                </div>
                <div class=""card-body align-items-center d-flex justify-content-center"">
                    <div id=""keyword-container""></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card mb-2 s");
            WriteLiteral(@"hadow-sm card-chart-height-2"">
                <div class=""card-header"">
                    <b>TextProcessing</b> <i class=""fas fa-keyboard""></i>
                </div>
                <div class=""card-body align-items-center d-flex justify-content-center"">
");
#nullable restore
#line 99 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                     if (Model.CommentTransformViewModels == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <lottie-player src=\"https://assets8.lottiefiles.com/packages/lf20_oga1x3jk.json\" background=\"transparent\" speed=\"1\" style=\"width: 400px; height: 300px;\" loop autoplay></lottie-player>\r\n");
#nullable restore
#line 102 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                   Write(await Html.PartialAsync("_CommentsTransformPartial", Model.CommentTransformViewModels));

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_RecordDisplayPartial.cshtml"
                                                                                                               
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
