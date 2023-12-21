namespace ClinicaVeterinariaBD.AbasForms.Cliente_Pet
{
    partial class Adiciona_Funcionario
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
            button2 = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            box_animal_sexo = new ComboBox();
            box_animal_peso = new TextBox();
            box_animal_idade = new TextBox();
            box_animal_especie = new TextBox();
            box_animal_raca = new TextBox();
            box_animal_nome = new TextBox();
            label2 = new Label();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 49);
            panel1.TabIndex = 2;
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
            btnExit.Location = new Point(1642, 9);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 25);
            btnExit.TabIndex = 7;
            btnExit.TabStop = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(366, 364);
            button2.Name = "button2";
            button2.Size = new Size(90, 25);
            button2.TabIndex = 77;
            button2.Text = "Inserir Animal";
            button2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ButtonFace;
            label19.Location = new Point(236, 314);
            label19.Name = "label19";
            label19.Size = new Size(57, 20);
            label19.TabIndex = 76;
            label19.Text = "Sexo* :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(236, 286);
            label18.Name = "label18";
            label18.Size = new Size(57, 20);
            label18.TabIndex = 75;
            label18.Text = "Peso* :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(236, 259);
            label17.Name = "label17";
            label17.Size = new Size(63, 20);
            label17.TabIndex = 74;
            label17.Text = "Idade* :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(236, 205);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 73;
            label16.Text = "Raça* :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(228, 233);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 72;
            label15.Text = "Espécie* :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(236, 178);
            label14.Name = "label14";
            label14.Size = new Size(67, 20);
            label14.TabIndex = 71;
            label14.Text = "Nome* :";
            // 
            // box_animal_sexo
            // 
            box_animal_sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            box_animal_sexo.FormattingEnabled = true;
            box_animal_sexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            box_animal_sexo.Location = new Point(309, 311);
            box_animal_sexo.Name = "box_animal_sexo";
            box_animal_sexo.Size = new Size(208, 23);
            box_animal_sexo.TabIndex = 70;
            // 
            // box_animal_peso
            // 
            box_animal_peso.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_peso.ForeColor = Color.Black;
            box_animal_peso.Location = new Point(309, 283);
            box_animal_peso.Margin = new Padding(3, 2, 3, 2);
            box_animal_peso.Name = "box_animal_peso";
            box_animal_peso.PlaceholderText = "78";
            box_animal_peso.Size = new Size(208, 23);
            box_animal_peso.TabIndex = 69;
            // 
            // box_animal_idade
            // 
            box_animal_idade.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_idade.ForeColor = Color.Black;
            box_animal_idade.Location = new Point(309, 256);
            box_animal_idade.Margin = new Padding(3, 2, 3, 2);
            box_animal_idade.Name = "box_animal_idade";
            box_animal_idade.PlaceholderText = "2";
            box_animal_idade.Size = new Size(208, 23);
            box_animal_idade.TabIndex = 68;
            // 
            // box_animal_especie
            // 
            box_animal_especie.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_especie.ForeColor = Color.Black;
            box_animal_especie.Location = new Point(309, 230);
            box_animal_especie.Margin = new Padding(3, 2, 3, 2);
            box_animal_especie.Name = "box_animal_especie";
            box_animal_especie.PlaceholderText = "Agapornis";
            box_animal_especie.Size = new Size(208, 23);
            box_animal_especie.TabIndex = 67;
            // 
            // box_animal_raca
            // 
            box_animal_raca.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_raca.ForeColor = Color.Black;
            box_animal_raca.Location = new Point(309, 203);
            box_animal_raca.Margin = new Padding(3, 2, 3, 2);
            box_animal_raca.Name = "box_animal_raca";
            box_animal_raca.PlaceholderText = "Labrador";
            box_animal_raca.Size = new Size(208, 23);
            box_animal_raca.TabIndex = 66;
            // 
            // box_animal_nome
            // 
            box_animal_nome.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_nome.ForeColor = Color.Black;
            box_animal_nome.Location = new Point(309, 175);
            box_animal_nome.Margin = new Padding(3, 2, 3, 2);
            box_animal_nome.Name = "box_animal_nome";
            box_animal_nome.PlaceholderText = "Bolão";
            box_animal_nome.Size = new Size(208, 23);
            box_animal_nome.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(290, 123);
            label2.Name = "label2";
            label2.Size = new Size(240, 20);
            label2.TabIndex = 64;
            label2.Text = "Insira as informações do Cliente";
            // 
            // Adiciona_Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(box_animal_sexo);
            Controls.Add(box_animal_peso);
            Controls.Add(box_animal_idade);
            Controls.Add(box_animal_especie);
            Controls.Add(box_animal_raca);
            Controls.Add(box_animal_nome);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Adiciona_Funcionario";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox Icn_Titulo;
        private Label Lbl_Titulo;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Button button2;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private ComboBox box_animal_sexo;
        private TextBox box_animal_peso;
        private TextBox box_animal_idade;
        private TextBox box_animal_especie;
        private TextBox box_animal_raca;
        private TextBox box_animal_nome;
        private Label label2;
    }
}