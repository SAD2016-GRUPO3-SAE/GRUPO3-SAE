using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NProveedor
    {
        public static DataTable ListaProveedores()
        {
            return new DProveedores().ListaProveedores();
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DProveedores().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DProveedores().Tamaño(parRegistrosPorPagina);
        }


        public static DataTable Buscar(String parNombre_Cliente_Buscado)
        {
            DProveedores clientes = new DProveedores();
            clientes.Nombre_Cliente_Buscado = parNombre_Cliente_Buscado;

            return clientes.Buscar(clientes);
        }

        public static String Eliminar(int parId_Cliente)
        {
            DProveedores clientes = new DProveedores();
            clientes.Id_Cliente = parId_Cliente;

            return clientes.Eliminar(clientes);
        }

        public static String Insertar(String parNombre_Cliente, String parNombre_Contacto,
            String parDireccion, String parCiudad, String parRegion, String parPais,
            String parTelefono, String parFax, String parEmail)
        {
            DProveedores clientes = new DProveedores();
            clientes.Nombre_Cliente = parNombre_Cliente;
            clientes.Nombre_Contacto = parNombre_Contacto;
            clientes.Direccion = parDireccion;
            clientes.Ciudad = parCiudad;
            clientes.Region = parRegion;
            clientes.Pais = parPais;
            clientes.Telefono = parTelefono;
            clientes.Fax = parFax;
            clientes.Email = parEmail;

            return clientes.Insertar(clientes);
        }

        public static String Editar(int parId_Cliente, String parNombre_Cliente, String parNombre_Contacto,
            String parDireccion, String parCiudad, String parRegion, String parPais,
            String parTelefono, String parFax, String parEmail)
        {
            DProveedores clientes = new DProveedores();
            clientes.Id_Cliente = parId_Cliente;
            clientes.Nombre_Cliente = parNombre_Cliente;
            clientes.Nombre_Contacto = parNombre_Contacto;
            clientes.Direccion = parDireccion;
            clientes.Ciudad = parCiudad;
            clientes.Region = parRegion;
            clientes.Pais = parPais;
            clientes.Telefono = parTelefono;
            clientes.Fax = parFax;
            clientes.Email = parEmail;

            return clientes.Editar(clientes);
        }
    }
}
