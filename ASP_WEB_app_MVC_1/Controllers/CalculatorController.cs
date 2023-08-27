using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_app_MVC_1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(string first, string second, string thirth) 
        {
            double.TryParse(first, out var A);
            double.TryParse(second, out var B);

            //https://localhost:7006/calculator/index/9/8,3/+

            switch (thirth)
            {
                case "+":
                    
                    return $"{A} + {B} = {A + B}";

                case "-":

                    return $"{A} - {B} = {A - B}";
                case "*":

                    return $"{A} * {B} = {A * B}";

                case "/":

                    return $"{A} / {B} = {A / B}";

                default:
                    
                    return "неизвестная операция указана в качестве третьего сегмента поддерживаются +,-,*,/,";
            }     
        }

        public string Index2(string a, string b, string c="+")
        {
            double.TryParse(a, out var A);
            double.TryParse(b, out var B);

            //https://localhost:7006/calculator/index/9/8,3/+

            switch (c)
            {
                case "+":

                    return $"{A} + {B} = {A + B}";

                case "-":

                    return $"{A} - {B} = {A - B}";
                case "*":

                    return $"{A} * {B} = {A * B}";

                case "/":

                    return $"{A} / {B} = {A / B}";

                default:

                    return "неизвестная операция указана в качестве третьего сегмента поддерживаются +,-,*,/,";
            }
        }
    }
}
