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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dt_Estoque).BeginInit();
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
            panel1.Size = new Size(800, 55);
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
            Btn_EditProduto.Size = new Size(226, 42);
            Btn_EditProduto.TabIndex = 2;
            Btn_EditProduto.TextAlign = ContentAlignment.MiddleCenter;
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
            Btn_RemoveProduto.Size = new Size(226, 42);
            Btn_RemoveProduto.TabIndex = 1;
            Btn_RemoveProduto.TextAlign = ContentAlignment.MiddleCenter;
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
            Btn_AddProduto.Size = new Size(226, 42);
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
            Dt_Estoque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Dt_Estoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Estoque.Location = new Point(27, 173);
            Dt_Estoque.Name = "Dt_Estoque";
            Dt_Estoque.RowHeadersWidth = 51;
            Dt_Estoque.RowTemplate.Height = 29;
            Dt_Estoque.Size = new Size(742, 236);
            Dt_Estoque.TabIndex = 1;
            // 
            // Frm_Estoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(Dt_Estoque);
            Controls.Add(panel1);
            Name = "Frm_Estoque";
            Text = "Frm_Estoque";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dt_Estoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_AddProduto;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_EditProduto;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_RemoveProduto;
        private BindingSource dbConnectionBindingSource;
        private DataGridView Dt_Estoque;
    }
}