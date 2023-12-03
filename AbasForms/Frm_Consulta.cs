using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVeterinariaBD
{
    public partial class Frm_Consulta : Form
    {
        public Frm_Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("opa", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToLongTimeString(), "Tempo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
