#pragma checksum "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "594c133a3245fb141e85ef48b1f9058e3ff552595b4e273379c97c23433c1d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineBankingApp.Pages.Help.Pages_Help_Index), @"mvc.1.0.razor-page", @"/Pages/Help/Index.cshtml")]
namespace OnlineBankingApp.Pages.Help
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
#line 1 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml"
      "{searchString?}"

#line default
#line hidden
#nullable disable
    )]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"594c133a3245fb141e85ef48b1f9058e3ff552595b4e273379c97c23433c1d18", @"/Pages/Help/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"de8f6aa451589ccefed85d6161d18cd6914b01d9abea7794e6387107ff513347", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Help_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml"
  
    ViewData["Title"] = "How can we help?";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>How can we help?</h1>\n\n<p>\n\n</p>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "594c133a3245fb141e85ef48b1f9058e3ff552595b4e273379c97c23433c1d184378", async() => {
                WriteLiteral("\n    <p>\n        Enter Keyword: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "594c133a3245fb141e85ef48b1f9058e3ff552595b4e273379c97c23433c1d184690", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 15 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml"
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
                WriteLiteral("\n        <input type=\"submit\" value=\"Search\" />\n    </p>\n");
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
#line 23 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml"
                 Html.DisplayNameFor(model => model.Knowledge[0].Topic)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th>\n                ");
            Write(
#nullable restore
#line 26 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml"
                 Html.DisplayNameFor(model => model.Knowledge[0].Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 32 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml"
 foreach (var item in Model.Knowledge) {    

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\n            <td>\n                ");
            Write(
#nullable restore
#line 35 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml"
                 Html.DisplayFor(modelItem => item.Topic)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n            <td>\n                ");
            Write(
#nullable restore
#line 38 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml"
                 Html.DisplayFor(modelItem => item.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 41 "D:\labs\5.AccessControl\insecure-direct-object-references\before\OnlineBankingApp\Pages\Help\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBankingApp.Pages.Knowledgebase.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBankingApp.Pages.Knowledgebase.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBankingApp.Pages.Knowledgebase.IndexModel>)PageContext?.ViewData;
        public OnlineBankingApp.Pages.Knowledgebase.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
