using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DOrdenes
    {
        public int Id_Orden { get; set; }
        public String Nombre_Proveedor { get; set; }
        public String Fecha_Ordenado { get; set; }
        public String Fecha_Requerido { get; set; }
        public String Fecha_Entregado { get; set; }
        public String Orden_Buscado { get; set; }

        public DOrdenes()
        {

        }

        public DOrdenes(int parId_Orden, String parNombre_Proveedor, String parFecha_Ordenado, String parFecha_Requerido,
            String parFecha_Entregado, String parOrden_Buscado)
        {
            this.Id_Orden = parId_Orden;
            this.Nombre_Proveedor = parNombre_Proveedor;
            this.Fecha_Ordenado = parFecha_Ordenado;
            this.Fecha_Requerido = parFecha_Requerido;
            this.Fecha_Entregado = parFecha_Entregado;
            this.Orden_Buscado = parOrden_Buscado;
        }

        public DataTable MostrarOrdenesPendientes(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("Compras.v_Ordenes");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.MostrarOrdenesPendientes";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.MostrarOrdenesPendientes. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable MostrarOrdenesEntregados(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("Compras.v_Ordenes");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.MostrarOrdenesEntregados";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.MostrarOrdenesEntregados. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public int TamañoOrdenesPendientes(int parRegistrosPorPagina)
        {
            SqlConnection SqlConexion = new SqlConnection();
            int totalPaginas = 1;

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.TamañoOrdenesPendientes";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.TamañoOrdenesPendientes. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public int TamañoOrdenesEntregados(int parRegistrosPorPagina)
        {
            SqlConnection SqlConexion = new SqlConnection();
            int totalPaginas = 1;

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.TamañoOrdenesEntregados";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.TamañoOrdenesEntregados. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable BuscarOrdenPendiente(DOrdenes parOrdenes)
        {
            DataTable TablaDatos = new DataTable("Compras.v_Ordenes");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.BuscarOrdenPendiente";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Buscado = new SqlParameter();
                ParNombre_Buscado.ParameterName = "@Orden_Buscado";
                ParNombre_Buscado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Buscado.Size = parOrdenes.Orden_Buscado.Length;
                ParNombre_Buscado.Value = parOrdenes.Orden_Buscado;
                SqlComando.Parameters.Add(ParNombre_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.BuscarOrdenPendiente. " + ex.Message, ex);
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

        public DataTable BuscarOrdenEntregado(DOrdenes parOrdenes)
        {
            DataTable TablaDatos = new DataTable("Compras.v_Ordenes");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.BuscarOrdenEntregado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Buscado = new SqlParameter();
                ParNombre_Buscado.ParameterName = "@Orden_Buscado";
                ParNombre_Buscado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Buscado.Size = parOrdenes.Orden_Buscado.Length;
                ParNombre_Buscado.Value = parOrdenes.Orden_Buscado;
                SqlComando.Parameters.Add(ParNombre_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.BuscarOrdenEntregado. " + ex.Message, ex);
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

        public string Insertar(DOrdenes parOrdenes)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.InsertarOrden";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Proveedor = new SqlParameter();
                ParNombre_Proveedor.ParameterName = "@Nombre_Proveedor";
                ParNombre_Proveedor.SqlDbType = SqlDbType.VarChar;
                ParNombre_Proveedor.Size = parOrdenes.Nombre_Proveedor.Length;
                ParNombre_Proveedor.Value = parOrdenes.Nombre_Proveedor;
                SqlComando.Parameters.Add(ParNombre_Proveedor);

                SqlParameter ParFecha_Ordenado = new SqlParameter();
                ParFecha_Ordenado.ParameterName = "@Fecha_Ordenado";
                ParFecha_Ordenado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Ordenado.Value = parOrdenes.Fecha_Ordenado;
                SqlComando.Parameters.Add(ParFecha_Ordenado);

                SqlParameter ParFecha_Requerido = new SqlParameter();
                ParFecha_Requerido.ParameterName = "@Fecha_Requerido";
                ParFecha_Requerido.SqlDbType = SqlDbType.DateTime;
                ParFecha_Requerido.Value = parOrdenes.Fecha_Requerido;
                SqlComando.Parameters.Add(ParFecha_Requerido);

             
                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 547)
                {
                    Respuesta = "La Fecha Requerido tiene que ser posterior a la Fecha Ordeando";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar los campos Proveedor o Fecha Ordenado vacíos";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Debes ingresar un Proveedor existente";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.InsertarOrden. " + ex.Message;
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

        public string Eliminar(DOrdenes parOrdenes)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.EliminarOrden";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Orden = new SqlParameter();
                ParId_Orden.ParameterName = "@Id_Orden";
                ParId_Orden.SqlDbType = SqlDbType.Int;
                ParId_Orden.Value = parOrdenes.Id_Orden;
                SqlComando.Parameters.Add(ParId_Orden);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (Exception ex)
            {
                Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EliminarOrden. " + ex.Message;
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

        public string Editar(DOrdenes parOrdenes)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.EditarOrden";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Orden = new SqlParameter();
                ParId_Orden.ParameterName = "@Id_Orden";
                ParId_Orden.SqlDbType = SqlDbType.Int;
                ParId_Orden.Value = parOrdenes.Id_Orden;
                SqlComando.Parameters.Add(ParId_Orden);

                SqlParameter ParNombre_Proveedor = new SqlParameter();
                ParNombre_Proveedor.ParameterName = "@Nombre_Proveedor";
                ParNombre_Proveedor.SqlDbType = SqlDbType.VarChar;
                ParNombre_Proveedor.Size = parOrdenes.Nombre_Proveedor.Length;
                ParNombre_Proveedor.Value = parOrdenes.Nombre_Proveedor;
                SqlComando.Parameters.Add(ParNombre_Proveedor);

       
                SqlParameter ParFecha_Ordenado = new SqlParameter();
                ParFecha_Ordenado.ParameterName = "@Fecha_Ordenado";
                ParFecha_Ordenado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Ordenado.Value = parOrdenes.Fecha_Ordenado;
                SqlComando.Parameters.Add(ParFecha_Ordenado);

                SqlParameter ParFecha_Requerido = new SqlParameter();
                ParFecha_Requerido.ParameterName = "@Fecha_Requerido";
                ParFecha_Requerido.SqlDbType = SqlDbType.DateTime;
                ParFecha_Requerido.Value = parOrdenes.Fecha_Requerido;
                SqlComando.Parameters.Add(ParFecha_Requerido);

                SqlParameter ParFecha_Entregado = new SqlParameter();
                ParFecha_Entregado.ParameterName = "@Fecha_Entregado";
                ParFecha_Entregado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Entregado.Value = parOrdenes.Fecha_Entregado;
                SqlComando.Parameters.Add(ParFecha_Entregado);


                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 547)
                {
                    Respuesta = "La Fecha Requerido o la Fecha Entregado tienen que ser posteriores a la Fecha Ordeando";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar los campos Proveedor o Fecha Ordenado vacíos";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Debes ingresar un Proveedor existente";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EditarOrden. " + ex.Message;
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

        public string MarcarEntregadoPendiente(DOrdenes parOrdenes)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.MarcarEntregadoPendiente";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Orden = new SqlParameter();
                ParId_Orden.ParameterName = "@Id_Orden";
                ParId_Orden.SqlDbType = SqlDbType.Int;
                ParId_Orden.Value = parOrdenes.Id_Orden;
                SqlComando.Parameters.Add(ParId_Orden);

                SqlParameter ParFecha_Entregado = new SqlParameter();
                ParFecha_Entregado.ParameterName = "@Fecha_Entregado";
                ParFecha_Entregado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Entregado.Value = parOrdenes.Fecha_Entregado;
                SqlComando.Parameters.Add(ParFecha_Entregado);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 547)
                {
                    Respuesta = "La Fecha Requerido o la Fecha Entregado tienen que ser posteriores a la Fecha Ordeando";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar campos vacíos";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.MarcarEntregadoPendiente. " + ex.Message;
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