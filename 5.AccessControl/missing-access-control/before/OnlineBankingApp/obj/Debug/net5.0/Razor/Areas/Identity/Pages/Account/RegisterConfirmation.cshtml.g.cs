#pragma checksum "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "759b762c8c9ee06e361a91fc4daeb6ce9bd518a15af148c5a49cc1b20e4bb64b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\_ViewImports.cshtml"
using OnlineBankingApp.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\_ViewImports.cshtml"
using OnlineBankingApp.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 1 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using OnlineBankingApp.Areas.Identity.Pages.Account

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"759b762c8c9ee06e361a91fc4daeb6ce9bd518a15af148c5a49cc1b20e4bb64b", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"45d9cdbf281c485f9b54e85064ceec72049a456950143dbcb3f68e5573459422", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"60854cadaab3b2715c9fbe783e387564440caf45f282c645d32cb691e0adab98", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>");
            Write(
#nullable restore
#line 7 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
     ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\n");
#nullable restore
#line 8 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("<p>\n    This app does not currently have a real email sender registered, see <a href=\"https://aka.ms/aspaccountconf\">these docs</a> for how to configure a real email sender.\n    Normally this would be emailed: <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 403, "\"", 437, 1);
            WriteAttributeValue("", 410, 
#nullable restore
#line 13 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                                                                Model.EmailConfirmationUrl

#line default
#line hidden
#nullable disable
            , 410, 27, false);
            EndWriteAttribute();
            WriteLiteral(">Click here to confirm your account</a>\n</p>\n");
#nullable restore
#line 15 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("<p>\n        Please check your email to confirm your account.\n</p>\n");
#nullable restore
#line 21 "D:\labs\5.AccessControl\missing-access-control\before\OnlineBankingApp\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
