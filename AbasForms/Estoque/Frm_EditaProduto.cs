using ClinicaVeterinariaBD.Arquitetura;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVeterinariaBD.AbasForms.Estoque
{
    public partial class Frm_EditaProduto : Form
    {
        public Frm_EditaProduto()
        {
            InitializeComponent();
        }

        // Used for Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Gainsboro;
        }

        private void Btn_Remove_MouseEnter(object sender, EventArgs e)
        {
            Btn_Remove.BackColor = Color.Red;
        }

        private void Btn_Remove_MouseLeave(object sender, EventArgs e)
        {
            Btn_Remove.BackColor = Color.White;
        }

        private void PreencherCamposComProduto()
        {
            // Verifica se o valor em Txt_Codigo é um número inteiro
            if (int.TryParse(Txt_Codigo.Text, out int idProduto))
            {

                DbConnection Connection = new DbConnection();
                // Construa a consulta SQL para obter os dados do produto com base no ID
                string query = "SELECT * FROM clinicaveterinaria2.produto WHERE Id = @IdProduto";

                using (NpgsqlCommand command = new NpgsqlCommand(query, Connection.Connection))
                {
                    command.Parameters.AddWithValue("@IdProduto", idProduto);

                    try
                    {

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Preencha os campos com os dados do produto
                                Txt_Nome.Text = reader["NomeProd"].ToString();
                                double preco;
                                if (double.TryParse(reader["Preco"].ToString(), out preco))
                                {
                                    Msk_Preco.Text = preco.ToString("0.00");
                                }
                                Txt_Quantidade.Text = reader["QntEstoque"].ToString();
                                Txt_Marca.Text = reader["Marca"].ToString();
                                Txt_Descricao.Text = reader["Descricao"].ToString();

                                // Formatação da data de vencimento
                                DateTime dataVencimento;
                                if (DateTime.TryParse(reader["DataVenc"].ToString(), out dataVencimento))
                                {
                                    Msk_Vencimento.Text = dataVencimento.ToString("dd/MM/yyyy");
                                }

                                Msk_Lote.Text = reader["Lote"].ToString();
                                Txt_Dose.Text = reader["Dose"].ToString();
                            }
                            else
                            {
                                // Caso o produto com o ID fornecido não seja encontrado
                                MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar dados do produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connection.Connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("O valor em Txt_Codigo não é um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            PreencherCamposComProduto();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja remover este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // O usuário escolheu Sim, proceder com a remoção
                RemoverProduto();
                this.Close();
            }
            // Se o usuário escolher Não, não é necessário fazer nada
        }

        private void RemoverProduto()
        {
            // O código de remoção do produto
            if (int.TryParse(Txt_Codigo.Text, out int idProduto))
            {
                DbConnection Connection = new DbConnection();

                string query = "DELETE FROM clinicaveterinaria2.produto WHERE Id = @IdProduto";

                using (NpgsqlCommand command = new NpgsqlCommand(query, Connection.Connection))
                {
                    command.Parameters.AddWithValue("@IdProduto", idProduto);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produto removido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado para remoção.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao remover o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connection.Connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("O valor em Txt_Codigo não é um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
  