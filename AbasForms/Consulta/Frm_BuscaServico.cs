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

        }



        private void Btn_confirmarbusca_Click(object sender, EventArgs e)
        {

            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string query = $"{connection.search_path} SELECT PCLIENTE.nome as nomecliente, PFUNC.nome AS nomefuncionario, nomeanimal, data, horaini, horafim, custo, observacoes, SERVICO.tipo FROM SERVICO, PESSOA AS PFUNC, PESSOA AS PCLIENTE WHERE";
            DateTime currentDate = DateTime.Now;

            if (Buscaporsemana.Checked)
            {
                DateTime firstDayWeek = currentDate.Date.AddDays(-(int)currentDate.DayOfWeek);
                DateTime lastDayWeek = firstDayWeek.AddDays(6);

                string firstDayWeek_s = firstDayWeek.ToString("yyyy-MM-dd");
                string lastDayWeek_s = lastDayWeek.ToString("yyyy-MM-dd");

                query = query + $" data BETWEEN ' {firstDayWeek_s} ' AND  '{lastDayWeek_s}'";

            }

            else if (Buscapormes.Checked)
            {
                DateTime firstDayMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
                DateTime lastDayMonth = firstDayMonth.AddMonths(1).AddDays(-1);
                string firstDayMonth_s = firstDayMonth.ToString("yyyy-MM-dd");
                string lastDayMonth_s = lastDayMonth.ToString("yyyy-MM-dd");

                query = query + $" data BETWEEN ' {firstDayMonth_s} ' AND  '{lastDayMonth_s}'";

            }

            else if (Buscaporcliente.Checked)

            {
                string entrada = INPUT_CPF_cliente.Text;
                query = query + $" PCLIENTE.CPF = '{entrada}'";

            }

            else if (Buscaporfuncionario.Checked)

            {
                string entrada = INPUT_CPF_funcionario.Text;

                query = query + $" PFUNC.CPF = '{entrada}'";


            }

            query = query + " AND PFUNC.id = funcid AND PCLIENTE.id = iddono ORDER BY data, horaini";

            command.CommandText = query;
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
            SchedulingViewer.Columns["observacoes"].HeaderText = "Observações";
            SchedulingViewer.Columns["data"].HeaderText = "Data";




            command.Dispose();
            connection.Connection.Close();

        }

        private void Buscaporsemana_CheckedChanged(object sender, EventArgs e)
        {
            Btn_confirmarbusca.Enabled = true;
            INPUT_CPF_cliente.Text = null;
            INPUT_CPF_funcionario.Text = null;
            INPUT_CPF_cliente.Enabled = false;
            INPUT_CPF_funcionario.Enabled = false;


        }

        private void Buscapormes_CheckedChanged(object sender, EventArgs e)
        {
            INPUT_CPF_cliente.Text = null;
            INPUT_CPF_funcionario.Text = null;
            INPUT_CPF_cliente.Enabled = false;
            INPUT_CPF_funcionario.Enabled = false;

            Btn_confirmarbusca.Enabled = true;


        }

        private void Buscaporcliente_CheckedChanged(object sender, EventArgs e)
        {

            INPUT_CPF_cliente.Enabled = true;
            INPUT_CPF_funcionario.Enabled = false;

            Btn_confirmarbusca.Enabled = false;


        }

        private void Buscaporfuncionario_CheckedChanged(object sender, EventArgs e)
        {
            INPUT_CPF_funcionario.Enabled = true;
            INPUT_CPF_cliente.Enabled = false;

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

        private void Maneiradebusca_Enter(object sender, EventArgs e)
        {

        }

        private void Icn_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
