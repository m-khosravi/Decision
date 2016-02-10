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
    using Decision.Common.HtmlHelpers;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Address/_AddressItem.cshtml")]
    public partial class _Views_Address__AddressItem_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.Address.AddressViewModel>
    {
        public _Views_Address__AddressItem_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"col-md-12 data-item\"");

WriteAttribute("id", Tuple.Create(" id=\"", 84), Tuple.Create("\"", 106)
, Tuple.Create(Tuple.Create("", 89), Tuple.Create("address-", 89), true)
            
            #line 2 "..\..\Views\Address\_AddressItem.cshtml"
, Tuple.Create(Tuple.Create("", 97), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 97), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n      \r\n        <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-mobile\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">شماره همراه:</label>\r\n                    <small>");

            
            #line 10 "..\..\Views\Address\_AddressItem.cshtml"
                      Write(Model.CellPhone);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-phone\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        شماره تلفن ثابت:\r\n                    </label>\r\n      " +
"              <small>");

            
            #line 18 "..\..\Views\Address\_AddressItem.cshtml"
                      Write(Model.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-map-o\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                        نوع آدرس:\r\n                    </label>\r\n             " +
"       <small>");

            
            #line 25 "..\..\Views\Address\_AddressItem.cshtml"
                      Write(Html.DisplayFor(a => a.Type));

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-location-arrow\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">شهر:</label>\r\n                    <small>");

            
            #line 31 "..\..\Views\Address\_AddressItem.cshtml"
                      Write(Model.City);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-map-marker\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">استان:</label>\r\n                    <small>");

            
            #line 36 "..\..\Views\Address\_AddressItem.cshtml"
                      Write(Model.State);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n           \r\n            <d" +
"iv");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-map-marker\"");

WriteLiteral("></i>\r\n                    <label");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">نشانی :</label>\r\n                    <small>");

            
            #line 44 "..\..\Views\Address\_AddressItem.cshtml"
                      Write(Model.Location.GetPersianNumber());

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n                </div>\r\n\r\n            </div>\r\n");

            
            #line 48 "..\..\Views\Address\_AddressItem.cshtml"
            
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Address\_AddressItem.cshtml"
              Html.RenderPartial(MVC.Shared.Views._AuditLog, Model);
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"panel-footer \"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"btn btn-primary btn-sm\"");

WriteLiteral(" data-ajax-oncomplete=\"editGetOnComplete(xhr,status)\"");

WriteLiteral("\r\n                   data-ajax=\"true\"");

WriteLiteral(" data-ajax-method=\"GET\"");

WriteLiteral("\r\n                   data-ajax-begin=\"onBegin(xhr,this)\"");

WriteLiteral("\r\n                   data-ajax-mode=\"REPLACE-WITH\"");

WriteLiteral(" data-ajax-success=\"inlineEditGetOnSuccess(data, status, xhr,\'");

            
            #line 55 "..\..\Views\Address\_AddressItem.cshtml"
                                                                                                         Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\')\"");

WriteLiteral("\r\n                   data-ajax-update=\"#address-");

            
            #line 56 "..\..\Views\Address\_AddressItem.cshtml"
                                         Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("href", Tuple.Create("\r\n                   href=\"", 2400), Tuple.Create("\"", 2466)
            
            #line 57 "..\..\Views\Address\_AddressItem.cshtml"
, Tuple.Create(Tuple.Create("", 2427), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Address.Edit(Model.Id))
            
            #line default
            #line hidden
, 2427), false)
);

WriteLiteral(" role=\"button\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-edit\"");

WriteLiteral("></i>ویرایش</a>\r\n\r\n                <button");

WriteLiteral(" class=\"btn-sm btn btn-danger\"");

WriteLiteral("\r\n                        type=\"button\"");

WriteLiteral(" data-delete-url=\"");

            
            #line 60 "..\..\Views\Address\_AddressItem.cshtml"
                                                  Write(Url.Action(MVC.Address.Delete()));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-applicant=\"");

            
            #line 60 "..\..\Views\Address\_AddressItem.cshtml"
                                                                                                     Write(Model.ApplicantId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-removal-element=\"#address-");

            
            #line 60 "..\..\Views\Address\_AddressItem.cshtml"
                                                                                                                                                        Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2744), Tuple.Create("\"", 2765)
, Tuple.Create(Tuple.Create("", 2749), Tuple.Create("remove-", 2749), true)
            
            #line 60 "..\..\Views\Address\_AddressItem.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create("", 2756), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 2756), false)
);

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral("></i>\r\n                    حذف\r\n                </button>\r\n            </div>\r\n  " +
"          <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
