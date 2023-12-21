using ClinicaVeterinariaBD.AbasForms.Pagamento;
using Npgsql.Internal;
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
    public partial class Frm_Pagamento : Form
    {
        public Frm_Pagamento()
        {
            InitializeComponent();
        }

        private void Btn_RealizarConsulta_Click(object sender, EventArgs e)
        {
            // Crie uma instância do formulário filho
            using (Frm_SelecionaServico formFilho = new Frm_SelecionaServico())
            {
                // Exiba o formulário filho como um diálogo modal
                formFilho.ShowDialog();

            }
        }

        private void Btn_VisualizarNF_Click(object sender, EventArgs e)
        {
            // Crie uma instância do formulário filho
            using (Frm_VisualizaNF formFilho = new Frm_VisualizaNF())
            {
                // Exiba o formulário filho como um diálogo modal
                formFilho.ShowDialog();

            }
        }

        private void Btn_VisualizaServico_Click(object sender, EventArgs e)
        {
            // Crie uma instância do formulário filho
            using (Frm_VisualizaServico formFilho = new Frm_VisualizaServico())
            {
                // Exiba o formulário filho como um diálogo modal
                formFilho.ShowDialog();

            }
        }
    }
}
