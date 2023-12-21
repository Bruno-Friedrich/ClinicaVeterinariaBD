namespace ClinicaVeterinariaBD.AbasForms.Pagamento
{
    partial class Frm_SelecionaServico
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
            Lbl_NomeProd = new Label();
            Dt_Horario = new DataGridView();
            Btn_Cancelar = new FontAwesome.Sharp.IconButton();
            Btn_Enviar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            Txt_Codigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Dt_Horario).BeginInit();
            SuspendLayout();
            // 
            // Lbl_NomeProd
            // 
            Lbl_NomeProd.AutoSize = true;
            Lbl_NomeProd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_NomeProd.ForeColor = Color.Gainsboro;
            Lbl_NomeProd.Location = new Point(12, 22);
            Lbl_NomeProd.Name = "Lbl_NomeProd";
            Lbl_NomeProd.Size = new Size(320, 23);
            Lbl_NomeProd.TabIndex = 13;
            Lbl_NomeProd.Text = "Selecione o horário do Serviço?";
            // 
            // Dt_Horario
            // 
            Dt_Horario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Horario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Horario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dt_Horario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Horario.Location = new Point(12, 48);
            Dt_Horario.Name = "Dt_Horario";
            Dt_Horario.RowHeadersWidth = 51;
            Dt_Horario.RowTemplate.Height = 29;
            Dt_Horario.Size = new Size(926, 101);
            Dt_Horario.TabIndex = 14;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_Cancelar.IconColor = Color.Black;
            Btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Cancelar.Location = new Point(185, 170);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(130, 33);
            Btn_Cancelar.TabIndex = 35;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Enviar
            // 
            Btn_Enviar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Enviar.IconChar = FontAwesome.Sharp.IconChar.None;
            Btn_Enviar.IconColor = Color.Black;
            Btn_Enviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Enviar.Location = new Point(343, 170);
            Btn_Enviar.Name = "Btn_Enviar";
            Btn_Enviar.Size = new Size(130, 33);
            Btn_Enviar.TabIndex = 34;
            Btn_Enviar.Text = "Enviar";
            Btn_Enviar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(14, 170);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 37;
            label1.Text = "Código";
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Location = new Point(99, 170);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(46, 27);
            Txt_Codigo.TabIndex = 36;
            // 
            // Frm_SelecionaServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(951, 230);
            Controls.Add(label1);
            Controls.Add(Txt_Codigo);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Enviar);
            Controls.Add(Dt_Horario);
            Controls.Add(Lbl_NomeProd);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Frm_SelecionaServico";
            Text = "Frm_SelecionaServico";
            ((System.ComponentModel.ISupportInitialize)Dt_Horario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_NomeProd;
        private DataGridView Dt_Horario;
        private FontAwesome.Sharp.IconButton Btn_Cancelar;
        private FontAwesome.Sharp.IconButton Btn_Enviar;
        private Label label1;
        private TextBox Txt_Codigo;
    }
}