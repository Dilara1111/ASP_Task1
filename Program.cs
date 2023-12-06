var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
app.MapControllerRoute(
    name: "defailt",
    pattern: "{controller}/{action}/{id?}"
    );



app.Run();
