#pragma checksum "C:\Users\korisnik\Source\Repos\MixedShop\MixedShop\Views\Item\Listt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "583feceb455fd6a30b2cf81308cf7c0a4073d8f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Listt), @"mvc.1.0.view", @"/Views/Item/Listt.cshtml")]
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
#line 1 "C:\Users\korisnik\Source\Repos\MixedShop\MixedShop\Views\_ViewImports.cshtml"
using MixedShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\korisnik\Source\Repos\MixedShop\MixedShop\Views\_ViewImports.cshtml"
using MixedShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\korisnik\Source\Repos\MixedShop\MixedShop\Views\_ViewImports.cshtml"
using MixedShop.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583feceb455fd6a30b2cf81308cf7c0a4073d8f2", @"/Views/Item/Listt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d0e6133d05b90d96ffd04a4f22df28b326cb84", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Item_Listt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Mixed Shop Market</h1>\r\n<h3>\r\n    ");
#nullable restore
#line 6 "C:\Users\korisnik\Source\Repos\MixedShop\MixedShop\Views\Item\Listt.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h3>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\korisnik\Source\Repos\MixedShop\MixedShop\Views\Item\Listt.cshtml"
     foreach (var item in Model.Items)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\korisnik\Source\Repos\MixedShop\MixedShop\Views\Item\Listt.cshtml"
   Write(Html.Partial("ItemOverviewSummary", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\korisnik\Source\Repos\MixedShop\MixedShop\Views\Item\Listt.cshtml"
                                                  
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
