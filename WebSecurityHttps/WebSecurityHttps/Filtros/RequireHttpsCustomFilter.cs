using System;
using System.Web.Mvc;

namespace WebSecurityHttps.Filtros
{
    public class RequireHttpsCustomFilter : RequireHttpsAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            if (filterContext.HttpContext.Request.IsLocal)
            {
                //Cuando la conexion a la aplicacion es local, no pide HTTPS
                return;
            }

            base.OnAuthorization(filterContext);
        }
    }
}