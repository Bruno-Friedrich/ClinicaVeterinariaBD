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
            ((System.ComponentModel.ISupportInitialize)SchedulingViewer).BeginInit();
            SuspendLayout();
            // 
            // SchedulingViewer
            // 
            SchedulingViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SchedulingViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SchedulingViewer.Location = new Point(3, 34);
            SchedulingViewer.Name = "SchedulingViewer";
            SchedulingViewer.RowHeadersVisible = false;
            SchedulingViewer.RowTemplate.Height = 25;
            SchedulingViewer.Size = new Size(685, 178);
            SchedulingViewer.TabIndex = 0;
            // 
            // btn_BuscaServico
            // 
            btn_BuscaServico.Location = new Point(157, 252);
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
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Consultas do dia";
            // 
            // button1
            // 
            button1.Location = new Point(393, 252);
            button1.Name = "button1";
            button1.Size = new Size(201, 45);
            button1.TabIndex = 3;
            button1.Text = "Agendar serviço";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm_Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btn_BuscaServico);
            Controls.Add(SchedulingViewer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Consulta";
            Text = "Frm_Consulta";
            Load += Frm_Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)SchedulingViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SchedulingViewer;
        private Button btn_BuscaServico;
        private Label label1;
        private Button button1;
    }
}