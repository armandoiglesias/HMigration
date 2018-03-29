using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;
using MigracionHyundai.Objetos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigracionHyundai.Modelo
{
    public class Modelo
    {
        public List<Cliente> getClientes()
        {
            List<Cliente> cliente = new List<Cliente>();

            SqlCommand command = new SqlCommand();
            command.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings[""].ConnectionString);
            command.Connection.Open();

            command.CommandText = "";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cliente.Add(new Cliente()
                {
                    rut = reader["rut"].ToString()
                    ,
                    nombre = reader["nombre"].ToString()

                });
            }

            return cliente;
        }
    }
}
