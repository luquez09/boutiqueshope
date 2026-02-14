using System;
using System.Windows.Forms;
using boutiqueshope.UI;

namespace boutiqueshope
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //AppContext.SetSwitch("System.Windows.Forms.UseLegacyAccessibilityFeatures", false);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuOptions());
        }
    }
}
