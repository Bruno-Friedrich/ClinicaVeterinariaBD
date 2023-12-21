using ClinicaVeterinariaBD.Arquitetura;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVeterinariaBD.AbasForms.Pagamento
{
    public partial class Frm_SelecionaServico : Form
    {
        public Frm_SelecionaServico()
        {
            InitializeComponent();
            ConsultarConsultas();
        }

        private void ConsultarConsultas()
        {
            try
            {
                using (DbConnection connection = new DbConnection())
                {
                    string query = $@"{connection.search_path}
            SELECT s.Id, s.HoraIni, s.HoraFim, a.Nome AS NomeAnimal, p.Nome AS NomeDono, pe.Nome AS NomeFuncionario
            FROM Servico s
            INNER JOIN Animal a ON s.IdDono = a.IdDono AND s.NomeAnimal = a.Nome
            INNER JOIN Funcionario f ON s.FuncId = f.Id
            INNER JOIN Cliente c ON a.IdDono = c.Id
            INNER JOIN Pessoa p ON c.Id = p.Id
            INNER JOIN Pessoa pe ON f.Id = pe.Id
            WHERE s.HoraIni >= CURRENT_TIME - INTERVAL '1 hour' AND s.Data = CURRENT_DATE;";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection.Connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            // Limpe os dados existentes no DataGridView
                            Dt_Horario.Rows.Clear();

                            // Adicione as colunas se necessário
                            if (Dt_Horario.Columns.Count == 0)
                            {
                                Dt_Horario.Columns.Add("Id", "ID");
                                Dt_Horario.Columns.Add("HoraIni", "Hora Início");
                                Dt_Horario.Columns.Add("HoraFim", "Hora Fim");
                                Dt_Horario.Columns.Add("NomeAnimal", "Nome do Animal");
                                Dt_Horario.Columns.Add("NomeDono", "Nome do Dono");
                                Dt_Horario.Columns.Add("NomeFuncionario", "Nome do Funcionário");
                            }

                            // Adicione os resultados ao DataGridView
                            while (reader.Read())
                            {
                                Dt_Horario.Rows.Add(
                                    reader["Id"],
                                    reader["HoraIni"],
                                    reader["HoraFim"],
                                    reader["NomeAnimal"],
                                    reader["NomeDono"],
                                    reader["NomeFuncionario"]
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar consultas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Used for Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Gainsboro;
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
