using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHelper
{
    static class Program
    {
    public static string filePath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "data.IS");
    public static Form1 form1;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            Application.Run(form1);
            var db = new SQLiteConnection(filePath);
        }
    }
}
