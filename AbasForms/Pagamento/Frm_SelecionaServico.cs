using ClinicaVeterinariaBD.Arquitetura;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                    string query = $@"{connection.search_path} SELECT s.HoraIni, s.HoraFim, a.Nome AS NomeAnimal, p.Nome AS NomeDono, pe.Nome AS NomeFuncionario FROM Servico s INNER JOIN Animal a ON s.IdDono = a.IdDono AND s.NomeAnimal = a.Nome INNER JOIN Funcionario f ON s.FuncId = f.Id INNER JOIN Cliente c ON a.IdDono = c.Id INNER JOIN Pessoa p ON c.Id = p.Id INNER JOIN Pessoa pe ON f.Id = pe.Id WHERE s.HoraIni >= CURRENT_TIME - INTERVAL '1 hour';";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection.Connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            // Limpe os dados existentes no DataGridView
                            Dt_Horario.Rows.Clear();

                            // Adicione as colunas se necessário
                            if (Dt_Horario.Columns.Count == 0)
                            {
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
    }
}
