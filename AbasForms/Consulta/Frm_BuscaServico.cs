using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using ClinicaVeterinariaBD.Arquitetura;
using Microsoft.VisualBasic;
using Npgsql;

namespace ClinicaVeterinariaBD.AbasForms.Consulta
{
    public partial class Frm_BuscaServico : Form
    {
        public Frm_BuscaServico()
        {
            InitializeComponent();

            INPUT_ID_cliente.Visible = false;
            INPUT_ID_funcionario.Visible = false;
            label_id_cliente.Visible = false;
            label_id_funcionario.Visible = false;
            Btn_confirmarbusca.Enabled = false;

        }



        private void Btn_confirmarbusca_Click(object sender, EventArgs e)
        {

            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string query = "SET search_path TO clinicaveterinaria2;SELECT * FROM SERVICO WHERE ";
            DateTime currentDate = DateTime.Now;

            if (Buscaporsemana.Checked)
            {
                DateTime firstDayWeek = currentDate.Date.AddDays(-(int)currentDate.DayOfWeek);
                DateTime lastDayWeek = firstDayWeek.AddDays(6);

                string firstDayWeek_s = firstDayWeek.ToString("yyyy-MM-dd");
                string lastDayWeek_s = lastDayWeek.ToString("yyyy-MM-dd");

                query =  query + $"data BETWEEN ' {firstDayWeek_s} ' AND  '{lastDayWeek_s}';";
                command.CommandText = query;  
            }

            else if (Buscapormes.Checked)
            {
                DateTime firstDayMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
                DateTime lastDayMonth = firstDayMonth.AddMonths(1).AddDays(-1);
                string firstDayMonth_s = firstDayMonth.ToString("yyyy-MM-dd");
                string lastDayMonth_s = lastDayMonth.ToString("yyyy-MM-dd");

                query = query + $"data BETWEEN ' {firstDayMonth_s} ' AND  '{lastDayMonth_s}';";
                command.CommandText = query;
            }

            else if (Buscaporcliente.Checked)

            {
                string entrada = INPUT_ID_cliente.Text;
                query = query + $" iddono = {entrada};";
                command.CommandText = query;
            }

            else if (Buscaporfuncionario.Checked)

            {
                string entrada = INPUT_ID_funcionario.Text;

                query = query + $" funcid = {entrada};";
                command.CommandText = query;          

            }

            NpgsqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            SchedulingViewer.DataSource = dataTable;
            command.Dispose();
            connection.Connection.Close();

        }

        private void Buscaporsemana_CheckedChanged(object sender, EventArgs e)
        {
            INPUT_ID_cliente.Visible = false;
            Btn_confirmarbusca.Enabled = true;


        }

        private void Buscapormes_CheckedChanged(object sender, EventArgs e)
        {
            INPUT_ID_cliente.Visible = false;
            Btn_confirmarbusca.Enabled = true;


        }

        private void Buscaporcliente_CheckedChanged(object sender, EventArgs e)
        {
            label_id_cliente.Visible = true;
            INPUT_ID_cliente.Visible = true;

            label_id_funcionario.Visible = false;
            INPUT_ID_funcionario.Visible = false;
            Btn_confirmarbusca.Enabled = false;


        }

        private void Buscaporfuncionario_CheckedChanged(object sender, EventArgs e)
        {
            label_id_funcionario.Visible = true;
            INPUT_ID_funcionario.Visible = true;

            label_id_cliente.Visible = false;
            INPUT_ID_cliente.Visible = false;
            Btn_confirmarbusca.Enabled = false;


        }

        private void Informacao_ID_TextChanged(object sender, EventArgs e)
        {
            Btn_confirmarbusca.Enabled = true;
        }

        private void Info_ID_func_TextChanged(object sender, EventArgs e)
        {
            Btn_confirmarbusca.Enabled = true;

        }
    }
}
