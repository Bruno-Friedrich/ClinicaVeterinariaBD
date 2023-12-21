using ClinicaVeterinariaBD.Arquitetura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ClinicaVeterinariaBD.AbasForms.Estoque
{
    public partial class Frm_InfoProduto : Form
    {
        public Frm_InfoProduto(string stringTitulo)
        {
            InitializeComponent();

            Lbl_Titulo.Text = stringTitulo;
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

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fechar o formulário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica a escolha do usuário
            if (result == DialogResult.Yes)
            {
                // Fecha o formulário se o usuário escolheu "Sim"
                this.Close();
            }
        }

        private bool CodigoJaExiste(string codigo)
        {

            using (DbConnection Connection = new DbConnection())
            {

                // Consulta para verificar se o código já existe
                string query = $"{Connection.search_path} SELECT COUNT(*) FROM produto WHERE Id = @Codigo";
                using (NpgsqlCommand command = new NpgsqlCommand(query, Connection.Connection))
                {
                    if (int.TryParse(codigo, out int codigoInt))
                    {
                        command.Parameters.AddWithValue("@Codigo", codigoInt);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                    else
                    {
                        // Lidar com o caso em que o código não é um número inteiro válido
                        return false;
                    }
                }
            }
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

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            // Validação dos campos obrigatórios
            if (string.IsNullOrEmpty(Txt_Nome.Text) || string.IsNullOrEmpty(Txt_Quantidade.Text) || string.IsNullOrEmpty(Txt_Marca.Text) || string.IsNullOrEmpty(Msk_Preco.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro no Envio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se os campos são válidos antes de enviar para o banco de dados
            if (ValidarCampos())
            {
                InserirDadosNoBanco();

                MessageBox.Show("Formulário enviado com sucesso!");
                this.Close();
            }
        }

        private void InserirDadosNoBanco()
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

                using (DbConnection Connection = new DbConnection())
                {
                    // Cria um comando SQL com parâmetros nomeados
                    using (NpgsqlCommand command = new NpgsqlCommand($"{Connection.search_path} INSERT INTO produto (NomeProd, Preco, PorcentagemLucro, QntEstoque, Marca, Descricao, Lote, Dose, DataVenc, Tipo) VALUES (@Nome, @Preco, @PorcentagemLucro, @Quantidade, @Marca, @Descricao, @Lote, @Dose, @DataVenc, @Tipo)", Connection.Connection))
                    {
                        // Adicione os parâmetros
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

                        // Execute o comando de inserção
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("O valor em Msk_Lucro não é um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
