namespace ClinicaVeterinariaBD.AbasForms.Pagamento
{
    partial class Frm_SelecionaServico
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
            Lbl_NomeProd = new Label();
            Dt_Horario = new DataGridView();
            Btn_Enviar = new FontAwesome.Sharp.IconButton();
            Lbl_NomeAnimal = new Label();
            Txt_NomeAnimal = new TextBox();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)Dt_Horario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Lbl_NomeProd
            // 
            Lbl_NomeProd.AutoSize = true;
            Lbl_NomeProd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_NomeProd.ForeColor = Color.Gainsboro;
            Lbl_NomeProd.Location = new Point(12, 18);
            Lbl_NomeProd.Name = "Lbl_NomeProd";
            Lbl_NomeProd.Size = new Size(309, 23);
            Lbl_NomeProd.TabIndex = 13;
            Lbl_NomeProd.Text = "Selecione o horário do Serviço";
            // 
            // Dt_Horario
            // 
            Dt_Horario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Horario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Horario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_Horario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Horario.Location = new Point(12, 71);
            Dt_Horario.Name = "Dt_Horario";
            Dt_Horario.RowHeadersWidth = 51;
            Dt_Horario.RowTemplate.Height = 29;
            Dt_Horario.Size = new Size(926, 181);
            Dt_Horario.TabIndex = 14;
            // 
            // Btn_Enviar
            // 
            Btn_Enviar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Enviar.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_Enviar.IconColor = Color.Black;
            Btn_Enviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Enviar.Location = new Point(808, 261);
            Btn_Enviar.Name = "Btn_Enviar";
            Btn_Enviar.Size = new Size(130, 33);
            Btn_Enviar.TabIndex = 34;
            Btn_Enviar.Text = "Enviar";
            Btn_Enviar.UseVisualStyleBackColor = true;
            Btn_Enviar.Click += Btn_Enviar_Click;
            // 
            // Lbl_NomeAnimal
            // 
            Lbl_NomeAnimal.AutoSize = true;
            Lbl_NomeAnimal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_NomeAnimal.ForeColor = Color.Gainsboro;
            Lbl_NomeAnimal.Location = new Point(12, 255);
            Lbl_NomeAnimal.Name = "Lbl_NomeAnimal";
            Lbl_NomeAnimal.Size = new Size(177, 23);
            Lbl_NomeAnimal.TabIndex = 37;
            Lbl_NomeAnimal.Text = "Nome do Animal";
            // 
            // Txt_NomeAnimal
            // 
            Txt_NomeAnimal.Location = new Point(195, 255);
            Txt_NomeAnimal.Name = "Txt_NomeAnimal";
            Txt_NomeAnimal.Size = new Size(149, 27);
            Txt_NomeAnimal.TabIndex = 36;
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
            btnExit.Location = new Point(909, 18);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 33);
            btnExit.TabIndex = 38;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 33, 74);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(Lbl_NomeProd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 65);
            panel1.TabIndex = 39;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.FromArgb(26, 25, 72);
            iconPictureBox1.ForeColor = Color.Gainsboro;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconPictureBox1.IconColor = Color.Gainsboro;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 29;
            iconPictureBox1.Location = new Point(1370, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(29, 33);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // Frm_SelecionaServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(951, 306);
            Controls.Add(panel1);
            Controls.Add(Lbl_NomeAnimal);
            Controls.Add(Txt_NomeAnimal);
            Controls.Add(Btn_Enviar);
            Controls.Add(Dt_Horario);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Frm_SelecionaServico";
            Text = "Frm_SelecionaServico";
            ((System.ComponentModel.ISupportInitialize)Dt_Horario).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_NomeProd;
        private DataGridView Dt_Horario;
        private FontAwesome.Sharp.IconButton Btn_Enviar;
        private Label Lbl_NomeAnimal;
        private TextBox Txt_NomeAnimal;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}