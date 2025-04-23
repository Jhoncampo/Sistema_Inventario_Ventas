using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Inventario_Ventas.Clases
{
    public class MetodosProveedores
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlconexion = new MySqlConnection();

        public DataTable ObtenerProveedores()
        {
            try
            {
                sqlconexion = new Conexion().ObternerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerProveedores", sqlconexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlconexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
                
            }catch (Exception ex)
            {
                throw ex;
            }finally
            {
                if(sqlconexion.State == ConnectionState.Open)
                {
                    sqlconexion.Close();
                }
            }
        }

        public string AgregarProveedor(Proveedor proveedor)
        {
            string respuesta = "";
            try
            {
                sqlconexion = new Conexion().ObternerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarProveedor", sqlconexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nomProveedor", MySqlDbType.VarChar).Value = proveedor.nomProveedor;
                comando.Parameters.Add("@numContacto", MySqlDbType.VarChar).Value = proveedor.numContacto;
                comando.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = proveedor.direccion;
                comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = proveedor.email;

                sqlconexion.Open();
                if(comando.ExecuteNonQuery() == 1) {
                    respuesta = "Se inserto correctamente";

                }else
                {
                    respuesta = "No se pudo insertar el registro";
                }
                return respuesta;

            }catch(Exception ex) 
            {
                throw ex;
             }finally
            {
                if(sqlconexion.State == ConnectionState.Open)
                {
                    sqlconexion.Close();
                }
            }
        }

        public DataTable BuscarProveedor(string nombre)
        {
            try
            {
                sqlconexion = new Conexion().ObternerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarProveedor", sqlconexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@proveedor", MySqlDbType.VarChar).Value = nombre.Trim();
                sqlconexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

                

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlconexion.State == ConnectionState.Open)
                {
                    sqlconexion.Close();
                }
            }
        }

        public string ActualizarProveedor(int idProveedor, Proveedor proveedor)
        {
            string respuesta = "";
            try
            {
                sqlconexion = new Conexion().ObternerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarProveedor", sqlconexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idProveedor;
                comando.Parameters.Add("@nomProveedor", MySqlDbType.VarChar).Value = proveedor.nomProveedor;
                comando.Parameters.Add("@numContacto", MySqlDbType.VarChar).Value = proveedor.numContacto;
                comando.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = proveedor.direccion;
                comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = proveedor.email;

                sqlconexion.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "Se actualizo correctamente";

                }
                else
                {
                    respuesta = "No se pudo actualizar el registro";
                }
                return respuesta;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlconexion.State == ConnectionState.Open)
                {
                    sqlconexion.Close();
                }
            }
        }

        public string ValidarProveedor(Proveedor proveedor)
        {
            string resultado = null;
            if(proveedor.nomProveedor.Equals("") || proveedor.numContacto.Equals("") ||
                proveedor.direccion.Equals("") || proveedor.email.Equals(""))
            {
                resultado = "Te falta llenar y/o seleccionar un campo";

            }
            else
            {
                resultado = "OK";
            }
            return resultado;
        }



    }
}
