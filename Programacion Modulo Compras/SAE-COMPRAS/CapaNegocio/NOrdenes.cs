using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NOrdenes
    {
        public static DataTable MostrarOrdenesPendientes(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DOrdenes().MostrarOrdenesPendientes(parNumeroPagina, parRegistrosPorPagina);
        }

        public static DataTable MostrarOrdenesEntregados(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DOrdenes().MostrarOrdenesEntregados(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int TamañoOrdenesPendientes(int parRegistrosPorPagina)
        {
            return new DOrdenes().TamañoOrdenesPendientes(parRegistrosPorPagina);
        }

        public static int TamañoOrdenesEntregados(int parRegistrosPorPagina)
        {
            return new DOrdenes().TamañoOrdenesEntregados(parRegistrosPorPagina);
        }

        public static DataTable BuscarOrdenPendiente(String parOrden_Buscado)
        {
            DOrdenes ordenes = new DOrdenes();
            ordenes.Orden_Buscado = parOrden_Buscado;

            return ordenes.BuscarOrdenPendiente(ordenes);
        }

        public static DataTable BuscarOrdenEntregado(String parOrden_Buscado)
        {
            DOrdenes ordenes = new DOrdenes();
            ordenes.Orden_Buscado = parOrden_Buscado;

            return ordenes.BuscarOrdenEntregado(ordenes);
        }

        public static String Eliminar(int parId_Orden)
        {
            DOrdenes ordenes = new DOrdenes();
            ordenes.Id_Orden = parId_Orden;

            return ordenes.Eliminar(ordenes);
        }

        public static String Insertar(String parNombre_Proveedor, String parFecha_Ordenado, String parFecha_Requerido)
        {
            DOrdenes ordenes = new DOrdenes();
            ordenes.Nombre_Proveedor = parNombre_Proveedor;
            ordenes.Fecha_Ordenado = parFecha_Ordenado;
            ordenes.Fecha_Requerido = parFecha_Requerido;

            return ordenes.Insertar(ordenes);
        }

        public static String Editar(int parIdOrden, String parNombre_Proveedor, String parFecha_Ordenado, String parFecha_Requerido,
            String parFecha_Entregado)
        {
            DOrdenes ordenes = new DOrdenes();
            ordenes.Id_Orden = parIdOrden;
            ordenes.Nombre_Proveedor = parNombre_Proveedor;
            ordenes.Fecha_Ordenado = parFecha_Ordenado;
            ordenes.Fecha_Requerido = parFecha_Requerido;
            ordenes.Fecha_Entregado = parFecha_Entregado;

            return ordenes.Editar(ordenes);
        }

        public static String MarcarEntregadoPendiente(int parIdOrden, String parFecha_Entregado)
        {
            DOrdenes ordenes = new DOrdenes();
            ordenes.Id_Orden = parIdOrden;
            ordenes.Fecha_Entregado = parFecha_Entregado;

            return ordenes.MarcarEntregadoPendiente(ordenes);
        }
    }
}
