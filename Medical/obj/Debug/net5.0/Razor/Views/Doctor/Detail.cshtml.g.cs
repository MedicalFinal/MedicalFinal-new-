#pragma checksum "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30f2cae9b420d985c00e47968ba28d517fff095f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Detail), @"mvc.1.0.view", @"/Views/Doctor/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30f2cae9b420d985c00e47968ba28d517fff095f", @"/Views/Doctor/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medical.ViewModels.CDoctorDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("450"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("450"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\r\n    <style>\r\n        .det {\r\n            float: left;\r\n            width: 800px;\r\n        }\r\n\r\n        .row {\r\n            font-size: 20px !important;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n<h1>醫生詳細資料</h1>\r\n<input type=\"hidden\" id=\"DoctorID\" name=\"DoctorID\"");
            BeginWriteAttribute("value", " value=\"", 359, "\"", 382, 1);
#nullable restore
#line 20 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
WriteAttributeValue("", 367, Model.DoctorID, 367, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<div>\r\n    <hr />\r\n    <dl class=\"row det\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayFor(model => model.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.DepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
       Write(Html.DisplayFor(model => model.DepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            治療項目:\r\n        </dt>\r\n        <dd class=\"col-sm-10\" id=\"trtD\">\r\n\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30f2cae9b420d985c00e47968ba28d517fff095f8602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1647, "~/images/", 1647, 9, true);
#nullable restore
#line 66 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
AddHtmlAttributeValue("", 1656, Html.DisplayFor(model => model.PicturePath), 1656, 44, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<button class=\"btn btn-success btn-sm\">我要掛號</button>\r\n<div>\r\n    <input type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1824, "\"", 1882, 3);
            WriteAttributeValue("", 1834, "location.href=\'", 1834, 15, true);
#nullable restore
#line 70 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
WriteAttributeValue("", 1849, Url.Action("ListTest","Doctor"), 1849, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1881, "\'", 1881, 1, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"返回醫生\" class=\"btn btn-info btn-sm\" />\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        loadTrTD();\r\n        async function loadTrTD()\r\n        {\r\n            const trts = await fetch(\'");
#nullable restore
#line 78 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
                                 Write(Url.Content("~/doctor/getTreatment"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + `?dcID=${");
#nullable restore
#line 78 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Views\Doctor\Detail.cshtml"
                                                                                   Write(Model.DoctorID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"}`).then(response => response.json());
            trts.forEach((TreatmentDetail1) => {
                    console.log(TreatmentDetail1)
                    name = TreatmentDetail1+""/""
                    document.querySelector(""#trtD"").innerHTML += name;
            })

        }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medical.ViewModels.CDoctorDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
