#pragma checksum "C:\Users\Samirah Alhusayni\OneDrive\المستندات\GitHubClass\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00de482a8f5a35e2c937f138d25e5f9401ece168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Samirah Alhusayni\OneDrive\المستندات\GitHubClass\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\_ViewImports.cshtml"
using ASP_CRUD_GitHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samirah Alhusayni\OneDrive\المستندات\GitHubClass\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\_ViewImports.cshtml"
using ASP_CRUD_GitHub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00de482a8f5a35e2c937f138d25e5f9401ece168", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ba5d27a574b6df67ea505aa6cca16e5390669a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Samirah Alhusayni\OneDrive\المستندات\GitHubClass\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Index.cshtml"
  
    var Students = (List<StudentModel>)ViewData["Students"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n \r\n\r\n<div>\r\n\r\n    <table>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Name</th>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\Samirah Alhusayni\OneDrive\المستندات\GitHubClass\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Index.cshtml"
         foreach (var item in Students)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Samirah Alhusayni\OneDrive\المستندات\GitHubClass\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Samirah Alhusayni\OneDrive\المستندات\GitHubClass\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Index.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Samirah Alhusayni\OneDrive\المستندات\GitHubClass\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n</div>\r\n        \r\n    \r\n");
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
