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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;


namespace ClinicaVeterinariaBD.AbasForms.Consulta
{
    public partial class s : Form
    {

        private string previousCPF = "";
        private string previousTypeService = "";
        public s()
        {
            InitializeComponent();

            todaysScheduleLabel.Text = $"Serviços agendados de hoje";
            ReadTodaysSchedule(DateTime.Today);

        }
        private void cpfOwner_KeyUp(object sender, KeyEventArgs e)
        {
            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();

            //Configuração do comando de busca

            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;


            string query = $" {connection.search_path} SELECT * FROM PESSOA WHERE CPF = '{cpfOwner.Text}';";
            command.CommandText = query;
            NpgsqlDataReader cpfReader = command.ExecuteReader();
            cpfInvalido.Visible = false;

            if (cpfOwner.Text.Length > 11 || !(cpfReader.HasRows)) // Nao pode ser >, tem q ser !=. Fiz por facilidade de testes.
            {

                animalName.SelectedItem = null;
                cpfInvalido.Visible = true;
                animalName.Enabled = false;
                btrConfirm.Enabled = false;
                tipoServico.Text = null;
                tipoServico.Enabled = false;
                funcionarioServico.Text = null;
                funcionarioServico.Enabled = false;
                horaIni.Text = null;
                horaIni.Enabled = false;
                horaFim.Text = null;
                horaFim.Enabled = false;
                valorServico.Text = null;
                valorServico.Enabled = false;
                obsServico.Text = null;
                obsServico.Enabled = false;


            }
            else
            {
                animalName.Enabled = true;
                cpfInvalido.Visible = false;
                if (previousCPF != cpfOwner.Text)
                {
                    animalName.SelectedItem = null;
                    animalName.Items.Clear();
                    ReadAnimalsDataReader();
                    previousCPF = cpfOwner.Text;
                }
            }


            command.Dispose();
            connection.Connection.Close();

        }


        private void animalName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoServico.Enabled = true;

        }

