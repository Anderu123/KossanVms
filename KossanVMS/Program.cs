using KossanVMS.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

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
            var branch = ConfigurationManager.AppSettings["Branch"] ?? "DEFAULT";
            AppSession.BranchName = branch;

            var connStr = ConfigurationManager.ConnectionStrings["DbConnStr"]?.ConnectionString?? throw new Exception("Connection string 'DbConnStr' not found.");



            var optionsBuilder = new DbContextOptionsBuilder<VmsContext>();
            optionsBuilder.UseSqlServer(connStr);

            var dbContext = new VmsContext(optionsBuilder.Options);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Application.Run(new MainPage(dbContext));
            Application.Run(new ADLoginScreen());
        }
    }
}