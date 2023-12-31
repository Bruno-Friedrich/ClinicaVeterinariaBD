﻿using Bunifu.Framework.UI;
using ClinicaVeterinariaBD.AbasForms.Estoque;
using ClinicaVeterinariaBD.Arquitetura;
using Npgsql;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ClinicaVeterinariaBD.AbasForms
{
    public partial class Frm_Estoque : Form
    {
        private bool estadoBtnCodigo = true;
        private bool estadoBtnPreco = true;
        private bool estadoBtnQuantidade = true;
        private bool estadoBtnDescricao = true;
        private bool estadoBtnVencimento = true;
        private bool estadoBtnMarca = true;
        private bool estadoBtnLote = true;
        private bool estadoBtnDose = true;
        private bool estadoBtnTipo = true;

        public Frm_Estoque()
        {
            InitializeComponent();
            CarregarDadosDoBanco();
            Cmb_Tipo.SelectedItem = "Todos";
        }

        private void CarregarDadosDoBanco()
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT * FROM Produto";

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
                        Dt_Estoque.Columns["Id"].HeaderText = "Código";
                        Dt_Estoque.Columns["marca"].HeaderText = "Marca";
                        Dt_Estoque.Columns["lote"].HeaderText = "Lote";
                        Dt_Estoque.Columns["dose"].HeaderText = "Dose";
                        Dt_Estoque.Columns["tipo"].HeaderText = "Tipo";
                        Dt_Estoque.Columns["PorcentagemLucro"].HeaderText = "Porcentagem de Lucro";

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
            using (Frm_InfoProduto formFilho = new Frm_InfoProduto("Adicionar Novo Produto"))
            {
                // Exiba o formulário filho como um diálogo modal
                formFilho.ShowDialog();

                // Após o fechamento do formulário filho, recarregue os dados do banco
                CarregarDadosDoBanco();
            }
        }


        private void Btn_RemoveProduto_Click(object sender, EventArgs e)
        {
            // Crie uma instância do formulário filho
            using (Frm_RemoveProduto formFilho = new Frm_RemoveProduto("Remover Produto"))
            {
                // Exiba o formulário filho como um diálogo modal
                formFilho.ShowDialog();

                // Após o fechamento do formulário filho, recarregue os dados do banco
                CarregarDadosDoBanco();
            }
        }

        private void Btn_EditProduto_Click(object sender, EventArgs e)
        {
            // Crie uma instância do formulário filho
            using (Frm_EditaProduto formFilho = new Frm_EditaProduto("Editar Produto"))
            {
                // Exiba o formulário filho como um diálogo modal
                formFilho.ShowDialog();

                // Após o fechamento do formulário filho, recarregue os dados do banco
                CarregarDadosDoBanco();
            }
        }

        private void AjustarBotaoEColuna(Bunifu.Framework.UI.BunifuThinButton2 botao, DataGridView dataGridView, string nomeColuna, ref bool estadoBotao)
        {
            if (estadoBotao)
            {
                estadoBotao = false;
                AjustarEstiloBotao(botao, false);
            }
            else
            {
                estadoBotao = true;
                AjustarEstiloBotao(botao, true);
            }

            dataGridView.Columns[nomeColuna].Visible = estadoBotao;
        }

        private void AjustarEstiloBotao(Bunifu.Framework.UI.BunifuThinButton2 botao, bool ativo)
        {
            if (ativo)
            {
                botao.ActiveFillColor = Color.FromArgb(47, 33, 74);
                botao.ActiveForecolor = Color.White;
                botao.ActiveLineColor = Color.FromArgb(47, 33, 74);

                botao.IdleFillColor = Color.White;
                botao.IdleForecolor = Color.FromArgb(47, 33, 74);
                botao.IdleLineColor = Color.White;
            }
            else
            {
                botao.ActiveFillColor = Color.White;
                botao.ActiveForecolor = Color.FromArgb(47, 33, 74);
                botao.ActiveLineColor = Color.White;

                botao.IdleFillColor = Color.FromArgb(47, 33, 74);
                botao.IdleForecolor = Color.White;
                botao.IdleLineColor = Color.FromArgb(47, 33, 74);
            }
        }

        // Exemplo de uso para o botão Btn_Id
        private void Btn_Id_Click(object sender, EventArgs e)
        {
            AjustarBotaoEColuna(Btn_Id, Dt_Estoque, "Id", ref estadoBtnCodigo);
        }

        private void Btn_Preco_Click(object sender, EventArgs e)
        {
            AjustarBotaoEColuna(Btn_Preco, Dt_Estoque, "Preco", ref estadoBtnPreco);
        }

        private void Btn_Quantidade_Click(object sender, EventArgs e)
        {
            AjustarBotaoEColuna(Btn_Quantidade, Dt_Estoque, "QntEstoque", ref estadoBtnQuantidade);
        }

        private void Btn_Descricao_Click(object sender, EventArgs e)
        {
            AjustarBotaoEColuna(Btn_Descricao, Dt_Estoque, "Descricao", ref estadoBtnDescricao);
        }

        private void Btn_Vencimento_Click(object sender, EventArgs e)
        {
            AjustarBotaoEColuna(Btn_Vencimento, Dt_Estoque, "DataVenc", ref estadoBtnVencimento);
        }

        private void Btn_Marca_Click(object sender, EventArgs e)
        {
            AjustarBotaoEColuna(Btn_Marca, Dt_Estoque, "marca", ref estadoBtnMarca);
        }

        private void Bnt_Lote_Click(object sender, EventArgs e)
        {
            AjustarBotaoEColuna(Bnt_Lote, Dt_Estoque, "lote", ref estadoBtnLote);
        }

        private void Bnt_Dose_Click(object sender, EventArgs e)
        {
            AjustarBotaoEColuna(Bnt_Dose, Dt_Estoque, "dose", ref estadoBtnDose);
        }

        private void Btn_Tipo_Click(object sender, EventArgs e)
        {
            AjustarBotaoEColuna(Btn_Tipo, Dt_Estoque, "tipo", ref estadoBtnTipo);
        }

        private void Btn_Filtro_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            // Construa a consulta SQL base
            string consultaSQL = "SELECT * FROM clinicaveterinaria.Produto WHERE 1 = 1";

            // Filtro por Nome do Produto
            string filtroNome = Txt_Pesquisa.Text;
            if (!string.IsNullOrEmpty(filtroNome))
            {
                consultaSQL += $" AND LOWER(NomeProd) LIKE LOWER('%{filtroNome}%')";
            }


            // Validação do campo Preco Max
            string precoMaxTexto = Msk_PrecoMax.Text;

            // Remover o símbolo de moeda e outros caracteres não numéricos
            precoMaxTexto = Regex.Replace(precoMaxTexto, @"[^\d,]", "");
            precoMaxTexto = precoMaxTexto.Replace(",", ".");


            // Validação do campo Preco Min
            string precoMinTexto = Msk_PrecoMin.Text;

            precoMinTexto = Regex.Replace(precoMinTexto, @"[^\d,]", "");
            precoMinTexto = precoMinTexto.Replace(",", ".");

            double? precoMin = null;
            double? precoMax = null;

            if (!string.IsNullOrEmpty(precoMinTexto) && double.TryParse(precoMinTexto, out double precoMinValue))
            {
                precoMin = precoMinValue;
            }

            if (!string.IsNullOrEmpty(precoMaxTexto) && double.TryParse(precoMaxTexto, out double precoMaxValue))
            {
                precoMax = precoMaxValue;
            }

            if (precoMin != null || precoMax != null)
            {
                consultaSQL += FiltrarPorFaixaDePrecoSQL(precoMin, precoMax);
            }

            // Filtro por Tipo
            string tipoSelecionado = Cmb_Tipo.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(tipoSelecionado) && tipoSelecionado != "Todos")
            {
                consultaSQL += $" AND Tipo = '{tipoSelecionado}'";
            }

            // Executar a consulta SQL e atualizar o DataGridView
            AtualizarDataGridView(consultaSQL);
        }

        private string FiltrarPorFaixaDePrecoSQL(double? precoMin, double? precoMax)
        {
            string filtro = "";

            if (precoMin != null)
            {
                filtro += $" AND Preco >= {precoMin}";
            }

            if (precoMax != null)
            {
                filtro += $" AND Preco <= {precoMax}";
            }

            return filtro;
        }

        private void AtualizarDataGridView(string consultaSQL)
        {
            using (DbConnection Connection = new DbConnection())
            {
                // Crie um adaptador de dados para preencher um DataTable
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(consultaSQL, Connection.Connection))
                {
                    DataTable dtFiltrado = new DataTable();
                    adapter.Fill(dtFiltrado);

                    // Atribua o DataTable ao seu DataGridView (Dt_Estoque)
                    Dt_Estoque.DataSource = dtFiltrado;
                }
            }
        }

    }
}
