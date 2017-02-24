using System;
using System.Web.Mvc;

namespace NTierMvcFramework.Common.MvcToolkit.Filters
{
    /// <summary>
    /// http://www.dotnettips.info/post/825 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public sealed class AjaxOnlyAttribute : ActionFilterAttribute
    {

        #region OnActionExecuting
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                base.OnActionExecuting(filterContext);
            }
            else
            {
                throw new InvalidOperationException("This operation can only be accessed via Ajax requests");
            }
        }
        #endregion

    }
}