#pragma checksum "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0939c4bde24bc0b47ec142341dc3bbb5820a8c2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__StatusMessage), @"mvc.1.0.view", @"/Views/Manage/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_StatusMessage.cshtml", typeof(AspNetCore.Views_Manage__StatusMessage))]
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
#line 1 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final;

#line default
#line hidden
#line 2 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#line 3 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_ViewImports.cshtml"
using Final.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0939c4bde24bc0b47ec142341dc3bbb5820a8c2d", @"/Views/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcdfd7574ee31cfe7db5033634b33589daf9de52", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b406912f8b37c4dca40b33b7ba44f88cf5a6276", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            BeginContext(131, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 135, "\"", 192, 4);
            WriteAttributeValue("", 143, "alert", 143, 5, true);
            WriteAttributeValue(" ", 148, "alert-", 149, 7, true);
#line 6 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 155, statusMessageClass, 155, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 174, "alert-dismissible", 175, 18, true);
            EndWriteAttribute();
            BeginContext(193, 144, true);
            WriteLiteral(" role=\"alert\">\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n");
            EndContext();
            BeginContext(338, 5, false);
#line 8 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_StatusMessage.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(343, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 10 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Manage\_StatusMessage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591