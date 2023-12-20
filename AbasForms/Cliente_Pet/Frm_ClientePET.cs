using ClinicaVeterinariaBD.AbasForms.Cliente_Pet;
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

namespace ClinicaVeterinariaBD.AbasForms
{
    public partial class Frm_ClientePET : Form
    {
        public Frm_ClientePET()
        {
            InitializeComponent();

            DbConnection Connection = new DbConnection();
            NpgsqlCommand Command = new NpgsqlCommand();
            Command.Connection = Connection.Connection;
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT * FROM clinicaveterinaria2.Pessoa WHERE tipo = 'cliente'";
            NpgsqlDataReader dr = Command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Dt_Consulta.DataSource = dt;
            Command.Dispose();
            Connection.Connection.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Icn_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserInputText = textBox1.Text.ToLower().Trim();

            using (DbConnection Connection = new DbConnection())
            {
                string query = "SELECT id FROM clinicaveterinaria2.Pessoa WHERE cast(id as varchar) LIKE @IdBuscado";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@IdBuscado", "%" + UserInputText + "%");
                    NpgsqlDataReader dr = Command.ExecuteReader();
                    if ((UserInputText == ""))
                    {
                        MessageBox.Show("Insira um ID", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Animal animal = new Animal();
                        animal.instance.tb1.Text = UserInputText;

                        //Animal DataGrid1
                        animal.ProcurarAnimal(UserInputText);

                        //Animal DataGrid2
                        animal.ProcurarCliente(UserInputText);
                        animal.Show();
                    }
                    Command.Dispose();
                    Connection.Connection.Close();
                }
            }
        }

        private void Dt_Consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
