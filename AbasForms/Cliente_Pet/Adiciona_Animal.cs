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
using ClinicaVeterinariaBD.Arquitetura;
using ClinicaVeterinariaBD.AbasForms.Cliente_Pet;


namespace ClinicaVeterinariaBD.AbasForms.Cliente_Pet
{

    public partial class Adiciona_Animal : Form
    {

        /*public void insereIdEmPessoa(int idCliente)
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = "INSERT INTO clinicaveterinaria2.Cliente (id) VALUES (@id)";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@id", idCliente);
                    NpgsqlDataReader dr = Command.ExecuteReader();
                }
            }
        }*/

        public void insereAnimal(int IdCliente)
        {
            string nomeAnimal, especieAnimal, racaAnimal;

            char sexoAnimal;

            int idadeAnimal, pesoAnimal;


            //Animal
            nomeAnimal = box_animal_nome.Text.ToLower().Trim();
            especieAnimal = box_animal_especie.Text.ToLower().Trim();
            racaAnimal = box_animal_raca.Text.ToLower().Trim();

            string temp1 = box_animal_idade.Text;
            string temp2 = box_animal_peso.Text;

            if (box_animal_sexo.Text == "Masculino")
                sexoAnimal = 'm';
            else
                sexoAnimal = 'f';

            if ((string.IsNullOrEmpty(nomeAnimal)) || (string.IsNullOrEmpty(racaAnimal)) || (string.IsNullOrEmpty(especieAnimal))
                ||  (string.IsNullOrEmpty(temp1)) || (string.IsNullOrEmpty(temp2)))
            {
                MessageBox.Show("Insira os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            idadeAnimal = Int32.Parse(temp1);
            pesoAnimal = Int32.Parse(temp2);

            using (DbConnection Connection = new DbConnection())
            {
                string query = "INSERT INTO clinicaveterinaria.Animal (iddono, nome, especie, raca, idade, sexo, peso) " +
                    "VALUES (@iddono, @nome, @especie, @raca, @idade, @sexo, @peso)";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    Command.Parameters.AddWithValue("@iddono", IdCliente);
                    Command.Parameters.AddWithValue("@nome", nomeAnimal);
                    Command.Parameters.AddWithValue("@especie", especieAnimal);
                    Command.Parameters.AddWithValue("@raca", racaAnimal);
                    Command.Parameters.AddWithValue("@idade", idadeAnimal);
                    Command.Parameters.AddWithValue("@sexo", sexoAnimal);
                    Command.Parameters.AddWithValue("@peso", pesoAnimal);

                    NpgsqlDataReader dr = Command.ExecuteReader();
                    MessageBox.Show("Inserido com Sucesso!");
                }
            }
        }

        public Adiciona_Animal()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string userImput = box_idCliente.Text;
            //insereIdEmPessoa(Int32.Parse(userImput));

            if(string.IsNullOrEmpty(userImput))
            {
                MessageBox.Show("Insira o Id", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            insereAnimal(Int32.Parse(userImput));
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
