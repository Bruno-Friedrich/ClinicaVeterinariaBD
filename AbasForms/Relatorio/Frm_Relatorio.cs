﻿using ClinicaVeterinariaBD.Arquitetura;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVeterinariaBD.AbasForms
{
    public partial class Frm_Relatorio : Form
    {
        DateTime begginingDate;
        DateTime endingDate;
        public Frm_Relatorio(DateTime begginingDate, DateTime endDate)
        {
            InitializeComponent();
            this.begginingDate = begginingDate;
            this.endingDate = endDate;
            dataInicio.Text = $"Data inicial: {begginingDate.ToString("yyyy/MM/dd")}";
            dataFim.Text = $"Data final: {endDate.ToString("yyyy/MM/dd")}";
        }

        private void procCirur_MouseClick(object sender, MouseEventArgs e)
        {
            GenerateReport(begginingDate, endingDate, "Procedimentos Cirúrgicos");

        }

        private void consultas_MouseClick(object sender, EventArgs e)
        {
            GenerateReport(begginingDate, endingDate, "Consulta");

        }

        private void procEstetico_MouseClick(object sender, EventArgs e)
        {
            GenerateReport(begginingDate, endingDate, "Procedimentos Estéticos");

        }

        private void vacinacao_MouseClick(object sender, EventArgs e)
        {
            GenerateReport(begginingDate, endingDate, "Vacinação");

        }

        private void GenerateReport(DateTime begginingDate, DateTime endDate, string typeService)
        {
            int total_sales = GetTotalSales(begginingDate, endDate, typeService);
            int total_cost = GetTotalCost(begginingDate, endDate, typeService);
            int total_profit = total_sales - total_cost;
            int total_services = GetTotalServices(begginingDate, endDate, typeService);
        }

        private int GetTotalSales(DateTime begginingDate, DateTime endDate, string typeService)
        {
            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;
            string dateBeggining_s = begginingDate.ToString("yyyy-MM-dd");
            string dateEnd_s = endDate.ToString("yyyy-MM-dd");


            string query = $"{connection.search_path} SELECT SUM(custo) as Faturamento FROM SERVICO WHERE tipo = '{typeService}' and data BETWEEN '{dateBeggining_s}' AND '{dateEnd_s}'";
            command.CommandText = query;

            NpgsqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            int result;
            if (dataReader["Faturamento"].ToString().Equals(""))
               result =  0;
            else
                result = Int32.Parse(dataReader["Faturamento"].ToString());
            command.Dispose();
            connection.Connection.Close();
            return result;

        }

        private int GetTotalCost(DateTime begginingDate, DateTime endDate, string typeService)
        {
            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;
            string dateBeggining_s = begginingDate.ToString("yyyy-MM-dd");
            string dateEnd_s = endDate.ToString("yyyy-MM-dd");


            string query = $"{connection.search_path} SELECT SUM(Custo_servico) AS Custo_total FROM (SELECT (preco * quantidadeconsumida) AS Custo_servico FROM (SELECT PRODUTO.preco as preco, quantidadeconsumida FROM PRODUTO, SERVICO_CONSOME_PRODUTO, SERVICO WHERE SERVICO.tipo = '{typeService}' AND SERVICO.id = idservico AND PRODUTO.id = idproduto));";
            command.CommandText = query;

            NpgsqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            int result;
            if (dataReader["Custo_total"].ToString().Equals(""))
                result = 0;
            else
                result = Int32.Parse(dataReader["Custo_total"].ToString());
            command.Dispose();
            connection.Connection.Close();
            return result;

        }

        private int GetTotalServices(DateTime begginingDate, DateTime endDate, string typeService)
        {
            DbConnection connection = new DbConnection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection.Connection;
            command.CommandType = CommandType.Text;
            string dateBeggining_s = begginingDate.ToString("yyyy-MM-dd");
            string dateEnd_s = endDate.ToString("yyyy-MM-dd");


            string query = $"{connection.search_path} SELECT COUNT(*) as total_servicos FROM SERVICO WHERE SERVICO.tipo = '{typeService}'";
            command.CommandText = query;

            NpgsqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            int result;
            if (dataReader["total_servicos"].ToString().Equals(""))
                result = 0;
            else
                result = Int32.Parse(dataReader["total_servicos"].ToString());
            command.Dispose();
            connection.Connection.Close();
            return result;

        }



    }
}
