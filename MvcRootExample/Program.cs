var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

    name: "anonim",
    pattern: "anonim",
    defaults: new { controller = "Companies", action = "Anonim" }
    );
app.MapControllerRoute(

    name: "limited",
    pattern: "limited",
    defaults: new { controller = "Companies", action = "Limited" }
    );
app.MapControllerRoute(

    name: "sahis",
    pattern: "sahis",
    defaults: new { controller = "Companies", action = "Sahis" }
    );
app.MapControllerRoute(

    name: "companieshome",
    pattern: "companies",
    defaults: new { controller = "Home", action = "Index" }
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
