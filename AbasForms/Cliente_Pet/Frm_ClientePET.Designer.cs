namespace ClinicaVeterinariaBD.AbasForms
{
    partial class Frm_ClientePET
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
            Dt_Consulta = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dt_Consulta).BeginInit();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 49);
            panel1.TabIndex = 1;
            // 
            // Icn_Titulo
            // 
            Icn_Titulo.BackColor = Color.FromArgb(34, 33, 74);
            Icn_Titulo.ForeColor = Color.Thistle;
            Icn_Titulo.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            Icn_Titulo.IconColor = Color.Thistle;
            Icn_Titulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Icn_Titulo.IconSize = 26;
            Icn_Titulo.Location = new Point(19, 16);
            Icn_Titulo.Margin = new Padding(3, 2, 3, 2);
            Icn_Titulo.Name = "Icn_Titulo";
            Icn_Titulo.Size = new Size(34, 26);
            Icn_Titulo.TabIndex = 9;
            Icn_Titulo.TabStop = false;
            Icn_Titulo.Click += Icn_Titulo_Click;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Titulo.ForeColor = Color.Gainsboro;
            Lbl_Titulo.Location = new Point(48, 16);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(118, 19);
            Lbl_Titulo.TabIndex = 8;
            Lbl_Titulo.Text = "Clientes Ativos";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(26, 25, 72);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 25;
            btnExit.Location = new Point(1042, 9);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 25);
            btnExit.TabIndex = 7;
            btnExit.TabStop = false;
            // 
            // Dt_Consulta
            // 
            Dt_Consulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Consulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Consulta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            Dt_Consulta.BackgroundColor = Color.FromArgb(34, 33, 74);
            Dt_Consulta.BorderStyle = BorderStyle.None;
            Dt_Consulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Consulta.Location = new Point(12, 137);
            Dt_Consulta.Margin = new Padding(3, 2, 3, 2);
            Dt_Consulta.Name = "Dt_Consulta";
            Dt_Consulta.RowHeadersWidth = 51;
            Dt_Consulta.RowTemplate.Height = 29;
            Dt_Consulta.Size = new Size(676, 177);
            Dt_Consulta.TabIndex = 6;
            Dt_Consulta.CellContentClick += Dt_Consulta_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(25, 110);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o ID do cliente...";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(159, 110);
            button1.Name = "button1";
            button1.Size = new Size(67, 25);
            button1.TabIndex = 8;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm_ClientePET
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Dt_Consulta);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_ClientePET";
            Text = "Frm_ClientePET";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dt_Consulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 Btn_AddProduto;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_EditProduto;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_RemoveProduto;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private DataGridView Dt_ClientePet;
        private FontAwesome.Sharp.IconPictureBox Icn_Titulo;
        private Label Lbl_Titulo;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private DataGridView Dt_Consulta;
        private TextBox textBox1;
        private Button button1;
    }
}