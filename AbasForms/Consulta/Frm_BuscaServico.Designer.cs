namespace ClinicaVeterinariaBD.AbasForms.Consulta
{
    partial class Frm_BuscaServico
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
            Maneiradebusca = new GroupBox();
            Buscaporfuncionario = new RadioButton();
            Buscaporcliente = new RadioButton();
            Buscapormes = new RadioButton();
            Buscaporsemana = new RadioButton();
            Btn_confirmarbusca = new Button();
            INPUT_CPF_cliente = new TextBox();
            SchedulingViewer = new DataGridView();
            label_id_cliente = new Label();
            label_id_funcionario = new Label();
            INPUT_CPF_funcionario = new TextBox();
            Icn_Titulo = new FontAwesome.Sharp.IconPictureBox();
            Maneiradebusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SchedulingViewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).BeginInit();
            SuspendLayout();
            // 
            // Maneiradebusca
            // 
            Maneiradebusca.Controls.Add(Buscaporfuncionario);
            Maneiradebusca.Controls.Add(Buscaporcliente);
            Maneiradebusca.Controls.Add(Buscapormes);
            Maneiradebusca.Controls.Add(Buscaporsemana);
            Maneiradebusca.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Maneiradebusca.ForeColor = Color.White;
            Maneiradebusca.Location = new Point(92, 25);
            Maneiradebusca.Name = "Maneiradebusca";
            Maneiradebusca.Size = new Size(976, 93);
            Maneiradebusca.TabIndex = 0;
            Maneiradebusca.TabStop = false;
            Maneiradebusca.Text = "Escolha a maneira de busca";
            Maneiradebusca.Enter += Maneiradebusca_Enter;
            // 
            // Buscaporfuncionario
            // 
            Buscaporfuncionario.AutoSize = true;
            Buscaporfuncionario.ForeColor = Color.White;
            Buscaporfuncionario.Location = new Point(717, 49);
            Buscaporfuncionario.Name = "Buscaporfuncionario";
            Buscaporfuncionario.Size = new Size(195, 23);
            Buscaporfuncionario.TabIndex = 3;
            Buscaporfuncionario.TabStop = true;
            Buscaporfuncionario.Text = "Busca por funcionário";
            Buscaporfuncionario.UseVisualStyleBackColor = true;
            Buscaporfuncionario.CheckedChanged += Buscaporfuncionario_CheckedChanged;
            // 
            // Buscaporcliente
            // 
            Buscaporcliente.AutoSize = true;
            Buscaporcliente.ForeColor = Color.White;
            Buscaporcliente.Location = new Point(523, 49);
            Buscaporcliente.Name = "Buscaporcliente";
            Buscaporcliente.Size = new Size(159, 23);
            Buscaporcliente.TabIndex = 2;
            Buscaporcliente.TabStop = true;
            Buscaporcliente.Text = "Busca por cliente";
            Buscaporcliente.UseVisualStyleBackColor = true;
            Buscaporcliente.CheckedChanged += Buscaporcliente_CheckedChanged;
            // 
            // Buscapormes
            // 
            Buscapormes.AutoSize = true;
            Buscapormes.ForeColor = Color.White;
            Buscapormes.Location = new Point(306, 49);
            Buscapormes.Name = "Buscapormes";
            Buscapormes.Size = new Size(161, 23);
            Buscapormes.TabIndex = 1;
            Buscapormes.TabStop = true;
            Buscapormes.Text = "Consultas do mês";
            Buscapormes.UseVisualStyleBackColor = true;
            Buscapormes.CheckedChanged += Buscapormes_CheckedChanged;
            // 
            // Buscaporsemana
            // 
            Buscaporsemana.AutoSize = true;
            Buscaporsemana.ForeColor = Color.White;
            Buscaporsemana.Location = new Point(61, 49);
            Buscaporsemana.Name = "Buscaporsemana";
            Buscaporsemana.Size = new Size(194, 23);
            Buscaporsemana.TabIndex = 0;
            Buscaporsemana.Text = "Consultas da semana";
            Buscaporsemana.UseVisualStyleBackColor = true;
            Buscaporsemana.CheckedChanged += Buscaporsemana_CheckedChanged;
            // 
            // Btn_confirmarbusca
            // 
            Btn_confirmarbusca.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_confirmarbusca.Location = new Point(789, 180);
            Btn_confirmarbusca.Name = "Btn_confirmarbusca";
            Btn_confirmarbusca.Size = new Size(245, 59);
            Btn_confirmarbusca.TabIndex = 1;
            Btn_confirmarbusca.Text = "Confirmar";
            Btn_confirmarbusca.UseVisualStyleBackColor = true;
            Btn_confirmarbusca.Click += Btn_confirmarbusca_Click;
            // 
            // INPUT_CPF_cliente
            // 
            INPUT_CPF_cliente.Location = new Point(129, 211);
            INPUT_CPF_cliente.Name = "INPUT_CPF_cliente";
            INPUT_CPF_cliente.Size = new Size(159, 23);
            INPUT_CPF_cliente.TabIndex = 2;
            INPUT_CPF_cliente.TextChanged += Informacao_ID_TextChanged;
            // 
            // SchedulingViewer
            // 
            SchedulingViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SchedulingViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SchedulingViewer.Location = new Point(26, 271);
            SchedulingViewer.Name = "SchedulingViewer";
            SchedulingViewer.RowHeadersVisible = false;
            SchedulingViewer.RowTemplate.Height = 25;
            SchedulingViewer.Size = new Size(1066, 354);
            SchedulingViewer.TabIndex = 3;
            // 
            // label_id_cliente
            // 
            label_id_cliente.AutoSize = true;
            label_id_cliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_id_cliente.ForeColor = Color.White;
            label_id_cliente.Location = new Point(150, 180);
            label_id_cliente.Name = "label_id_cliente";
            label_id_cliente.Size = new Size(119, 19);
            label_id_cliente.TabIndex = 4;
            label_id_cliente.Text = "CPF do cliente";
            // 
            // label_id_funcionario
            // 
            label_id_funcionario.AutoSize = true;
            label_id_funcionario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_id_funcionario.ForeColor = Color.White;
            label_id_funcionario.Location = new Point(323, 180);
            label_id_funcionario.Name = "label_id_funcionario";
            label_id_funcionario.Size = new Size(155, 19);
            label_id_funcionario.TabIndex = 5;
            label_id_funcionario.Text = "CPF do funcionário";
            // 
            // INPUT_CPF_funcionario
            // 
            INPUT_CPF_funcionario.Location = new Point(323, 211);
            INPUT_CPF_funcionario.Name = "INPUT_CPF_funcionario";
            INPUT_CPF_funcionario.Size = new Size(159, 23);
            INPUT_CPF_funcionario.TabIndex = 6;
            INPUT_CPF_funcionario.TextChanged += Info_ID_func_TextChanged;
            // 
            // Icn_Titulo
            // 
            Icn_Titulo.BackColor = Color.FromArgb(34, 33, 74);
            Icn_Titulo.ForeColor = Color.Thistle;
            Icn_Titulo.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            Icn_Titulo.IconColor = Color.Thistle;
            Icn_Titulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Icn_Titulo.IconSize = 84;
            Icn_Titulo.Location = new Point(-1, 34);
            Icn_Titulo.Margin = new Padding(3, 2, 3, 2);
            Icn_Titulo.Name = "Icn_Titulo";
            Icn_Titulo.Size = new Size(87, 84);
            Icn_Titulo.TabIndex = 11;
            Icn_Titulo.TabStop = false;
            Icn_Titulo.Click += Icn_Titulo_Click;
            // 
            // Frm_BuscaServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1120, 678);
            Controls.Add(Icn_Titulo);
            Controls.Add(INPUT_CPF_funcionario);
            Controls.Add(label_id_funcionario);
            Controls.Add(label_id_cliente);
            Controls.Add(SchedulingViewer);
            Controls.Add(INPUT_CPF_cliente);
            Controls.Add(Btn_confirmarbusca);
            Controls.Add(Maneiradebusca);
            Name = "Frm_BuscaServico";
            Text = "Buscas e Consultas";
            Maneiradebusca.ResumeLayout(false);
            Maneiradebusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SchedulingViewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Maneiradebusca;
        private RadioButton Buscaporfuncionario;
        private RadioButton Buscaporcliente;
        private RadioButton Buscapormes;
        private RadioButton Buscaporsemana;
        private Button Btn_confirmarbusca;
        private TextBox INPUT_CPF_cliente;
        private DataGridView SchedulingViewer;
        private Label label_id_cliente;
        private Label label_id_funcionario;
        private TextBox INPUT_CPF_funcionario;
        private FontAwesome.Sharp.IconPictureBox Icn_Titulo;
    }
}