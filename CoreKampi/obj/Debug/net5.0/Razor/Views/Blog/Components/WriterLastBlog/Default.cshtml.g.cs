#pragma checksum "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Blog\Components\WriterLastBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ddcede327e6cc0d7bc1e94efae0c18b93c87367"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Components_WriterLastBlog_Default), @"mvc.1.0.view", @"/Views/Blog/Components/WriterLastBlog/Default.cshtml")]
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
#line 1 "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\_ViewImports.cshtml"
using CoreKampi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\_ViewImports.cshtml"
using CoreKampi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Blog\Components\WriterLastBlog\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ddcede327e6cc0d7bc1e94efae0c18b93c87367", @"/Views/Blog/Components/WriterLastBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3de1325e3222c41617bc1a6f78f03d254ed8fb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Components_WriterLastBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"tech-btm\">\r\n    <h4>Yazarın Diğer Yazıları</h4>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Blog\Components\WriterLastBlog\Default.cshtml"
     foreach (var i in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a href=\"single.html\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 313, "\"", 331, 1);
#nullable restore
#line 14 "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Blog\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 319, i.BlogImage, 319, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 350, "\"", 356, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 500, "\"", 533, 2);
            WriteAttributeValue("", 507, "/Blog/BlogDetail/", 507, 17, true);
#nullable restore
#line 20 "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Blog\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 524, i.BlogId, 524, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Blog\Components\WriterLastBlog\Default.cshtml"
                                                    Write(i.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 24 "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Blog\Components\WriterLastBlog\Default.cshtml"
                                                Write(i.BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\bugra\Desktop\Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Blog\Components\WriterLastBlog\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
