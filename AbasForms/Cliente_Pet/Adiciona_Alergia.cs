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
        public bool verificaIdCliente(int idCliente)
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT * FROM Pessoa WHERE id = '{idCliente}';";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {

                    Command.CommandText = query;
                    NpgsqlDataReader dr = Command.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        MessageBox.Show("Digite um ID válido!", "Erro", MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public void ProcurarAnimal(String Id)
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT * FROM Animal WHERE iddono = cast(@IdBuscado as int)";

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

        private bool verificaAlergiaExistente(int idCliente, string nomeAnimal)
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT * FROM Alergia_animal WHERE iddono = '{idCliente}' " +
                    $"AND nomeanimal = '{nomeAnimal}';";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {

                    Command.CommandText = query;
                    NpgsqlDataReader dr = Command.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        MessageBox.Show("Animal com Alergia já inserida!", "Erro", MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
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
            if (!verificaIdCliente(idDono))
                return;

            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} INSERT INTO Alergia_animal (Iddono, NomeAnimal, Alergia) VALUES ('{idDono}', '{nomeAnimal}', '{Alergia}');";
                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    if (!verificaAlergiaExistente(idDono, nomeAnimal))
                        return;

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
            verificaIdCliente(idDono);

            using (DbConnection Connection = new DbConnection())
            {
                string nomeAnimal = box_NomeAnimal.Text;
                string query;

                if (string.IsNullOrEmpty(nomeAnimal))
                {
                    query = $"{Connection.search_path} SELECT * FROM Alergia_animal WHERE iddono = @iddono";
                }
                else
                {
                    query = $"{Connection.search_path} SELECT * FROM Alergia_animal WHERE iddono = @iddono AND nomeanimal = '{nomeAnimal}';";
                }

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

        private void box_IdDono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
