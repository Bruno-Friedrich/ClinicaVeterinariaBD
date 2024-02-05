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
using ClinicaVeterinariaBD.AbasForms.Cliente_Pet;
using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClinicaVeterinariaBD.AbasForms.Cliente_Pet
{
    public partial class Adiciona_Cliente : Form
    {
        public void inserirPessoa()
        {
            string nomeCliente, cpf, email, cel1, cel2, cep,
                cidade, bairro, endereco, compl;

            int numEndereco = 0;

            //Pessoa
            nomeCliente = box_nome.Text.ToLower().Trim();
            cpf = box_cpf.Text.ToLower().Trim();
            email = box_email.Text.ToLower().Trim();
            cel1 = box_cel1.Text.ToLower().Trim();
            cel2 = box_cel2.Text.ToLower().Trim();
            cep = box_cep.Text.ToLower().Trim();
            cidade = box_cidade.Text.ToLower().Trim();
            bairro = box_bairro.Text.ToLower().Trim();
            endereco = box_endereco.Text.ToLower().Trim();
            compl = box_compl.Text.ToLower().Trim();

            string temp = box_num.Text;

            string novoCel1 = cel1;
            novoCel1 = Regex.Replace(novoCel1, @"[^\d,]", "");


            if ((string.IsNullOrEmpty(nomeCliente)) || (string.IsNullOrEmpty(cpf)) || (string.IsNullOrEmpty(email))
                || (string.IsNullOrEmpty(novoCel1)) || (string.IsNullOrEmpty(cep))
                || (string.IsNullOrEmpty(cidade)) || (string.IsNullOrEmpty(bairro))
                || (string.IsNullOrEmpty(endereco)) || (string.IsNullOrEmpty(temp)))
            {
                MessageBox.Show("Insira os Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                numEndereco = Int32.Parse(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira os Dados Corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Pessoa
            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} INSERT INTO Pessoa (tipo, cpf, nome, email, celular1, celular2, complemento, cidade, bairro, " +
                    "numero, logradouro, cep) VALUES (@tipo, @cpf, @nome, @email, @celular1, @celular2, @complemento, @cidade, @bairro, @numero, " +
                    "@logradouro, @cep)";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@tipo", "cliente");
                    Command.Parameters.AddWithValue("@cpf", cpf);
                    Command.Parameters.AddWithValue("@nome", nomeCliente);
                    Command.Parameters.AddWithValue("@email", email);
                    Command.Parameters.AddWithValue("@celular1", cel1);
                    Command.Parameters.AddWithValue("@celular2", cel2);
                    Command.Parameters.AddWithValue("@complemento", compl);
                    Command.Parameters.AddWithValue("@cidade", cidade);
                    Command.Parameters.AddWithValue("@bairro", bairro);
                    Command.Parameters.AddWithValue("@numero", numEndereco);
                    Command.Parameters.AddWithValue("@logradouro", endereco);
                    Command.Parameters.AddWithValue("@cep", cep);

                    try
                    {
                        NpgsqlDataReader dr = Command.ExecuteReader();
                        int idcliente = FindClientId(cpf);
                        add_tupla_cliente(idcliente);
                        MessageBox.Show("Inserido com Sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cliente não inserido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void add_tupla_cliente(int chave)
        {

            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string insertion = $" {connection.search_path} INSERT INTO CLIENTE (id) VALUES({chave});";
            command.CommandText = insertion;
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Connection.Close();

        }

        private int FindClientId(string CPF)
        {
            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;

            string query = $" {connection.search_path} SELECT PESSOA.ID FROM PESSOA WHERE CPF = '{CPF}';";
            command.CommandText = query;
            NpgsqlDataReader IdReader = command.ExecuteReader();

            IdReader.Read();
            return Int32.Parse(IdReader["ID"].ToString());

        }


        public Adiciona_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*if (box_cel1.Text == "")
            {
                MessageBox.Show("Insira os Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            inserirPessoa();
        }

        private void box_cel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_cel1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
