using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Kill any existing instances (prevents build errors)
            foreach (var process in Process.GetProcessesByName("GymClassBooking.SpotMe"))
            {
                if (process.Id != Process.GetCurrentProcess().Id)
                {
                    process.Kill();
                    process.WaitForExit(1000);
                }
            }

            try
            {
                // Add global exception handlers
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MessageBox.Show("Application starting...", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Run(new LoginForm());

                MessageBox.Show("Application exited normally", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatal error in Main: {ex.Message}\n\n{ex.StackTrace}",
                    "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"Thread Exception: {e.Exception.Message}\n\n{e.Exception.StackTrace}",
                "Unhandled Thread Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            MessageBox.Show($"Unhandled Exception: {ex?.Message}\n\n{ex?.StackTrace}",
                "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}