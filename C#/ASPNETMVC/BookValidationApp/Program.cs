var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

//  Set startup to Book/Add
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Book}/{action=Add}/{id?}");

app.Run();
