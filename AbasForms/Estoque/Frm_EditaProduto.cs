using ClinicaVeterinariaBD.Arquitetura;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVeterinariaBD.AbasForms.Estoque
{
    public partial class Frm_EditaProduto : Form
    {
        public Frm_EditaProduto(string stringTexto)
        {
            InitializeComponent();
            Lbl_Titulo.Text = stringTexto;
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

        private void Btn_Edita_MouseEnter(object sender, EventArgs e)
        {
            Btn_Edita.BackColor = Color.Blue;
        }

        private void Btn_Edita_MouseLeave(object sender, EventArgs e)
        {
            Btn_Edita.BackColor = Color.White;
        }

        private void PreencherCamposComProduto()
        {
            // Verifica se o valor em Txt_Codigo é um número inteiro
            if (int.TryParse(Txt_Codigo.Text, out int idProduto))
            {
                DbConnection Connection = new DbConnection();
                // Construa a consulta SQL para obter os dados do produto com base no ID
                string query = $"{Connection.search_path} SELECT * FROM produto WHERE Id = @IdProduto";

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
                                Cmb_Tipo.SelectedItem = reader["Tipo"].ToString();

                                // Novo campo adicionado
                                int porcentagemLucro;
                                if (int.TryParse(reader["PorcentagemLucro"].ToString(), out porcentagemLucro))
                                {
                                    Msk_Lucro.Text = porcentagemLucro.ToString();
                                }
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

        private bool ValidarCampos()
        {
            // Validação do campo NomeProd
            if (!string.IsNullOrEmpty(Txt_Nome.Text) && Txt_Nome.Text.Length > 30)
            {
                MessageBox.Show("O campo NomeProd não pode ter mais de 30 caracteres.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do campo Preco
            string precoTexto = Msk_Preco.Text;

            // Remover o símbolo de moeda e outros caracteres não numéricos
            precoTexto = Regex.Replace(precoTexto, @"[^\d,]", "");

            // Substituir a vírgula por ponto para formatar corretamente o valor double
            precoTexto = precoTexto.Replace(",", ".");

            if (!string.IsNullOrEmpty(precoTexto) && double.TryParse(precoTexto, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double preco))
            {
                // O valor é um número válido
            }
            else if (!string.IsNullOrEmpty(precoTexto))
            {
                // O valor não é um número válido
                MessageBox.Show($"Formato Invalido: {Msk_Preco.Text}", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do campo QntEstoque
            if (!string.IsNullOrEmpty(Txt_Quantidade.Text) && (!int.TryParse(Txt_Quantidade.Text, out int quantidade) || quantidade < 0))
            {
                MessageBox.Show("O campo Quantidade em Estoque deve ser um número inteiro não negativo.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do campo Descricao
            if (!string.IsNullOrEmpty(Txt_Descricao.Text) && Txt_Descricao.Text.Length > 1000)
            {
                MessageBox.Show("A descrição não pode ter mais de 1000 caracteres.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do campo Marca
            if (!string.IsNullOrEmpty(Txt_Marca.Text) && Txt_Marca.Text.Length > 30)
            {
                MessageBox.Show("O campo Marca não pode ter mais de 30 caracteres.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do campo Dose
            if (!string.IsNullOrEmpty(Txt_Dose.Text) && !int.TryParse(Txt_Dose.Text, out int dose))
            {
                MessageBox.Show("O campo Dose deve ser um número inteiro.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do campo Lote
            if (!string.IsNullOrEmpty(Msk_Lote.Text) && Msk_Lote.Text.Length > 20)
            {
                MessageBox.Show("O campo Lote não pode ter mais de 20 caracteres.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do campo DataVenc
            string dataVencimentoTexto = Msk_Vencimento.Text.Replace("/", "").Replace(" ", "");

            if (string.IsNullOrEmpty(dataVencimentoTexto))
            {
                // O valor é nulo ou vazio, não há validação a ser feita
            }

            else if (DateTime.TryParseExact(dataVencimentoTexto, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataVenc))
            {
                // Se desejar, você pode usar a variável 'dataVenc' conforme necessário.
            }
            else
            {
                MessageBox.Show($"Formato de data inválido. Utilize DD/MM/AAAA", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Se todas as validações passaram, retorna true
            return true;
        }

        private void Btn_Edita_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja editar este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // O usuário escolheu Sim, proceder com a edição
                if (ValidarCampos())
                {
                    AtualizarDadosNoBanco();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problema na edição!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            // Se o usuário escolher Não, não é necessário fazer nada
        }

        private void AtualizarDadosNoBanco()
        {
            // Verifica se o valor em Txt_Codigo é um número inteiro
            if (int.TryParse(Txt_Codigo.Text, out int idProduto))
            {
                string nome = Txt_Nome.Text;

                // Validação do campo Preco
                string precoTexto = Msk_Preco.Text;

                // Remover o símbolo de moeda e outros caracteres não numéricos
                precoTexto = Regex.Replace(precoTexto, @"[^\d,]", "");

                // Substituir a vírgula por ponto para formatar corretamente o valor double
                precoTexto = precoTexto.Replace(",", ".");

                if (double.TryParse(precoTexto, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double preco))
                {
                    // O valor é um número válido
                }

                int quantidade = int.Parse(Txt_Quantidade.Text);
                string marca = Txt_Marca.Text;
                string descricao = Txt_Descricao.Text;

                // Campos opcionais que podem ser nulos
                string lote = !string.IsNullOrEmpty(Msk_Lote.Text) ? Msk_Lote.Text : null;
                int? dose = !string.IsNullOrEmpty(Txt_Dose.Text) ? int.Parse(Txt_Dose.Text) : (int?)null;

                // Campos de data
                DateTime? dataVencimento = null;
                string dataVencimentoTexto = Msk_Vencimento.Text.Replace("/", "").Replace(" ", "");
                if (!string.IsNullOrEmpty(dataVencimentoTexto))
                {
                    if (DateTime.TryParseExact(dataVencimentoTexto, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataVenc))
                    {
                        dataVencimento = dataVenc;
                    }
                }

                // Obtém o valor selecionado no ComboBox Cmb_Tipo
                string tipo = Cmb_Tipo.SelectedItem?.ToString();

                // Validação do campo Msk_Lucro
                string lucroTexto = Msk_Lucro.Text;

                // Remover caracteres não numéricos
                lucroTexto = Regex.Replace(lucroTexto, @"[^\d]", "");

                if (int.TryParse(lucroTexto, out int porcentagemLucro))
                {
                    // O valor é um número válido
                }

                using (DbConnection Connection = new DbConnection())
                {
                    // Cria um comando SQL com parâmetros nomeados
                    using (NpgsqlCommand command = new NpgsqlCommand($"{Connection.search_path} UPDATE produto SET NomeProd = @Nome, Preco = @Preco, PorcentagemLucro = @PorcentagemLucro, QntEstoque = @Quantidade, Marca = @Marca, Descricao = @Descricao, Lote = @Lote, Dose = @Dose, DataVenc = @DataVenc, Tipo = @Tipo WHERE Id = @IdProduto", Connection.Connection))
                    {
                        // Adicione os parâmetros
                        command.Parameters.AddWithValue("@IdProduto", idProduto);
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Preco", preco);
                        command.Parameters.AddWithValue("@PorcentagemLucro", porcentagemLucro);
                        command.Parameters.AddWithValue("@Quantidade", quantidade);
                        command.Parameters.AddWithValue("@Marca", marca);
                        command.Parameters.AddWithValue("@Descricao", descricao);
                        command.Parameters.AddWithValue("@Lote", lote ?? (object)DBNull.Value); // Trata o valor nulo
                        command.Parameters.AddWithValue("@Dose", dose ?? (object)DBNull.Value); // Trata o valor nulo
                        command.Parameters.AddWithValue("@DataVenc", dataVencimento ?? (object)DBNull.Value); // Trata o valor nulo
                        command.Parameters.AddWithValue("@Tipo", tipo);

                        // Execute o comando de atualização
                        command.ExecuteNonQuery();
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
