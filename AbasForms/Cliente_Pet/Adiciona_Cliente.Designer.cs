namespace ClinicaVeterinariaBD.AbasForms.Cliente_Pet
{
    partial class Adiciona_Cliente
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
            box_nome = new TextBox();
            box_cpf = new TextBox();
            box_email = new TextBox();
            box_cel1 = new TextBox();
            box_cel2 = new TextBox();
            box_cep = new TextBox();
            box_cidade = new TextBox();
            box_bairro = new TextBox();
            box_endereco = new TextBox();
            box_num = new TextBox();
            label1 = new Label();
            box_compl = new TextBox();
            label2 = new Label();
            box_animal_nome = new TextBox();
            box_animal_raca = new TextBox();
            box_animal_especie = new TextBox();
            box_animal_idade = new TextBox();
            box_animal_peso = new TextBox();
            box_animal_sexo = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            button1 = new Button();
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
            Lbl_Titulo.Size = new Size(247, 19);
            Lbl_Titulo.TabIndex = 8;
            Lbl_Titulo.Text = "Adicionar Cliente/ Funcionário";
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
            // box_nome
            // 
            box_nome.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_nome.ForeColor = Color.Black;
            box_nome.Location = new Point(145, 111);
            box_nome.Margin = new Padding(3, 2, 3, 2);
            box_nome.Name = "box_nome";
            box_nome.PlaceholderText = "Rodrigues Orkblezhuk";
            box_nome.Size = new Size(208, 23);
            box_nome.TabIndex = 8;
            box_nome.TextChanged += textBox1_TextChanged;
            // 
            // box_cpf
            // 
            box_cpf.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_cpf.ForeColor = Color.Black;
            box_cpf.Location = new Point(145, 138);
            box_cpf.Margin = new Padding(3, 2, 3, 2);
            box_cpf.Name = "box_cpf";
            box_cpf.PlaceholderText = "12345678901";
            box_cpf.Size = new Size(208, 23);
            box_cpf.TabIndex = 9;
            box_cpf.Tag = "";
            box_cpf.TextChanged += textBox2_TextChanged;
            // 
            // box_email
            // 
            box_email.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_email.ForeColor = Color.Black;
            box_email.Location = new Point(145, 165);
            box_email.Margin = new Padding(3, 2, 3, 2);
            box_email.Name = "box_email";
            box_email.PlaceholderText = "@usp.br";
            box_email.Size = new Size(208, 23);
            box_email.TabIndex = 10;
            // 
            // box_cel1
            // 
            box_cel1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_cel1.ForeColor = Color.Black;
            box_cel1.Location = new Point(145, 192);
            box_cel1.Margin = new Padding(3, 2, 3, 2);
            box_cel1.Name = "box_cel1";
            box_cel1.PlaceholderText = "(011) 911327785";
            box_cel1.Size = new Size(208, 23);
            box_cel1.TabIndex = 11;
            // 
            // box_cel2
            // 
            box_cel2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_cel2.ForeColor = Color.Black;
            box_cel2.Location = new Point(145, 219);
            box_cel2.Margin = new Padding(3, 2, 3, 2);
            box_cel2.Name = "box_cel2";
            box_cel2.PlaceholderText = "(41) 954170984";
            box_cel2.Size = new Size(208, 23);
            box_cel2.TabIndex = 12;
            // 
            // box_cep
            // 
            box_cep.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_cep.ForeColor = Color.Black;
            box_cep.Location = new Point(145, 246);
            box_cep.Margin = new Padding(3, 2, 3, 2);
            box_cep.Name = "box_cep";
            box_cep.PlaceholderText = "01823000";
            box_cep.Size = new Size(208, 23);
            box_cep.TabIndex = 13;
            // 
            // box_cidade
            // 
            box_cidade.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_cidade.ForeColor = Color.Black;
            box_cidade.Location = new Point(145, 273);
            box_cidade.Margin = new Padding(3, 2, 3, 2);
            box_cidade.Name = "box_cidade";
            box_cidade.PlaceholderText = "São Paulo";
            box_cidade.Size = new Size(208, 23);
            box_cidade.TabIndex = 14;
            // 
            // box_bairro
            // 
            box_bairro.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_bairro.ForeColor = Color.Black;
            box_bairro.Location = new Point(145, 300);
            box_bairro.Margin = new Padding(3, 2, 3, 2);
            box_bairro.Name = "box_bairro";
            box_bairro.PlaceholderText = "Jardim das Luzes";
            box_bairro.Size = new Size(208, 23);
            box_bairro.TabIndex = 15;
            // 
            // box_endereco
            // 
            box_endereco.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_endereco.ForeColor = Color.Black;
            box_endereco.Location = new Point(145, 327);
            box_endereco.Margin = new Padding(3, 2, 3, 2);
            box_endereco.Name = "box_endereco";
            box_endereco.PlaceholderText = "Rua Regente Feijó";
            box_endereco.Size = new Size(208, 23);
            box_endereco.TabIndex = 16;
            // 
            // box_num
            // 
            box_num.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_num.ForeColor = Color.Black;
            box_num.Location = new Point(145, 354);
            box_num.Margin = new Padding(3, 2, 3, 2);
            box_num.Name = "box_num";
            box_num.PlaceholderText = "1350";
            box_num.Size = new Size(208, 23);
            box_num.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(82, 69);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 18;
            label1.Text = "Insira as informações do Cliente";
            label1.Click += label1_Click;
            // 
            // box_compl
            // 
            box_compl.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_compl.ForeColor = Color.Black;
            box_compl.Location = new Point(145, 381);
            box_compl.Margin = new Padding(3, 2, 3, 2);
            box_compl.Name = "box_compl";
            box_compl.PlaceholderText = "Apto 45 C";
            box_compl.Size = new Size(208, 23);
            box_compl.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(504, 137);
            label2.Name = "label2";
            label2.Size = new Size(242, 20);
            label2.TabIndex = 20;
            label2.Text = "Insira as informações do Animal";
            // 
            // box_animal_nome
            // 
            box_animal_nome.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_nome.ForeColor = Color.Black;
            box_animal_nome.Location = new Point(538, 179);
            box_animal_nome.Margin = new Padding(3, 2, 3, 2);
            box_animal_nome.Name = "box_animal_nome";
            box_animal_nome.PlaceholderText = "Bolão";
            box_animal_nome.Size = new Size(208, 23);
            box_animal_nome.TabIndex = 21;
            // 
            // box_animal_raca
            // 
            box_animal_raca.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_raca.ForeColor = Color.Black;
            box_animal_raca.Location = new Point(538, 233);
            box_animal_raca.Margin = new Padding(3, 2, 3, 2);
            box_animal_raca.Name = "box_animal_raca";
            box_animal_raca.PlaceholderText = "Labrador";
            box_animal_raca.Size = new Size(208, 23);
            box_animal_raca.TabIndex = 22;
            // 
            // box_animal_especie
            // 
            box_animal_especie.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_especie.ForeColor = Color.Black;
            box_animal_especie.Location = new Point(538, 206);
            box_animal_especie.Margin = new Padding(3, 2, 3, 2);
            box_animal_especie.Name = "box_animal_especie";
            box_animal_especie.PlaceholderText = "Agapornis";
            box_animal_especie.Size = new Size(208, 23);
            box_animal_especie.TabIndex = 23;
            // 
            // box_animal_idade
            // 
            box_animal_idade.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_idade.ForeColor = Color.Black;
            box_animal_idade.Location = new Point(538, 260);
            box_animal_idade.Margin = new Padding(3, 2, 3, 2);
            box_animal_idade.Name = "box_animal_idade";
            box_animal_idade.PlaceholderText = "2";
            box_animal_idade.Size = new Size(208, 23);
            box_animal_idade.TabIndex = 24;
            // 
            // box_animal_peso
            // 
            box_animal_peso.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            box_animal_peso.ForeColor = Color.Black;
            box_animal_peso.Location = new Point(538, 287);
            box_animal_peso.Margin = new Padding(3, 2, 3, 2);
            box_animal_peso.Name = "box_animal_peso";
            box_animal_peso.PlaceholderText = "78";
            box_animal_peso.Size = new Size(208, 23);
            box_animal_peso.TabIndex = 25;
            // 
            // box_animal_sexo
            // 
            box_animal_sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            box_animal_sexo.FormattingEnabled = true;
            box_animal_sexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            box_animal_sexo.Location = new Point(538, 315);
            box_animal_sexo.Name = "box_animal_sexo";
            box_animal_sexo.Size = new Size(208, 23);
            box_animal_sexo.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 114);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 27;
            label3.Text = "*Nome :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(31, 141);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 28;
            label4.Text = "*CPF :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(31, 168);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 29;
            label5.Text = "*Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(31, 195);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 30;
            label6.Text = "*Celular 1 :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(31, 222);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 31;
            label7.Text = "Celular 2 :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(31, 249);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 32;
            label8.Text = "*CEP :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(31, 276);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 33;
            label9.Text = "*Cidade :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(31, 303);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 34;
            label10.Text = "*Bairro :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(31, 330);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 35;
            label11.Text = "*Endereço :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(31, 357);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 36;
            label12.Text = "*Número :";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(23, 381);
            label13.Name = "label13";
            label13.Size = new Size(116, 20);
            label13.TabIndex = 37;
            label13.Text = "Complemento :";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(465, 182);
            label14.Name = "label14";
            label14.Size = new Size(67, 20);
            label14.TabIndex = 38;
            label14.Text = "*Nome :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(457, 209);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 39;
            label15.Text = "*Espécie :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(465, 236);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 40;
            label16.Text = "*Raça :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(465, 263);
            label17.Name = "label17";
            label17.Size = new Size(63, 20);
            label17.TabIndex = 41;
            label17.Text = "*Idade :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(465, 290);
            label18.Name = "label18";
            label18.Size = new Size(57, 20);
            label18.TabIndex = 42;
            label18.Text = "*Peso :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ButtonFace;
            label19.Location = new Point(465, 318);
            label19.Name = "label19";
            label19.Size = new Size(57, 20);
            label19.TabIndex = 43;
            label19.Text = "*Sexo :";
            // 
            // button1
            // 
            button1.Location = new Point(601, 381);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 44;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Adiciona_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(box_animal_sexo);
            Controls.Add(box_animal_peso);
            Controls.Add(box_animal_idade);
            Controls.Add(box_animal_especie);
            Controls.Add(box_animal_raca);
            Controls.Add(box_animal_nome);
            Controls.Add(label2);
            Controls.Add(box_compl);
            Controls.Add(label1);
            Controls.Add(box_num);
            Controls.Add(box_endereco);
            Controls.Add(box_bairro);
            Controls.Add(box_cidade);
            Controls.Add(box_cep);
            Controls.Add(box_cel2);
            Controls.Add(box_cel1);
            Controls.Add(box_email);
            Controls.Add(box_cpf);
            Controls.Add(box_nome);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "Adiciona_Cliente";
            Text = "Adicionar Cliente";
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
        private TextBox box_nome;
        private TextBox box_cpf;
        private TextBox box_email;
        private TextBox box_cel1;
        private TextBox box_cel2;
        private TextBox box_cep;
        private TextBox box_cidade;
        private TextBox box_bairro;
        private TextBox box_endereco;
        private TextBox box_num;
        private Label label1;
        private TextBox box_compl;
        private Label label2;
        private TextBox box_animal_nome;
        private TextBox box_animal_raca;
        private TextBox box_animal_especie;
        private TextBox box_animal_idade;
        private TextBox box_animal_peso;
        private ComboBox box_animal_sexo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button1;
    }
}