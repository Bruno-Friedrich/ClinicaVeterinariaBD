namespace ClinicaVeterinariaBD.AbasForms
{
    partial class Frm_Relatorio
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
            dataInicio = new Label();
            dataFim = new Label();
            Maneiradebusca = new GroupBox();
            consultas = new RadioButton();
            procCirur = new RadioButton();
            procEstetico = new RadioButton();
            vacinacao = new RadioButton();
            totalservicosLabel = new Label();
            totalFaturamento = new Label();
            totalCusto = new Label();
            totalLucro = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            numMeses = new Label();
            Maneiradebusca.SuspendLayout();
            SuspendLayout();
            // 
            // dataInicio
            // 
            dataInicio.AutoSize = true;
            dataInicio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dataInicio.Location = new Point(12, 21);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(109, 28);
            dataInicio.TabIndex = 0;
            dataInicio.Text = "Data Início:";
            // 
            // dataFim
            // 
            dataFim.AutoSize = true;
            dataFim.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dataFim.Location = new Point(271, 21);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(103, 28);
            dataFim.TabIndex = 1;
            dataFim.Text = "Data Final:";
            // 
            // Maneiradebusca
            // 
            Maneiradebusca.Controls.Add(consultas);
            Maneiradebusca.Controls.Add(procCirur);
            Maneiradebusca.Controls.Add(procEstetico);
            Maneiradebusca.Controls.Add(vacinacao);
            Maneiradebusca.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Maneiradebusca.Location = new Point(12, 69);
            Maneiradebusca.Name = "Maneiradebusca";
            Maneiradebusca.Size = new Size(976, 93);
            Maneiradebusca.TabIndex = 3;
            Maneiradebusca.TabStop = false;
            // 
            // consultas
            // 
            consultas.AutoSize = true;
            consultas.Location = new Point(687, 33);
            consultas.Name = "consultas";
            consultas.Size = new Size(114, 32);
            consultas.TabIndex = 3;
            consultas.TabStop = true;
            consultas.Text = "Consultas";
            consultas.UseVisualStyleBackColor = true;
            consultas.MouseClick += consultas_MouseClick;
            // 
            // procCirur
            // 
            procCirur.AutoSize = true;
            procCirur.Location = new Point(405, 33);
            procCirur.Name = "procCirur";
            procCirur.Size = new Size(254, 32);
            procCirur.TabIndex = 2;
            procCirur.TabStop = true;
            procCirur.Text = "Procedimentos Cirúrgicos";
            procCirur.UseVisualStyleBackColor = true;
            procCirur.MouseClick += procCirur_MouseClick;
            // 
            // procEstetico
            // 
            procEstetico.AutoSize = true;
            procEstetico.Location = new Point(157, 33);
            procEstetico.Name = "procEstetico";
            procEstetico.Size = new Size(242, 32);
            procEstetico.TabIndex = 1;
            procEstetico.TabStop = true;
            procEstetico.Text = "Procedimentos Estéticos";
            procEstetico.UseVisualStyleBackColor = true;
            procEstetico.MouseClick += procEstetico_MouseClick;
            // 
            // vacinacao
            // 
            vacinacao.AutoSize = true;
            vacinacao.Location = new Point(22, 33);
            vacinacao.Name = "vacinacao";
            vacinacao.Size = new Size(117, 32);
            vacinacao.TabIndex = 0;
            vacinacao.Text = "Vacinação";
            vacinacao.UseVisualStyleBackColor = true;
            vacinacao.MouseClick += vacinacao_MouseClick;
            // 
            // totalservicosLabel
            // 
            totalservicosLabel.AutoSize = true;
            totalservicosLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalservicosLabel.Location = new Point(34, 211);
            totalservicosLabel.Name = "totalservicosLabel";
            totalservicosLabel.Size = new Size(700, 50);
            totalservicosLabel.TabIndex = 4;
            totalservicosLabel.Text = "Quantidade total de serviços prestados";
            // 
            // totalFaturamento
            // 
            totalFaturamento.AutoSize = true;
            totalFaturamento.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalFaturamento.Location = new Point(34, 297);
            totalFaturamento.Name = "totalFaturamento";
            totalFaturamento.Size = new Size(244, 50);
            totalFaturamento.TabIndex = 5;
            totalFaturamento.Text = "Faturamento";
            // 
            // totalCusto
            // 
            totalCusto.AutoSize = true;
            totalCusto.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalCusto.Location = new Point(34, 379);
            totalCusto.Name = "totalCusto";
            totalCusto.Size = new Size(120, 50);
            totalCusto.TabIndex = 6;
            totalCusto.Text = "Custo";
            // 
            // totalLucro
            // 
            totalLucro.AutoSize = true;
            totalLucro.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalLucro.Location = new Point(34, 456);
            totalLucro.Name = "totalLucro";
            totalLucro.Size = new Size(119, 50);
            totalLucro.TabIndex = 7;
            totalLucro.Text = "Lucro";
            // 
            // numMeses
            // 
            numMeses.AutoSize = true;
            numMeses.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            numMeses.Location = new Point(530, 456);
            numMeses.Name = "numMeses";
            numMeses.Size = new Size(392, 50);
            numMeses.TabIndex = 9;
            numMeses.Text = "Meses contabilizados";
            // 
            // Frm_Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 672);
            Controls.Add(numMeses);
            Controls.Add(totalLucro);
            Controls.Add(totalCusto);
            Controls.Add(totalFaturamento);
            Controls.Add(totalservicosLabel);
            Controls.Add(Maneiradebusca);
            Controls.Add(dataFim);
            Controls.Add(dataInicio);
            Name = "Frm_Relatorio";
            Text = "Frm_Relatorio";
            Maneiradebusca.ResumeLayout(false);
            Maneiradebusca.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dataInicio;
        private Label dataFim;
        private GroupBox Maneiradebusca;
        private RadioButton consultas;
        private RadioButton procCirur;
        private RadioButton procEstetico;
        private RadioButton vacinacao;
        private Label totalservicosLabel;
        private Label totalFaturamento;
        private Label totalCusto;
        private Label totalLucro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label numMeses;
    }
}