using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaVeterinariaBD.AbasForms.Consulta;
using Npgsql;
using ClinicaVeterinariaBD.Arquitetura;

namespace ClinicaVeterinariaBD
{
    public partial class Frm_Consulta : Form
    {
        public Frm_Consulta()
        {
            InitializeComponent();

            DateTime currentDate = DateTime.Now;

            //Conexão ao banco de dados
            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();

            //Configuração do comando de busca
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;
            string query = $"SET search_path TO clinicaveterinaria2; SELECT nomeanimal, iddono, funcid, horaini, horafim, custo, tipo FROM SERVICO WHERE data = '{currentDate.ToString("yyyy-MM-dd")}'";
            command.CommandText = query;



            label1.Text = $"Consultas do dia [{currentDate.ToString("dd/MM/yyyy")}]";
            NpgsqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            SchedulingViewer.DataSource = dataTable;
            command.Dispose();
            connection.Connection.Close();
        }

        private void btn_BuscaServico_Click(object sender, EventArgs e)
        {

            Frm_BuscaServico searchServiceWindow = new Frm_BuscaServico();
            searchServiceWindow.Show();
        }
    }
}
