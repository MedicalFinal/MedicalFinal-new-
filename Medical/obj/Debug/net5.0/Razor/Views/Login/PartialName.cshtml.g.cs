#pragma checksum "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Login\PartialName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd12f6b0a91f1579235a4c8ceb7c3159bec6cc9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_PartialName), @"mvc.1.0.view", @"/Views/Login/PartialName.cshtml")]
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
#line 1 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd12f6b0a91f1579235a4c8ceb7c3159bec6cc9d", @"/Views/Login/PartialName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_PartialName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medical.ViewModel.CLoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Login\PartialName.cshtml"
  
    ViewData["Title"] = "showCountBySession";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Session</h1>\r\n");
#nullable restore
#line 9 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Login\PartialName.cshtml"
Write(Model.txtAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medical.ViewModel.CLoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
