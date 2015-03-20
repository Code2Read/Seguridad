using System;
using System.Web.Mvc;

namespace WebSecurityHttps
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
        
    }
}