#pragma checksum "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\News\AllNewsByCategoryId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b48373e415882e60c28eafbb9b6ab74b22afdc2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_AllNewsByCategoryId), @"mvc.1.0.view", @"/Views/News/AllNewsByCategoryId.cshtml")]
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
#line 1 "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\_ViewImports.cshtml"
using NewsMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\_ViewImports.cshtml"
using NewsMvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\_ViewImports.cshtml"
using NewsMvc.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b48373e415882e60c28eafbb9b6ab74b22afdc2d", @"/Views/News/AllNewsByCategoryId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ecebe2843a820093814ecf3972dc68c4ba54cd", @"/Views/_ViewImports.cshtml")]
    public class Views_News_AllNewsByCategoryId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- <section id=""banner"">
    <div class=""container"">
        <div class=""banner3"">
            <a href=""#"">
                <img class=""max-w-full"" src=""assets/img/banner-03.jpg"" alt=""IMG"">
            </a>
        </div>
    </div>
</section> -->
<section id=""news-by-category"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10 col-lg-8"">
                <div class=""row"">
");
#nullable restore
#line 21 "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\News\AllNewsByCategoryId.cshtml"
                     foreach (var news in Model.News)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-6"">
                            <div class=""last-added-news"">
                                <div class=""news-item pos-relative"">
                                    <a href=""/news-detail.html"" class=""news-pic trans-03 shadow"">
                                        <!-- <span class=""dis-sub-item-tag"">Technology</span> -->
                                        <img");
            BeginWriteAttribute("src", " src=\"", 1078, "\"", 1106, 2);
            WriteAttributeValue("", 1084, "assets/img/", 1084, 11, true);
#nullable restore
#line 28 "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\News\AllNewsByCategoryId.cshtml"
WriteAttributeValue("", 1095, news.Photo, 1095, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""IMG"">
                                    </a>
                                    <div class=""p-t-15 news-title"">
                                        <span>
                                            <a href=""#"" class=""name trans-03"">
                                                By, Sahra
                                            </a>
                                            <span class=""f1-s-3 m-rl-3""> - </span>
                                            <span class=""f1-s-3""> 22 Jan, 2020</span>
                                        </span>
                                        <h5>
                                            <a href=""blog-detail-1.html"" class=""trans-03 news-title-a"">
                                                ");
#nullable restore
#line 40 "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\News\AllNewsByCategoryId.cshtml"
                                           Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </h5>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 47 "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\News\AllNewsByCategoryId.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
                <!-- Pagination -->
                <div class=""pagination"">
                    <a href=""#"" class=""flex-c-c page-item hov-btn1 trans-03"">
                        <i class=""fa fa-angle-left""></i>
                    </a>
                    <a href=""#"" class=""page-item trans-03 page-active"">1</a>
                    <a href=""#"" class=""page-item trans-03"">2</a>
                    <a href=""#"" class=""page-item trans-03"">3</a>
                    <a href=""#"" class=""page-item trans-03"">
                        <i class=""fa fa-angle-right""></i>
                    </a>
                </div>
            </div>
            <div class=""col-md-10 col-lg-4"">
                <div class=""relative-news-banner"">
                    <div class=""banner"">
                        <a href=""#"">
                            <img class=""max-w-full"" src=""assets/img/banner-2.jpg"" alt=""IMG"">
                        </a>
                    </div>
                    <div");
            WriteLiteral(@" class=""most-shared"">
                        <div class=""head  m-r-10"">
                            <h3 class=""title"">Most Shared News</h3>
                        </div>
                        <ul class=""news"">
                            <li>
                                <div class=""news-image"">
                                    <img src=""assets/img/economy-3.jpg"" alt=""Img"">
                                </div>
                                <div class=""title"">
                                    <a href=""#"" class=""trans-03"">
                                        Zhang social media pop
                                        also known when smart innocent...
                                    </a>
                                </div>
                            </li>
                            <li>
                                <div class=""news-image"">
                                    <img src=""assets/img/technology-3.jpg"" alt=""Img"">
                                </");
            WriteLiteral(@"div>
                                <div class=""title"">
                                    <a href=""#"" class=""trans-03"">
                                        Venezuela elan govt
                                        and opposit the property collect...
                                    </a>
                                </div>
                            </li>
                            <li>
                                <div class=""news-image"">
                                    <img src=""assets/img/post-10.jpg"" alt=""Img"">
                                </div>
                                <div class=""title"">
                                    <a href=""#"" class=""trans-03"">
                                        Zhang social media pop
                                        also known when smart innocent...
                                    </a>
                                </div>
                            </li>
                            <li>
                   ");
            WriteLiteral(@"             <div class=""news-image"">
                                    <img src=""assets/img/economy-1.jpg"" alt=""Img"">
                                </div>
                                <div class=""title"">
                                    <a href=""#"" class=""trans-03"">
                                        Venezuela elan govt
                                        and opposit the property collect...
                                    </a>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class=""follow-us"">
                        <div class=""head  m-r-10"">
                            <h3 class=""title"">Follow Us</h3>
                        </div>
                        <ul class=""link"">
                            <li class=""facebook"">
                                <a href=""#""><i class=""fab fa-facebook-f""></i></a>
                            </li>
                        ");
            WriteLiteral(@"    <li class=""twitter"">
                                <a href=""#""><i class=""fab fa-twitter""></i></a>
                            </li>
                            <li class=""pinterest"">
                                <a href=""#""><i class=""fab fa-pinterest""></i></a>
                            </li>
                            <li class=""dribbble"">
                                <a href=""#"">
                                    <i class=""fab fa-dribbble""></i>
                                </a>
                            </li>
                            <li class=""youtube"">
                                <a href=""#""><i class=""fab fa-youtube""></i></a>
                            </li>
                            <li class=""instagram"">
                                <a href=""#""><i class=""fab fa-instagram""></i></a>
                            </li>
                        </ul>
                    </div>
                    <div class=""banner2"">
                        <a href=""#"">
 ");
            WriteLiteral(@"                           <img class=""max-w-full"" src=""assets/img/banner-1.png"" alt=""IMG"">
                        </a>
                    </div>
                    <!-- <div class=""banner"">
                        <a href=""#"">
                            <img class=""max-w-full"" src=""assets/img/banner-2.jpg"" alt=""IMG"">
                        </a>
                    </div> -->
                </div>
            </div>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591