namespace ClinicaVeterinariaBD.AbasForms.Estoque
{
    partial class Frm_InfoProduto
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
            Pnl_Shadow = new Panel();
            textBox1 = new TextBox();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 65);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // Icn_Titulo
            // 
            Icn_Titulo.BackColor = Color.FromArgb(34, 33, 74);
            Icn_Titulo.ForeColor = Color.Thistle;
            Icn_Titulo.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            Icn_Titulo.IconColor = Color.Thistle;
            Icn_Titulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Icn_Titulo.IconSize = 35;
            Icn_Titulo.Location = new Point(22, 16);
            Icn_Titulo.Name = "Icn_Titulo";
            Icn_Titulo.Size = new Size(39, 35);
            Icn_Titulo.TabIndex = 9;
            Icn_Titulo.TabStop = false;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Titulo.ForeColor = Color.Gainsboro;
            Lbl_Titulo.Location = new Point(55, 22);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(242, 23);
            Lbl_Titulo.TabIndex = 8;
            Lbl_Titulo.Text = "Adicionar novo produto";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(26, 25, 72);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 29;
            btnExit.Location = new Point(619, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 33);
            btnExit.TabIndex = 7;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // Pnl_Shadow
            // 
            Pnl_Shadow.BackColor = Color.FromArgb(26, 24, 58);
            Pnl_Shadow.Dock = DockStyle.Top;
            Pnl_Shadow.Location = new Point(0, 65);
            Pnl_Shadow.Name = "Pnl_Shadow";
            Pnl_Shadow.Size = new Size(660, 9);
            Pnl_Shadow.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 4;
            // 
            // Frm_InfoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 72);
            ClientSize = new Size(660, 481);
            Controls.Add(textBox1);
            Controls.Add(Pnl_Shadow);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_InfoProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_InfoProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icn_Titulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Panel Pnl_Shadow;
        private Label Lbl_Titulo;
        private FontAwesome.Sharp.IconPictureBox Icn_Titulo;
        private TextBox textBox1;
    }
}