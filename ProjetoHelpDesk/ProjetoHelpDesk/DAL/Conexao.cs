using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHelpDesk.DAL
{
    public class Conexao
    {

        SqlConnection conec = new SqlConnection();
        public Conexao()
        {
            conec.ConnectionString = @"Data Source=DESKTOP-QMR9G8J;Initial Catalog=ProjetoHelpDesk;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if(conec.State == System.Data.ConnectionState.Closed)
            {
                conec.Open();
            }
            return conec;
        }
        public void desconectar()
        {
            if (conec.State == System.Data.ConnectionState.Open)
            {
                conec.Close();
            }
        }
    }
}
