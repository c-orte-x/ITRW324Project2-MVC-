<<<<<<< HEAD
#pragma checksum "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ecc4d2bcad30a6aee551879bc7e7094ebb4184d"
=======
#pragma checksum "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ecc4d2bcad30a6aee551879bc7e7094ebb4184d"
>>>>>>> 88bce06099295c0e6bcfd1a1efde4243150f5ba2
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final;

#line default
#line hidden
#line 2 "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
<<<<<<< HEAD
#line 3 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
=======
#line 3 "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
>>>>>>> 88bce06099295c0e6bcfd1a1efde4243150f5ba2
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
<<<<<<< HEAD
#line 4 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
=======
#line 4 "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
>>>>>>> 88bce06099295c0e6bcfd1a1efde4243150f5ba2
using Final.Models.AccountViewModels;

#line default
#line hidden
<<<<<<< HEAD
#line 5 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
=======
#line 5 "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\_ViewImports.cshtml"
>>>>>>> 88bce06099295c0e6bcfd1a1efde4243150f5ba2
using Final.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ecc4d2bcad30a6aee551879bc7e7094ebb4184d", @"/Views/Shared/Error.cshtml")]
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcdfd7574ee31cfe7db5033634b33589daf9de52", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c1cff6f40abb5ed398bef63fed200d06795041", @"/Views/_ViewImports.cshtml")]
>>>>>>> 88bce06099295c0e6bcfd1a1efde4243150f5ba2
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(60, 116, true);
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
            EndContext();
#line 9 "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(204, 51, true);
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(256, 15, false);
<<<<<<< HEAD
#line 12 "C:\Users\wwwar\Documents\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Shared\Error.cshtml"
=======
#line 12 "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Shared\Error.cshtml"
>>>>>>> 88bce06099295c0e6bcfd1a1efde4243150f5ba2
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(271, 17, true);
            WriteLiteral("</code>\n    </p>\n");
            EndContext();
#line 14 "C:\Users\Hubert\Desktop\ITRW324Project2-MVC-\ITRW324Project2(MVC)\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(290, 566, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
