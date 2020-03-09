#pragma checksum "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de397401f9e765bc89699bcf5cbe180430e536d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\_ViewImports.cshtml"
using CasaDeShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\_ViewImports.cshtml"
using CasaDeShow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de397401f9e765bc89699bcf5cbe180430e536d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e14b4a6b6de72f110567a0b7dc451115319be6d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CasaDeShow.Models.Evento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 class=\"fonte-clara\">Eventos</h2>\n\n\n<table class=\"table table-bordered table-hover\">\n    <thead>\n        <tr class=\"table-dark text-center\">\n            <th>\n");
            WriteLiteral("               Evento\n            </th>\n            <th>\n");
            WriteLiteral("                Capacidade\n            </th>\n            <th>\n");
            WriteLiteral("                Data\n            </th>\n            <th>\n");
            WriteLiteral("                Valor do ingresso\n            </th>\n            <th>\n");
            WriteLiteral("                Local\n            </th>\n            <th>\n");
            WriteLiteral("                Gênero musical\n            </th>\n            <th>\n\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 38 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table-primary text-center\">\n            <td>\n                ");
#nullable restore
#line 41 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeEvento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 44 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Capacidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorIngresso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Casadeshow.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GeneroMusica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 59 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
                 if(@item.IngressosRestantes != 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9de397401f9e765bc89699bcf5cbe180430e536d6654", async() => {
                WriteLiteral("Comprar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1843, "~/Evento/Compra/", 1843, 16, true);
#nullable restore
#line 60 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1859, item.Id, 1859, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 60 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
                                                                                   }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-danger\" href=\"#\" disable  >Esgotado</a>\n");
#nullable restore
#line 62 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n        </tr>\n");
#nullable restore
#line 65 "C:\Users\BSBO\Desktop\Projeto Casa API\CasaDeShow\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CasaDeShow.Models.Evento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
