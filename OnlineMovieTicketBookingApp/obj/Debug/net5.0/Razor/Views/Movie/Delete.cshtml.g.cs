#pragma checksum "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c515f031ea26b84fd7b1e05fd6942cd6d8fe12b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Delete), @"mvc.1.0.view", @"/Views/Movie/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c515f031ea26b84fd7b1e05fd6942cd6d8fe12b2", @"/Views/Movie/Delete.cshtml")]
    public class Views_Movie_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMovieTicketBookingApp.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>
<style>
    .container{
        position:relative;
        left:100px;
        top:10px;
    }
    .message {
        color:red;
    }
</style>

<div class=""container"">
    <h3>Are you sure you want to delete this?</h3>
    <p class=""message"">
        ");
#nullable restore
#line 24 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <div>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 30 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 33 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 36 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 39 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 42 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 45 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 48 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Age_Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 51 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Age_Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 54 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Run_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 57 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Run_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 60 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Release_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 63 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Release_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 66 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 69 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 72 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Cast));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 75 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Cast));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 78 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 81 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 84 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Distributor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 87 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Distributor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 90 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Synopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 93 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Synopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 96 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Poster));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 99 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Poster));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 102 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 105 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 108 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.BgImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 111 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
           Write(Html.DisplayFor(model => model.BgImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c515f031ea26b84fd7b1e05fd6942cd6d8fe12b215406", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c515f031ea26b84fd7b1e05fd6942cd6d8fe12b215677", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 116 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Movie\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-outline-danger\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c515f031ea26b84fd7b1e05fd6942cd6d8fe12b217511", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                WriteLiteral("\r\n            <br />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMovieTicketBookingApp.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
