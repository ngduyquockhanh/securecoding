#pragma checksum "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f47cc7bf6192d02fcf462dedaa3b9011c18b9057544864df9c793291b4baae27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineBankingApp.Pages.FundTransfers.Pages_FundTransfers_Index), @"mvc.1.0.razor-page", @"/Pages/FundTransfers/Index.cshtml")]
namespace OnlineBankingApp.Pages.FundTransfers
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
#line 1 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\_ViewImports.cshtml"
using OnlineBankingApp

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", 
    // language=Route
#nullable restore
#line 1 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
      "{searchString?}"

#line default
#line hidden
#nullable disable
    )]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f47cc7bf6192d02fcf462dedaa3b9011c18b9057544864df9c793291b4baae27", @"/Pages/FundTransfers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"de8f6aa451589ccefed85d6161d18cd6914b01d9abea7794e6387107ff513347", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_FundTransfers_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
  
    ViewData["Title"] = "Fund Transfers";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>Fund Transfers</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f47cc7bf6192d02fcf462dedaa3b9011c18b9057544864df9c793291b4baae275485", async() => {
                WriteLiteral("Send Money");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f47cc7bf6192d02fcf462dedaa3b9011c18b9057544864df9c793291b4baae276670", async() => {
                WriteLiteral("\n    <p>\n        Title: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f47cc7bf6192d02fcf462dedaa3b9011c18b9057544864df9c793291b4baae276974", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 17 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                                           SearchString

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Filter\" />\n    </p>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            Write(
#nullable restore
#line 25 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 Html.DisplayNameFor(model => model.FundTransfer[0].AccountFrom)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th>\n                ");
            Write(
#nullable restore
#line 28 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 Html.DisplayNameFor(model => model.FundTransfer[0].AccountTo)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th>\n                ");
            Write(
#nullable restore
#line 31 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 Html.DisplayNameFor(model => model.FundTransfer[0].TransactionDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th>\n                ");
            Write(
#nullable restore
#line 34 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 Html.DisplayNameFor(model => model.FundTransfer[0].Amount)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th>\n                ");
            Write(
#nullable restore
#line 37 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 Html.DisplayNameFor(model => model.FundTransfer[0].Note)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 43 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
 foreach (var item in Model.FundTransfer) {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\n            <td>\n                ");
            Write(
#nullable restore
#line 46 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 Html.DisplayFor(modelItem => item.AccountFrom)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n            <td>\n                ");
            Write(
#nullable restore
#line 49 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 Html.DisplayFor(modelItem => item.AccountTo)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n            <td>\n                ");
            Write(
#nullable restore
#line 52 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 Html.DisplayFor(modelItem => item.TransactionDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n            <td>\n                ");
            Write(
#nullable restore
#line 55 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 Html.DisplayFor(modelItem => item.Amount)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 58 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                 if (item.Note is not null) {            
                    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 59 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                      new Microsoft.AspNetCore.Html.HtmlString(htmlEncoder.Encode(item.Note))

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 59 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                                                                                              
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f47cc7bf6192d02fcf462dedaa3b9011c18b9057544864df9c793291b4baae2714791", async() => {
                WriteLiteral("Send Again");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 63 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                                                      item.ID

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 63 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                                                                               item.Note is null ? string.Empty : urlEncoder.Encode(item.Note)

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Fragment = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-fragment", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Fragment, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f47cc7bf6192d02fcf462dedaa3b9011c18b9057544864df9c793291b4baae2717934", async() => {
                WriteLiteral("See Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 66 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                                                       item.ID

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 69 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#nullable restore
#line 4 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
        System.Text.Encodings.Web.UrlEncoder

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                                             urlEncoder

#line default
#line hidden
#nullable disable
         { get; private set; }
         = default!;
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#nullable restore
#line 3 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
        System.Text.Encodings.Web.HtmlEncoder

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\FundTransfers\Index.cshtml"
                                              htmlEncoder

#line default
#line hidden
#nullable disable
         { get; private set; }
         = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBankingApp.Pages.FundTransfers.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBankingApp.Pages.FundTransfers.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBankingApp.Pages.FundTransfers.IndexModel>)PageContext?.ViewData;
        public OnlineBankingApp.Pages.FundTransfers.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591