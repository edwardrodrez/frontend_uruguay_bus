#pragma checksum "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc1781e62b59fc253708aff624a83268413a9338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Control_AsignarRoles), @"mvc.1.0.view", @"/Views/Control/AsignarRoles.cshtml")]
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
#line 1 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\_ViewImports.cshtml"
using UruguayBus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\_ViewImports.cshtml"
using UruguayBus.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1781e62b59fc253708aff624a83268413a9338", @"/Views/Control/AsignarRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ad0fe2798b37d6f0a339c6f4b44823b54ba7ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Control_AsignarRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AsignarRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Conductor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "superadmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AsignarRoles2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml"
  
    ViewData["Title"] = "AsignarRoles";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<center>

    <div class=""card"" style=""max-width: 50.5em;position: revert;background: bottom;border:none;margin:20px"">
        <div class=""form-row"" style=""background: white;margin-top: 100px;"">
            <div class=""card-body"">
                <h4 class=""card-title"" style=""text-align:initial;color:cornflowerblue;font-weight:600"">Asignar Roles</h4>
            </div>
        </div>
    </div>


    <div class=""card"" style=""max-width: 50.5em;margin:0 auto;padding:20px;margin-top:20px"">
        <!-- Busqueda por email se listara el nombre del usuario en el input desabilitado-->
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1781e62b59fc253708aff624a83268413a93386087", async() => {
                WriteLiteral(@"
            <div class=""form-row"">
                <div class=""form-group col-md-8"">
                    <input id=""email"" name=""email"" type=""email"" class=""form-control"" placeholder=""Email del usuario name@example.com"">
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Buscar"" class=""btn btn-danger"" />
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"form-row\">\r\n");
#nullable restore
#line 30 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml"
             if (ViewBag.buscar == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-group col-md-8"">
                    <label for=""disabledTextInput"">Resultado</label>
                    <input type=""text"" id=""disabledTextInput"" class=""form-control"" placeholder=""No hay Registro"" disabled>
                </div>
");
#nullable restore
#line 36 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group col-md-8\">\r\n                    <label for=\"disabledTextInput\">Resultado</label>\r\n                    <input type=\"text\" id=\"disabledTextInput\" class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1736, "\"", 1800, 3);
#nullable restore
#line 42 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml"
WriteAttributeValue("", 1750, ViewBag.buscar.FullName, 1750, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1774, "--Rol:", 1774, 6, true);
#nullable restore
#line 42 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml"
WriteAttributeValue(" ", 1780, ViewBag.buscar.rol, 1781, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1781e62b59fc253708aff624a83268413a933810016", async() => {
                WriteLiteral("\r\n\r\n\r\n            <div class=\"form-group col-md-4\">\r\n                <label for=\"inputState\">Elegir Rol</label>\r\n                <select name=\"inputState\" class=\"form-control\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1781e62b59fc253708aff624a83268413a933810489", async() => {
                    WriteLiteral("User");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1781e62b59fc253708aff624a83268413a933812054", async() => {
                    WriteLiteral("Conductor");
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
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1781e62b59fc253708aff624a83268413a933813301", async() => {
                    WriteLiteral("SuperAdmin");
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
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1781e62b59fc253708aff624a83268413a933814549", async() => {
                    WriteLiteral("Administrativo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>

            <!-- la fecha se debera poder ingresar y mostrar si se elige el rol conductor-->
            <div class=""accordion-body collapse"" for-field=""inputState"" for-value=""Conductor"" id=""collapseExample"">
                <div class=""form-group col-md-12"">
                    <label for=""fechalibreta"">Fecha de Libreta de Conducir</label>
                    <input type=""date"" name=""fechalibreta"" id=""fechalibreta"" class=""form-control"">
                </div>
            </div>
");
#nullable restore
#line 66 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml"
             if (@ViewBag.id != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"text\" name=\"idusuario\" id=\"idusuario\"");
                BeginWriteAttribute("value", " value=\"", 3013, "\"", 3032, 1);
#nullable restore
#line 68 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml"
WriteAttributeValue("", 3021, ViewBag.id, 3021, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden class=\"form-control\">\r\n                <input type=\"submit\" value=\"Confirmar\" class=\"btn btn-danger\" />\r\n");
#nullable restore
#line 70 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\AsignarRoles.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

            <script>

                $('select[name=""inputState""]').change(function (event) {
                    var selected = $(this).find('option:selected');
                    var value = selected.attr(""value"");
                    var name = $(this).attr(""name"");
                    var selector = '[for-field=""' + name + '""]';
                    $('.accordion-body' + selector).addClass('collapse');
                    var selectorForValue = selector + '[for-value=""' + value + '""]';
                    var selectedPanel = $('.accordion-body' + selectorForValue);
                    selectedPanel.removeClass('collapse');
                })
            </script>

        ");
            }
            );
            WriteLiteral("\r\n\r\n\r\n</center>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591