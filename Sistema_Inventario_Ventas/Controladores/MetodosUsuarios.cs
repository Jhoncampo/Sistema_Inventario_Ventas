using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Sistema_Inventario_Ventas.Clases
{
    public class MetodosUsuarios
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerUsuarios()
        {
            try
            {
                sqlConexion = new Conexion().ObternerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerUsuarios", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;


            }catch(Exception ex)
            {
                throw ex;
            } finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public List<Permiso> ObtenerPermisos()
        {
            List<Permiso> listaPermisos = new List<Permiso>();
            try {
                sqlConexion = new Conexion().ObternerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerPermisos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaPermisos.Add(
                        new Permiso(resultado.GetInt32(0), resultado.GetString(1)));
                };
                return listaPermisos;


            } catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                };
            }

        }

        public List<Estado> ObtenerEstados()
        {
            List<Estado> listaEstados = new List<Estado>();
            try
            {
                sqlConexion = new Conexion().ObternerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerEstados", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaEstados.Add(
                        new Estado(
                        resultado.GetInt32(0),
                        resultado.GetInt32(1),
                        resultado.GetString(2)));
                };
                return listaEstados;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                };
            }

        }

        public string ValidarUsuario(Usuario usuario)
        {
            string resultado = null;
            if (usuario.nomUsuario.Equals("") ||
                usuario.usuario.Equals("") ||
                usuario.contrasena.Equals("") ||
                usuario.idPermiso == 0 || usuario.idEstado == 0)
            {
                resultado = "Te falta llenar y/o seleccionar un campo";
            }
            else
            {
                resultado = "OK";
            }
            return resultado;
        }

        public string AgregarUsuario(Usuario usuario)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObternerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nomUsuario", MySqlDbType.VarChar).Value = usuario.nomUsuario;
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuario.usuario;
                comando.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = usuario.contrasena;
                comando.Parameters.Add("@idPermiso", MySqlDbType.Int32).Value = usuario.idPermiso;
                comando.Parameters.Add("@idEstado", MySqlDbType.Int32).Value = usuario.idEstado;
                sqlConexion.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "Se inserto correctamente";
                }else
                {
                    respuesta = "No se pudo insertar el registro";
                }
                return respuesta;
            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public string ActualizarUsuario(int idUsuario, Usuario usuario)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObternerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = usuario.idUsuario;
                comando.Parameters.Add("@nomUsuario", MySqlDbType.VarChar).Value = usuario.nomUsuario;
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuario.usuario;
                comando.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = usuario.contrasena;
                comando.Parameters.Add("@idPermiso", MySqlDbType.Int32).Value = usuario.idPermiso;
                comando.Parameters.Add("@idEstado", MySqlDbType.Int32).Value = usuario.idEstado;
                sqlConexion.Open();
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
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

    }
}
