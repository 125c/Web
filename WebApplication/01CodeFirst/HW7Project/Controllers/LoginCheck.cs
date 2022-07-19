using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW7Project.Controllers
{
    public class LoginCheck:ActionFilterAttribute
    {
        void LoginState(HttpContext context) 
        {
            if (context.Session["user"] == null) 
            {
                context.Response.Redirect("/Home/Index");
            }
        
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext context=HttpContext.Current;
            LoginState(context);
        }
    }
}