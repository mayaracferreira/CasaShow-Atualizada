#pragma checksum "C:\Users\MRCR\Desktop\CasaShow\Views\Show\Proximos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10ff90f16013da185ee68ffb60f491e888c3000a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Show_Proximos), @"mvc.1.0.view", @"/Views/Show/Proximos.cshtml")]
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
#line 1 "C:\Users\MRCR\Desktop\CasaShow\Views\_ViewImports.cshtml"
using CasaShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MRCR\Desktop\CasaShow\Views\_ViewImports.cshtml"
using CasaShow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10ff90f16013da185ee68ffb60f491e888c3000a", @"/Views/Show/Proximos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6768e84646838318e7bc5a37923e6f95d524d7d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Show_Proximos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CasaShow.Models.Show>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Próximos Shows</h3>\r\n\r\n<table width=\"100%\" border=\"1px\" style=\"background-color:white\">\r\n\r\n<thead>\r\n    <th>Nome</th>\r\n    <th>Data</th>\r\n    <th>Local</th>\r\n    <th>Valor</th>\r\n    <th>Editar</th>\r\n    <th>Excluir</th>\r\n</thead>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10ff90f16013da185ee68ffb60f491e888c3000a3302", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "C:\Users\MRCR\Desktop\CasaShow\Views\Show\Proximos.cshtml"
 foreach(var proximos in Model) 


{

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r\n   \r\n    <td >");
#nullable restore
#line 23 "C:\Users\MRCR\Desktop\CasaShow\Views\Show\Proximos.cshtml"
    Write(proximos.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\MRCR\Desktop\CasaShow\Views\Show\Proximos.cshtml"
   Write(proximos.Hora);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\MRCR\Desktop\CasaShow\Views\Show\Proximos.cshtml"
   Write(proximos.Casa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n    <td>R$: ");
#nullable restore
#line 26 "C:\Users\MRCR\Desktop\CasaShow\Views\Show\Proximos.cshtml"
       Write(proximos.Valor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>     \r\n    <td><a");
                BeginWriteAttribute("href", " href=\"", 483, "\"", 515, 2);
                WriteAttributeValue("", 490, "/Show/Editar/", 490, 13, true);
#nullable restore
#line 27 "C:\Users\MRCR\Desktop\CasaShow\Views\Show\Proximos.cshtml"
WriteAttributeValue("", 503, proximos.Id, 503, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  class=\"btn btn-success\">Editar</a></td>    \r\n    <td><a");
                BeginWriteAttribute("href", " href=\"", 573, "\"", 606, 2);
                WriteAttributeValue("", 580, "/Show/Deletar/", 580, 14, true);
#nullable restore
#line 28 "C:\Users\MRCR\Desktop\CasaShow\Views\Show\Proximos.cshtml"
WriteAttributeValue("", 594, proximos.Id, 594, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Deletar</a></td>\r\n\r\n\r\n    </tr>\r\n");
#nullable restore
#line 32 "C:\Users\MRCR\Desktop\CasaShow\Views\Show\Proximos.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CasaShow.Models.Show>> Html { get; private set; }
    }
}
#pragma warning restore 1591
