using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Radzen;
using Zip2Clear.Data;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSyncfusionBlazor();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjgxNjA5QDMyMzAyZTMyMmUzMFZnNlJrdTUyYWFNMGZEK1NWVXdkMXFzMTJYSVJBVVpaL1kvOFIwakRMaTQ9");
builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped<SfDialogService>();

// Add Db
builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlite("Data Source = MyData.db");
    options.EnableSensitiveDataLogging();
});

builder.Services.AddScoped<DeclarationServices>();
builder.Services.AddScoped<InvoiceServices>();
builder.Services.AddScoped<ItemServices>();
builder.Services.AddScoped<VendorServices>();

// Radzen components
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();

// blazorise
builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
