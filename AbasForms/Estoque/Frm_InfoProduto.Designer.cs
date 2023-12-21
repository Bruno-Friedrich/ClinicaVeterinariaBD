namespace ClinicaVeterinariaBD.AbasForms.Estoque
{
    partial class Frm_InfoProduto
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
            panel1 = new Panel();
            Icn_Titulo = new FontAwesome.Sharp.IconPictureBox();
            Lbl_Titulo = new Label();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            Pnl_Shadow = new Panel();
            Lbl_NomeProd = new Label();
            Txt_Nome = new TextBox();
            Lbl_Preco = new Label();
            Lbl_Quantidade = new Label();
            Txt_Quantidade = new TextBox();
            Lbl_Marca = new Label();
            Txt_Marca = new TextBox();
            Lbl_Descricao = new Label();
            Txt_Descricao = new TextBox();
            Lbl_Venc = new Label();
            Lbl_Lote = new Label();
            Lbl_Dose = new Label();
            Txt_Dose = new TextBox();
            Msk_Vencimento = new MaskedTextBox();
            Msk_Lote = new MaskedTextBox();
            Msk_Preco = new MaskedTextBox();
            Btn_Enviar = new FontAwesome.Sharp.IconButton();
            Btn_Cancelar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            Cmb_Tipo = new ComboBox();
            Msk_Lucro = new MaskedTextBox();
            Lbl_Lucro = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 33, 74);
            panel1.Controls.Add(Icn_Titulo);
            panel1.Controls.Add(Lbl_Titulo);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 65);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // Icn_Titulo
            // 
            Icn_Titulo.BackColor = Color.FromArgb(34, 33, 74);
            Icn_Titulo.ForeColor = Color.Thistle;
            Icn_Titulo.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            Icn_Titulo.IconColor = Color.Thistle;
            Icn_Titulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Icn_Titulo.IconSize = 35;
            Icn_Titulo.Location = new Point(22, 16);
            Icn_Titulo.Name = "Icn_Titulo";
            Icn_Titulo.Size = new Size(39, 35);
            Icn_Titulo.TabIndex = 9;
            Icn_Titulo.TabStop = false;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Titulo.ForeColor = Color.Gainsboro;
            Lbl_Titulo.Location = new Point(67, 22);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(122, 23);
            Lbl_Titulo.TabIndex = 8;
            Lbl_Titulo.Text = "Modificado";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(34, 33, 74);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 29;
            btnExit.Location = new Point(619, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 33);
            btnExit.TabIndex = 7;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // Pnl_Shadow
            // 
            Pnl_Shadow.BackColor = Color.FromArgb(26, 24, 58);
            Pnl_Shadow.Dock = DockStyle.Top;
            Pnl_Shadow.Location = new Point(0, 65);
            Pnl_Shadow.Name = "Pnl_Shadow";
            Pnl_Shadow.Size = new Size(660, 9);
            Pnl_Shadow.TabIndex = 3;
            // 
            // Lbl_NomeProd
            // 
            Lbl_NomeProd.AutoSize = true;
            Lbl_NomeProd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_NomeProd.ForeColor = Color.Gainsboro;
            Lbl_NomeProd.Location = new Point(21, 91);
            Lbl_NomeProd.Name = "Lbl_NomeProd";
            Lbl_NomeProd.Size = new Size(191, 23);
            Lbl_NomeProd.TabIndex = 12;
            Lbl_NomeProd.Text = "Nome do Produto*";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(21, 117);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(249, 27);
            Txt_Nome.TabIndex = 11;
            // 
            // Lbl_Preco
            // 
            Lbl_Preco.AutoSize = true;
            Lbl_Preco.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Preco.ForeColor = Color.Gainsboro;
            Lbl_Preco.Location = new Point(21, 176);
            Lbl_Preco.Name = "Lbl_Preco";
            Lbl_Preco.Size = new Size(75, 23);
            Lbl_Preco.TabIndex = 14;
            Lbl_Preco.Text = "Preço*";
            // 
            // Lbl_Quantidade
            // 
            Lbl_Quantidade.AutoSize = true;
            Lbl_Quantidade.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Quantidade.ForeColor = Color.Gainsboro;
            Lbl_Quantidade.Location = new Point(164, 179);
            Lbl_Quantidade.Name = "Lbl_Quantidade";
            Lbl_Quantidade.Size = new Size(136, 23);
            Lbl_Quantidade.TabIndex = 16;
            Lbl_Quantidade.Text = "Quantidade*";
            // 
            // Txt_Quantidade
            // 
            Txt_Quantidade.Location = new Point(164, 205);
            Txt_Quantidade.Name = "Txt_Quantidade";
            Txt_Quantidade.Size = new Size(133, 27);
            Txt_Quantidade.TabIndex = 15;
            // 
            // Lbl_Marca
            // 
            Lbl_Marca.AutoSize = true;
            Lbl_Marca.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Marca.ForeColor = Color.Gainsboro;
            Lbl_Marca.Location = new Point(318, 91);
            Lbl_Marca.Name = "Lbl_Marca";
            Lbl_Marca.Size = new Size(82, 23);
            Lbl_Marca.TabIndex = 18;
            Lbl_Marca.Text = "Marca*";
            // 
            // Txt_Marca
            // 
            Txt_Marca.Location = new Point(318, 117);
            Txt_Marca.Name = "Txt_Marca";
            Txt_Marca.Size = new Size(150, 27);
            Txt_Marca.TabIndex = 17;
            // 
            // Lbl_Descricao
            // 
            Lbl_Descricao.AutoSize = true;
            Lbl_Descricao.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Descricao.ForeColor = Color.Gainsboro;
            Lbl_Descricao.Location = new Point(318, 176);
            Lbl_Descricao.Name = "Lbl_Descricao";
            Lbl_Descricao.Size = new Size(109, 23);
            Lbl_Descricao.TabIndex = 20;
            Lbl_Descricao.Text = "Descrição";
            // 
            // Txt_Descricao
            // 
            Txt_Descricao.Location = new Point(318, 202);
            Txt_Descricao.Multiline = true;
            Txt_Descricao.Name = "Txt_Descricao";
            Txt_Descricao.ScrollBars = ScrollBars.Vertical;
            Txt_Descricao.Size = new Size(307, 191);
            Txt_Descricao.TabIndex = 19;
            // 
            // Lbl_Venc
            // 
            Lbl_Venc.AutoSize = true;
            Lbl_Venc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Venc.ForeColor = Color.Gainsboro;
            Lbl_Venc.Location = new Point(19, 261);
            Lbl_Venc.Name = "Lbl_Venc";
            Lbl_Venc.Size = new Size(130, 23);
            Lbl_Venc.TabIndex = 22;
            Lbl_Venc.Text = "Vencimento";
            // 
            // Lbl_Lote
            // 
            Lbl_Lote.AutoSize = true;
            Lbl_Lote.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Lote.ForeColor = Color.Gainsboro;
            Lbl_Lote.Location = new Point(164, 261);
            Lbl_Lote.Name = "Lbl_Lote";
            Lbl_Lote.Size = new Size(51, 23);
            Lbl_Lote.TabIndex = 24;
            Lbl_Lote.Text = "Lote";
            // 
            // Lbl_Dose
            // 
            Lbl_Dose.AutoSize = true;
            Lbl_Dose.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Dose.ForeColor = Color.Gainsboro;
            Lbl_Dose.Location = new Point(21, 346);
            Lbl_Dose.Name = "Lbl_Dose";
            Lbl_Dose.Size = new Size(59, 23);
            Lbl_Dose.TabIndex = 26;
            Lbl_Dose.Text = "Dose";
            // 
            // Txt_Dose
            // 
            Txt_Dose.Location = new Point(22, 372);
            Txt_Dose.Name = "Txt_Dose";
            Txt_Dose.Size = new Size(71, 27);
            Txt_Dose.TabIndex = 25;
            // 
            // Msk_Vencimento
            // 
            Msk_Vencimento.Location = new Point(21, 287);
            Msk_Vencimento.Mask = "00/00/0000";
            Msk_Vencimento.Name = "Msk_Vencimento";
            Msk_Vencimento.Size = new Size(100, 27);
            Msk_Vencimento.TabIndex = 27;
            Msk_Vencimento.TextAlign = HorizontalAlignment.Center;
            Msk_Vencimento.ValidatingType = typeof(DateTime);
            // 
            // Msk_Lote
            // 
            Msk_Lote.Location = new Point(164, 287);
            Msk_Lote.Mask = "AAAAAAAAAAAAAAAAAAAA";
            Msk_Lote.Name = "Msk_Lote";
            Msk_Lote.Size = new Size(133, 27);
            Msk_Lote.TabIndex = 28;
            // 
            // Msk_Preco
            // 
            Msk_Preco.Location = new Point(21, 202);
            Msk_Preco.Mask = "$##0.00";
            Msk_Preco.Name = "Msk_Preco";
            Msk_Preco.Size = new Size(100, 27);
            Msk_Preco.TabIndex = 31;
            Msk_Preco.TextAlign = HorizontalAlignment.Center;
            Msk_Preco.ValidatingType = typeof(DateTime);
            // 
            // Btn_Enviar
            // 
            Btn_Enviar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Enviar.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_Enviar.IconColor = Color.Black;
            Btn_Enviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Enviar.Location = new Point(476, 414);
            Btn_Enviar.Name = "Btn_Enviar";
            Btn_Enviar.Size = new Size(149, 46);
            Btn_Enviar.TabIndex = 32;
            Btn_Enviar.Text = "Enviar";
            Btn_Enviar.UseVisualStyleBackColor = true;
            Btn_Enviar.Click += Btn_Enviar_Click;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_Cancelar.IconColor = Color.Black;
            Btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Cancelar.Location = new Point(318, 414);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(149, 46);
            Btn_Cancelar.TabIndex = 33;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(476, 91);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 40;
            label2.Text = "Tipo*";
            // 
            // Cmb_Tipo
            // 
            Cmb_Tipo.FormattingEnabled = true;
            Cmb_Tipo.Items.AddRange(new object[] { "Medicamentos", "Comida", "Outros" });
            Cmb_Tipo.Location = new Point(476, 117);
            Cmb_Tipo.Name = "Cmb_Tipo";
            Cmb_Tipo.Size = new Size(151, 28);
            Cmb_Tipo.TabIndex = 39;
            // 
            // Msk_Lucro
            // 
            Msk_Lucro.Location = new Point(101, 440);
            Msk_Lucro.Mask = "000%";
            Msk_Lucro.Name = "Msk_Lucro";
            Msk_Lucro.Size = new Size(49, 27);
            Msk_Lucro.TabIndex = 42;
            Msk_Lucro.TextAlign = HorizontalAlignment.Right;
            // 
            // Lbl_Lucro
            // 
            Lbl_Lucro.AutoSize = true;
            Lbl_Lucro.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Lucro.ForeColor = Color.Gainsboro;
            Lbl_Lucro.Location = new Point(22, 414);
            Lbl_Lucro.Name = "Lbl_Lucro";
            Lbl_Lucro.Size = new Size(233, 23);
            Lbl_Lucro.TabIndex = 41;
            Lbl_Lucro.Text = "Porcentagem de Lucro";
            // 
            // Frm_InfoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 72);
            ClientSize = new Size(660, 481);
            Controls.Add(Msk_Lucro);
            Controls.Add(Lbl_Lucro);
            Controls.Add(label2);
            Controls.Add(Cmb_Tipo);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Enviar);
            Controls.Add(Msk_Preco);
            Controls.Add(Msk_Lote);
            Controls.Add(Msk_Vencimento);
            Controls.Add(Lbl_Dose);
            Controls.Add(Txt_Dose);
            Controls.Add(Lbl_Lote);
            Controls.Add(Lbl_Venc);
            Controls.Add(Lbl_Descricao);
            Controls.Add(Txt_Descricao);
            Controls.Add(Lbl_Marca);
            Controls.Add(Txt_Marca);
            Controls.Add(Lbl_Quantidade);
            Controls.Add(Txt_Quantidade);
            Controls.Add(Lbl_Preco);
            Controls.Add(Lbl_NomeProd);
            Controls.Add(Txt_Nome);
            Controls.Add(Pnl_Shadow);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_InfoProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_InfoProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Panel Pnl_Shadow;
        private Label Lbl_Titulo;
        private FontAwesome.Sharp.IconPictureBox Icn_Titulo;
        private Label Lbl_NomeProd;
        private TextBox Txt_Nome;
        private Label Lbl_Preco;
        private Label Lbl_Quantidade;
        private TextBox Txt_Quantidade;
        private Label Lbl_Marca;
        private TextBox Txt_Marca;
        private Label Lbl_Descricao;
        private TextBox Txt_Descricao;
        private Label Lbl_Venc;
        private Label Lbl_Lote;
        private Label Lbl_Dose;
        private TextBox Txt_Dose;
        private MaskedTextBox Msk_Vencimento;
        private MaskedTextBox Msk_Lote;
        private MaskedTextBox Msk_Preco;
        private FontAwesome.Sharp.IconButton Btn_Enviar;
        private FontAwesome.Sharp.IconButton Btn_Cancelar;
        private Label label2;
        private ComboBox Cmb_Tipo;
        private MaskedTextBox Msk_Lucro;
        private Label Lbl_Lucro;
    }
}