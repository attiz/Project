using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace Szerver.App_Start
{
    public class AllowCors : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext == null)
            {
                throw new ArgumentException("ActionExecutedContext");
            }
            else
            {
                actionExecutedContext.Response.Headers.Remove("Access-Control-Allow-Origin");
                actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            }
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}