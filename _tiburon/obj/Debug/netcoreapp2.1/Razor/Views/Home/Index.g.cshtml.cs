#pragma checksum "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de9db6be3ce3bdd3ad2ae2f9e8a705a58e35a34f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\_ViewImports.cshtml"
using _tiburon;

#line default
#line hidden
#line 2 "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\_ViewImports.cshtml"
using _tiburon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de9db6be3ce3bdd3ad2ae2f9e8a705a58e35a34f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf540f191b265f6267ee338e2b0424fbdd050d3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_tiburon.Models.ViewModels.RespondentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 71, true);
            WriteLiteral("\r\n<div class=\"row\" >\r\n    <div class=\"col align-self-center\">\r\n        ");
            EndContext();
            BeginContext(127, 24, false);
#line 5 "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\Home\Index.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(151, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(161, 921, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77ba30b7a47f4bf99612a230f7d9b726", async() => {
                BeginContext(302, 35, true);
                WriteLiteral("\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(338, 19, false);
#line 8 "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\Home\Index.cshtml"
           Write(Model.FirstQuestion);

#line default
#line hidden
                EndContext();
                BeginContext(357, 292, true);
                WriteLiteral(@"
                <label>Мужской</label>
                <input type=""radio"" name=""gender"" value=""male"" required />
                <label>Женский</label>
                <input type=""radio"" name=""gender"" value=""female"" required  />
            </p>
            <p>
                    ");
                EndContext();
                BeginContext(650, 20, false);
#line 15 "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\Home\Index.cshtml"
               Write(Model.SecondQuestion);

#line default
#line hidden
                EndContext();
                BeginContext(670, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\Home\Index.cshtml"
                     foreach (var PhoneMark in Model.PhoneMarks)
                    {


#line default
#line hidden
                BeginContext(763, 31, true);
                WriteLiteral("                        <label>");
                EndContext();
                BeginContext(795, 14, false);
#line 19 "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\Home\Index.cshtml"
                          Write(PhoneMark.Name);

#line default
#line hidden
                EndContext();
                BeginContext(809, 69, true);
                WriteLiteral("</label>\r\n                        <input type=\"checkbox\" name=\"items\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 878, "\"", 901, 1);
#line 20 "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\Home\Index.cshtml"
WriteAttributeValue("", 886, PhoneMark.Name, 886, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(902, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 21 "C:\Users\Den\documents\visual studio 2017\Projects\_tiburon\_tiburon\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
                BeginContext(932, 143, true);
                WriteLiteral("            </p>\r\n            <p>\r\n                <input type=\"submit\" value=\"Ответить\" class=\"btn btn-success\" />\r\n            </p>\r\n        ");
                EndContext();
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1082, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_tiburon.Models.ViewModels.RespondentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591