#pragma checksum "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dd69a9f370bc3f4b839220fabe725715cfb1313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle__ComponentTable), @"mvc.1.0.view", @"/Views/Vehicle/_ComponentTable.cshtml")]
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
#line 1 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\_ViewImports.cshtml"
using ProjectStep8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\_ViewImports.cshtml"
using ProjectStep8.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd69a9f370bc3f4b839220fabe725715cfb1313", @"/Views/Vehicle/_ComponentTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e854ff93bfe06fbe1b23f66b25e6416c1041ee9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle__ComponentTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Component>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Component", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table>
   <tr>
      <th class=""text-left""> Component Name </th>
      <th class=""text-left""> Current Condition </th>
      <th class=""text-left""> Replaced Mileage </th>
      <th class=""text-left""> Purchase Date </th>
      <th class=""text-left""> Component Cost </th>
      <th class=""text-left""> Labor Cost </th>
      <th class=""text-left""> Purchase Vendor </th>
      <th class=""text-left""> Component Manufacturer </th>
      <th class=""text-left""> Warranty Expiration </th>
      <th class=""text-left""> Upgrade or OEM Replacement </th>
      <th class=""text-left""> Update </th>
      <th class=""text-left""> Delete </th>
   </tr>
");
#nullable restore
#line 17 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
    foreach (Component c in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n       <td> ");
#nullable restore
#line 20 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.ComponentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td> ");
#nullable restore
#line 21 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.ComponentCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td> ");
#nullable restore
#line 22 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.ReplacedMileage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td> ");
#nullable restore
#line 23 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.PurchaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td> ");
#nullable restore
#line 24 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.ComponentCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td> ");
#nullable restore
#line 25 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.LaborCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td> ");
#nullable restore
#line 26 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.PurchaseVendor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td> ");
#nullable restore
#line 27 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.ComponentManufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td> ");
#nullable restore
#line 28 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.WarrantyExpiration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td> ");
#nullable restore
#line 29 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
       Write(c.AftermarketOrOem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td>\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd69a9f370bc3f4b839220fabe725715cfb13137805", async() => {
                WriteLiteral(" Update ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
                                                                     WriteLiteral(c.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n       </td>\r\n       <td>\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd69a9f370bc3f4b839220fabe725715cfb131310241", async() => {
                WriteLiteral(" Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
                                                                     WriteLiteral(c.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n       </td>\r\n    </tr>\r\n");
#nullable restore
#line 37 "C:\Users\isubl\source\repos\ProjectStep8\ProjectStep8\Views\Vehicle\_ComponentTable.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Component>> Html { get; private set; }
    }
}
#pragma warning restore 1591
