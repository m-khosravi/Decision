﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class _Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\Index.cshtml"
  
    ViewBag.Title = "پنل مدیریتی";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\Home\Index.cshtml"
  Html.RenderAction(MVC.Home.GetBenckMarks());
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<hr />\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-4 asyncLoad\"");

WriteLiteral(" id=\"TopScoreApplicants\"");

WriteLiteral(" data-load-url=\"\"");

WriteLiteral(" data-progress-div=\"progressOne\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"progressOne\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 317), Tuple.Create("\"", 367)
            
            #line 10 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 323), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Content/images/loading.gif")
            
            #line default
            #line hidden
, 323), false)
);

WriteLiteral(" alt=\"loading...\"");

WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"col-md-4 asyncLoad\"");

WriteLiteral(" id=\"NewAddedApplicants\"");

WriteLiteral(" data-load-url=\"\"");

WriteLiteral(" data-progress-div=\"progressTwo\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"progressTwo\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 616), Tuple.Create("\"", 666)
            
            #line 16 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 622), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Content/images/loading.gif")
            
            #line default
            #line hidden
, 622), false)
);

WriteLiteral(" alt=\"loading...\"");

WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
