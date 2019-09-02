using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
    class Conexion
    {
        public MySqlConnection getconexion() {
            try {

                string cadena = "datasource=localhost;port=3306;username=root;database=prueba1;";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                return con;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
