#pragma checksum "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce7eae1d55496d6efbc87b04415b0021e764ea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
#line 1 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
using Clean_Store.Application.Services.Users.Queries.GetUsers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce7eae1d55496d6efbc87b04415b0021e764ea4", @"/Areas/Admin/Views/Users/Index.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultGetUserDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/SiteTemplate/assets/css/vendor/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SiteTemplate/assets/js/vendor/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- .card -->

<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"">لیست کاربران</h3>
    </div>
    <!-- /.card-header -->
    <div class=""card-body"">
        <div id=""example1_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
            <div class=""row"">
                <div class=""col-sm-12 col-md-6""><div class=""dataTables_length"" id=""example1_length""><label>Show <select name=""example1_length"" aria-controls=""example1"" class=""form-control form-control-sm"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce7eae1d55496d6efbc87b04415b0021e764ea46385", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce7eae1d55496d6efbc87b04415b0021e764ea47505", async() => {
                WriteLiteral("25");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce7eae1d55496d6efbc87b04415b0021e764ea48625", async() => {
                WriteLiteral("50");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce7eae1d55496d6efbc87b04415b0021e764ea49745", async() => {
                WriteLiteral("100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</select> entries</label></div></div>                <div class=\"col-sm-12 col-md-3\">\r\n                    <div class=\"input-group mb-3\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce7eae1d55496d6efbc87b04415b0021e764ea411068", async() => {
                WriteLiteral(@"
                            <input type=""text"" name=""searchKey"" class=""form-control"" placeholder=""جستجو در لیست"">
                            <span class=""input-group-append"">
                                <button type=""submit"" id=""searchKey"" class=""btn btn-info btn-flat"">جستجو</button>
                            </span>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-sm-12"">
                    <table id=""example1"" class=""table table-bordered table-striped dataTable"" role=""grid"">
                        <thead>
                            <tr role=""row"">
                                <th class=""sorting_asc"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""موتور رندر: activate to sort column descending"" style=""width: 178.975px;"">موتور رندر</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""مرورگر: activate to sort column ascending"" style=""width: 327.625px;"">مرورگر</th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 41 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                               var odd = true; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                             foreach (var item in Model.Users)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr role=\"row\"");
            BeginWriteAttribute("class", " class=\"", 2500, "\"", 2530, 1);
#nullable restore
#line 44 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 2508, odd ? "odd": "even", 2508, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td class=\"sorting_1\">");
#nullable restore
#line 45 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                                                     Write(item.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 46 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <button type=\"button\" class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2805, "\"", 2877, 9);
            WriteAttributeValue("", 2815, "ShowModalEdituser(\'", 2815, 19, true);
#nullable restore
#line 48 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 2834, item.Id, 2834, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2842, "\',", 2842, 2, true);
            WriteAttributeValue(" ", 2844, "\'", 2845, 2, true);
#nullable restore
#line 48 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 2846, item.Fullname, 2846, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2860, "\',", 2860, 2, true);
            WriteAttributeValue(" ", 2862, "\'", 2863, 2, true);
#nullable restore
#line 48 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 2864, item.Email, 2864, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2875, "\')", 2875, 2, true);
            EndWriteAttribute();
            WriteLiteral(">ویرایش</button>\r\n                                        <button type=\"button\" class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2987, "\"", 3019, 3);
            WriteAttributeValue("", 2997, "DeleteUser(\'", 2997, 12, true);
#nullable restore
#line 49 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 3009, item.Id, 3009, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3017, "\')", 3017, 2, true);
            EndWriteAttribute();
            WriteLiteral(">حذف</button>\r\n                                        <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 3096, "\"", 3162, 3);
            WriteAttributeValue("", 3104, "btn", 3104, 3, true);
#nullable restore
#line 50 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue(" ", 3107, item.IsActive? "btn-warning" : "btn-success", 3108, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3155, "btn-sm", 3156, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3163, "\"", 3201, 3);
            WriteAttributeValue("", 3173, "UserStatusChange(\'", 3173, 18, true);
#nullable restore
#line 50 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 3191, item.Id, 3191, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3199, "\')", 3199, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                                                                                                                                                                    Write(item.IsActive? "غیر فعال" : "فعال");

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 53 "D:\Asp.net core Traning\Clean_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                        <tfoot>
                            <tr>
                                <th rowspan=""1"" colspan=""1"">موتور رندر</th>
                                <th rowspan=""1"" colspan=""1"">مرورگر</th>
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
            <div class=""row""><div class=""col-sm-12 col-md-5""></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""example1_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""example1_previous""><a href=""#"" aria-controls=""example1"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">قبلی</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""example1"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example1"" data-dt-idx=""2"" tabindex=""0"" class=""p");
            WriteLiteral(@"age-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example1"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example1"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example1"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example1"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""example1_next""><a href=""#"" aria-controls=""example1"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">بعدی</a></li></ul></div></div></div>
        </div>
    </div>
    <!-- /.card-body -->
</div>

<!-- /.card -->

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ce7eae1d55496d6efbc87b04415b0021e764ea421143", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce7eae1d55496d6efbc87b04415b0021e764ea422322", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        function DeleteUser(UserId) {
            swal.fire({
                title: 'حذف کاربر',
                text: ""کاربر گرامی از حذف کاربر مطمئن هستید؟"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#7cacbe',
                confirmButtonText: 'بله ، کاربر حذف شود',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.value) {
                    var postData = {
                        'UserId': UserId,
                    };

                    $.ajax({
                        contentType: 'application/x-www-form-urlencoded',
                        dataType: 'json',
                        type: ""POST"",
                        url: ""Delete"",
                        data: postData,
                        success: function (data) {
                            if (data.isSuccess == true) {
                  ");
                WriteLiteral(@"              swal.fire(
                                    'موفق!',
                                    data.message,
                                    'success'
                                ).then(function (isConfirm) {
                                    location.reload();
                                });
                            } else {
                                swal.fire(
                                    'هشدار!',
                                    data.message,
                                    'warning'
                                );
                            }
                        },
                        error: function (request, status, error) {
                            alert(request.responseText);
                        }
                    });
                }
            })
        }

        function UserStatusChange(UserId) {
            swal.fire({
                title: 'تغییر وضعیت',
                text: ""کاربر گرامی از تغی");
                WriteLiteral(@"یر وضعیت کاربر مطمئن هستید؟"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#7cacbe',
                confirmButtonText: 'بله ، انجام شود',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.value) {
                    var postData = {
                        'UserId': UserId,
                    };

                    $.ajax({
                        contentType: 'application/x-www-form-urlencoded',
                        dataType: 'json',
                        type: ""POST"",
                        url: ""UserStatusChange"",
                        data: postData,
                        success: function (data) {
                            if (data.isSuccess == true) {
                                swal.fire(
                                    'موفق!',
                                    data.message,
                     ");
                WriteLiteral(@"               'success'
                                ).then(function (isConfirm) {
                                    location.reload();
                                });
                            } else {
                                swal.fire(
                                    'هشدار!',
                                    data.message,
                                    'warning'
                                );
                            }
                        },
                        error: function (request, status, error) {
                            alert(request.responseText);
                        }
                    });
                }
            })
        }

        function ShowModalEdituser(UserId, fullname, email) {
            $('#Edit_Fullname').val(fullname);
            $('#Edit_Email').val(email);
            $('#Edit_UserId').val(UserId);

            $('#EditUser').modal('show');
        }

        function Edituser() {

      ");
                WriteLiteral(@"      var userId = $(""#Edit_UserId"").val();
            var fullName = $(""#Edit_Fullname"").val();
            var email = $(""#Edit_Email"").val();

            var postData = {
                'UserId': userId,
                'FullName': fullName,
                'Email': email
            };


            $.ajax({
                contentType: 'application/x-www-form-urlencoded',
                dataType: 'json',
                type: ""POST"",
                url: ""Edit"",
                data: postData,
                success: function (data) {
                    if (data.isSuccess == true) {
                        swal.fire(
                            'موفق!',
                            data.message,
                            'success'
                        ).then(function (isConfirm) {
                            location.reload();
                        });
                    }
                    else {
                        swal.fire(
                            '");
                WriteLiteral(@"هشدار!',
                            data.message,
                            'warning'
                        );
                    }
                },
                error: function (request, status, error) {
                    alert(request.responseText);
                }
            });

            $('#EditUser').modal('hide');

        }
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
            DefineSection("Modals", async() => {
                WriteLiteral(@"
    <!-- Modal Edit User -->
    <div class=""modal fade"" id=""EditUser"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">ویرایش کاربر</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
                        <fieldset class=""form-group"">
                            <input type=""hidden"" id=""Edit_UserId"" />
                            <label for=""Edit_Fullname"">نام و نام خانوادگی</label>
                            <input type=""text"" class=""form-control"" id=""");
                WriteLiteral(@"Edit_Fullname"">
                            <label for=""Edit_Email"">ایمیل</label>
                            <input type=""text"" class=""form-control"" id=""Edit_Email"">
                        </fieldset>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <a class=""btn btn-secondary"" data-dismiss=""modal"">بستن</a>
                    <a class=""btn btn-primary"" onclick=""Edituser()"">اعمال تغییرات</a>
                </div>
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultGetUserDto> Html { get; private set; }
    }
}
#pragma warning restore 1591