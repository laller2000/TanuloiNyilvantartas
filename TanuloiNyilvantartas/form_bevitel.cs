using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TanuloiNyilvantartas
{
    public partial class form_bevitel : Form
    {
        public form_bevitel()
        {
            InitializeComponent();
        }

        private void button1_Vissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_nyito.Show();
        }

        private void button2_Kiiras_Click(object sender, EventArgs e)
        {
            string nev=textBox1_Nev.Text.Trim();
            if (String.IsNullOrWhiteSpace(nev))
            {
                MessageBox.Show("Addjon meg nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1_Nev.Focus();
                return;
            }
            string osztaly=comboBox1_Osztaly.SelectedItem.ToString();
            if (comboBox1_Osztaly.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon osztályt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime szuletett=dateTimePicker1_Szuletett.Value;
            Program.sql.CommandText = "INSERT INTO `tanulok`(`id`, `nev`, `osztaly`, `szuletett`) VALUES (NULL,'"+nev+"','"+osztaly+"','"+szuletett.ToString("yyyy-MM-dd")+"')";
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show("A rögzítés sikertelen!\n\n" + myex.Message);
                throw;
            }
            comboBox1_Osztaly.SelectedIndex = -1;
            textBox1_Nev.Text = "";
        }
    }
}
