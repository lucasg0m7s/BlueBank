using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.DAL
{
    public class Conexao
    {
        SqlConnection conn = new SqlConnection();
        public Conexao() 
        { 
            conn.ConnectionString = @"";
        }

        public SqlConnection Conectar()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        public void Desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
