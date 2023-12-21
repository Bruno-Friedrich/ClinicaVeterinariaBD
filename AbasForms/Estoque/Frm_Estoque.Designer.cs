namespace ClinicaVeterinariaBD.AbasForms
{
    partial class Frm_Estoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estoque));
            panel1 = new Panel();
            Btn_EditProduto = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_RemoveProduto = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_AddProduto = new Bunifu.Framework.UI.BunifuThinButton2();
            dbConnectionBindingSource = new BindingSource(components);
            Dt_Estoque = new DataGridView();
            Txt_Pesquisa = new TextBox();
            Btn_Id = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_Quantidade = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_Preco = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_Marca = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_Descricao = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_Vencimento = new Bunifu.Framework.UI.BunifuThinButton2();
            Bnt_Lote = new Bunifu.Framework.UI.BunifuThinButton2();
            Bnt_Dose = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_Tipo = new Bunifu.Framework.UI.BunifuThinButton2();
            Lbl_Marca = new Label();
            label1 = new Label();
            label2 = new Label();
            Cmb_Tipo = new ComboBox();
            Btn_Filtro = new FontAwesome.Sharp.IconPictureBox();
            Msk_PrecoMin = new MaskedTextBox();
            Msk_PrecoMax = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dt_Estoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Filtro).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 33, 74);
            panel1.Controls.Add(Btn_EditProduto);
            panel1.Controls.Add(Btn_RemoveProduto);
            panel1.Controls.Add(Btn_AddProduto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 55);
            panel1.TabIndex = 0;
            // 
            // Btn_EditProduto
            // 
            Btn_EditProduto.ActiveBorderThickness = 1;
            Btn_EditProduto.ActiveCornerRadius = 20;
            Btn_EditProduto.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_EditProduto.ActiveForecolor = Color.White;
            Btn_EditProduto.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_EditProduto.BackColor = Color.FromArgb(34, 33, 74);
            Btn_EditProduto.BackgroundImage = (Image)resources.GetObject("Btn_EditProduto.BackgroundImage");
            Btn_EditProduto.ButtonText = "Editar Produto";
            Btn_EditProduto.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_EditProduto.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_EditProduto.IdleBorderThickness = 1;
            Btn_EditProduto.IdleCornerRadius = 20;
            Btn_EditProduto.IdleFillColor = Color.White;
            Btn_EditProduto.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_EditProduto.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_EditProduto.Location = new Point(521, 5);
            Btn_EditProduto.Margin = new Padding(6, 5, 6, 5);
            Btn_EditProduto.Name = "Btn_EditProduto";
            Btn_EditProduto.Size = new Size(226, 43);
            Btn_EditProduto.TabIndex = 2;
            Btn_EditProduto.TextAlign = ContentAlignment.MiddleCenter;
            Btn_EditProduto.Click += Btn_EditProduto_Click;
            // 
            // Btn_RemoveProduto
            // 
            Btn_RemoveProduto.ActiveBorderThickness = 1;
            Btn_RemoveProduto.ActiveCornerRadius = 20;
            Btn_RemoveProduto.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_RemoveProduto.ActiveForecolor = Color.White;
            Btn_RemoveProduto.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_RemoveProduto.BackColor = Color.FromArgb(34, 33, 74);
            Btn_RemoveProduto.BackgroundImage = (Image)resources.GetObject("Btn_RemoveProduto.BackgroundImage");
            Btn_RemoveProduto.ButtonText = "Remove Produto";
            Btn_RemoveProduto.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_RemoveProduto.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_RemoveProduto.IdleBorderThickness = 1;
            Btn_RemoveProduto.IdleCornerRadius = 20;
            Btn_RemoveProduto.IdleFillColor = Color.White;
            Btn_RemoveProduto.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_RemoveProduto.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_RemoveProduto.Location = new Point(283, 5);
            Btn_RemoveProduto.Margin = new Padding(6, 5, 6, 5);
            Btn_RemoveProduto.Name = "Btn_RemoveProduto";
            Btn_RemoveProduto.Size = new Size(226, 43);
            Btn_RemoveProduto.TabIndex = 1;
            Btn_RemoveProduto.TextAlign = ContentAlignment.MiddleCenter;
            Btn_RemoveProduto.Click += Btn_RemoveProduto_Click;
            // 
            // Btn_AddProduto
            // 
            Btn_AddProduto.ActiveBorderThickness = 1;
            Btn_AddProduto.ActiveCornerRadius = 20;
            Btn_AddProduto.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_AddProduto.ActiveForecolor = Color.White;
            Btn_AddProduto.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_AddProduto.BackColor = Color.FromArgb(34, 33, 74);
            Btn_AddProduto.BackgroundImage = (Image)resources.GetObject("Btn_AddProduto.BackgroundImage");
            Btn_AddProduto.ButtonText = "Adicionar novo Produto";
            Btn_AddProduto.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_AddProduto.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_AddProduto.IdleBorderThickness = 1;
            Btn_AddProduto.IdleCornerRadius = 20;
            Btn_AddProduto.IdleFillColor = Color.White;
            Btn_AddProduto.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_AddProduto.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_AddProduto.Location = new Point(45, 5);
            Btn_AddProduto.Margin = new Padding(6, 5, 6, 5);
            Btn_AddProduto.Name = "Btn_AddProduto";
            Btn_AddProduto.Size = new Size(226, 43);
            Btn_AddProduto.TabIndex = 0;
            Btn_AddProduto.TextAlign = ContentAlignment.MiddleCenter;
            Btn_AddProduto.Click += Btn_AddProduto_Click;
            // 
            // dbConnectionBindingSource
            // 
            dbConnectionBindingSource.DataSource = typeof(Arquitetura.DbConnection);
            // 
            // Dt_Estoque
            // 
            Dt_Estoque.AllowUserToAddRows = false;
            Dt_Estoque.AllowUserToDeleteRows = false;
            Dt_Estoque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Estoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Estoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            Dt_Estoque.BackgroundColor = Color.DarkGray;
            Dt_Estoque.CausesValidation = false;
            Dt_Estoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Estoque.GridColor = Color.AliceBlue;
            Dt_Estoque.Location = new Point(45, 146);
            Dt_Estoque.Name = "Dt_Estoque";
            Dt_Estoque.ReadOnly = true;
            Dt_Estoque.RowHeadersVisible = false;
            Dt_Estoque.RowHeadersWidth = 51;
            Dt_Estoque.RowTemplate.Height = 29;
            Dt_Estoque.RowTemplate.Resizable = DataGridViewTriState.True;
            Dt_Estoque.Size = new Size(826, 293);
            Dt_Estoque.TabIndex = 1;
            // 
            // Txt_Pesquisa
            // 
            Txt_Pesquisa.Location = new Point(45, 67);
            Txt_Pesquisa.Margin = new Padding(3, 4, 3, 4);
            Txt_Pesquisa.Name = "Txt_Pesquisa";
            Txt_Pesquisa.PlaceholderText = "Digite o Nome do Produto";
            Txt_Pesquisa.Size = new Size(183, 27);
            Txt_Pesquisa.TabIndex = 2;
            // 
            // Btn_Id
            // 
            Btn_Id.ActiveBorderThickness = 1;
            Btn_Id.ActiveCornerRadius = 20;
            Btn_Id.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_Id.ActiveForecolor = Color.White;
            Btn_Id.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_Id.BackColor = Color.FromArgb(34, 33, 74);
            Btn_Id.BackgroundImage = (Image)resources.GetObject("Btn_Id.BackgroundImage");
            Btn_Id.ButtonText = "Código";
            Btn_Id.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Id.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_Id.IdleBorderThickness = 1;
            Btn_Id.IdleCornerRadius = 20;
            Btn_Id.IdleFillColor = Color.White;
            Btn_Id.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_Id.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Id.Location = new Point(45, 102);
            Btn_Id.Margin = new Padding(4);
            Btn_Id.Name = "Btn_Id";
            Btn_Id.Size = new Size(78, 37);
            Btn_Id.TabIndex = 3;
            Btn_Id.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Id.Click += Btn_Id_Click;
            // 
            // Btn_Quantidade
            // 
            Btn_Quantidade.ActiveBorderThickness = 1;
            Btn_Quantidade.ActiveCornerRadius = 20;
            Btn_Quantidade.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_Quantidade.ActiveForecolor = Color.White;
            Btn_Quantidade.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_Quantidade.BackColor = Color.FromArgb(34, 33, 74);
            Btn_Quantidade.BackgroundImage = (Image)resources.GetObject("Btn_Quantidade.BackgroundImage");
            Btn_Quantidade.ButtonText = "Quatidade";
            Btn_Quantidade.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Quantidade.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_Quantidade.IdleBorderThickness = 1;
            Btn_Quantidade.IdleCornerRadius = 20;
            Btn_Quantidade.IdleFillColor = Color.White;
            Btn_Quantidade.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_Quantidade.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Quantidade.Location = new Point(217, 102);
            Btn_Quantidade.Margin = new Padding(4);
            Btn_Quantidade.Name = "Btn_Quantidade";
            Btn_Quantidade.Size = new Size(94, 37);
            Btn_Quantidade.TabIndex = 6;
            Btn_Quantidade.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Quantidade.Click += Btn_Quantidade_Click;
            // 
            // Btn_Preco
            // 
            Btn_Preco.ActiveBorderThickness = 1;
            Btn_Preco.ActiveCornerRadius = 20;
            Btn_Preco.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_Preco.ActiveForecolor = Color.White;
            Btn_Preco.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_Preco.BackColor = Color.FromArgb(34, 33, 74);
            Btn_Preco.BackgroundImage = (Image)resources.GetObject("Btn_Preco.BackgroundImage");
            Btn_Preco.ButtonText = "Preço";
            Btn_Preco.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Preco.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_Preco.IdleBorderThickness = 1;
            Btn_Preco.IdleCornerRadius = 20;
            Btn_Preco.IdleFillColor = Color.White;
            Btn_Preco.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_Preco.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Preco.Location = new Point(131, 102);
            Btn_Preco.Margin = new Padding(4);
            Btn_Preco.Name = "Btn_Preco";
            Btn_Preco.Size = new Size(78, 37);
            Btn_Preco.TabIndex = 5;
            Btn_Preco.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Preco.Click += Btn_Preco_Click;
            // 
            // Btn_Marca
            // 
            Btn_Marca.ActiveBorderThickness = 1;
            Btn_Marca.ActiveCornerRadius = 20;
            Btn_Marca.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_Marca.ActiveForecolor = Color.White;
            Btn_Marca.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_Marca.BackColor = Color.FromArgb(34, 33, 74);
            Btn_Marca.BackgroundImage = (Image)resources.GetObject("Btn_Marca.BackgroundImage");
            Btn_Marca.ButtonText = "Marca";
            Btn_Marca.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Marca.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_Marca.IdleBorderThickness = 1;
            Btn_Marca.IdleCornerRadius = 20;
            Btn_Marca.IdleFillColor = Color.White;
            Btn_Marca.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_Marca.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Marca.Location = new Point(538, 102);
            Btn_Marca.Margin = new Padding(4);
            Btn_Marca.Name = "Btn_Marca";
            Btn_Marca.Size = new Size(78, 37);
            Btn_Marca.TabIndex = 10;
            Btn_Marca.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Marca.Click += Btn_Marca_Click;
            // 
            // Btn_Descricao
            // 
            Btn_Descricao.ActiveBorderThickness = 1;
            Btn_Descricao.ActiveCornerRadius = 20;
            Btn_Descricao.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_Descricao.ActiveForecolor = Color.White;
            Btn_Descricao.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_Descricao.BackColor = Color.FromArgb(34, 33, 74);
            Btn_Descricao.BackgroundImage = (Image)resources.GetObject("Btn_Descricao.BackgroundImage");
            Btn_Descricao.ButtonText = "Descrição";
            Btn_Descricao.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Descricao.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_Descricao.IdleBorderThickness = 1;
            Btn_Descricao.IdleCornerRadius = 20;
            Btn_Descricao.IdleFillColor = Color.White;
            Btn_Descricao.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_Descricao.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Descricao.Location = new Point(319, 102);
            Btn_Descricao.Margin = new Padding(4);
            Btn_Descricao.Name = "Btn_Descricao";
            Btn_Descricao.Size = new Size(94, 37);
            Btn_Descricao.TabIndex = 8;
            Btn_Descricao.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Descricao.Click += Btn_Descricao_Click;
            // 
            // Btn_Vencimento
            // 
            Btn_Vencimento.ActiveBorderThickness = 1;
            Btn_Vencimento.ActiveCornerRadius = 20;
            Btn_Vencimento.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_Vencimento.ActiveForecolor = Color.White;
            Btn_Vencimento.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_Vencimento.BackColor = Color.FromArgb(34, 33, 74);
            Btn_Vencimento.BackgroundImage = (Image)resources.GetObject("Btn_Vencimento.BackgroundImage");
            Btn_Vencimento.ButtonText = "Vencimento";
            Btn_Vencimento.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Vencimento.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_Vencimento.IdleBorderThickness = 1;
            Btn_Vencimento.IdleCornerRadius = 20;
            Btn_Vencimento.IdleFillColor = Color.White;
            Btn_Vencimento.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_Vencimento.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Vencimento.Location = new Point(421, 102);
            Btn_Vencimento.Margin = new Padding(4);
            Btn_Vencimento.Name = "Btn_Vencimento";
            Btn_Vencimento.Size = new Size(109, 37);
            Btn_Vencimento.TabIndex = 11;
            Btn_Vencimento.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Vencimento.Click += Btn_Vencimento_Click;
            // 
            // Bnt_Lote
            // 
            Bnt_Lote.ActiveBorderThickness = 1;
            Bnt_Lote.ActiveCornerRadius = 20;
            Bnt_Lote.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Bnt_Lote.ActiveForecolor = Color.White;
            Bnt_Lote.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Bnt_Lote.BackColor = Color.FromArgb(34, 33, 74);
            Bnt_Lote.BackgroundImage = (Image)resources.GetObject("Bnt_Lote.BackgroundImage");
            Bnt_Lote.ButtonText = "Lote";
            Bnt_Lote.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Bnt_Lote.ForeColor = Color.FromArgb(33, 45, 74);
            Bnt_Lote.IdleBorderThickness = 1;
            Bnt_Lote.IdleCornerRadius = 20;
            Bnt_Lote.IdleFillColor = Color.White;
            Bnt_Lote.IdleForecolor = Color.FromArgb(47, 33, 74);
            Bnt_Lote.IdleLineColor = Color.FromArgb(47, 33, 74);
            Bnt_Lote.Location = new Point(624, 102);
            Bnt_Lote.Margin = new Padding(4);
            Bnt_Lote.Name = "Bnt_Lote";
            Bnt_Lote.Size = new Size(73, 37);
            Bnt_Lote.TabIndex = 12;
            Bnt_Lote.TextAlign = ContentAlignment.MiddleCenter;
            Bnt_Lote.Click += Bnt_Lote_Click;
            // 
            // Bnt_Dose
            // 
            Bnt_Dose.ActiveBorderThickness = 1;
            Bnt_Dose.ActiveCornerRadius = 20;
            Bnt_Dose.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Bnt_Dose.ActiveForecolor = Color.White;
            Bnt_Dose.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Bnt_Dose.BackColor = Color.FromArgb(34, 33, 74);
            Bnt_Dose.BackgroundImage = (Image)resources.GetObject("Bnt_Dose.BackgroundImage");
            Bnt_Dose.ButtonText = "Dose";
            Bnt_Dose.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Bnt_Dose.ForeColor = Color.FromArgb(33, 45, 74);
            Bnt_Dose.IdleBorderThickness = 1;
            Bnt_Dose.IdleCornerRadius = 20;
            Bnt_Dose.IdleFillColor = Color.White;
            Bnt_Dose.IdleForecolor = Color.FromArgb(47, 33, 74);
            Bnt_Dose.IdleLineColor = Color.FromArgb(47, 33, 74);
            Bnt_Dose.Location = new Point(705, 102);
            Bnt_Dose.Margin = new Padding(4);
            Bnt_Dose.Name = "Bnt_Dose";
            Bnt_Dose.Size = new Size(78, 37);
            Bnt_Dose.TabIndex = 13;
            Bnt_Dose.TextAlign = ContentAlignment.MiddleCenter;
            Bnt_Dose.Click += Bnt_Dose_Click;
            // 
            // Btn_Tipo
            // 
            Btn_Tipo.ActiveBorderThickness = 1;
            Btn_Tipo.ActiveCornerRadius = 20;
            Btn_Tipo.ActiveFillColor = Color.FromArgb(47, 33, 74);
            Btn_Tipo.ActiveForecolor = Color.White;
            Btn_Tipo.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_Tipo.BackColor = Color.FromArgb(34, 33, 74);
            Btn_Tipo.BackgroundImage = (Image)resources.GetObject("Btn_Tipo.BackgroundImage");
            Btn_Tipo.ButtonText = "Tipo";
            Btn_Tipo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Tipo.ForeColor = Color.FromArgb(33, 45, 74);
            Btn_Tipo.IdleBorderThickness = 1;
            Btn_Tipo.IdleCornerRadius = 20;
            Btn_Tipo.IdleFillColor = Color.White;
            Btn_Tipo.IdleForecolor = Color.FromArgb(47, 33, 74);
            Btn_Tipo.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Tipo.Location = new Point(791, 102);
            Btn_Tipo.Margin = new Padding(4);
            Btn_Tipo.Name = "Btn_Tipo";
            Btn_Tipo.Size = new Size(78, 37);
            Btn_Tipo.TabIndex = 14;
            Btn_Tipo.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Tipo.Click += Btn_Tipo_Click;
            // 
            // Lbl_Marca
            // 
            Lbl_Marca.AutoSize = true;
            Lbl_Marca.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Marca.ForeColor = Color.Gainsboro;
            Lbl_Marca.Location = new Point(230, 69);
            Lbl_Marca.Name = "Lbl_Marca";
            Lbl_Marca.Size = new Size(153, 23);
            Lbl_Marca.TabIndex = 19;
            Lbl_Marca.Text = "Filtrar por valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(437, 71);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 33;
            label1.Text = "até";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(537, 69);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 35;
            label2.Text = "Filtrar por tipo:";
            // 
            // Cmb_Tipo
            // 
            Cmb_Tipo.FormattingEnabled = true;
            Cmb_Tipo.Items.AddRange(new object[] { "Medicamentos", "Comida", "Outros", "Todos" });
            Cmb_Tipo.Location = new Point(680, 67);
            Cmb_Tipo.Name = "Cmb_Tipo";
            Cmb_Tipo.Size = new Size(127, 28);
            Cmb_Tipo.TabIndex = 40;
            // 
            // Btn_Filtro
            // 
            Btn_Filtro.BackColor = Color.FromArgb(34, 33, 74);
            Btn_Filtro.ForeColor = Color.Gainsboro;
            Btn_Filtro.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            Btn_Filtro.IconColor = Color.Gainsboro;
            Btn_Filtro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Filtro.IconSize = 36;
            Btn_Filtro.Location = new Point(813, 61);
            Btn_Filtro.Name = "Btn_Filtro";
            Btn_Filtro.Size = new Size(45, 36);
            Btn_Filtro.TabIndex = 41;
            Btn_Filtro.TabStop = false;
            Btn_Filtro.Click += Btn_Filtro_Click;
            // 
            // Msk_PrecoMin
            // 
            Msk_PrecoMin.Location = new Point(382, 68);
            Msk_PrecoMin.Mask = "$000.00";
            Msk_PrecoMin.Name = "Msk_PrecoMin";
            Msk_PrecoMin.Size = new Size(56, 27);
            Msk_PrecoMin.TabIndex = 42;
            // 
            // Msk_PrecoMax
            // 
            Msk_PrecoMax.Location = new Point(477, 68);
            Msk_PrecoMax.Mask = "$000.00";
            Msk_PrecoMax.Name = "Msk_PrecoMax";
            Msk_PrecoMax.Size = new Size(56, 27);
            Msk_PrecoMax.TabIndex = 43;
            // 
            // Frm_Estoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(892, 492);
            Controls.Add(Msk_PrecoMax);
            Controls.Add(Msk_PrecoMin);
            Controls.Add(Btn_Filtro);
            Controls.Add(Cmb_Tipo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Lbl_Marca);
            Controls.Add(Btn_Tipo);
            Controls.Add(Bnt_Dose);
            Controls.Add(Bnt_Lote);
            Controls.Add(Btn_Vencimento);
            Controls.Add(Btn_Marca);
            Controls.Add(Btn_Descricao);
            Controls.Add(Btn_Quantidade);
            Controls.Add(Btn_Preco);
            Controls.Add(Btn_Id);
            Controls.Add(Txt_Pesquisa);
            Controls.Add(Dt_Estoque);
            Controls.Add(panel1);
            Name = "Frm_Estoque";
            Text = "Frm_Estoque";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dt_Estoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Filtro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_AddProduto;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_EditProduto;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_RemoveProduto;
        private BindingSource dbConnectionBindingSource;
        private DataGridView Dt_Estoque;
        private TextBox Txt_Pesquisa;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Id;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Quantidade;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Preco;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Marca;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Descricao;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Vencimento;
        private Bunifu.Framework.UI.BunifuThinButton2 Bnt_Lote;
        private Bunifu.Framework.UI.BunifuThinButton2 Bnt_Dose;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Tipo;
        private Label Lbl_Marca;
        private Label label1;
        private Label label2;
        private ComboBox Cmb_Tipo;
        private FontAwesome.Sharp.IconPictureBox Btn_Filtro;
        private MaskedTextBox Msk_PrecoMin;
        private MaskedTextBox Msk_PrecoMax;
    }
}