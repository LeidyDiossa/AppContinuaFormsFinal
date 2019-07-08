using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace appcontinuaforms
{
    public class ConexionBD

    {
        public MySqlConnection conn = null;
        public string mensajeerror = null;
        public string numeroerror = null;

        public void conectarBD()
        {
            //Cadena de conexión a la base de datos
            string connStr = "server=localhost;user=root;database=appiushbd;port=3306;password=mysql";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
               
            }
            catch (MySqlException ex)
            {
                mensajeerror = ex.Message;
                numeroerror = Convert.ToString(ex.Number);
            }           

        }

        public void desconectarBD()
        {
            conn.Close();
        }
    }

}
