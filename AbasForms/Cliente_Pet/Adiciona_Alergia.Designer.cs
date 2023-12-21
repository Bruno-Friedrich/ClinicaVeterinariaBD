namespace ClinicaVeterinariaBD.AbasForms.Cliente_Pet
{
    partial class Adiciona_Alergia
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
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            box_Alergia = new TextBox();
            box_NomeAnimal = new TextBox();
            label2 = new Label();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            box_IdDono = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(800, 49);
            panel1.TabIndex = 3;
            // 
            // Icn_Titulo
            // 
            Icn_Titulo.BackColor = Color.FromArgb(34, 33, 74);
            Icn_Titulo.ForeColor = Color.Thistle;
            Icn_Titulo.IconChar = FontAwesome.Sharp.IconChar.VialVirus;
            Icn_Titulo.IconColor = Color.Thistle;
            Icn_Titulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Icn_Titulo.IconSize = 26;
            Icn_Titulo.Location = new Point(19, 16);
            Icn_Titulo.Margin = new Padding(3, 2, 3, 2);
            Icn_Titulo.Name = "Icn_Titulo";
            Icn_Titulo.Size = new Size(34, 26);
            Icn_Titulo.TabIndex = 9;
            Icn_Titulo.TabStop = false;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Titulo.ForeColor = Color.Gainsboro;
            Lbl_Titulo.Location = new Point(48, 16);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(147, 19);
            Lbl_Titulo.TabIndex = 8;
            Lbl_Titulo.Text = "Adicionar Alergia";
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
            btnExit.Location = new Point(2236, 9);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 25);
            btnExit.TabIndex = 7;
            btnExit.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(245, 300);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 36;
            label5.Text = "Alergia* :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(203, 276);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 35;
            label4.Text = "Nome do Pet* :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(275, 208);
            label1.Name = "label1";
            label1.Size = new Size(242, 20);
            label1.TabIndex = 33;
            label1.Text = "Insira as informações da Alergia";
            // 
            // box_Alergia
            // 
            box_Alergia.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_Alergia.ForeColor = Color.Black;
            box_Alergia.Location = new Point(325, 300);
            box_Alergia.Margin = new Padding(3, 2, 3, 2);
            box_Alergia.Name = "box_Alergia";
            box_Alergia.PlaceholderText = "Alergico a Anestesia";
            box_Alergia.Size = new Size(208, 23);
            box_Alergia.TabIndex = 32;
            // 
            // box_NomeAnimal
            // 
            box_NomeAnimal.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_NomeAnimal.ForeColor = Color.Black;
            box_NomeAnimal.Location = new Point(325, 273);
            box_NomeAnimal.Margin = new Padding(3, 2, 3, 2);
            box_NomeAnimal.Name = "box_NomeAnimal";
            box_NomeAnimal.PlaceholderText = "Luki";
            box_NomeAnimal.Size = new Size(208, 23);
            box_NomeAnimal.TabIndex = 31;
            box_NomeAnimal.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(217, 249);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 38;
            label2.Text = "Id do Dono* :";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(260, 352);
            button1.Name = "button1";
            button1.Size = new Size(108, 25);
            button1.TabIndex = 39;
            button1.Text = "Adicionar Alergia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView2.BackgroundColor = Color.FromArgb(34, 33, 74);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(30, 67);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(737, 79);
            dataGridView2.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(30, 25, 55);
            panel2.Enabled = false;
            panel2.Location = new Point(30, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 24);
            panel2.TabIndex = 41;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(425, 352);
            button2.Name = "button2";
            button2.Size = new Size(108, 25);
            button2.TabIndex = 42;
            button2.Text = "Ver Alergias";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.FromArgb(34, 33, 74);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 412);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(737, 82);
            dataGridView1.TabIndex = 43;
            // 
            // box_IdDono
            // 
            box_IdDono.Location = new Point(325, 245);
            box_IdDono.Mask = "0000";
            box_IdDono.Name = "box_IdDono";
            box_IdDono.Size = new Size(208, 23);
            box_IdDono.TabIndex = 44;
            // 
            // Adiciona_Alergia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 517);
            Controls.Add(box_IdDono);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(box_NomeAnimal);
            Controls.Add(label1);
            Controls.Add(box_Alergia);
            Name = "Adiciona_Alergia";
            Text = "Adicionar Alergia";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox Icn_Titulo;
        private Label Lbl_Titulo;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox box_Alergia;
        private TextBox box_NomeAnimal;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView2;
        private Panel panel2;
        private Button button2;
        private DataGridView dataGridView1;
        private MaskedTextBox box_IdDono;
    }
}