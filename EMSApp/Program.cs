using EMSApp.Data;
using EMSApp.Repository;
using EMSApp.Repository.InMemory;
using EMSApp.Repository.MsSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EmployeeDbContext>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeDBRepository>();
//builder.Services.AddScoped<IEmployeeRepository,EmployeeDBRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=GetAllEmployees}/{id?}");

app.Run();
