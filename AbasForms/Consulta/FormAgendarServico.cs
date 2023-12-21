using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ClinicaVeterinariaBD.Arquitetura;
using System.Security.Principal;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace ClinicaVeterinariaBD.AbasForms.Consulta
{
    public partial class s : Form
    {

        private string previousCPF = "";

        public s()
        {
            InitializeComponent();

        }

        private void cpfOwner_KeyDown(object sender, KeyEventArgs e)
        {

            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();

            //Configuração do comando de busca

            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            if (e.KeyCode == Keys.Enter)
            {

                string query = $" {connection.search_path} SELECT * FROM PESSOA WHERE CPF = '{cpfOwner.Text}';";
                command.CommandText = query;
                NpgsqlDataReader cpfReader = command.ExecuteReader();
                cpfInvalido.Visible = false;

                if (cpfOwner.Text.Length > 11 || !(cpfReader.HasRows)) // Nao pode ser >, tem q ser !=. Fiz por facilidade de testes.
                {
                    cpfInvalido.Visible = true;
                    btrConfirm.Enabled = false;

                }
                else
                {
                    animalName.Enabled = true;
                    cpfInvalido.Visible = false;
                    if (previousCPF != cpfOwner.Text)
                    {
                        animalName.SelectedItem = "";
                        animalName.Items.Clear();
                        ReadAnimalsDataReader();
                        previousCPF = cpfOwner.Text;
                    }
                }

            }
            command.Dispose();
            connection.Connection.Close();

        }

        private void tipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalendarSchedule.Enabled = true;

        }

        private void CalendarSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {

            DateTime daySelected = CalendarSchedule.SelectionStart;

            if (DateTime.Today > daySelected)
            {
                dateInvalid.Visible = true;
                todaysScheduleLabel.Visible = false;
                todaysScheduleDataGrid.Visible = false;
            }
            else
            {
                dateInvalid.Visible = false;
                funcionarioServico.Enabled = true;
                todaysScheduleLabel.Text = $"Serviços agendados no dia {daySelected.ToString("yyyy/MM/dd")}";
                todaysScheduleLabel.Visible = true;
                ReadTodaysSchedule(daySelected);
                horaIni.Enabled = true;

            }

        }


        private void horaFim_TextChanged(object sender, EventArgs e)
        {
            string timeBeggining = horaIni.Text;
            string timeEnd = horaFim.Text;


            //MessageBox.Show("ERRO","titulo da mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ReadAnimalsDataReader()
        {

            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string query = $" {connection.search_path} SELECT ANIMAL.nome as Nome FROM ANIMAL, CLIENTE, PESSOA WHERE CLIENTE.id = ANIMAL.iddono AND PESSOA.id = CLIENTE.id AND PESSOA.CPF = '{cpfOwner.Text}';";
            command.CommandText = query;
            NpgsqlDataReader animalReader = command.ExecuteReader();

            while (animalReader.Read())
            {
                string animalName_record = animalReader["Nome"].ToString();
                animalName.Items.Add(animalName_record);

            }

        }



        private void ReadTodaysSchedule(DateTime Today)
        {

            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string query = $" {connection.search_path} SELECT horaini, horafim, tipo FROM SERVICO WHERE data = '{Today.ToString("yyyy-MM-dd")}';";
            command.CommandText = query;
            NpgsqlDataReader scheduleReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(scheduleReader);
            todaysScheduleDataGrid.DataSource = dataTable;
            todaysScheduleDataGrid.Columns["horaini"].HeaderText = "Hora de início";
            todaysScheduleDataGrid.Columns["horafim"].HeaderText = "Hora de fim";
            todaysScheduleDataGrid.Columns["tipo"].HeaderText = "Tipo de serviço";
            todaysScheduleDataGrid.Show();
            command.Dispose();
            connection.Connection.Close();

        }
    }
}
