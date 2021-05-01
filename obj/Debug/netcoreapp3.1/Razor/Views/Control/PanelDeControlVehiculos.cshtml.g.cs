#pragma checksum "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ab0ce703bf9c189a2a28493fe174fb63d25ee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Control_PanelDeControlVehiculos), @"mvc.1.0.view", @"/Views/Control/PanelDeControlVehiculos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ab0ce703bf9c189a2a28493fe174fb63d25ee3", @"/Views/Control/PanelDeControlVehiculos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ad0fe2798b37d6f0a339c6f4b44823b54ba7ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Control_PanelDeControlVehiculos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Entities.DtoViajeControl>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SiguienteParada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml"
  
    ViewData["Title"] = "PanelDeControlVehiculos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"" style=""background: bottom;border: none;margin: 20px"">
    <div class=""col-12 col-lg-12 col-md-12 col-sm-12 col-xl-12"">
        <div class=""card"" style=""margin-top: 20px;text-align: center;background: white;margin-top: 100px;"">

            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-12 col-lg-12 col-md-12 col-sm-12 col-xl-12"">
                        <h3 class=""card-title"">Panel de Control de Vehiculos de la Empresa</h3>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-12 col-lg-12 col-md-12 col-sm-12 col-xl-12"">
        <div class=""card text-black bg-light"" style=""text-align:center;margin:30px"">


            <div class=""card-body"">

                <div class=""row"">
                    <div class=""col-12 col-lg-12 col-md-12 col-sm-12 col-xl-8"">
                        <!-- Mapa de todos los vehiculos del sistema -->

      ");
            WriteLiteral("                  <div class=\"card\" style=\"width: 100%\"> <div id=\"myMap\" style=\"height:500px\"></div></div>\r\n\r\n                    </div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

                        <script>
                                const tilesProvider = 'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png'

                                //CREAMOS EL MAPA
                                let myMap = L.map('myMap').setView([-32.522779, -55.765835], 7)
                                            L.tileLayer(tilesProvider, {
                                                maxZoom: 10,

                                            }).addTo(myMap)
                            //MUETRO PARADAS
                        var paradas = ");
#nullable restore
#line 48 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml"
                                 Write(Html.Raw(Json.Serialize(ViewBag.paradas)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                        for (var i = 0; i < paradas.length; i++) {\r\n                            var subs = paradas[i].geoReferencia.split(\';\');\r\n                            let iconParada = L.icon({ iconUrl: \'");
#nullable restore
#line 51 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml"
                                                           Write(Url.Content("/img/parada.png"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', iconSize: [20, 40], iconAnchor: [40, 60] })
                            let marcaParada = new L.marker([subs[0], subs[1]], { icon: iconParada }).addTo(myMap)
                            marcaParada.bindPopup(paradas[i].nombre).openPopup();
                         };
                         //MUESTRO VEHICULOS
                         var vehiculos = ");
#nullable restore
#line 56 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml"
                                    Write(Html.Raw(Json.Serialize(ViewBag.viajes)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                            for (var i = 0; i < vehiculos.length; i++) {\r\n                            var subs = vehiculos[i].localisacion.split(\';\');\r\n                            let iconBus = L.icon({iconUrl: \'");
#nullable restore
#line 59 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml"
                                                       Write(Url.Content("/img/vehiculo.png"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', iconSize: [20, 20],iconAnchor: [30, 30]})
                            let marcaBus = new L.marker([subs[0], subs[1]], { icon: iconBus }).addTo(myMap)
                             marcaBus.bindPopup(vehiculos[i].nombre).openPopup();
                         }
                         myMap.doubleClickZoom.disable()


                        </script>



                    ");
            }
            );
            WriteLiteral(@"
                    <div class=""col-12 col-lg-12 col-md-12 col-sm-12 col-xl-4"">

                        <div class=""card text-white bg-dark "" style=""text-align:center"">
                            <h5 class=""card-header"">Vehiculos</h5>
                            <div class=""card-body"">
                                <div class=""form-row"">
                                    <div class=""form-group col-md-12"">
                                        <!-- Filtrado de vehiculos -->
                                        <input type=""text"" id=""filtrarparada"" class=""form-control"" placeholder=""Filtrar"">
                                    </div>

                                </div>

                                <ul class=""list-group"" style=""height:375px;overflow-y:auto;border-bottom:1px solid gray;color:black"">

                                    <!-- Foreach de vehiculos  -->
                                    <!-- listado vehiculos -->
");
#nullable restore
#line 89 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml"
                                     foreach (Models.Entities.DtoViajeControl con in ViewBag.viajes)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                                            ");
#nullable restore
#line 92 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml"
                                       Write(con.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7ab0ce703bf9c189a2a28493fe174fb63d25ee310181", async() => {
                WriteLiteral("\r\n                                                <input type=\"text\" name=\"id\" id=\"idusuario\"");
                BeginWriteAttribute("value", " value=\"", 4687, "\"", 4707, 1);
#nullable restore
#line 94 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml"
WriteAttributeValue("", 4695, con.idviaje, 4695, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden class=\"form-control\">\r\n                                                <input type=\"submit\" value=\"Confirmar\" class=\"btn btn-danger\" />\r\n                                            ");
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
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 98 "C:\Users\edd_b\Desktop\Frontend Net\netfrontend\UruguayBus\Views\Control\PanelDeControlVehiculos.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <!-- cierra foreach -->



                                </ul>



                            </div>
                        </div>


                    </div>
                </div>


            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Entities.DtoViajeControl>> Html { get; private set; }
    }
}
#pragma warning restore 1591
