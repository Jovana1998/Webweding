#pragma checksum "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b94d74285d98ab4e62fe350c93f9e436e9a3602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebWedding.Pages.AdminPages.Pages_AdminPages_AdminVratiZahtev), @"mvc.1.0.razor-page", @"/Pages/AdminPages/AdminVratiZahtev.cshtml")]
namespace WebWedding.Pages.AdminPages
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
#line 1 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\_ViewImports.cshtml"
using WebWedding;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b94d74285d98ab4e62fe350c93f9e436e9a3602", @"/Pages/AdminPages/AdminVratiZahtev.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3464181ae681d34a13d0f774cba4d279cadfeef3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminPages_AdminVratiZahtev : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("adminID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AdminPregledArhiviranihZahteva", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
  
    ViewData["Title"] = "AdminVratiZahtev";
    Layout = "_Layout_Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div style=\" display:flex;\n                 flex-direction:column;\n                 align-items:center\">\n\n        <h2 style=\"display:flex;color:lightcoral;\">Da li ste sigruni da zelite da vratite ovaj zahtev?</h2>\n        <div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b94d74285d98ab4e62fe350c93f9e436e9a36025220", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 14 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.AdminID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <hr />\n            <dl class=\"dl-horizontal\">\n                <dt>\n                    ");
#nullable restore
#line 18 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayNameFor(model => model.Zahtev.UkupnaCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 21 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.UkupnaCena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    Korisnik\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 27 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.MojKorisnik.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
                                                                       Write(Html.DisplayFor(model => model.Zahtev.MojKorisnik.Prezime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    Fotograf\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 33 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.MojFotograf.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
                                                                       Write(Html.DisplayFor(model => model.Zahtev.MojFotograf.Prezime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    Dekoracija\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 39 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.MojaDekoracija.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    Muzika\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 45 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.MojaMuzika.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    Prostor\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 51 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.MojProstor.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    Meni\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 57 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.MojMeni.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    Datum podnosenja zahteva\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 63 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.DatumPodnosenjaZahteva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    Izabrani datum\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 69 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.IzabraniDatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    ");
#nullable restore
#line 72 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayNameFor(model => model.Zahtev.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 75 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt>\n                    Broj gostiju\n                </dt>\n                <dd>\n                    ");
#nullable restore
#line 81 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
               Write(Html.DisplayFor(model => model.Zahtev.BrojGostiju));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n");
            WriteLiteral("            </dl>\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b94d74285d98ab4e62fe350c93f9e436e9a360213332", async() => {
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b94d74285d98ab4e62fe350c93f9e436e9a360213605", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 116 "C:\Users\Jovana\Desktop\GIT\WebWedding\Aplikacija\WebWedding\WebWedding\Pages\AdminPages\AdminVratiZahtev.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Zahtev.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                <input type=\"submit\" value=\"Vrati\" class=\"btn btn-default\" /> |\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b94d74285d98ab4e62fe350c93f9e436e9a360215445", async() => {
                    WriteLiteral("Nazad na listu arhiviranih zahteva");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebWedding.Pages.AdminPages.AdminVratiZahtevModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebWedding.Pages.AdminPages.AdminVratiZahtevModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebWedding.Pages.AdminPages.AdminVratiZahtevModel>)PageContext?.ViewData;
        public WebWedding.Pages.AdminPages.AdminVratiZahtevModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
