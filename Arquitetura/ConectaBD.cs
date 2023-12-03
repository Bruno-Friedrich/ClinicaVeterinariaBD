﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVeterinariaBD.Arquitetura
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }
        
        public DbConnection()
        {
                Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=CliniVet;User Id=postgres;Password=admin;");
                Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}