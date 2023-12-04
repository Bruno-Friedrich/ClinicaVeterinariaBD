using ClinicaVeterinariaBD.AbasForms.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ClinicaVeterinariaBD.AbasForms
{
    public partial class Frm_Estoque : Form
    {
        public Frm_Estoque()
        {
            InitializeComponent();
            NpgsqlConnection Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=CliniVet;User Id=postgres;Password=admin;");
            Connection.Open();
            NpgsqlCommand Command = new NpgsqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.Text;
            Command.CommandText = "SELECT * FROM clinicaveterinaria2.Produto";
            NpgsqlDataReader dr = Command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Dt_Estoque.DataSource = dt;
            Command.Dispose();
            Connection.Close();
        }

        private void Btn_AddProduto_Click(object sender, EventArgs e)
        {
            // Crie uma instância do formulário filho
            using (Frm_InfoProduto formFilho = new Frm_InfoProduto())
            {
                // Exiba o formulário filho como um diálogo modal
                formFilho.ShowDialog();
            }
        }


    }
}
