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
using System.Speech.Synthesis.TtsEngine;

namespace ClinicaVeterinariaBD.AbasForms.Cliente_Pet
{
    public partial class Adiciona_Alergia : Form
    {
        public void ProcurarAnimal(String Id)
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = "SELECT * FROM clinicaveterinaria.Animal WHERE iddono = cast(@IdBuscado as int)";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@IdBuscado", Id);
                    NpgsqlDataReader dr2 = Command.ExecuteReader();
                    DataTable dt2 = new DataTable();
                    dt2.Load(dr2);
                    dataGridView2.DataSource = dt2;
                }
            }
        }

        private void insereAlergia()
        {
            string temp = box_IdDono.Text;
            
            string nomeAnimal = box_NomeAnimal.Text.ToLower().Trim();
            string Alergia = box_Alergia.Text.ToLower().Trim();

            if ((string.IsNullOrEmpty(temp)) || (string.IsNullOrEmpty(nomeAnimal)) || (string.IsNullOrEmpty(Alergia)))
            {
                MessageBox.Show("Insira os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idDono = Int32.Parse(temp);

            using (DbConnection Connection = new DbConnection())
            {
                string query = "INSERT INTO clinicaveterinaria.Alergia_animal (iddono, nomeanimal, alergia) " +
                    "VALUES (@iddono, @nome, @alergia)";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@iddono", idDono);
                    Command.Parameters.AddWithValue("@nome", nomeAnimal);
                    Command.Parameters.AddWithValue("@alergia", Alergia);

                    NpgsqlDataReader dr = Command.ExecuteReader();
                    MessageBox.Show("Adicionado com sucesso!");
                }
            }
        }

        public void verificaAlergias()
        {
            string temp = box_IdDono.Text;
            if (string.IsNullOrEmpty(temp))
            {
                MessageBox.Show("Insira o Id", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int idDono = Int32.Parse(temp);

            using (DbConnection Connection = new DbConnection())
            {
                string query = "SELECT * FROM clinicaveterinaria.Alergia_animal WHERE iddono = @iddono";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@iddono", idDono);

                    NpgsqlDataReader dr = Command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        public Adiciona_Alergia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insereAlergia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verificaAlergias();
        }
    }
}
