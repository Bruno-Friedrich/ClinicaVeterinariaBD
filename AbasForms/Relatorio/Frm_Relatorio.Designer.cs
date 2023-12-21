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
            ReportDataGrid = new DataGridView();
            Maneiradebusca = new GroupBox();
            consultas = new RadioButton();
            procCirur = new RadioButton();
            procEstetico = new RadioButton();
            vacinacao = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)ReportDataGrid).BeginInit();
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
            // ReportDataGrid
            // 
            ReportDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportDataGrid.Location = new Point(12, 219);
            ReportDataGrid.Name = "ReportDataGrid";
            ReportDataGrid.RowTemplate.Height = 25;
            ReportDataGrid.Size = new Size(976, 350);
            ReportDataGrid.TabIndex = 2;
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
            // Frm_Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 672);
            Controls.Add(Maneiradebusca);
            Controls.Add(ReportDataGrid);
            Controls.Add(dataFim);
            Controls.Add(dataInicio);
            Name = "Frm_Relatorio";
            Text = "Frm_Relatorio";
            ((System.ComponentModel.ISupportInitialize)ReportDataGrid).EndInit();
            Maneiradebusca.ResumeLayout(false);
            Maneiradebusca.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dataInicio;
        private Label dataFim;
        private DataGridView ReportDataGrid;
        private GroupBox Maneiradebusca;
        private RadioButton consultas;
        private RadioButton procCirur;
        private RadioButton procEstetico;
        private RadioButton vacinacao;
    }
}