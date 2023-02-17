using System.Web;
using System.Web.Mvc;

namespace SitecoreDev.Foundation.Model
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
