#pragma checksum "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\VerificadorDePasajes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d5429e623aaf362710ee65010219968e90a7318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Control_VerificadorDePasajes), @"mvc.1.0.view", @"/Views/Control/VerificadorDePasajes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d5429e623aaf362710ee65010219968e90a7318", @"/Views/Control/VerificadorDePasajes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ad0fe2798b37d6f0a339c6f4b44823b54ba7ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Control_VerificadorDePasajes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Entities.DtoValidarRet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/jquery-1.9.1.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/html5-qrcode.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\VerificadorDePasajes.cshtml"
  
    ViewData["Title"] = "VerificadorDePasajes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d5429e623aaf362710ee65010219968e90a73185174", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 6 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\VerificadorDePasajes.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d5429e623aaf362710ee65010219968e90a73187076", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 7 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\VerificadorDePasajes.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



<center>
    <div class=""card"" style=""max-width: 50.5em;background: bottom;border:none;margin:20px"">
        <div class=""form-row"" style=""background: white;margin-top: 100px;"">
            <div class=""card-body"">
                <h4 class=""card-title"" style=""text-align:initial;color:cornflowerblue;font-weight:600"">Verificar Pasajes </h4>
                <p class=""card-text"" style=""text-align:center"">El Conductor podra validar si los clientes suben en la parada correcta y si el pasaje es valido.</p>
            </div>
        </div>
    </div>
</center>

        <!-- Modal Pasaje Correcto-->
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">

        </div>








        <center>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d5429e623aaf362710ee65010219968e90a73189806", async() => {
                WriteLiteral(@"
                <div id=""qr-reader"" style=""width: 300px; height: 250px; margin-top: 30px; margin-bottom: 30px;background:white""></div>
                <div id=""qr-reader-results"" style=""width: 300px; margin-top: 300px; margin-bottom: 30px""></div>
                <div id=""pasaje-valido"">

                </div>

");
                DefineSection("scripts", async() => {
                    WriteLiteral(@"
                    <script>
                        function docReady(fn) {
                            // see if DOM is already available
                            if (document.readyState === ""complete"" || document.readyState === ""interactive"") {
                                // call on next available tick
                                setTimeout(fn, 1);
                            } else {
                                document.addEventListener(""DOMContentLoaded"", fn);
                            }
                        }

                        docReady(function () {
                            var resultContainer = document.getElementById('pasaje-valido');
                            var lastResult, countResults = 0;

                            var html5QrcodeScanner = new Html5QrcodeScanner(
                                ""qr-reader"", { fps: 10, qrbox: 250 });

                            function onScanSuccess(qrCodeMessage) {
                                if (qrCode");
                    WriteLiteral(@"Message !== lastResult) {
                                    ++countResults;
                                    lastResult = qrCodeMessage;
                                    $.post(""/Control/Verificar"", { 'qr': qrCodeMessage })
                                        .done(function (response, status, jqxhr) {
                                            if (response.valido == true) {
                                                document.getElementById('exampleModal').innerHTML = '<div class=""modal-dialog""><div class=""card text-white bg-info mb-3"" ><div class=""modal-header""><h5 class=""modal-title"" id=""exampleModalLabel"">Verificacion Completada</h5></div><div class=""modal-body""><div class=""card-body""><h5 class=""card-title"">' + response.mensaje + '</h5></div></div></div ></div >';
                                                $(""#exampleModal"").modal('show');
                                                setTimeout(function () {
                                                    $(""#exampleMo");
                    WriteLiteral(@"dal"").modal('hide');
                                                }, 5000);
                                            } else {
                                                document.getElementById('exampleModal').innerHTML = '<div class=""modal-dialog""><div class=""card text-white bg-danger mb-3"" ><div class=""modal-header""><h5 class=""modal-title"" id=""exampleModalLabel"">Atencion !!!</h5></div><div class=""modal-body""><div class=""card-body""><h5 class=""card-title"">' + response.mensaje + '</h5></div></div></div ></div >';

                                                $(""#exampleModal"").modal('show');
                                                setTimeout(function () {
                                                    $(""#exampleModal"").modal('hide');
                                                }, 5000);
                                            }

                                        })
                                        .fail(function (jqxhr, status, error) {
             ");
                    WriteLiteral(@"                               alert(""Ah ocurrido un error con el servidor, intentelo mas tarde"")
                                        });
                                }
                            }

                            // Optional callback for error, can be ignored.
                            function onScanError(qrCodeError) {
                                // This callback would be called in case of qr code scan error or setup error.
                                // You can avoid this callback completely, as it can be very verbose in nature.

                            }

                            html5QrcodeScanner.render(onScanSuccess);
                        });

                    </script>
                ");
                }
                );
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </center>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Entities.DtoValidarRet> Html { get; private set; }
    }
}
#pragma warning restore 1591