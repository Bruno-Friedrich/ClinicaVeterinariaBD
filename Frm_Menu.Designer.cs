namespace ClinicaVeterinariaBD
{
    partial class Frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            Pnl_Menu = new Panel();
            Btn_Estoque = new FontAwesome.Sharp.IconButton();
            Btn_Relatorio = new FontAwesome.Sharp.IconButton();
            Btn_Pagamento = new FontAwesome.Sharp.IconButton();
            Btn_ClientePET = new FontAwesome.Sharp.IconButton();
            Btn_Consultas = new FontAwesome.Sharp.IconButton();
            Pnl_Logo = new Panel();
            Btn_Home = new PictureBox();
            panel1 = new Panel();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            Pnl_Shadow = new Panel();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            Pnl_Menu.SuspendLayout();
            Pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Home).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Menu
            // 
            Pnl_Menu.BackColor = Color.FromArgb(31, 30, 68);
            Pnl_Menu.Controls.Add(Btn_Estoque);
            Pnl_Menu.Controls.Add(Btn_Relatorio);
            Pnl_Menu.Controls.Add(Btn_Pagamento);
            Pnl_Menu.Controls.Add(Btn_ClientePET);
            Pnl_Menu.Controls.Add(Btn_Consultas);
            Pnl_Menu.Controls.Add(Pnl_Logo);
            Pnl_Menu.Dock = DockStyle.Left;
            Pnl_Menu.Location = new Point(0, 0);
            Pnl_Menu.Name = "Pnl_Menu";
            Pnl_Menu.Size = new Size(220, 485);
            Pnl_Menu.TabIndex = 0;
            // 
            // Btn_Estoque
            // 
            Btn_Estoque.Dock = DockStyle.Top;
            Btn_Estoque.FlatAppearance.BorderSize = 0;
            Btn_Estoque.FlatStyle = FlatStyle.Flat;
            Btn_Estoque.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Estoque.ForeColor = Color.Gainsboro;
            Btn_Estoque.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            Btn_Estoque.IconColor = Color.Gainsboro;
            Btn_Estoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Estoque.IconSize = 36;
            Btn_Estoque.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Estoque.Location = new Point(0, 365);
            Btn_Estoque.Name = "Btn_Estoque";
            Btn_Estoque.Padding = new Padding(10, 0, 20, 0);
            Btn_Estoque.Size = new Size(220, 60);
            Btn_Estoque.TabIndex = 5;
            Btn_Estoque.Text = "Estoque";
            Btn_Estoque.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Estoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Estoque.UseVisualStyleBackColor = true;
            Btn_Estoque.Click += Btn_Estoque_Click;
            // 
            // Btn_Relatorio
            // 
            Btn_Relatorio.Dock = DockStyle.Top;
            Btn_Relatorio.FlatAppearance.BorderSize = 0;
            Btn_Relatorio.FlatStyle = FlatStyle.Flat;
            Btn_Relatorio.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Relatorio.ForeColor = Color.Gainsboro;
            Btn_Relatorio.IconChar = FontAwesome.Sharp.IconChar.ChartGantt;
            Btn_Relatorio.IconColor = Color.Gainsboro;
            Btn_Relatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Relatorio.IconSize = 36;
            Btn_Relatorio.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Relatorio.Location = new Point(0, 305);
            Btn_Relatorio.Name = "Btn_Relatorio";
            Btn_Relatorio.Padding = new Padding(10, 0, 20, 0);
            Btn_Relatorio.Size = new Size(220, 60);
            Btn_Relatorio.TabIndex = 4;
            Btn_Relatorio.Text = "Relatório";
            Btn_Relatorio.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Relatorio.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Relatorio.UseVisualStyleBackColor = true;
            Btn_Relatorio.Click += Btn_Relatorio_Click;
            // 
            // Btn_Pagamento
            // 
            Btn_Pagamento.Dock = DockStyle.Top;
            Btn_Pagamento.FlatAppearance.BorderSize = 0;
            Btn_Pagamento.FlatStyle = FlatStyle.Flat;
            Btn_Pagamento.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Pagamento.ForeColor = Color.Gainsboro;
            Btn_Pagamento.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            Btn_Pagamento.IconColor = Color.Gainsboro;
            Btn_Pagamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Pagamento.IconSize = 36;
            Btn_Pagamento.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Pagamento.Location = new Point(0, 245);
            Btn_Pagamento.Name = "Btn_Pagamento";
            Btn_Pagamento.Padding = new Padding(10, 0, 20, 0);
            Btn_Pagamento.Size = new Size(220, 60);
            Btn_Pagamento.TabIndex = 3;
            Btn_Pagamento.Text = "Pagamento";
            Btn_Pagamento.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Pagamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Pagamento.UseVisualStyleBackColor = true;
            Btn_Pagamento.Click += Btn_Pagamento_Click;
            // 
            // Btn_ClientePET
            // 
            Btn_ClientePET.Dock = DockStyle.Top;
            Btn_ClientePET.FlatAppearance.BorderSize = 0;
            Btn_ClientePET.FlatStyle = FlatStyle.Flat;
            Btn_ClientePET.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_ClientePET.ForeColor = Color.Gainsboro;
            Btn_ClientePET.IconChar = FontAwesome.Sharp.IconChar.Paw;
            Btn_ClientePET.IconColor = Color.Gainsboro;
            Btn_ClientePET.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_ClientePET.IconSize = 36;
            Btn_ClientePET.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_ClientePET.Location = new Point(0, 185);
            Btn_ClientePET.Name = "Btn_ClientePET";
            Btn_ClientePET.Padding = new Padding(10, 0, 20, 0);
            Btn_ClientePET.Size = new Size(220, 60);
            Btn_ClientePET.TabIndex = 2;
            Btn_ClientePET.Text = "Cliente e PETs";
            Btn_ClientePET.TextAlign = ContentAlignment.MiddleLeft;
            Btn_ClientePET.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_ClientePET.UseVisualStyleBackColor = true;
            Btn_ClientePET.Click += Btn_ClientePET_Click;
            // 
            // Btn_Consultas
            // 
            Btn_Consultas.Dock = DockStyle.Top;
            Btn_Consultas.FlatAppearance.BorderSize = 0;
            Btn_Consultas.FlatStyle = FlatStyle.Flat;
            Btn_Consultas.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Consultas.ForeColor = Color.Gainsboro;
            Btn_Consultas.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            Btn_Consultas.IconColor = Color.Gainsboro;
            Btn_Consultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Consultas.IconSize = 36;
            Btn_Consultas.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Consultas.Location = new Point(0, 125);
            Btn_Consultas.Name = "Btn_Consultas";
            Btn_Consultas.Padding = new Padding(10, 0, 20, 0);
            Btn_Consultas.Size = new Size(220, 60);
            Btn_Consultas.TabIndex = 1;
            Btn_Consultas.Text = "Consulta";
            Btn_Consultas.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Consultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Consultas.UseVisualStyleBackColor = true;
            Btn_Consultas.Click += Btn_Consultas_Click;
            // 
            // Pnl_Logo
            // 
            Pnl_Logo.Controls.Add(Btn_Home);
            Pnl_Logo.Dock = DockStyle.Top;
            Pnl_Logo.Location = new Point(0, 0);
            Pnl_Logo.Name = "Pnl_Logo";
            Pnl_Logo.Size = new Size(220, 125);
            Pnl_Logo.TabIndex = 0;
            // 
            // Btn_Home
            // 
            Btn_Home.Cursor = Cursors.Hand;
            Btn_Home.Image = (Image)resources.GetObject("Btn_Home.Image");
            Btn_Home.Location = new Point(0, 0);
            Btn_Home.Name = "Btn_Home";
            Btn_Home.Size = new Size(220, 125);
            Btn_Home.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Home.TabIndex = 0;
            Btn_Home.TabStop = false;
            Btn_Home.Click += Btn_Home_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 25, 72);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(lblTitleChildForm);
            panel1.Controls.Add(iconCurrentChildForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 75);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(26, 25, 72);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 29;
            btnExit.Location = new Point(749, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 33);
            btnExit.TabIndex = 4;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(26, 25, 72);
            btnMaximize.ForeColor = Color.Gainsboro;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            btnMaximize.IconColor = Color.Gainsboro;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 29;
            btnMaximize.Location = new Point(717, 6);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(29, 33);
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btnMaximize_MouseEnter;
            btnMaximize.MouseLeave += btnMaximize_MouseLeave;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(26, 25, 72);
            btnMinimize.ForeColor = Color.Gainsboro;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Gainsboro;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 27;
            btnMinimize.Location = new Point(684, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(27, 36);
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(55, 28);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(59, 21);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 72);
            iconCurrentChildForm.ForeColor = Color.Plum;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.Plum;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 31;
            iconCurrentChildForm.Location = new Point(20, 24);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(33, 31);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // Pnl_Shadow
            // 
            Pnl_Shadow.BackColor = Color.FromArgb(26, 24, 58);
            Pnl_Shadow.Dock = DockStyle.Top;
            Pnl_Shadow.Location = new Point(220, 75);
            Pnl_Shadow.Name = "Pnl_Shadow";
            Pnl_Shadow.Size = new Size(781, 9);
            Pnl_Shadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(781, 401);
            panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Frm_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 485);
            Controls.Add(panelDesktop);
            Controls.Add(Pnl_Shadow);
            Controls.Add(panel1);
            Controls.Add(Pnl_Menu);
            Name = "Frm_Menu";
            Text = "Form1";
            Pnl_Menu.ResumeLayout(false);
            Pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Home).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Menu;
        private FontAwesome.Sharp.IconButton Btn_Consultas;
        private Panel Pnl_Logo;
        private FontAwesome.Sharp.IconButton Btn_Estoque;
        private FontAwesome.Sharp.IconButton Btn_Relatorio;
        private FontAwesome.Sharp.IconButton Btn_Pagamento;
        private FontAwesome.Sharp.IconButton Btn_ClientePET;
        private PictureBox Btn_Home;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel Pnl_Shadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private PictureBox pictureBox1;
    }
}