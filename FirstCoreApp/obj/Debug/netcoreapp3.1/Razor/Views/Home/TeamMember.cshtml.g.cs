#pragma checksum "C:\Users\Ahmedeng_2537\source\repos\FirstCoreApp\FirstCoreApp\Views\Home\TeamMember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64021992541c53eb16b8cf8a805856df8ba02874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TeamMember), @"mvc.1.0.view", @"/Views/Home/TeamMember.cshtml")]
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
#line 1 "C:\Users\Ahmedeng_2537\source\repos\FirstCoreApp\FirstCoreApp\Views\_ViewImports.cshtml"
using FirstCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmedeng_2537\source\repos\FirstCoreApp\FirstCoreApp\Views\_ViewImports.cshtml"
using FirstCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64021992541c53eb16b8cf8a805856df8ba02874", @"/Views/Home/TeamMember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc6a6529343c758d8f2982761ab5f4d40d86903", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TeamMember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TeamMember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"



<section id=""doctors"" class=""doctors section-bg"">
    <div class=""container aos-init aos-animate"" data-aos=""fade-up"">

        <div class=""section-title"">
            <h2>Ahmed Khaled Is The Only Member Until Now</h2>
        </div>

        <div class=""row"">

");
#nullable restore
#line 15 "C:\Users\Ahmedeng_2537\source\repos\FirstCoreApp\FirstCoreApp\Views\Home\TeamMember.cshtml"
             foreach (var item in Model)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-6 col-md-6 d-flex align-items-stretch\">\r\n                <div class=\"member aos-init aos-animate\" data-aos=\"fade-up\" data-aos-delay=\"100\">\r\n                    <div class=\"member-img\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "64021992541c53eb16b8cf8a805856df8ba028744644", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 616, "~/images/TeamMembers/", 616, 21, true);
#nullable restore
#line 22 "C:\Users\Ahmedeng_2537\source\repos\FirstCoreApp\FirstCoreApp\Views\Home\TeamMember.cshtml"
AddHtmlAttributeValue("", 637, item.Image, 637, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"social\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 753, "\"", 760, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icofont-twitter\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 836, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icofont-facebook\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 906, "\"", 913, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icofont-instagram\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 984, "\"", 991, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icofont-linkedin\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"member-info\">\r\n                        <h4 class=\"text-info\">");
#nullable restore
#line 31 "C:\Users\Ahmedeng_2537\source\repos\FirstCoreApp\FirstCoreApp\Views\Home\TeamMember.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <span class=\"text-primary\">");
#nullable restore
#line 32 "C:\Users\Ahmedeng_2537\source\repos\FirstCoreApp\FirstCoreApp\Views\Home\TeamMember.cshtml"
                                              Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\Ahmedeng_2537\source\repos\FirstCoreApp\FirstCoreApp\Views\Home\TeamMember.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TeamMember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
