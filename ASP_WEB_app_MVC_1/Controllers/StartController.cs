using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            DateTime dateTime = DateTime.Now;

            if (dateTime.Hour < 6 && dateTime.Hour > 0)
            {
                return "Good Night";
            }
            else if (dateTime.Hour >= 6 && dateTime.Hour < 12)
            {
                return "Good Morning";
            }
            else if (dateTime.Hour >= 12 && dateTime.Hour < 18)
            {
                return "Good Day";
            }
            else
            {
                return "Good Evening";
            }
        }
    }
}
