using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Biblioteca
{
    class Operaciones
    {

        public bool insert(string nombre,string apellidos , int celular)
        {
            Conexion cn = new Conexion();
            try
            {
                string mysql = "insert into ejemplo.nombres (nombre, documento, tipodocumento) values (?nombre, ?documento, ?tipodocumento);";
                MySqlCommand cmd = new MySqlCommand(mysql,cn.getconexion());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception) {

                return false;
            }
        }
    }
}
