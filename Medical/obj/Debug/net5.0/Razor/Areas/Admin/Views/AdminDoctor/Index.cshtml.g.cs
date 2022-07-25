#pragma checksum "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13a80330c00b03d200d513637a7dab2eeaf8d78d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminDoctor_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminDoctor/Index.cshtml")]
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
#line 1 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a80330c00b03d200d513637a7dab2eeaf8d78d", @"/Areas/Admin/Views/AdminDoctor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminDoctor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.Models.Doctor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/add.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral(@"
    <style>
        .input-selector {
            outline: none;
            border: none;
        }

        .muti-selector {
            width: max-content;
            float: left;
            padding-right: 4px
        }

        .select-field {
            border: 1px solid black;
        }

        .select-field, .task, .list {
            width: 100%;
            background-color: white;
        }

        .list {
            box-shadow: 0px 30px 60px rgb(0,0,0,0.2);
            display: none;
            position: absolute;
            width: 207.75px;
            z-index: 10;
        }

        .down-arrow {
            font-size: 1.2rem;
            cursor: pointer;
            display: inline-block;
            transition: 0.2s linear;
        }

        .task {
            display: block;
            padding-left: 0;
        }

            .task span {
                float: right;
                font-size: 0.6rem;
                padding-top: 6px;
 ");
                WriteLiteral(@"           }

                .task span:hover {
                    background-color: aliceblue;
                }

        .show {
            display: block;
        }

        .rotate180 {
            transform: rotate(180deg);
        }

        .detail {
            margin-left: 60px;
            margin-right: 60px;
        }

        .slideInUp {
            background-color: #616E83;
            border: 0.2px #666;
            border-radius: 25px 25px 25px 25px;
            margin: 10px 5px 10px 5px;
        }

        .icon {
            width: 16px;
            height: 16px;
            margin-bottom: 9px;
        }
    </style>
");
            }
            );
            WriteLiteral("<h1>醫生後台</h1>\r\n");
#nullable restore
#line 88 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"muti-selector\">\r\n        <div class=\"select-field\">\r\n            <input type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 2093, "\"", 2100, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"篩選專長\" class=\"input-selector\" />\r\n            <span class=\"down-arrow\">&blacktriangledown;</span>\r\n\r\n        </div>\r\n        <div class=\"list\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 2277, "\"", 2283, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""task"">
                <input type=""checkbox"" class=""check"" onclick=""CCC()"" name=""123"" id=""c"" />
                全選
            </label>
        </div>
    </div>
    <div class=""muti-selector"">
        <div class=""select-field"" id=""select-field1"">
            <input type=""text""");
            BeginWriteAttribute("name", " name=\"", 2579, "\"", 2586, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"篩選醫生\" class=\"input-selector\" />\r\n            <span class=\"down-arrow\" id=\"down-arrow1\">&blacktriangledown;</span>\r\n        </div>\r\n        <div class=\"list\" id=\"list1\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 2789, "\"", 2795, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"task\">\r\n                <input type=\"checkbox\" />\r\n                全選\r\n            </label>\r\n        </div>\r\n    </div>\r\n    <input id=\"txtKeyword\" hidden=\"hidden\" type=\"text\" name=\"txtKeyword\"");
            BeginWriteAttribute("value", " value=\"", 2997, "\"", 3005, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"submit\" id=\"sub\" value=\"查詢\" />\r\n");
#nullable restore
#line 117 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"

} 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3101, "\"", 3168, 3);
            WriteAttributeValue("", 3111, "location.href=\'", 3111, 15, true);
#nullable restore
#line 119 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
WriteAttributeValue("", 3126, Url.Action("CreateDetail","AdminDoctor"), 3126, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3167, "\'", 3167, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13a80330c00b03d200d513637a7dab2eeaf8d78d9614", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("新增醫生\r\n    </button>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<table class=""table table-hover"">
    <thead>
        <tr>
            <th>
                醫生編號
            </th>
            <th>
                醫生姓名
            </th>

            <th>
                學歷
            </th>
            <th>
                職位
            </th>

            <th>
                載入圖片
            </th>
            <th>
                管理
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 152 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
           int count = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 158 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 161 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 165 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 168 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13a80330c00b03d200d513637a7dab2eeaf8d78d13111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4462, "~/images/", 4462, 9, true);
#nullable restore
#line 172 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
AddHtmlAttributeValue("", 4471, Html.DisplayFor(modelItem => item.PicturePath), 4471, 47, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 175 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                   Write(Html.ActionLink("管理醫師評論", "DoctorRatinglist", new { id = item.DoctorId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 176 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                   Write(Html.ActionLink("修改資料", "EditDetail", new { id = item.DoctorId }, new { @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 177 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                   Write(Html.ActionLink("刪除", "Delete", new { id = item.DoctorId }, new { onclick = "return confirm('確定刪除?')", @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 180 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n");
                WriteLiteral(@"        document.querySelector('.select-field').addEventListener('click', () => {
        document.querySelector('.list').classList.toggle('show');
            document.querySelector('.down-arrow').classList.toggle('rotate180')

        })
        document.querySelector('#select-field1').addEventListener('click', () => {
            document.querySelector('#list1').classList.toggle('show');
            document.querySelector('#down-arrow1').classList.toggle('rotate180')
        })
        loadDep();
        //document.querySelector('.check').addEventListener('checked', () => {
        //    loadDoc()
        //})
        function CCC() {
            if ($(event.target)[0].checked == true) {
                loadDoc();
            }
            else
                cancelDoc();
        }
        function DDD() {
            if ($(event.target)[0].checked == true) {
                $('#txtKeyword').val($(event.target)[0].name);
            }
            if ($(event.target)[0].checked != t");
                WriteLiteral("rue)\r\n                $(\'#txtKeyword\').val=\"\";\r\n        }\r\n");
                WriteLiteral("        async function loadDep() {\r\n\r\n            const deps = await fetch(\'");
#nullable restore
#line 219 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                                 Write(Url.Content("~/Admin/AdminDoctor/Dep"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"').then(response => response.json())
            deps.forEach((DeptName) => {
                console.log(DeptName)
                name =`<label for="""" class=""task"">
                <input type=""checkbox"" class=""check"" onclick=""CCC()"" id=""${DeptName}"" name=""${DeptName}"" value=""${DeptName}""/>
                ${DeptName}
            </label>`;
                document.querySelector('.list').innerHTML += name;
            })

        }
");
                WriteLiteral("        async function loadDoc() {\r\n                depName = ($(event.target)[0].name);\r\n                const trtDs = await fetch(\'");
#nullable restore
#line 233 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                                      Write(Url.Content("~/Admin/AdminDoctor/Doc"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + `?depName=${depName}`).then(response => response.json());
                trtDs.forEach((DoctorName) => {
                    name = `<label for="""" class=""task"" id=""${DoctorName}"">
                <input type=""checkbox"" class=""check"" name=""${DoctorName}"" onclick=""DDD()"" value=""${DoctorName}""/>
                ${DoctorName}
            </label>`;
                    document.querySelector('#list1').innerHTML+= name;
                })
        }

");
                WriteLiteral("        async function cancelDoc() {\r\n                depName = ($(event.target)[0].name);\r\n                const trtDs = await fetch(\'");
#nullable restore
#line 246 "C:\Users\lonel\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminDoctor\Index.cshtml"
                                      Write(Url.Content("~/Admin/AdminDoctor/Doc"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + `?depName=${depName}`).then(response => response.json());\r\n                trtDs.forEach((DoctorName) => {\r\n                    document.querySelector(`#${DoctorName}`).remove();\r\n                })\r\n        }\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
