using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Inventario_Ventas.Clases
{
    public class Conexion
    {
        string db;
        string servidor;
        string usuario;
        string contrasena;
        string ssl;

        public Conexion()
        {
            this.db = "sistemaventas";
            this.servidor = "localhost";
            this.usuario = "root";
            this.contrasena = "Jhon3126114451";
            this.ssl = "None";
        }

        public MySqlConnection ObternerConexion()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "Database=" + db +
                    "; Data Source=" + servidor +
                    "; User id=" + usuario +
                    "; Password=" + contrasena +
                    "; SSL Mode=" + ssl + ";";

            } catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;

        }
    }
}
