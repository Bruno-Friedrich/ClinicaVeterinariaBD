namespace ClinicaVeterinariaBD.AbasForms
{
    partial class Frm_RelatorioPeriodo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataInicio = new MaskedTextBox();
            btn_GerarRelatorio = new Button();
            dataFinal = new MaskedTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 65);
            label1.Name = "label1";
            label1.Size = new Size(655, 54);
            label1.TabIndex = 0;
            label1.Text = "Escolha um período para o relatório";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(109, 204);
            label2.Name = "label2";
            label2.Size = new Size(216, 45);
            label2.TabIndex = 1;
            label2.Text = "Data de Início";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(512, 204);
            label3.Name = "label3";
            label3.Size = new Size(160, 45);
            label3.TabIndex = 2;
            label3.Text = "Data Final";
            // 
            // dataInicio
            // 
            dataInicio.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataInicio.Location = new Point(109, 252);
            dataInicio.Mask = "0000/00/00";
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(225, 43);
            dataInicio.TabIndex = 3;
            dataInicio.TextAlign = HorizontalAlignment.Center;
            dataInicio.ValidatingType = typeof(DateTime);
            dataInicio.KeyUp += dataInicio_KeyUp;
            // 
            // btn_GerarRelatorio
            // 
            btn_GerarRelatorio.Enabled = false;
            btn_GerarRelatorio.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_GerarRelatorio.Location = new Point(269, 337);
            btn_GerarRelatorio.Name = "btn_GerarRelatorio";
            btn_GerarRelatorio.Size = new Size(269, 100);
            btn_GerarRelatorio.TabIndex = 4;
            btn_GerarRelatorio.Text = "Gerar Relatório";
            btn_GerarRelatorio.UseVisualStyleBackColor = true;
            btn_GerarRelatorio.Click += button1_Click;
            // 
            // dataFinal
            // 
            dataFinal.Enabled = false;
            dataFinal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataFinal.Location = new Point(478, 252);
            dataFinal.Mask = "0000/00/00";
            dataFinal.Name = "dataFinal";
            dataFinal.Size = new Size(219, 43);
            dataFinal.TabIndex = 5;
            dataFinal.TextAlign = HorizontalAlignment.Center;
            dataFinal.ValidatingType = typeof(DateTime);
            dataFinal.KeyUp += dataFinal_KeyUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(314, 136);
            label4.Name = "label4";
            label4.Size = new Size(183, 37);
            label4.TabIndex = 6;
            label4.Text = "(ano/mês/dia)";
            // 
            // Frm_RelatorioPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 450);
            Controls.Add(label4);
            Controls.Add(dataFinal);
            Controls.Add(btn_GerarRelatorio);
            Controls.Add(dataInicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_RelatorioPeriodo";
            Text = "Form_EscolhaPeriodo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox dataInicio;
        private Button btn_GerarRelatorio;
        private MaskedTextBox dataFinal;
        private Label label4;
    }
}