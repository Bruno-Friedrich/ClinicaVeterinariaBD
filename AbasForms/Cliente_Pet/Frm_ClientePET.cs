using ClinicaVeterinariaBD.AbasForms.Cliente_Pet;
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
using System.Linq.Expressions;

namespace ClinicaVeterinariaBD.AbasForms
{
    public partial class Frm_ClientePET : Form
    {
        private void inicializar()
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT * FROM Pessoa WHERE tipo = 'cliente'";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    try
                    {
                        NpgsqlDataReader dr = Command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        Dt_Consulta.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao executar a consulta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        public Frm_ClientePET()
        {
            InitializeComponent();
            inicializar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserInputText = textBox1.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(UserInputText))
            {
                MessageBox.Show("Insira o Id", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idCliente = Int32.Parse(UserInputText);

            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT * FROM Pessoa WHERE id = '{idCliente}';";
                
                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    try
                    {
                        Command.CommandText = query;
                        NpgsqlDataReader dr = Command.ExecuteReader();

                        if(!dr.HasRows)
                        {
                            MessageBox.Show("Digite um ID válido!", "Erro", MessageBoxButtons.OK
                                , MessageBoxIcon.Error );
                            return;
                        }

                        Animal animal = new Animal();
                        animal.instance.tb1.Text = UserInputText;
                        animal.Id_Cliente = UserInputText;

                        //Animal DataGrid1
                        animal.ProcurarAnimal(UserInputText);

                        //Animal DataGrid2
                        animal.ProcurarCliente(UserInputText);
                        animal.Show();
                        
                        Command.Dispose();
                        Connection.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ID não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Nome_Cliente = textBox2.Text.ToLower().Trim();

            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT * FROM Pessoa WHERE tipo = 'cliente' AND LOWER(nome) LIKE @Nome_cliente";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@Nome_cliente", "%" + Nome_Cliente + "%");

                    try
                    {
                        NpgsqlDataReader dr = Command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        Dt_Consulta.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao executar a consulta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adiciona_Cliente adiciona_cliente = new Adiciona_Cliente();
            adiciona_cliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adiciona_Animal adiciona_Animal = new Adiciona_Animal();
            adiciona_Animal.Show();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Icn_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Dt_Consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
