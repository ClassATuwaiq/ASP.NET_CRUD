#pragma checksum "C:\Users\Reema\source\repos\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23fc6f5a687415deabe56fc153bf7efe7053905b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Reema\source\repos\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\_ViewImports.cshtml"
using ASP_CRUD_GitHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Reema\source\repos\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\_ViewImports.cshtml"
using ASP_CRUD_GitHub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23fc6f5a687415deabe56fc153bf7efe7053905b", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ba5d27a574b6df67ea505aa6cca16e5390669a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Reema\source\repos\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Details.cshtml"
  
    var st = (StudentModel)ViewData["students"];


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card align-item-center\" style=\"width:60%; margin-left:230px\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 8 "C:\Users\Reema\source\repos\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Details.cshtml"
                          Write(st.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 9 "C:\Users\Reema\source\repos\ASP.NET_CRUD\ASP_CRUD_GitHub\ASP_CRUD_GitHub\Views\Home\Details.cshtml"
                        Write(st.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
