using IUIS.Forms.Login;
using IUIS.Utilities;
using System.Collections.Generic;

namespace IUIS
{
    internal static class Program
    {
        private static readonly HashSet<Form> ThemedForms = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Idle += (_, _) =>
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (ThemedForms.Add(form))
                    {
                        ModernUi.ApplyTheme(form);
                        form.FormClosed += (_, _) => ThemedForms.Remove(form);
                    }
                }
            };
            Application.Run(new frmLogin());
        }
    }
}
