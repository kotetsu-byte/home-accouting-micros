using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Extensions.DependencyInjection;
using Домашняя_бухгалтерия.Data;
using Домашняя_бухгалтерия.Interfaces;
using Домашняя_бухгалтерия.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Домашняя_бухгалтерия
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseNpgsql("Host=localhost;Port=5432;Database=micros_test_task;Username=postgres;Password=jalol;");
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<Login>();

            var provider = services.BuildServiceProvider();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var scope = provider.CreateScope())
            {
                var loginForm = scope.ServiceProvider.GetRequiredService<Login>();
                Application.Run(loginForm);
            }
        }
    }
}