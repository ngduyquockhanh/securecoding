#pragma checksum "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "735750cf43248ceb566df3910c7c5aaa6096191f75730be4e92526ea2216559f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineBankingApp.Pages.Customers.Pages_Customers_Index), @"mvc.1.0.razor-page", @"/Pages/Customers/Index.cshtml")]
namespace OnlineBankingApp.Pages.Customers
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
#line 1 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\_ViewImports.cshtml"
using OnlineBankingApp

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"735750cf43248ceb566df3910c7c5aaa6096191f75730be4e92526ea2216559f", @"/Pages/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"de8f6aa451589ccefed85d6161d18cd6914b01d9abea7794e6387107ff513347", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Customers_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
  
    ViewData["Title"] = "List of Customers";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>List of Customers</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "735750cf43248ceb566df3910c7c5aaa6096191f75730be4e92526ea2216559f4098", async() => {
                WriteLiteral("Create New Customer Account");
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
            WriteLiteral("\n</p>\n\n<table id=\"table\" class=\"table\">\n    <tr>\n        <th>First Name</th>\n        <th>Middle Name</th>\n        <th>Last Name</th>\n        <th>Date of Birth</th>\n        <th>Primary Email Addrress</th>\n        <th>Phone</th>\n    </tr>\n</table>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script type=\"text/javascript\">    \n\n        $(document).ready(function() {\n");
#nullable restore
#line 30 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
             foreach (var item in Model.Customer) {
                

#line default
#line hidden
#nullable disable

                WriteLiteral("\n                    var $tr = $(\'<tr>\').append($(\'<td>\').text(\"");
                Write(
#nullable restore
#line 32 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
                                                                jsEncoder.Encode(item.FirstName)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\"));\n                    $tr.append($(\'<td>\').text(\"");
                Write(
#nullable restore
#line 33 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
                                                jsEncoder.Encode(item.MiddleName)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\"));\n                    $tr.append($(\'<td>\').text(\"");
                Write(
#nullable restore
#line 34 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
                                                jsEncoder.Encode(item.LastName)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\"));\n                    $tr.append($(\'<td>\').text(\"");
                Write(
#nullable restore
#line 35 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
                                                jsEncoder.Encode(item.DateOfBirth.ToString("d"))

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\"));\n                    $tr.append($(\'<td>\').text(\"");
                Write(
#nullable restore
#line 36 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
                                                jsEncoder.Encode(item.Email)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\"));\n                    $tr.append($(\'<td>\').text(\"");
                Write(
#nullable restore
#line 37 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
                                                jsEncoder.Encode(item.Phone)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\"));\n                    $tr.appendTo(\'#table\');\n                ");
#nullable restore
#line 39 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
                       
            }

#line default
#line hidden
#nullable disable

                WriteLiteral("        });\n        \n    </script>\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#nullable restore
#line 3 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
        System.Text.Encodings.Web.JavaScriptEncoder

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "C:\Users\Savvycom\OneDrive - Savvycom\Documents\ASP.NET-Core-Secure-Coding-Cookbook-main\ASP.NET-Core-Secure-Coding-Cookbook-main\Chapter02\command-injection\before\OnlineBankingApp\Pages\Customers\Index.cshtml"
                                                    jsEncoder

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBankingApp.Pages.Customers.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBankingApp.Pages.Customers.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBankingApp.Pages.Customers.IndexModel>)PageContext?.ViewData;
        public OnlineBankingApp.Pages.Customers.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
