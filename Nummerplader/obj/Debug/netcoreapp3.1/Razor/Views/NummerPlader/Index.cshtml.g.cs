#pragma checksum "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3521633c928c7425af1a5b83c35eb8ea83bde2f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NummerPlader_Index), @"mvc.1.0.view", @"/Views/NummerPlader/Index.cshtml")]
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
#line 1 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\_ViewImports.cshtml"
using Nummerplader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\_ViewImports.cshtml"
using Nummerplader.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3521633c928c7425af1a5b83c35eb8ea83bde2f7", @"/Views/NummerPlader/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e22acbdcab9b092a445b81eabe52fdf1a8201a16", @"/Views/_ViewImports.cshtml")]
    public class Views_NummerPlader_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nummerplader.Models.NummerPladerModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NummerPlader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
  
    ViewData["Title"] = "Nummer Plader";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div>\r\n\r\n        <div style=\"text-align:center; margin-bottom:3%\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3521633c928c7425af1a5b83c35eb8ea83bde2f74506", async() => {
                WriteLiteral("\r\n                <input name=\"regnr\" type=\"text\" placeholder=\"Indtast nummerplade\" />\r\n                <input class=\"btn-outline-primary\" type=\"submit\" value=\"Kør her\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row col-black-border\">\r\n\r\n                <div class=\"col  border-right\">\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 23 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Registration_number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 23 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                              Write(Model.Registration_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 24 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 24 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                 Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 25 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Status_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 25 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                      Write(Model.Status_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 26 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 26 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                               Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 27 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Use));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 27 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                              Write(Model.Use);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 28 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.First_registration));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 28 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                             Write(Model.First_registration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 29 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Vin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 29 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                              Write(Model.Vin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 30 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Own_weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 30 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                     Write(Model.Own_weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 31 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Total_weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 31 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                       Write(Model.Total_weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 32 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Axels));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 32 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                Write(Model.Axels);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 33 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Pulling_axels));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 33 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                        Write(Model.Pulling_axels);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 34 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Seats));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 34 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                Write(Model.Seats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 35 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Coupling));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 35 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                   Write(Model.Coupling);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col \">\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 38 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Doors));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 38 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                Write(Model.Doors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 39 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 39 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                               Write(Model.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 40 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 40 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 41 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Variant));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 41 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                  Write(Model.Variant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 42 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Model_type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 42 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                     Write(Model.Model_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 43 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Model_year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 43 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                     Write(Model.Model_year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 44 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 44 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 45 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Chassis_type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 45 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                       Write(Model.Chassis_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 46 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Engine_cylinders));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 46 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                           Write(Model.Engine_cylinders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 47 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Engine_volume));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 47 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                        Write(Model.Engine_volume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 48 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Engine_power));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 48 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                       Write(Model.Engine_power);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 49 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Fuel_type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 49 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                    Write(Model.Fuel_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"underline\"><b>");
#nullable restore
#line 50 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                       Write(Html.DisplayNameFor(m => m.Registration_zipcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 50 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
                                                                                               Write(Model.Registration_zipcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
         if(ViewData["Alert"] != null) { 
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"alert-danger alert-border\">Ingen nummerplade fundet</p>\r\n");
#nullable restore
#line 58 "C:\Users\aznzl\Desktop\Github\Nummerplader\Nummerplader\Views\NummerPlader\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nummerplader.Models.NummerPladerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
