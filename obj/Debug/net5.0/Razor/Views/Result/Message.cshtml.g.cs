#pragma checksum "D:\Projects\My_Project\Views\Result\Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84306291eb579d2ffce63de149bd35485175da0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Result_Message), @"mvc.1.0.view", @"/Views/Result/Message.cshtml")]
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
#line 1 "D:\Projects\My_Project\Views\_ViewImports.cshtml"
using My_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\My_Project\Views\_ViewImports.cshtml"
using My_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84306291eb579d2ffce63de149bd35485175da0", @"/Views/Result/Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8039bf55ff2b34b8f27e3e86689bf0e0814999c7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Result_Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Message_ViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projects\My_Project\Views\Result\Message.cshtml"
   
  Layout = "_Layout2";
  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container text-center"">
    <table class=""table table-hover table-bordered"">
      <thead class=""bg-dark"">
        <tr>
          <th class=""text-center""> ردیف </th>
          <th class=""text-center""> نام و نام خانوادگی </th>
          <th class=""text-center""> موضوع </th>
          <th class=""text-center""> تاریخ </th>
          <th class=""text-center""> ایمیل </th>
          <th class=""text-center"" rows=""2""> پیام </th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 18 "D:\Projects\My_Project\Views\Result\Message.cshtml"
         foreach (var item in Model)
        {
            int i = 1 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n              <td>");
#nullable restore
#line 22 "D:\Projects\My_Project\Views\Result\Message.cshtml"
             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 23 "D:\Projects\My_Project\Views\Result\Message.cshtml"
             Write(item.NameFamily);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 24 "D:\Projects\My_Project\Views\Result\Message.cshtml"
             Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 25 "D:\Projects\My_Project\Views\Result\Message.cshtml"
             Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 26 "D:\Projects\My_Project\Views\Result\Message.cshtml"
             Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 27 "D:\Projects\My_Project\Views\Result\Message.cshtml"
             Write(item.UserMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\Projects\My_Project\Views\Result\Message.cshtml"
            i++; 
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Message_ViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
