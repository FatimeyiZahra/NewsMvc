#pragma checksum "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\CategoryEdit\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c1154624e2f26f62340db3085ba0facd88348b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryEdit_Details), @"mvc.1.0.view", @"/Views/CategoryEdit/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1154624e2f26f62340db3085ba0facd88348b1", @"/Views/CategoryEdit/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ecebe2843a820093814ecf3972dc68c4ba54cd", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoryEdit_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-4\">\r\n            <div class=\"form-group\">\r\n                <label>cat name</label>\r\n                <span class=\"form-control\">");
#nullable restore
#line 12 "C:\Users\MacBook AIr\Desktop\NewsMvc\NewsMvc\Views\CategoryEdit\Details.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591