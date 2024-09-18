using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace sitenovo.view.banco_de_dados
{
    internal class banco
    {
        private SqlConnection con;
        private string DataBase = "TKLOJINHA";
        private string Server = "sqlexpress";
        private string UserName = "aluno";
        private string Password = "aluno";

        public banco() 
        {
            string stringConnection = @" Data Souce =" + Server +
            "; Iitial Catalog = " + DataBase + 
            "; User id =" + UserName + 
            "; Password =" + Password +
            "; Encrypt = false";
            con = new SqlConnection(stringConnection);
            con.Open();
        }
        public void CloseConnect()
        { 
        if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public SqlConnection ReturnConnect()
        {
            return con;
        }
    }
}
