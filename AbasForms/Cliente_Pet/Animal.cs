using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaVeterinariaBD.Arquitetura;
using System.Windows.Input;


namespace ClinicaVeterinariaBD.AbasForms.Cliente_Pet
{
    public partial class Animal : Form
    {
        public Animal instance;
        public TextBox tb1;
        public string Id_Cliente { get; set; }

        public void ProcurarCliente(string Id)
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = "SELECT * FROM clinicaveterinaria2.Pessoa WHERE tipo = 'cliente' AND id = cast(@IdBuscado as int)";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@IdBuscado", Id);
                    NpgsqlDataReader dr = Command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView2.DataSource = dt;
                }
            }
        }

        public void ProcurarAnimal(String Id)
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = "SELECT * FROM clinicaveterinaria2.Animal WHERE iddono = cast(@IdBuscado as int)";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@IdBuscado", Id);
                    NpgsqlDataReader dr2 = Command.ExecuteReader();
                    DataTable dt2 = new DataTable();
                    dt2.Load(dr2);
                    dataGridView1.DataSource = dt2;
                }
            }
        }

        public Animal()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
