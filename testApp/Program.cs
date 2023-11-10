using System;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;

namespace LRTapp
{
    static class Program
    {
        public static List<PatientData> patients;
        public static Client client;
        public static int currentPatient;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainWindow());
        }
    }
}
