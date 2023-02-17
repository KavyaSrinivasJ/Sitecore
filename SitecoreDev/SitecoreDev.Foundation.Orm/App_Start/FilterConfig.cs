using System.Web;
using System.Web.Mvc;

namespace SitecoreDev.Foundation.Orm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