        private void tipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalendarSchedule.Enabled = true;
            horaIni.Text = null;
            horaFim.Text = null;
            horaIni.Enabled = false;
            horaFim.Enabled = false;
            btrConfirm.Enabled = false;
            valorServico.Enabled = false;
            valorServico.Text = null;
            obsServico.Text = null;
            obsServico.Enabled = false;
            funcionarioServico.SelectedItem = null;
            if (previousTypeService != tipoServico.Text && !(tipoServico.Text.Equals("")))
            {
                previousTypeService = tipoServico.Text;
                funcionarioServico.Items.Clear();
                FindEmployees(tipoServico.Text);
            }
            funcionarioServico.Enabled = true;

        }


        private void CalendarSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {

            DateTime daySelected = CalendarSchedule.SelectionStart;

            if (DateTime.Today > daySelected)
            {

                horaIni.Enabled = false;
                horaFim.Enabled = false;
                InvalidTimeLabel.Visible = false;
                dateInvalid.Visible = true;
                todaysScheduleLabel.Visible = false;
                todaysScheduleDataGrid.Visible = false;

            }
            else
            {
                dateInvalid.Visible = false;
                funcionarioServico.Enabled = true;
                InvalidTimeLabel.Visible = false;
                if (daySelected == DateTime.Today)
                {
                    todaysScheduleLabel.Text = $"Serviços agendados de hoje";

                }
                else
                    todaysScheduleLabel.Text = $"Serviços agendados no dia {daySelected.ToString("yyyy/MM/dd")}";

                todaysScheduleLabel.Visible = true;
                ReadTodaysSchedule(daySelected);
                horaIni.Text = null;
                horaFim.Text = null;
                horaIni.Enabled = true;
                valorServico.Text = null;
                valorServico.Enabled = false;
                btrConfirm.Enabled = false;

            }

        }
        private void horaIni_KeyUp(object sender, KeyEventArgs e)
        {
            horaFim.Enabled = true;

        }

        private void horaFim_KeyUp(object sender, KeyEventArgs e)
        {
            string timeBeggining = horaIni.Text;
            string timeEnd = horaFim.Text;
            if (timeBeggining.Length == 5 && timeEnd.Length == 5)
            {
                bool TimeValidation = ValidateTimeService(timeBeggining, timeEnd, tipoServico.Text, CalendarSchedule.SelectionStart);

                if (TimeValidation)
                {
                    InvalidTimeLabel.Visible = false;
                    valorServico.Enabled = true;

                }

                else
                {
                    InvalidTimeLabel.Visible = true;
                }

            }

        }

        private void valorServico_TextChanged(object sender, EventArgs e)
        {
            obsServico.Enabled = true;
            btrConfirm.Enabled = true;


        }

        private void btrConfirm_Click(object sender, EventArgs e)
        {

            int commonPosition = funcionarioServico.Text.IndexOf(",");
            int idEmployee = Int32.Parse(funcionarioServico.Text.Substring(commonPosition + 1).Trim());
            int idOwner = FindPersonId("CLIENTE");
            string animalName_s = animalName.Text;
            string typeService_s = tipoServico.Text;
            string timeBeggining = horaIni.Text;
            string timeEnd = horaFim.Text;
            int price = Int32.Parse(valorServico.Text);
            string observations = obsServico.Text;
            string date = CalendarSchedule.SelectionStart.ToString("yyyy-MM-dd");
            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string insertion = $" {connection.search_path} INSERT INTO SERVICO (iddono, nomeanimal, funcid, data, horaini, horafim, custo, observacoes, tipo) VALUES({idOwner}, '{animalName_s}', {idEmployee}, '{date}', '{timeBeggining}', '{timeEnd}', {price}, '{observations}', '{typeService_s}');";
            command.CommandText = insertion;
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Connection.Close();

            MessageBox.Show($"INSERÇÃO BEM SUCEDIDA", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ReadAnimalsDataReader()
        {

            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string query = $" {connection.search_path} SELECT ANIMAL.nome as Nome, ANIMAL.iddono FROM ANIMAL, CLIENTE, PESSOA WHERE CLIENTE.id = ANIMAL.iddono AND PESSOA.id = CLIENTE.id AND PESSOA.CPF = '{cpfOwner.Text}';";
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

            string query = $" {connection.search_path} SELECT horaini, horafim, tipo, funcid FROM SERVICO WHERE data = '{Today.ToString("yyyy-MM-dd")}';";
            command.CommandText = query;
            NpgsqlDataReader scheduleReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(scheduleReader);
            todaysScheduleDataGrid.DataSource = dataTable;
            todaysScheduleDataGrid.Columns["horaini"].HeaderText = "Hora de início";
            todaysScheduleDataGrid.Columns["horafim"].HeaderText = "Hora de fim";
            todaysScheduleDataGrid.Columns["tipo"].HeaderText = "Tipo de serviço";
            todaysScheduleDataGrid.Columns["funcid"].HeaderText = "Id do funcionário";

            todaysScheduleDataGrid.Show();
            command.Dispose();
            connection.Connection.Close();

        }

        private void FindEmployees(string typeService)
        {
            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string typeEmployee = "";

            switch (typeService)
            {
                case "Vacinação":
                case "Consulta":
                    typeEmployee = "Auxiliar de Veterinário";
                    break;
                case "Procedimento Cirúrgico":
                    typeEmployee = "Veterinário";
                    break;
                case "Procedimento Estético":
                    typeEmployee = "Banhista/Tosador";
                    break;
            }

            string query = $" {connection.search_path} SELECT PESSOA.nome as Nome, PESSOA.id as ID FROM FUNCIONARIO JOIN Pessoa ON PESSOA.id = FUNCIONARIO.id WHERE funcao = '{typeEmployee}';";
            command.CommandText = query;
            NpgsqlDataReader employeeReader = command.ExecuteReader();
            if (!(employeeReader.HasRows))
            {
                MessageBox.Show($"Não'há funcionários para {typeService}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            while (employeeReader.Read())
            {
                string employeeName = employeeReader["Nome"].ToString();
                string employeeId = employeeReader["ID"].ToString();
                funcionarioServico.Items.Add($"{employeeName},{employeeId}");

            }

        }

        private bool ValidateTimeService(string timeBeggining, string timeEnd, string typeService, DateTime date_selected)
        {

            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;
            string date_selected_s = date_selected.ToString("yyyy-MM-dd");

            string query = $" {connection.search_path} SELECT * FROM SERVICO as s1 WHERE s1.data = '{date_selected_s}' AND EXISTS ((SELECT * FROM SERVICO as s2 WHERE '{timeBeggining}' < s2.horaini AND '{timeEnd}' > s2.horaini AND s2.data = '{date_selected_s}') UNION (SELECT *  FROM SERVICO as s2 WHERE '{timeBeggining}' < s2.horafim AND '{timeEnd}' > s2.horafim AND s2.data = '{date_selected_s}') UNION (SELECT *  FROM SERVICO as s2 WHERE '{timeBeggining}' = s2.horaini AND '{timeEnd}' = s2.horafim AND s2.data = '{date_selected_s}'))";

            command.CommandText = query;
            NpgsqlDataReader timeReader = command.ExecuteReader();
            if (!(timeReader.HasRows))
                return true;
            return false;
        }

        private int FindPersonId(string typePerson)
        {
            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string query = $" {connection.search_path} SELECT {typePerson}.id as ID FROM PESSOA, {typePerson} WHERE PESSOA.id = {typePerson}.id AND PESSOA.CPF = '{cpfOwner.Text}';";
            command.CommandText = query;
            NpgsqlDataReader IdReader = command.ExecuteReader();

            IdReader.Read();
            return Int32.Parse(IdReader["ID"].ToString());

        }
    }

    /* DateTime StringToDateTime(string time)

      {
          DateTime dateTime = DateTime.ParseExact(time, "HH:mm", null);
          return dateTime;

      }*/
}

