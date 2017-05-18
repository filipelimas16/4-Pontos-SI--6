using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hortfruit
{
    public class Conexao
    {
        SqlConnection con = null;
        public SqlConnection ConectarDatabase()
        {
            try
            {

                //Criar uma nova instancia
                con = new SqlConnection();
                //Utilizado para poder pegar qualquer diretorio para o localDB
                string path = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug\\", "").Replace("bin\\Debug", "");
                con.ConnectionString = string.Format(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename ={0}Database1.mdf;Integrated Security = True; Connect Timeout = 30", path);
                con.Open();
                return con;
            }

            catch (Exception )
            {

                throw ;
            }
        }

    }
}
