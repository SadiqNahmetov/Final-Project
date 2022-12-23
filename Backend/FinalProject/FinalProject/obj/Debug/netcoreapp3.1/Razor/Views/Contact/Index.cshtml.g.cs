#pragma checksum "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e129413824d6766f117195ba8ec095bd786ebd5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e129413824d6766f117195ba8ec095bd786ebd5f", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7626e0e603e68da04de663b8c06edebfc4499762", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comments-form contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral(@"
    <link rel=""shortcut icon"" href=""https://img.icons8.com/office/512/online-store.png"" type=""image/x-icon"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""./assets/css/contact/contact.css"">


");
            }
            );
            WriteLiteral(@"


<main>
    <section id=""product-mapp"">
        <div class=""container"">
            <div class=""row"" style=""margin-right: 0;"">
                <div class=""col-12"">
                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.3887914843153!2d50.065651315354565!3d40.37807497936953!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x403065d483cfd80f%3A0x85b770a1c0314ca7!2zSMO2dnNhbiBZYcWfYXnEscWfIEtvbXBsZWtzaQ!5e0!3m2!1sen!2s!4v1663414423010!5m2!1sen!2s""
                            width=""100%"" height=""400"" style=""overflow-y: none;""
                            style=""border: 0; filter: brightness(0.1)""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1081, "\"", 1099, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy""
                            referrerpolicy=""no-referrer-when-downgrade""></iframe>
                </div>
            </div>
        </div>

    </section>


    <section id=""contact-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""contact-area-main"">
                        <div class=""aa-contact-address"">
                            <div class=""row"">
                                <h2>Get in Touch</h2>

                                <div class=""col-md-8"">
                                    <div class=""aa-contact-address-left"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e129413824d6766f117195ba8ec095bd786ebd5f6546", async() => {
                WriteLiteral(@"
                                            <div class=""row"">
                                                <div class=""col-md-6"">
                                                    <div class=""form-group"">
                                                        <input type=""text"" placeholder=""Your Name""
                                                               class=""form-control"">
                                                    </div>
                                                </div>
                                                <div class=""col-md-6"">
                                                    <div class=""form-group"">

                                                        <input type=""text"" placeholder=""Your Surname""
                                                               class=""form-control"">

                                                    </div>
                                                </div>
                                            </di");
                WriteLiteral(@"v>
                                            <div class=""row"">
                                                <div class=""col-md-6"">
                                                    <div class=""form-group"">
                                                        <input type=""text"" placeholder=""Subject""
                                                               class=""form-control"">
                                                    </div>
                                                </div>
                                                <div class=""col-md-6"">
                                                    <div class=""form-group"">
                                                        <input type=""email"" placeholder=""Email""
                                                               class=""form-control"">
                                                    </div>
                                                </div>
                                            </div>

    ");
                WriteLiteral(@"                                        <div class=""form-group"">
                                                <textarea class=""form-control"" rows=""3""
                                                          placeholder=""Message""></textarea>
                                            </div>
                                            <a");
                BeginWriteAttribute("href", " href=\"", 4251, "\"", 4258, 0);
                EndWriteAttribute();
                WriteLiteral(">Submit</a>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""aa-contact-address-right"">
                                        <address>
                                            <h4>DailyShop</h4>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum modi
                                                dolor facilis! Nihil error, eius.
                                            </p>
                                            <p><span class=""fa fa-home""></span>Huntsville, AL 35813, USA</p>
                                            <p><span class=""fa fa-phone""></span>+994 00 000 00 00</p>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 5211, "\"", 5218, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span class=""fa fa-envelope""></span>Email: support@dailyshop.com</a>
                                        </address>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    ");
#nullable restore
#line 103 "C:\Users\Sadiq\Desktop\Final-Project\Backend\FinalProject\FinalProject\Views\Contact\Index.cshtml"
Write(await Component.InvokeAsync("InstagramPhoto"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  \r\n\r\n\r\n  \r\n</main>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.1/jquery.min.js""
            integrity=""sha512-aVKKRRi/Q/YV+4mjoKBsE4x3H+BkegoM/em46NNlCqNTmUYADjBbeNefNxYV7giUp0VxICtqdrbqU7iVaeZNXA==""
            crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script src=""https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.js""></script>

    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p""
            crossorigin=""anonymous""></script>


    <script src=""https://kit.fontawesome.com/0622708fc2.js"" crossorigin=""anonymous""></script>

    <script src=""./assets/js/contact/contact.js""></script>


");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
