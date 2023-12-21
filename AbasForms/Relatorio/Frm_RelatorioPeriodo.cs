using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVeterinariaBD.AbasForms
{
    public partial class Frm_RelatorioPeriodo : Form
    {
        public DateTime begginingDate;
        public DateTime finalDate;

        public Frm_RelatorioPeriodo()
        {
            InitializeComponent();
        }

        private void dataInicio_KeyUp(object sender, KeyEventArgs e)
        {
            dataFinal.Text = null;
            if (dataInicio.Text.Length == 10)
            {
                dataFinal.Enabled = true;
                btn_GerarRelatorio.Enabled = false;

            }
        }

        private void dataFinal_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataFinal.Text.Length == 10 && dataInicio.Text.Length == 10)
            {
                begginingDate = DateTime.ParseExact(dataInicio.Text, "yyyy/MM/dd", null);
                finalDate = DateTime.ParseExact(dataFinal.Text, "yyyy/MM/dd", null);

                if (begginingDate > finalDate)
                {
                    MessageBox.Show("DATA FINAL MENOR QUE A INICIAL", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_GerarRelatorio.Enabled = false;

                }
                else
                {
                    dataFinal.Enabled = true;
                    btn_GerarRelatorio.Enabled = true;

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Relatorio ReportWindow = new Frm_Relatorio(begginingDate, finalDate);
            ReportWindow.Show();

        }
    }
}
