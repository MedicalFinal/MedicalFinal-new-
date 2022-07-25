#pragma checksum "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b71ea57164f9e2e22388a7552755ef5ff58569a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Doctors_Views_Consultation_List), @"mvc.1.0.view", @"/Areas/Doctors/Views/Consultation/List.cshtml")]
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
#line 1 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b71ea57164f9e2e22388a7552755ef5ff58569a8", @"/Areas/Doctors/Views/Consultation/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Doctors_Views_Consultation_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.CClinicDetailAdminViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Areas/Doctors/Doctor_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Content Wrapper. Contains page content -->\r\n\r\n<!-- Main content -->\r\n<div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n                    <div class=\"card\">\r\n");
            WriteLiteral(@"                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table id=""example1"" class=""table table-bordered table-striped"">
                                <thead>
                                    <tr>
                                        <th>
                                            門診編號
                                        </th>
                                        <th>
                                            醫生
                                        </th>
                                        <th>
                                            科別
                                        </th>
                                        <th>
                                            時段
                                        </th>
                                        <th>
                                            診間
                                        </th>
                                        <th");
            WriteLiteral(@">
                                            開診日期
                                        </th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 46 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 50 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.ClinicDetailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 53 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Doctor.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 56 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Department.DeptName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 59 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Period.PeriodDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 62 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Room.RoomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 65 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.ClinicDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 68 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
                                           Write(Html.ActionLink("進入工作區", "WorkSpace", null, new { id = item.ClinicDetailId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 71 "C:\Users\lonel\source\repos\MedicalFinal-new-\Medical\Areas\Doctors\Views\Consultation\List.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
<!-- /.container-fluid -->

<!-- Control Sidebar -->
<aside class=""control-sidebar control-sidebar-dark"">
    <!-- Control sidebar content goes here -->
</aside>
<!-- /.control-sidebar -->
<!-- ./wrapper -->

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#example1"").DataTable({
                ""responsive"": true, ""lengthChange"": false, ""autoWidth"": false,
                ""buttons"": [""copy"", ""csv"", ""excel"", ""pdf"", ""print"", ""colvis""]
            }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.CClinicDetailAdminViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
