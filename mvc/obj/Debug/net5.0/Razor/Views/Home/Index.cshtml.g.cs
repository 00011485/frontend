#pragma checksum "D:\CC\frontend_111485\frontend\mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "337e98e2423b7fa4f3f948898a325d470f2512f3"
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
#line 1 "D:\CC\frontend_111485\frontend\mvc\Views\_ViewImports.cshtml"
using mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CC\frontend_111485\frontend\mvc\Views\_ViewImports.cshtml"
using mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"337e98e2423b7fa4f3f948898a325d470f2512f3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a06753573638890b0ff2d42042a0bcf031bf36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CC\frontend_111485\frontend\mvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "User List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex justify-content-between align-items-center mb-3"">
    <h1>User List</h1>
    <button class=""btn btn-success"">Create User</button>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Username</th>
            <!-- Add other headers as needed -->
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "D:\CC\frontend_111485\frontend\mvc\Views\Home\Index.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "D:\CC\frontend_111485\frontend\mvc\Views\Home\Index.cshtml"
               Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\CC\frontend_111485\frontend\mvc\Views\Home\Index.cshtml"
               Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\CC\frontend_111485\frontend\mvc\Views\Home\Index.cshtml"
               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\CC\frontend_111485\frontend\mvc\Views\Home\Index.cshtml"
               Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "D:\CC\frontend_111485\frontend\mvc\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
