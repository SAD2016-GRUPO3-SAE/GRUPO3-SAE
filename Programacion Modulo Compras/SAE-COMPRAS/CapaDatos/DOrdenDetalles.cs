using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DOrdenDetalles
    {
        public int Id_Orden { get; set; }
        public String Nombre_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Descuento { get; set; }

        public DOrdenDetalles()
        {

        }

        public DOrdenDetalles(int parId_Orden, String parNombre_Producto, int parCantidad,
            decimal parPrecio_Unitario, decimal parDescuento)
        {
            this.Id_Orden = parId_Orden;
            this.Nombre_Producto = parNombre_Producto;
            this.Cantidad = parCantidad;
            this.Precio_Unitario = parPrecio_Unitario;
            this.Descuento = parDescuento;
        }

        public DataTable MostrarOrdenDetalles(int parIdOrden)
        {
            DataTable TablaDatos = new DataTable("Compras.OrdenDetalles");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.MostrarOrdenDetalles";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdOrden = new SqlParameter();
                ParIdOrden.ParameterName = "@Id_Orden";
                ParIdOrden.SqlDbType = SqlDbType.Int;
                ParIdOrden.Value = parIdOrden;
                SqlComando.Parameters.Add(ParIdOrden);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Compras.MostrarOrdenDetalles. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public string Insertar(DOrdenDetalles parOrdenDetalles)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.InsertarOrdenDetalles";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Producto = new SqlParameter();
                ParNombre_Producto.ParameterName = "@Nombre_Producto";
                ParNombre_Producto.SqlDbType = SqlDbType.VarChar;
                ParNombre_Producto.Size = parOrdenDetalles.Nombre_Producto.Length;
                ParNombre_Producto.Value = parOrdenDetalles.Nombre_Producto;
                SqlComando.Parameters.Add(ParNombre_Producto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = parOrdenDetalles.Cantidad;
                SqlComando.Parameters.Add(ParCantidad);

                SqlParameter ParPrecioUnitario = new SqlParameter();
                ParPrecioUnitario.ParameterName = "@Precio_Unitario";
                ParPrecioUnitario.SqlDbType = SqlDbType.Money;
                ParPrecioUnitario.Value = parOrdenDetalles.Precio_Unitario;
                SqlComando.Parameters.Add(ParPrecioUnitario);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@Descuento";
                ParDescuento.SqlDbType = SqlDbType.Decimal;
                ParDescuento.Value = parOrdenDetalles.Descuento;
                SqlComando.Parameters.Add(ParDescuento);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar campos vacíos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "No puedes insertar más de una vez el mismo producto en un pedido. Si quieres agregar más de un mismo producto simplemente modifica la cantidad del mismo.";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Ingresa un producto existente. Si el producto no existe deberás primero crearlo";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.InsertarOrdenDetalles. " + ex.Message;
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

        public string Editar(DOrdenDetalles parOrdenDetalles)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Compras.EditarOrdenDetalles";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Orden = new SqlParameter();
                ParId_Orden.ParameterName = "@Id_Orden";
                ParId_Orden.SqlDbType = SqlDbType.Int;
                ParId_Orden.Value = parOrdenDetalles.Id_Orden;
                SqlComando.Parameters.Add(ParId_Orden);

                SqlParameter ParNombre_Producto = new SqlParameter();
                ParNombre_Producto.ParameterName = "@Nombre_Producto";
                ParNombre_Producto.SqlDbType = SqlDbType.VarChar;
                ParNombre_Producto.Size = parOrdenDetalles.Nombre_Producto.Length;
                ParNombre_Producto.Value = parOrdenDetalles.Nombre_Producto;
                SqlComando.Parameters.Add(ParNombre_Producto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = parOrdenDetalles.Cantidad;
                SqlComando.Parameters.Add(ParCantidad);

                SqlParameter ParPrecioUnitario = new SqlParameter();
                ParPrecioUnitario.ParameterName = "@Precio_Unitario";
                ParPrecioUnitario.SqlDbType = SqlDbType.Money;
                ParPrecioUnitario.Value = parOrdenDetalles.Precio_Unitario;
                SqlComando.Parameters.Add(ParPrecioUnitario);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@Descuento";
                ParDescuento.SqlDbType = SqlDbType.Decimal;
                ParDescuento.Value = parOrdenDetalles.Descuento;
                SqlComando.Parameters.Add(ParDescuento);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar campos vacíos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "No puedes insertar más de una vez el mismo producto en un pedido. Si quieres agregar más de un mismo producto simplemente modifica la cantidad del mismo.";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Ingresa un producto existente. Si el p oducto no existe deberás primero crearlo";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Compras.EditarOrdenDetalles. " + ex.Message;
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