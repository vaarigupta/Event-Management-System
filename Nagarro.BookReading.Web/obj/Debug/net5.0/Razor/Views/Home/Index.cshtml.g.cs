#pragma checksum "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63872719972a843e877e16abb9ace763fdfb4170"
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
#line 1 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63872719972a843e877e16abb9ace763fdfb4170", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20a1b69223e6b1c0b253c2fcdf9856c5d56b091", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Nagarro.BookReading.Web.Models.EventViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_EventDetailsIndexPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
  
    var user = await _userManager.GetUserAsync(User);
    var email = user != null ? user.Email : "";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""text-center"">
        <h1 class=""display-4 text-danger font-weight-bold"">Welcome!!</h1>
        <div class=""row"">
            <div class=""col-md-6 bg-info"">
                <h4><a class=""text-dark "" href=""#previousEvents""> Previous Events📕</a></h4>
                <div class=""row"" id=""previousEvents"">
");
#nullable restore
#line 21 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                     if (email == "myadmin@bookevents.com")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                         foreach (var _event in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                             if (_event.date < DateTime.Now)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63872719972a843e877e16abb9ace763fdfb41705375", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 27 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = _event;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                         
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                         foreach (var _event in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                             if (_event.date < DateTime.Now && _event.eventType.Equals("Public"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63872719972a843e877e16abb9ace763fdfb41708266", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 39 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = _event;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"col-md-6 bg-success\">\r\n                <h4><a class=\"text-dark \" href=\"#upcomingEvents\">Upcoming Events📙</a></h4>\r\n                <div class=\"row\" id=\"upcomingEvents\">\r\n");
#nullable restore
#line 52 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                     if (email == "myadmin@bookevents.com")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                         foreach (var _event in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                             if (_event.date > DateTime.Now)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63872719972a843e877e16abb9ace763fdfb417011613", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 58 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = _event;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                         
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                         foreach (var _event in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                             if (_event.date > DateTime.Now && _event.eventType.Equals("Public"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63872719972a843e877e16abb9ace763fdfb417014505", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 70 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = _event;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 71 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Nagarro.BookReading.Web.Models.EventViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
