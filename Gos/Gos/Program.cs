using Gos.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ����������� ��������� ���� ������ � PostgreSQL
builder.Services.AddDbContext<SpoProjectContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))); // ���������� ������ PostgreSQL

builder.Services.AddControllersWithViews();

var app = builder.Build();

// ��������� ��� ������ � �������� � ����������
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ��������� �������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Authorization}/{action=Index}/{id?}");
});

app.Run();
