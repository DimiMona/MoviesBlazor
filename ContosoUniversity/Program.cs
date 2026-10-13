using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContosoUniversity.Data;
//using ContosoUniversity.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContosoUniversityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContosoUniversityContext") ?? throw new InvalidOperationException("Connection string 'ContosoUniversityContext' not found.")));
//builder.Services.AddDbContext<ContosoUniversityContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("ContosoUniversityContext") ?? throw new InvalidOperationException("Connection string 'ContosoUniversityContext' not found.")));

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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

CreateDbIfNotExists(app);

app.Run();


static void  CreateDbIfNotExists(IHost host)
{
    using (IServiceScope scope=host.Services.CreateScope())
    {
        IServiceProvider provider = scope.ServiceProvider;
        try
        {
            ContosoUniversityContext context = provider.GetRequiredService<ContosoUniversityContext>();
            DbInitializer.Initialize(context);
        }
        catch (Exception ex)
        {
            ILogger<Program> logger = provider.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "Ошибка инициализации Базы данных");
        }
    }
}