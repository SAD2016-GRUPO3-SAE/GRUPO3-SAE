using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DProveedores
    {
        public int Id_Proveedor { get; set; }
        public String Nombre_Proveedor { get; set; }
      //  public String Nombre_Contacto { get; set; }
        public String Direccion { get; set; }
        public String Nit { get; set; }
       // public String Region { get; set; }
       // public String Pais { get; set; }
        public String Telefono { get; set; }
        //public String Fax { get; set; }
        public String Email { get; set; }
        public String Nombre_Proveedor_Buscado { get; set; }

        public DProveedores()
        {

        }

        public DProveedores(int parId_Proveedor, String parNombre_Proveedor, String parDireccion, 
            String parNit, String parTelefono, String parEmail, String parNombre_Proveedor_Buscado)
        {
            this.Id_Proveedor = parId_Proveedor;
            this.Nombre_Proveedor = parNombre_Proveedor;
            //this.Nombre_Contacto = parNombre_Contacto;
            this.Direccion = parDireccion;
            this.Nit = parNit;
            //this.Region = parRegion;
            //this.Pais = parPais;
            this.Telefono = parTelefono;
            //this.Fax = parFax;
            this.Email = parEmail;
            this.Nombre_Proveedor_Buscado = parNombre_Proveedor_Buscado;
        }

        public DataTable ListaProveedores()
        {
            DataTable TablaDatos = new DataTable("Compras.Proveedor");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.ListaProveedor";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado ListaProveedor. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("Compras.Proveedor");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.MostrarProveedor";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumeroPagina = new SqlParameter();
                ParNumeroPagina.ParameterName = "@NumeroPagina";
                ParNumeroPagina.SqlDbType = SqlDbType.Int;
                ParNumeroPagina.Value = parNumeroPagina;
                SqlComando.Parameters.Add(ParNumeroPagina);

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.MostrarProveedores. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public int Tamaño(int parRegistrosPorPagina)
        {
            SqlConnection SqlConexion = new SqlConnection();
            int totalPaginas = 1;

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.TamañoProveedor";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlParameter ParTotalPaginas = new SqlParameter();
                ParTotalPaginas.ParameterName = "@TotalPaginas";
                ParTotalPaginas.SqlDbType = SqlDbType.Int;
                ParTotalPaginas.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(ParTotalPaginas);

                SqlComando.ExecuteNonQuery();

                totalPaginas = (int)SqlComando.Parameters["@TotalPaginas"].Value;
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.TamañoProveedores. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable Buscar(DProveedores parProveedores)
        {
            DataTable TablaDatos = new DataTable("Compras.Proveedor");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.BuscarProveedor";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Proveedor_Buscado = new SqlParameter();
                ParNombre_Proveedor_Buscado.ParameterName = "@NombreProveedorBuscado";
                ParNombre_Proveedor_Buscado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Proveedor_Buscado.Size = parProveedores.Nombre_Proveedor_Buscado.Length;
                ParNombre_Proveedor_Buscado.Value = parProveedores.Nombre_Proveedor_Buscado;
                SqlComando.Parameters.Add(ParNombre_Proveedor_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.BuscarProveedor. " + ex.Message, ex);
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return TablaDatos;
        }

        public string Insertar(DProveedores parProveedores)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.InsertarProveedor";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Proveedor = new SqlParameter();
                ParNombre_Proveedor.ParameterName = "@Nombre_Proveedor";
                ParNombre_Proveedor.SqlDbType = SqlDbType.VarChar;
                ParNombre_Proveedor.Size = parProveedores.Nombre_Proveedor.Length;
                ParNombre_Proveedor.Value = parProveedores.Nombre_Proveedor;
                SqlComando.Parameters.Add(ParNombre_Proveedor);


                /*
                SqlParameter ParNombre_Contacto = new SqlParameter();
                ParNombre_Contacto.ParameterName = "@Nombre_Contacto";
                ParNombre_Contacto.SqlDbType = SqlDbType.VarChar;
                ParNombre_Contacto.Size = parProveedores.Nombre_Contacto.Length;
                ParNombre_Contacto.Value = parProveedores.Nombre_Contacto;
                SqlComando.Parameters.Add(ParNombre_Contacto);*/

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = parProveedores.Direccion.Length;
                ParDireccion.Value = parProveedores.Direccion;
                SqlComando.Parameters.Add(ParDireccion);

                SqlParameter ParNit = new SqlParameter();
                ParNit.ParameterName = "@Nit";
                ParNit.SqlDbType = SqlDbType.VarChar;
                ParNit.Size = parProveedores.Nit.Length;
                ParNit.Value = parProveedores.Nit;
                SqlComando.Parameters.Add(ParNit);

                /*
                SqlParameter ParRegion = new SqlParameter();
                ParRegion.ParameterName = "@Region";
                ParRegion.SqlDbType = SqlDbType.VarChar;
                ParRegion.Size = parProveedores.Region.Length;
                ParRegion.Value = parProveedores.Region;
                SqlComando.Parameters.Add(ParRegion);
                */

                /*
                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = parProveedores.Pais.Length;
                ParPais.Value = parProveedores.Pais;
                SqlComando.Parameters.Add(ParPais);
                */

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = parProveedores.Telefono.Length;
                ParTelefono.Value = parProveedores.Telefono;
                SqlComando.Parameters.Add(ParTelefono);

                /*
                SqlParameter ParFax = new SqlParameter();
                ParFax.ParameterName = "@Fax";
                ParFax.SqlDbType = SqlDbType.VarChar;
                ParFax.Size = parProveedores.Fax.Length;
                ParFax.Value = parProveedores.Fax;
                SqlComando.Parameters.Add(ParFax);

                */

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = parProveedores.Email.Length;
                ParEmail.Value = parProveedores.Email;
                SqlComando.Parameters.Add(ParEmail);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe un cliente con ese Nombre";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "Sólo puedes dejar vacíos los campos Nombre de Teléfono y Email";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.InsertarProveedor. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }

        public string Eliminar(DProveedores parProveedores)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.EliminarProveedor";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Proveedor = new SqlParameter();
                ParId_Proveedor.ParameterName = "@Id_Proveedor";
                ParId_Proveedor.SqlDbType = SqlDbType.Int;
                ParId_Proveedor.Value = parProveedores.Id_Proveedor;
                SqlComando.Parameters.Add(ParId_Proveedor);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Respuesta = "No puedes eliminar un socio que cuenta con uno o varias Ordenes. Debes eliminar o actualizar sus Pedidos antes de eliminar el Socio.";
                }

                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EliminarProveedor. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }

        public string Editar(DProveedores parProveedores)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.EditarProveedor";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Proveedor = new SqlParameter();
                ParId_Proveedor.ParameterName = "@Id_Proveedor";
                ParId_Proveedor.SqlDbType = SqlDbType.Int;
                ParId_Proveedor.Value = parProveedores.Id_Proveedor;
                SqlComando.Parameters.Add(ParId_Proveedor);

                SqlParameter ParNombre_Proveedor = new SqlParameter();
                ParNombre_Proveedor.ParameterName = "@Nombre_Proveedor";
                ParNombre_Proveedor.SqlDbType = SqlDbType.VarChar;
                ParNombre_Proveedor.Size = parProveedores.Nombre_Proveedor.Length;
                ParNombre_Proveedor.Value = parProveedores.Nombre_Proveedor;
                SqlComando.Parameters.Add(ParNombre_Proveedor);

                /*
                SqlParameter ParNombre_Contacto = new SqlParameter();
                ParNombre_Contacto.ParameterName = "@Nombre_Contacto";
                ParNombre_Contacto.SqlDbType = SqlDbType.VarChar;
                ParNombre_Contacto.Size = parProveedores.Nombre_Contacto.Length;
                ParNombre_Contacto.Value = parProveedores.Nombre_Contacto;
                SqlComando.Parameters.Add(ParNombre_Contacto);
                */

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = parProveedores.Direccion.Length;
                ParDireccion.Value = parProveedores.Direccion;
                SqlComando.Parameters.Add(ParDireccion);

                SqlParameter ParNit = new SqlParameter();
                ParNit.ParameterName = "@Nit";
                ParNit.SqlDbType = SqlDbType.VarChar;
                ParNit.Size = parProveedores.Nit.Length;
                ParNit.Value = parProveedores.Nit;
                SqlComando.Parameters.Add(ParNit);

                /*
                SqlParameter ParRegion = new SqlParameter();
                ParRegion.ParameterName = "@Region";
                ParRegion.SqlDbType = SqlDbType.VarChar;
                ParRegion.Size = parProveedores.Region.Length;
                ParRegion.Value = parProveedores.Region;
                SqlComando.Parameters.Add(ParRegion);
                */

                /*
                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = parProveedores.Pais.Length;
                ParPais.Value = parProveedores.Pais;
                SqlComando.Parameters.Add(ParPais);
                */

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = parProveedores.Telefono.Length;
                ParTelefono.Value = parProveedores.Telefono;
                SqlComando.Parameters.Add(ParTelefono);

                /*
                SqlParameter ParFax = new SqlParameter();
                ParFax.ParameterName = "@Fax";
                ParFax.SqlDbType = SqlDbType.VarChar;
                ParFax.Size = parProveedores.Fax.Length;
                ParFax.Value = parProveedores.Fax;
                SqlComando.Parameters.Add(ParFax);
                */

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = parProveedores.Email.Length;
                ParEmail.Value = parProveedores.Email;
                SqlComando.Parameters.Add(ParEmail);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe un socio con ese Nombre";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "Sólo puedes dejar vacíos los campos  Teléfono y Email";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EditarProveedor. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }
    }
}
 