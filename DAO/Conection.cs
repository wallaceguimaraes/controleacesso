using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace AcessoControle.DAO
{
    public class Conection
    {
        public string connection;

        public Conection()
        {
            connection = ConfigurationManager.AppSettings["acesso"];
        }
    }
}
