using Manga.Repositories.ThinhPH;
using Manga.Services.ThinhPH;
using Manga.Services.ThinhPH.Interface;

namespace Manga.WebMVCApp.ThinhPH
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // ??ng ký t?ng Service (B?t bu?c ph?i có dòng này ?? Controller nh?n di?n)
            builder.Services.AddScoped<IContractMasterThinhPhService, ContractMasterThinhPhService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
