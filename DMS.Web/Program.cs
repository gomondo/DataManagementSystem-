using DMS.DAL;
using DMS.Web.Components;
using DMS.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// DbContexts

var connectionString = builder.Configuration.GetConnectionString("dmsConnectionString");

builder.Services.AddDbContextFactory<DMSDbContext>(
    option => option.UseSqlServer(connectionString));
// ASP.NET Core Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(option =>
{
    option.Password.RequiredLength = 8;
})
.AddEntityFrameworkStores<DMSDbContext>()
.AddSignInManager<SignInManager<ApplicationUser>>();

//Add authentication state provider to use in App.razor root component
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddFluentUIComponents();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>() .AddInteractiveServerRenderMode();

app.Run();
