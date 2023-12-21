namespace ClinicaVeterinariaBD
{
    partial class Frm_Consulta
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
            SchedulingViewer = new DataGridView();
            btn_BuscaServico = new Button();
            label1 = new Label();
            button1 = new Button();
            Icn_Titulo = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)SchedulingViewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).BeginInit();
            SuspendLayout();
            // 
            // SchedulingViewer
            // 
            SchedulingViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SchedulingViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SchedulingViewer.Location = new Point(30, 54);
            SchedulingViewer.Name = "SchedulingViewer";
            SchedulingViewer.RowHeadersVisible = false;
            SchedulingViewer.RowTemplate.Height = 25;
            SchedulingViewer.Size = new Size(636, 178);
            SchedulingViewer.TabIndex = 0;
            // 
            // btn_BuscaServico
            // 
            btn_BuscaServico.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_BuscaServico.Location = new Point(75, 262);
            btn_BuscaServico.Name = "btn_BuscaServico";
            btn_BuscaServico.Size = new Size(196, 45);
            btn_BuscaServico.TabIndex = 1;
            btn_BuscaServico.Text = "Buscar por serviço";
            btn_BuscaServico.UseVisualStyleBackColor = true;
            btn_BuscaServico.Click += btn_BuscaServico_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 2;
            label1.Text = "Consultas do dia";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(415, 262);
            button1.Name = "button1";
            button1.Size = new Size(201, 45);
            button1.TabIndex = 3;
            button1.Text = "Agendar serviço";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Icn_Titulo
            // 
            Icn_Titulo.BackColor = Color.FromArgb(34, 33, 74);
            Icn_Titulo.ForeColor = Color.Thistle;
            Icn_Titulo.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            Icn_Titulo.IconColor = Color.Thistle;
            Icn_Titulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Icn_Titulo.IconSize = 26;
            Icn_Titulo.Location = new Point(12, 9);
            Icn_Titulo.Margin = new Padding(3, 2, 3, 2);
            Icn_Titulo.Name = "Icn_Titulo";
            Icn_Titulo.Size = new Size(34, 26);
            Icn_Titulo.TabIndex = 10;
            Icn_Titulo.TabStop = false;
            // 
            // Frm_Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(700, 355);
            Controls.Add(Icn_Titulo);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btn_BuscaServico);
            Controls.Add(SchedulingViewer);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            HelpButton = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Consulta";
            Text = "Consultas do dia";
            Load += Frm_Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)SchedulingViewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SchedulingViewer;
        private Button btn_BuscaServico;
        private Label label1;
        private Button button1;
        private FontAwesome.Sharp.IconPictureBox Icn_Titulo;
    }
}