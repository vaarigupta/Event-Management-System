#pragma checksum "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c1f84ef280ba9438056af123427f8d2e00aee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_ViewDetails), @"mvc.1.0.view", @"/Views/Event/ViewDetails.cshtml")]
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
#line 1 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73c1f84ef280ba9438056af123427f8d2e00aee3", @"/Views/Event/ViewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20a1b69223e6b1c0b253c2fcdf9856c5d56b091", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_ViewDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nagarro.BookReading.Web.Models.EventViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetEvents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""col-md-12"" align=""center"">
    <div class=""card mb-12 shadow-sm"" style=""width: 50%;"" align=""center"">
        <img class=""bd-placeholder-img card-img-top"" width=""100"" height=""225"" src=""https://janefriedman.com/wp-content/uploads/2016/07/book-reading-1000x750.jpg"" alt=""Card image cap"">
        <div class=""card-body"">
            <h3 class=""card-title font-weight-bold text-dark"">");
#nullable restore
#line 7 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                         Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n            <div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 11 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                 if (Model.description != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <p class=\"card-text\"> <p class=\"text-success d-inline\">Description :</p> ");
#nullable restore
#line 14 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                                                            Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 16 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <p class=\"card-text\"> <p class=\"text-success d-inline\">Venue</p> : ");
#nullable restore
#line 18 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                                                  Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div>\r\n                    <p class=\"card-text\"> <p class=\"text-success d-inline\">Event Date</p> : ");
#nullable restore
#line 22 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                                                       Write(Model.date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div>\r\n                    <p class=\"card-text\"> <p class=\"text-success d-inline\">Start Time :</p> ");
#nullable restore
#line 26 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                                                       Write(Model.startTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 28 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                 if (Model.duration != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <p class=\"card-text\"> <p class=\"text-success d-inline\">Duration :</p> ");
#nullable restore
#line 31 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                                                         Write(Model.duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 33 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                 if (Model.invitees != null)
                {
                    var count = Model.invitees.Split(',').Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <p class=\"card-text\"> <p class=\"text-success d-inline\">Total Invitees :</p> ");
#nullable restore
#line 39 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                                                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 41 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div>It\'s a <p class=\"font-weight-bold d-inline text-primary\">");
#nullable restore
#line 47 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                                             Write(Model.eventType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>Event</div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div>Organised by <p class=\"font-weight-bold d-inline text-danger\">");
#nullable restore
#line 50 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                                                  Write(Model.organiser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                </div>\r\n            </div>\r\n            <p></p>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c1f84ef280ba9438056af123427f8d2e00aee311692", async() => {
                WriteLiteral("<p class=\"font-weight-bold d-inline\">Back to Event Page</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <p></p>\r\n\r\n    <hr style=\"height:2px; width:80%; border-width:0; color:black; background-color:black\">\r\n    <div class=\"container\">\r\n        <div class=\"col-md-12\" align=\"center\" style=\"width: 50%;\">\r\n");
#nullable restore
#line 64 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
             using (Html.BeginForm("PostComment", "Comment", new { EventId = Model.Id }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-group"">
                    <div class=""row"">
                        <div class=""col-sm-3"">

                            <img src=""https://image.ibb.co/jw55Ex/def_face.jpg"" class=""img img-rounded img-fluid"" />
                            <p>
                                <a class=""float-left"" href=""https://maniruzzaman-akash.blogspot.com/p/contact.html""><strong class=""text-success"">Anonymous</strong></a>
                                <span class=""float-right""><i class=""text-warning fa fa-star""></i></span>
                                <span class=""float-right""><i class=""text-warning fa fa-star""></i></span>
                                <span class=""float-right""><i class=""text-warning fa fa-star""></i></span>
                                <span class=""float-right""><i class=""text-warning fa fa-star""></i></span>

                            </p>
                        </div>

                        <div class=""col-sm-9"">
                            <te");
            WriteLiteral(@"xtarea class=""form-control"" name=""comment"" id=""comment"" rows=""5""></textarea>
                        </div>
                    </div>

                </div>
                <div class=""form-group"">
                    <div class=""col-sm-offset-2 col-sm-10"">
                        <button class=""btn btn-success btn-circle text-uppercase"" type=""submit"" value=""Post"" id=""submitComment""><span class=""glyphicon glyphicon-send""></span> Post comment</button>
                    </div>
                </div>
");
#nullable restore
#line 92 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 97 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
     if (@Model.Comments.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"class=\"display-4 text-danger\"\">Previous Comments!!</h3>\r\n");
#nullable restore
#line 100 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
         foreach (var i in Model.Comments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""container"">
                <div class=""card mb-12 shadow-sm"" style=""width: 50%;"" align=""center"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-md-2"">
                                <img src=""https://image.ibb.co/jw55Ex/def_face.jpg"" class=""img img-rounded img-fluid"" />
                                <p>
                                    <a class=""float-left"" href=""https://maniruzzaman-akash.blogspot.com/p/contact.html""><strong class=""text-danger"">Anonymous</strong></a>
                                    <span class=""float-right""><i class=""text-warning fa fa-star""></i></span>
                                    <span class=""float-right""><i class=""text-warning fa fa-star""></i></span>
                                    <span class=""float-right""><i class=""text-warning fa fa-star""></i></span>
                                    <span class=""float-right""><i class=""text-warning fa fa-star""></");
            WriteLiteral("i></span>\r\n\r\n                                </p>\r\n                            </div>\r\n                            <div class=\"col-md-10\">\r\n                                <p>");
#nullable restore
#line 118 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                              Write(i.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                   \r\n                </div>\r\n                 <small align=\"right\" class=\"text-muted\">");
#nullable restore
#line 126 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
                                                    Write(i.timeStamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 129 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "D:\Nagarro Training\Assignments\ASP.NET Core Assignment-v3\5-ASP.NET Core Assignment - Main\Nagarro.BookReading.Web\Views\Event\ViewDetails.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nagarro.BookReading.Web.Models.EventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
