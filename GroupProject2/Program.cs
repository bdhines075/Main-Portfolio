using GroupProject2;
using GroupProject2.Data;
using GroupProject2.Hubs;
using GroupProject2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR(); // SignalR for all hubs
builder.Services.AddHttpClient();
builder.Services.AddScoped<DeezerService>(); // Needed for Guess game
builder.Services.AddScoped<IDAL, DAL>();


var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Map all hubs
app.MapHub<CharadesHub>("/charadesHub");
app.MapHub<ChameleonHub>("/chameleonHub");
app.MapHub<ChatHub>("/chatHub");

app.MapRazorPages();
app.MapDefaultControllerRoute();


app.Run();
