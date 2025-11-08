using KossanVMS.Data;
using Microsoft.EntityFrameworkCore;

namespace KossanVMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var optionsBuilder = new DbContextOptionsBuilder<VmsContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=newVms;User Id=root; Password=Kossan@123456;");

            var dbContext = new VmsContext(optionsBuilder.Options);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Application.Run(new MainPage(dbContext));
            Application.Run(new ADLoginScreen());
        }
    }
}