using ClinicaVeterinariaBD.AbasForms.Estoque;
using ClinicaVeterinariaBD.Arquitetura;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicaVeterinariaBD.AbasForms
{
    public partial class Frm_Estoque : Form
    {
        public Frm_Estoque()
        {
            InitializeComponent();
            CarregarDadosDoBanco();
        }

        private void CarregarDadosDoBanco()
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = "SELECT * FROM clinicaveterinaria2.Produto";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    try
                    {
                        NpgsqlDataReader dr = Command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        Dt_Estoque.DataSource = dt;

                        // Renomear as colunas conforme necessário
                        Dt_Estoque.Columns["NomeProd"].HeaderText = "Nome";
                        Dt_Estoque.Columns["Preco"].HeaderText = "Preço";
                        Dt_Estoque.Columns["QntEstoque"].HeaderText = "Quantidade em Estoque";
                        Dt_Estoque.Columns["Descricao"].HeaderText = "Descrição";
                        Dt_Estoque.Columns["DataVenc"].HeaderText = "Data de Vencimento";
                        Dt_Estoque.Columns["Id"].HeaderText = "Código   ";
                        Dt_Estoque.Columns["marca"].HeaderText = "Marca";
                        Dt_Estoque.Columns["lote"].HeaderText = "Lote";
                        Dt_Estoque.Columns["dose"].HeaderText = "Dose";

                    }
                    catch (Exception ex)
                    {
                        // Trate a exceção adequadamente
                        MessageBox.Show("Erro ao carregar dados do banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // O bloco using garante que o comando seja descartado e a conexão seja fechada automaticamente
            } // O bloco using garante que a conexão seja fechada automaticamente
        }

        private void Btn_AddProduto_Click(object sender, EventArgs e)
        {
            // Crie uma instância do formulário filho
            using (Frm_InfoProduto formFilho = new Frm_InfoProduto())
            {
                // Exiba o formulário filho como um diálogo modal
                formFilho.ShowDialog();

                // Após o fechamento do formulário filho, recarregue os dados do banco
                CarregarDadosDoBanco();
            }
        }

        private void Txt_Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            //string produtoBuscado = Txt_Pesquisa.Text.ToLower().Trim();

            // Utilize o método separado para executar a consulta
            //ExecutarConsulta(produtoBuscado);
        }

        private void ExecutarConsulta(string produtoBuscado)
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = "SELECT * FROM clinicaveterinaria2.Produto WHERE LOWER(NomeProd) LIKE @ProdutoBuscado";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@ProdutoBuscado", "%" + produtoBuscado + "%");

                    try
                    {
                        NpgsqlDataReader dr = Command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        Dt_Estoque.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        // Trate a exceção adequadamente
                        MessageBox.Show("Erro ao executar a consulta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // O bloco using garante que o comando seja descartado e a conexão seja fechada automaticamente
            } // O bloco using garante que a conexão seja fechada automaticamente
        }

        private void Txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            string produtoBuscado = Txt_Pesquisa.Text.ToLower().Trim();

            // Utilize o método separado para executar a consulta
            ExecutarConsulta(produtoBuscado);
        }
    }
}
