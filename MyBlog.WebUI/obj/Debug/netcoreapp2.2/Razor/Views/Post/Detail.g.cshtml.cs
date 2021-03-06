#pragma checksum "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12b95f1dec8c610d06ed5fc8fefc56f52d37202d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Detail), @"mvc.1.0.view", @"/Views/Post/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Detail.cshtml", typeof(AspNetCore.Views_Post_Detail))]
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
#line 1 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\_ViewImports.cshtml"
using MyBlog.WebUI;

#line default
#line hidden
#line 2 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\_ViewImports.cshtml"
using MyBlog.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b95f1dec8c610d06ed5fc8fefc56f52d37202d", @"/Views/Post/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b96df1fe9848f97de6cba257787bbb9d8b29c26", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.DataAccess.ViewModels.PostViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(93, 96, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(190, 43, false);
#line 10 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
       Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
            EndContext();
            BeginContext(233, 200, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"row\">\r\n                <div class=\"card text-center\">\r\n                    <div class=\"card-header\">\r\n                        ");
            EndContext();
            BeginContext(434, 19, false);
#line 16 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
                   Write(Model.PostDto.Title);

#line default
#line hidden
            EndContext();
            BeginContext(453, 103, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 556, "\"", 584, 1);
#line 19 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
WriteAttributeValue("", 562, Model.PostDto.Picture, 562, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(585, 63, true);
            WriteLiteral(" width=\"100%\" />\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(649, 21, false);
#line 20 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
                                        Write(Model.PostDto.Content);

#line default
#line hidden
            EndContext();
            BeginContext(670, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
                          
                            var timeSpan = (DateTime.Now - Model.PostDto.CreationDate);
                            int day = timeSpan.Days;
                            int hours = timeSpan.Hours;
                            int minutes = timeSpan.Minutes;

                        

#line default
#line hidden
            BeginContext(994, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1021, 3, false);
#line 29 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
                   Write(day);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 7, true);
            WriteLiteral(" gün - ");
            EndContext();
            BeginContext(1032, 5, false);
#line 29 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
                              Write(hours);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 8, true);
            WriteLiteral(" saat - ");
            EndContext();
            BeginContext(1046, 7, false);
#line 29 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
                                            Write(minutes);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 217, true);
            WriteLiteral(" dakika önce eklendi.\r\n                    </div>\r\n                    <hr />\r\n                    <div class=\"text-left\" style=\"margin-left:20px;\">\r\n                        <h3>Yorumlar</h3>\r\n                        ");
            EndContext();
            BeginContext(1271, 73, false);
#line 34 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Post\Detail.cshtml"
                   Write(await Component.InvokeAsync("Comment", new { postId = Model.PostDto.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 120, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.DataAccess.ViewModels.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
