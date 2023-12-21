﻿namespace ClinicaVeterinariaBD.AbasForms.Consulta
{
    partial class s
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            valorServico = new TextBox();
            obsServico = new TextBox();
            tipoServico = new ComboBox();
            funcionarioServico = new ComboBox();
            btrConfirm = new Button();
            cpfOwner = new MaskedTextBox();
            cpfInvalido = new Label();
            animalName = new ComboBox();
            CalendarSchedule = new MonthCalendar();
            dateInvalid = new Label();
            todaysScheduleLabel = new Label();
            todaysScheduleDataGrid = new DataGridView();
            horaFim = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            horaIni = new TextBox();
            ((System.ComponentModel.ISupportInitialize)todaysScheduleDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 46);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 0;
            label1.Text = "CPF dono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(279, 46);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 1;
            label2.Text = "Nome Animal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(500, 46);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 150);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 3;
            label4.Text = "Data";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 404);
            label5.Name = "label5";
            label5.Size = new Size(134, 28);
            label5.TabIndex = 4;
            label5.Text = "Hora de início";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(274, 404);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 5;
            label6.Text = "Horários de fim";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(715, 46);
            label8.Name = "label8";
            label8.Size = new Size(115, 28);
            label8.TabIndex = 7;
            label8.Text = "Funcionário";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(46, 487);
            label9.Name = "label9";
            label9.Size = new Size(57, 28);
            label9.TabIndex = 8;
            label9.Text = "Valor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(274, 487);
            label10.Name = "label10";
            label10.Size = new Size(115, 28);
            label10.TabIndex = 9;
            label10.Text = "Observação";
            // 
            // valorServico
            // 
            valorServico.Location = new Point(46, 518);
            valorServico.Name = "valorServico";
            valorServico.Size = new Size(181, 23);
            valorServico.TabIndex = 12;
            // 
            // obsServico
            // 
            obsServico.Location = new Point(274, 518);
            obsServico.Multiline = true;
            obsServico.Name = "obsServico";
            obsServico.Size = new Size(267, 23);
            obsServico.TabIndex = 13;
            // 
            // tipoServico
            // 
            tipoServico.FormattingEnabled = true;
            tipoServico.Items.AddRange(new object[] { "Procedimento Estético", "Vacinação", "Procedimento Cirúrgico", "Consulta" });
            tipoServico.Location = new Point(503, 77);
            tipoServico.Name = "tipoServico";
            tipoServico.Size = new Size(181, 23);
            tipoServico.TabIndex = 14;
            tipoServico.SelectedIndexChanged += tipoServico_SelectedIndexChanged;
            // 
            // funcionarioServico
            // 
            funcionarioServico.Enabled = false;
            funcionarioServico.FormattingEnabled = true;
            funcionarioServico.Location = new Point(715, 77);
            funcionarioServico.Name = "funcionarioServico";
            funcionarioServico.Size = new Size(181, 23);
            funcionarioServico.TabIndex = 16;
            // 
            // btrConfirm
            // 
            btrConfirm.Enabled = false;
            btrConfirm.Location = new Point(735, 439);
            btrConfirm.Name = "btrConfirm";
            btrConfirm.Size = new Size(161, 105);
            btrConfirm.TabIndex = 19;
            btrConfirm.Text = "Confirmar";
            btrConfirm.UseVisualStyleBackColor = true;
            // 
            // cpfOwner
            // 
            cpfOwner.Location = new Point(42, 77);
            cpfOwner.Mask = "00000000000";
            cpfOwner.Name = "cpfOwner";
            cpfOwner.Size = new Size(181, 23);
            cpfOwner.TabIndex = 20;
            cpfOwner.Leave += cpfOwner_Leave;
            // 
            // cpfInvalido
            // 
            cpfInvalido.AutoSize = true;
            cpfInvalido.Location = new Point(42, 103);
            cpfInvalido.Name = "cpfInvalido";
            cpfInvalido.Size = new Size(83, 15);
            cpfInvalido.TabIndex = 21;
            cpfInvalido.Text = "CPF INVÁLIDO";
            cpfInvalido.Visible = false;
            // 
            // animalName
            // 
            animalName.Enabled = false;
            animalName.FormattingEnabled = true;
            animalName.Location = new Point(279, 77);
            animalName.Name = "animalName";
            animalName.Size = new Size(168, 23);
            animalName.TabIndex = 22;
            // 
            // CalendarSchedule
            // 
            CalendarSchedule.Enabled = false;
            CalendarSchedule.Location = new Point(42, 187);
            CalendarSchedule.Name = "CalendarSchedule";
            CalendarSchedule.TabIndex = 23;
            CalendarSchedule.DateChanged += CalendarSchedule_DateChanged;
            // 
            // dateInvalid
            // 
            dateInvalid.AutoSize = true;
            dateInvalid.Location = new Point(105, 358);
            dateInvalid.Name = "dateInvalid";
            dateInvalid.Size = new Size(75, 15);
            dateInvalid.TabIndex = 24;
            dateInvalid.Text = "Data Inválida";
            dateInvalid.Visible = false;
            // 
            // todaysScheduleLabel
            // 
            todaysScheduleLabel.AutoSize = true;
            todaysScheduleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            todaysScheduleLabel.Location = new Point(407, 150);
            todaysScheduleLabel.Name = "todaysScheduleLabel";
            todaysScheduleLabel.Size = new Size(144, 28);
            todaysScheduleLabel.TabIndex = 26;
            todaysScheduleLabel.Text = "Serviços no dia";
            todaysScheduleLabel.Visible = false;
            // 
            // todaysScheduleDataGrid
            // 
            todaysScheduleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todaysScheduleDataGrid.Location = new Point(341, 187);
            todaysScheduleDataGrid.Name = "todaysScheduleDataGrid";
            todaysScheduleDataGrid.RowTemplate.Height = 25;
            todaysScheduleDataGrid.Size = new Size(463, 167);
            todaysScheduleDataGrid.TabIndex = 27;
            todaysScheduleDataGrid.Visible = false;
            // 
            // horaFim
            // 
            horaFim.Location = new Point(274, 451);
            horaFim.Name = "horaFim";
            horaFim.Size = new Size(267, 23);
            horaFim.TabIndex = 29;
            horaFim.TextChanged += horaFim_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // horaIni
            // 
            horaIni.Location = new Point(46, 451);
            horaIni.Name = "horaIni";
            horaIni.Size = new Size(181, 23);
            horaIni.TabIndex = 30;
            // 
            // s
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 589);
            Controls.Add(horaIni);
            Controls.Add(horaFim);
            Controls.Add(todaysScheduleDataGrid);
            Controls.Add(todaysScheduleLabel);
            Controls.Add(dateInvalid);
            Controls.Add(CalendarSchedule);
            Controls.Add(animalName);
            Controls.Add(cpfInvalido);
            Controls.Add(cpfOwner);
            Controls.Add(btrConfirm);
            Controls.Add(funcionarioServico);
            Controls.Add(tipoServico);
            Controls.Add(obsServico);
            Controls.Add(valorServico);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "s";
            Text = "FormAgendarServico";
            ((System.ComponentModel.ISupportInitialize)todaysScheduleDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox valorServico;
        private TextBox obsServico;
        private ComboBox tipoServico;
        private ComboBox funcionarioServico;
        private Button btrConfirm;
        private MaskedTextBox cpfOwner;
        private Label cpfInvalido;
        private ComboBox animalName;
        private MonthCalendar CalendarSchedule;
        private Label dateInvalid;
        private Label todaysScheduleLabel;
        private DataGridView todaysScheduleDataGrid;
        private TextBox horaFim;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox horaIni;
    }
}