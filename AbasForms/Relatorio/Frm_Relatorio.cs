using ClinicaVeterinariaBD.Arquitetura;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVeterinariaBD.AbasForms
{
    public partial class Frm_Relatorio : Form
    {
        DateTime begginingDate;
        DateTime endingDate;
        public Frm_Relatorio(DateTime begginingDate, DateTime endDate)
        {
            InitializeComponent();
            this.begginingDate = begginingDate;
            this.endingDate = endDate;
        }

        private void procCirur_MouseClick(object sender, MouseEventArgs e)
        {
            GenerateReport(begginingDate, endingDate, "Procedimentos Cirúrgicos");

        }

        private void consultas_MouseClick(object sender, EventArgs e)
        {
            GenerateReport(begginingDate, endingDate, "Consulta");

        }

        private void procEstetico_MouseClick(object sender, EventArgs e)
        {
            GenerateReport(begginingDate, endingDate, "Procedimentos Estéticos");

        }

        private void vacinacao_MouseClick(object sender, EventArgs e)
        {
            GenerateReport(begginingDate, endingDate, "Vacinação");

        }

        private void GenerateReport(DateTime begginingDate, DateTime endDate, string typeService)
        {
            dataInicio.Text = $"Data inicial: {begginingDate.ToString("yyyy/MM/dd")}";
            dataFim.Text = $"Data final: {begginingDate.ToString("yyyy/MM/dd")}";

            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;
            string query = $"{connection.search_path} SELECT SUM(custo) as Faturamento FROM SERVICO WHERE tipo = '{typeService}'";
            command.CommandText = query;

            NpgsqlDataReader dataReader = command.ExecuteReader();
            BigInteger sales;
            dataReader.Read();

            if (dataReader["Faturamento"].ToString().Equals(""))
                sales = 0;
            else
                sales = BigInteger.Parse(dataReader["Faturamento"].ToString());

            MessageBox.Show(sales.ToString());
            command.Dispose();
            connection.Connection.Close();
        }
    }
}
