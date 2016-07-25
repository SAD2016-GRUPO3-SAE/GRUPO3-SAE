using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        Proveedores proveedores;
        Categorias categorias;
        Productos productos;
        Ordenes ordenes;
        FrmReportes reportes;
        Reporte1 reporte1;

        public FrmInicio()
        {
            String mensaje = NConexion.ChequearConexion();
            if (mensaje == "Y")
            {
                InitializeComponent();

            }
            else
            {
                MessageBox.Show("El Sistema de Compras no se puede iniciar ya que existió un error al conectarse con la Base de Datos. " + mensaje,
                  "Error al iniciar el Sistema de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }


        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ordenes = new Ordenes();
            ordenes.Show();

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            productos = new Productos();
            productos.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            proveedores = new Proveedores();
            proveedores.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            categorias = new Categorias();
            categorias.Show();

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            reportes = new FrmReportes();
            reportes.Show();
        }


        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void ordenesDeCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ordenes = new Ordenes();
            ordenes.Show();
        }

        private void agregarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ordenesPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte1 = new Reporte1();
            reporte1.Show();
        }

        private void agregarNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte2 agregar = new Reporte2();
            agregar.Show();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proveedores = new Proveedores();
            proveedores.Show();
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos = new Productos();
            productos.Show();
        }

        private void historialProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte2 agregar = new Reporte2();
            agregar.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportesPorSocioYProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReportes administracionReportes = new FrmReportes();
                administracionReportes.ShowDialog();
            }

            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void proveedoresYProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
    }


