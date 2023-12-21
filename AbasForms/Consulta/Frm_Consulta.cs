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
            string query = $"{connection.search_path} SELECT PCLIENTE.nome AS nomecliente, PFUNC.nome AS nomefuncionario,nomeanimal, horaini, horafim, custo, SERVICO.tipo  FROM SERVICO, FUNCIONARIO, CLIENTE, PESSOA AS PFUNC, PESSOA AS PCLIENTE  WHERE data = '{currentDate.ToString("yyyy-MM-dd")}' AND FUNCIONARIO.id = SERVICO.funcid  AND CLIENTE.id = SERVICO.iddono AND PFUNC.id = FUNCIONARIO.id AND PCLIENTE.id = CLIENTE.id ORDER BY horaini";
            command.CommandText = query;



            label1.Text = $"Consultas do dia [{currentDate.ToString("dd/MM/yyyy")}]";
            NpgsqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            SchedulingViewer.DataSource = dataTable;

            SchedulingViewer.Columns["nomecliente"].HeaderText = "Nome do Cliente";
            SchedulingViewer.Columns["nomefuncionario"].HeaderText = "Nome do Funcionario";
            SchedulingViewer.Columns["nomeanimal"].HeaderText = "Nome do Animal";
            SchedulingViewer.Columns["horaini"].HeaderText = "Horário de início";
            SchedulingViewer.Columns["horafim"].HeaderText = "Horário de fim";
            SchedulingViewer.Columns["custo"].HeaderText = "Custo";
            SchedulingViewer.Columns["tipo"].HeaderText = "Tipo";

            command.Dispose();
            connection.Connection.Close();
        }

        private void btn_BuscaServico_Click(object sender, EventArgs e)
        {

            Frm_BuscaServico searchServiceWindow = new Frm_BuscaServico();
            searchServiceWindow.Show();
        }

        private void Frm_Consulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s scheduleWindows = new s();
            scheduleWindows.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
