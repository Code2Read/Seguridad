using System.Web.Mvc;
using WebSecurityHttps.Filtros;

namespace WebSecurityHttps
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new RequireHttpsCustomFilter());
        }
    }
}