#pragma checksum "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcb01944bd90edbd89cadbe2e3de477e27f57c40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NowShowing), @"mvc.1.0.view", @"/Views/Shared/_NowShowing.cshtml")]
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
#line 1 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_ViewImports.cshtml"
using OnlineMovieTicketBookingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb01944bd90edbd89cadbe2e3de477e27f57c40", @"/Views/Shared/_NowShowing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db105dce3486a9c51c185e842f4ab27d9704963f", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared__NowShowing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineMovieTicketBookingApp.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
 foreach (var item in Model)
{
   

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
    if (item.Status == "Now Showing")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n        <div>\r\n            <a");
            BeginWriteAttribute("href", " href=\'", 226, "\'", 286, 1);
#nullable restore
#line 11 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
WriteAttributeValue("", 233, Url.Action("Details", "Movie", new { id = item.Id }), 233, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=", 310, "", 329, 1);
#nullable restore
#line 12 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
WriteAttributeValue("", 315, item.Poster, 315, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" />\r\n            </a>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\"><b>");
#nullable restore
#line 17 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n            <h6 class=\"card-text\"><i>(");
#nullable restore
#line 18 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
                                 Write(item.Age_Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</i></h6>\r\n            <p class=\"card-text\">\r\n                ");
#nullable restore
#line 20 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
           Write(item.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 22 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
           Write(item.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 24 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
           Write(item.Run_Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes\r\n            </p>\r\n            <button class=\"btn btn-warning\">Buy Tickets</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\kaiya\source\repos\OnlineMovieTicketBookingApp\OnlineMovieTicketBookingApp\Views\Shared\_NowShowing.cshtml"
 
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineMovieTicketBookingApp.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
