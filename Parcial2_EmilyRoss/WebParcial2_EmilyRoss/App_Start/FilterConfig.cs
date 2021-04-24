using System.Web;
using System.Web.Mvc;

namespace WebParcial2_EmilyRoss
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
