using Gos.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ����������� ��������� ���� ������ � PostgreSQL
builder.Services.AddDbContext<SpoProjectContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// �������� ������� ��� ������ � ��������
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // ����� ����� ������ (30 �����)
    options.Cookie.HttpOnly = true; // ������ �� XSS
    options.Cookie.IsEssential = true; // ������ ����� �������� ���� ���� ������������ �� ������ ����
});

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

// �������� middleware ��� ������������� ������
app.UseSession();

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