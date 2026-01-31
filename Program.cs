using System.Configuration;

namespace LabLink
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string licenseKey = ConfigurationManager.AppSettings["SyncfusionLicenseKey"];
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.frmMain());
        }
    }
}