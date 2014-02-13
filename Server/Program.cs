using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String dataDirectory = Path.GetDirectoryName(Path.GetDirectoryName(
                         System.IO.Path.GetDirectoryName(
                            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
            dataDirectory = dataDirectory.Remove(0, 6);
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
            
            Application.Run(new MainForm());
        }
    }
}
