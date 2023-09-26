using ASP_WEB_app_MVC_1.Models.Storages;
using ASP_WEB_app_MVC_1.Services.Interfaces;
using ASP_WEB_app_MVC_1.Services.Storages;

namespace ASP_WEB_app_MVC_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IProductStorage, ProductStorageService>();
            builder.Services.AddSingleton<IBasketStorage, BasketStorageService>();
            builder.Services.AddSingleton<IUserStorage, UserStorage>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
           
            app.UseHttpsRedirection(); //  позволяет запрос хттп конверирвоатьв хттпс 
            app.UseStaticFiles(); // позволяет использ статические файлы  жаваскрипт сиэсэс картинки текст итд

            app.UseRouting(); // добавление шаблона маршрутизации 

            app.UseAuthorization();
            
            //http:// localhost:5001/hello/start         hello  контроллер   start - дейстк=вие  action
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=myshop}/{action=allproducts}/{first?}/{second?}/{thirth?}");   // pattern: "{controller=Home}/{action=Index}/{id?}/{a?}");

            app.Run();
        }
    }
}