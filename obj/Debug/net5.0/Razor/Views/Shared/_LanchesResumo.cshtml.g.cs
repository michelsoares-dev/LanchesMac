#pragma checksum "C:\Users\Michel Soares\source\repos\LanchesMac\Views\Shared\_LanchesResumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ed1ee5720c1b0580f658373c0b47595e1f97e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LanchesResumo), @"mvc.1.0.view", @"/Views/Shared/_LanchesResumo.cshtml")]
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
#line 1 "C:\Users\Michel Soares\source\repos\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Michel Soares\source\repos\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Michel Soares\source\repos\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ed1ee5720c1b0580f658373c0b47595e1f97e7", @"/Views/Shared/_LanchesResumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c7892fd1ae777588319feebe0369dedf46be42", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LanchesResumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lanche>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-sm-4\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 49, "\"", 71, 1);
#nullable restore
#line 4 "C:\Users\Michel Soares\source\repos\LanchesMac\Views\Shared\_LanchesResumo.cshtml"
WriteAttributeValue("", 55, Model.ImagemUrl, 55, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 72, "\"", 78, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <h3 class=text-left> ");
#nullable restore
#line 5 "C:\Users\Michel Soares\source\repos\LanchesMac\Views\Shared\_LanchesResumo.cshtml"
                    Write(Model.Preco.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n    <p>");
#nullable restore
#line 6 "C:\Users\Michel Soares\source\repos\LanchesMac\Views\Shared\_LanchesResumo.cshtml"
  Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 7 "C:\Users\Michel Soares\source\repos\LanchesMac\Views\Shared\_LanchesResumo.cshtml"
  Write(Model.DescricaoCurta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lanche> Html { get; private set; }
    }
}
#pragma warning restore 1591