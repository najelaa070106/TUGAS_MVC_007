<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Tambahin session service
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // lama session
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// ✅ Tambahin Authentication pakai Cookie
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login";  // redirect ke login kalau belum auth
        options.LogoutPath = "/Login/Logout";
        options.AccessDeniedPath = "/Login/AccessDenied"; // opsional
    });

=======
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
>>>>>>> c93be1074cac6ec7a368a48bf8cf1f4872d649c6
builder.Services.AddControllersWithViews();

var app = builder.Build();

<<<<<<< HEAD
// Aktifin session sebelum MapControllerRoute
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

// ✅ Tambahin authentication
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");
=======
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

>>>>>>> c93be1074cac6ec7a368a48bf8cf1f4872d649c6

app.Run();
