using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TanuloiNyilvantartas
{
    static class Program
    {
        public static Form form_nyito;
        public static Form form_bevitel;
        public static Form form_lekerdezes;
        public static Form form_modositas;
        public static Form form_torles;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;
        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tanulok";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException myex)
            {
                Console.WriteLine(myex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_nyito = new form_nyito();
            form_bevitel = new form_bevitel();
            form_lekerdezes = new form_lekerdezes();
            form_modositas = new form_modositas();
            form_torles = new form_torles();
            Application.Run(new form_nyito());
        }
    }
}
