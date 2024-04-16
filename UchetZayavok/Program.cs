using UchetZayavok.Database;
using UchetZayavok.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace UchetZayavok;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    static readonly IServiceCollection services = new ServiceCollection();

    [STAThread]
    static void Main(string[] args)
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        InitDb();

        var provider = services.BuildServiceProvider();
        Application.Run(new AuthorizationForm(provider));
    }

    static void InitDb()
    {
        services.AddDbContext<AppDbContext>((options =>
            options.UseNpgsql(ConfigurationManager.ConnectionStrings["conn"].ConnectionString)));
    }

}