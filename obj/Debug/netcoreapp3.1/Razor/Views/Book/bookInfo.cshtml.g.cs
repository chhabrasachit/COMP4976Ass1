#pragma checksum "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b78a97becccd8fc6d4fc8ae664eb2f8805ea4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_bookInfo), @"mvc.1.0.view", @"/Views/Book/bookInfo.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b78a97becccd8fc6d4fc8ae664eb2f8805ea4e", @"/Views/Book/bookInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96d75aaeaecb138cbae0a51ca0748d9993072eba", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_bookInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    tr
    {
        line-height: 6;
        
    }
    tr:hover 
    {
        background-color: #F5DEB3;
    }
    .authors {
        display: block;
        line-height: 4;
    }
    th
    {
        width: 200px;
    }
</style>
<div class=""text-center"">
    <h1 class=""display-4"">Book Information</h1>
    <table>
");
            WriteLiteral("            <tr>\n                <th>Title: </th>\n                <td>");
#nullable restore
#line 29 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
               Write(ViewBag.bookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <th>Thumbnail: </th>\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 569, "\"", 593, 1);
#nullable restore
#line 33 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
WriteAttributeValue("", 575, ViewBag.thumbnail, 575, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\n            </tr>\n            <tr>\n                <th>Authors: </th>\n");
#nullable restore
#line 37 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
                 for (var i = 0; i < @ViewBag.length; i++)
                {
              

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"authors\">");
#nullable restore
#line 40 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
                                   Write(ViewBag.authors[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /></td>\n");
#nullable restore
#line 41 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
                  
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \n            </tr>\n            <tr>\n                <th>Publisher: </th>\n                <td>");
#nullable restore
#line 47 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
               Write(ViewBag.publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr>\n                <th>Published Date: </th>\n                <td>");
#nullable restore
#line 51 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
               Write(ViewBag.publishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n            <tr style=\"line-height: normal;\">\n                <th>Description: </th>\n                <td>");
#nullable restore
#line 55 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
               Write(ViewBag.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n              <tr>\n                <th>ISBN_10: </th>\n                <td>");
#nullable restore
#line 59 "C:\Users\User\Documents\GitHub\COMP4976Ass1\Views\Book\bookInfo.cshtml"
               Write(ViewBag.isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
            WriteLiteral("    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
