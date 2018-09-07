#pragma checksum "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebdde2a4dfab5f00c393b09d708ff30267ed19de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_List), @"mvc.1.0.view", @"/Views/Customer/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/List.cshtml", typeof(AspNetCore.Views_Customer_List))]
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
#line 1 "G:\StagingArea\Omnius\Omnius.UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#line 2 "G:\StagingArea\Omnius\Omnius.UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#line 1 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
using Omnius.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebdde2a4dfab5f00c393b09d708ff30267ed19de", @"/Views/Customer/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
  
    ViewData["Title"] = "Реестр потребителей";

#line default
#line hidden
            BeginContext(107, 90, true);
            WriteLiteral("\r\n<div class=\"container\" style=\"overflow-x:auto;\">\r\n    <h3>Реестр потребителей</h3>\r\n    ");
            EndContext();
            BeginContext(198, 37, false);
#line 11 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
Write(Html.ActionLink("Добавить", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(235, 125, true);
            WriteLiteral("\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                   Фамилия ");
            EndContext();
            BeginContext(410, 70, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                   Имя ");
            EndContext();
            BeginContext(525, 75, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                   Отчество ");
            EndContext();
            BeginContext(653, 80, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                   Дата рождения ");
            EndContext();
            BeginContext(785, 153, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                   Действия\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 33 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
             foreach (var item in Model.Customers)
            {

#line default
#line hidden
            BeginContext(1005, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1078, 45, false);
#line 37 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FamilyName));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1203, 39, false);
#line 40 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1324, 47, false);
#line 44 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PaternalName));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1451, 46, false);
#line 47 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1577, 57, false);
#line 50 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
                   Write(Html.ActionLink("Изменить", "Edit", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(1638, 61, false);
#line 50 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
                                                                                Write(Html.ActionLink("Подробнее", "Details", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(1703, 58, false);
#line 50 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
                                                                                                                                                 Write(Html.ActionLink("Удалить", "Delete", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 54 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
            }

#line default
#line hidden
            BeginContext(1830, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 57 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
         if (Model.PageViewModel.HasPreviousPage)
        {

#line default
#line hidden
            BeginContext(1924, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1936, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "798079af7e3e4b8386f0a6bd502cb9e1", async() => {
                BeginContext(2072, 103, true);
                WriteLiteral("\r\n                <i class=\"glyphicon glyphicon-chevron-left\"></i>\r\n                Назад\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
                    WriteLiteral(Model.PageViewModel.PageNumber - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2179, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 65 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
        }

#line default
#line hidden
            BeginContext(2192, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 66 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
         if (Model.PageViewModel.HasNextPage)
        {

#line default
#line hidden
            BeginContext(2250, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2262, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e0974860fca4d53a6fa0f513ccfc38e", async() => {
                BeginContext(2398, 105, true);
                WriteLiteral("\r\n                <i class=\"glyphicon glyphicon-chevron-right\"></i>\r\n                Вперед\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
                    WriteLiteral(Model.PageViewModel.PageNumber + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2507, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
        }

#line default
#line hidden
            BeginContext(2520, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
#line 77 "G:\StagingArea\Omnius\Omnius.UI\Views\Customer\List.cshtml"
  
    Layout = "_Layout";

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591