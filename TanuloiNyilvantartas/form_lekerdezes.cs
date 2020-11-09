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
    public partial class form_lekerdezes : Form
    {
        public form_lekerdezes()
        {
            InitializeComponent();
        }

        private void form_lekerdezes_Load(object sender, EventArgs e)
        {
            dataGridView1_Tanulok.ColumnCount = 4;
            dataGridView1_Tanulok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Tanulok.Columns[0].Name = "id";
            dataGridView1_Tanulok.Columns[0].HeaderText = "ID";
            dataGridView1_Tanulok.Columns[1].Name = "nev";
            dataGridView1_Tanulok.Columns[1].HeaderText = "Név";
            dataGridView1_Tanulok.Columns[2].Name = "osztaly";
            dataGridView1_Tanulok.Columns[2].HeaderText = "Osztály";
            dataGridView1_Tanulok.Columns[3].Name = "szuletett";
            dataGridView1_Tanulok.Columns[3].HeaderText = "Született";
            try
            {
                Program.sql.CommandText = "SELECT `id`,`nev`,`osztaly`,`szuletett`FROM `tanulok` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView1_Tanulok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView1_Tanulok.Rows
                            [uj_sor_indexe];
                        uj_sor.Cells["id"].Value = dr.GetInt32("id");
                        uj_sor.Cells["nev"].Value = dr.GetString("nev");
                        uj_sor.Cells["osztaly"].Value = dr.GetString("osztaly");
                        uj_sor.Cells["szuletett"].Value = dr.GetDateTime("szuletett").ToString("yyyy-MM-dd");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                throw;
            }
        }

        private void form_lekerdezes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.form_nyito.Show();
        }
    }
}
