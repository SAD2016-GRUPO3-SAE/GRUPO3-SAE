using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Ordenes : Form
    {
        int numeroPaginaPedidosPendientes = 1;
        int numeroPaginaPedidosEntegados = 1;
        int registrosPorPagina = 25;
        int cantidadPaginasPedidosPendientes;
        int cantidadPaginasPedidosEntregados;

        int esPendiente = 1;
        public Ordenes()
        {
            InitializeComponent();
            Mostrar();
        }

        private void tabControlPedidos_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlPedidos.SelectedTab == tabControlPedidos.TabPages["tabPagePendientes"])
            {
                esPendiente = 1;
                Mostrar();
            }
            else if (tabControlPedidos.SelectedTab == tabControlPedidos.TabPages["tabPageEntregados"])
            {
                esPendiente = 0;
                Mostrar();
            }
        }

        public void Mostrar()
        {
            try
            {
                if (esPendiente == 1)
                {
                    this.Dock = DockStyle.Fill;
                    this.dataGridViewPedidosPendientes.DataSource = NOrdenes.MostrarOrdenesPendientes(numeroPaginaPedidosPendientes, registrosPorPagina);
                    this.dataGridViewPedidosPendientes.Columns[1].Visible = false;
                    this.dataGridViewPedidosPendientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridViewPedidosPendientes.Columns[8].DefaultCellStyle.Format = "0.00## Q";
                    cantidadPaginasPedidosPendientes = NOrdenes.TamañoOrdenesPendientes(registrosPorPagina);
                    this.labelPagina.Text = String.Format("Página {0} de {1}", numeroPaginaPedidosPendientes, cantidadPaginasPedidosPendientes);
                }

                else if (esPendiente == 0)
                {
                    this.Dock = DockStyle.Fill;
                    this.dataGridViewPedidosEntregados.DataSource = NOrdenes.MostrarOrdenesEntregados(numeroPaginaPedidosEntegados, registrosPorPagina);
                    this.dataGridViewPedidosEntregados.Columns[1].Visible = false;
                    this.dataGridViewPedidosEntregados.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.dataGridViewPedidosEntregados.Columns[8].DefaultCellStyle.Format = "0.00## Q";
                    cantidadPaginasPedidosEntregados = NOrdenes.TamañoOrdenesEntregados(registrosPorPagina);
                    this.labelPagina.Text = String.Format("Página {0} de {1}", numeroPaginaPedidosEntegados, cantidadPaginasPedidosEntregados);
                }
            }

            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        public void Buscar()
        {
            try
            {
                if (esPendiente == 1)
                {
                    this.dataGridViewPedidosPendientes.DataSource = NOrdenes.BuscarOrdenPendiente(this.textBoxBuscarNombre.Text);
                }
                else
                {
                    this.dataGridViewPedidosEntregados.DataSource = NOrdenes.BuscarOrdenEntregado(this.textBoxBuscarNombre.Text);
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        public void Refrescar()
        {
            if (esPendiente == 1)
            {
                this.numeroPaginaPedidosPendientes = 1;
            }
            else if (esPendiente == 0)
            {
                this.numeroPaginaPedidosEntegados = 1;
            }

            this.Mostrar();
            this.textBoxBuscarNombre.Text = String.Empty;
        }

        public void Mensaje(String mensaje)
        {
            this.labelMensajes.Text = mensaje;
        }

        public void LimpiarMensaje()
        {
            this.labelMensajes.Text = String.Empty;
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataGridViewRow ObtenerSeleccionPedidos()
        {
            DataGridViewRow filaSeleccionada = null;

            if (esPendiente == 1)
            {
                filaSeleccionada = this.dataGridViewPedidosPendientes.Rows[this.dataGridViewPedidosPendientes.CurrentRow.Index];
            }

            else if (esPendiente == 0)
            {
                filaSeleccionada = this.dataGridViewPedidosEntregados.Rows[this.dataGridViewPedidosEntregados.CurrentRow.Index];
            }

            return filaSeleccionada;
        }

      

        private void textBoxBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxBuscarNombre.Text == String.Empty)
            {
                if (esPendiente == 1)
                {
                    this.numeroPaginaPedidosPendientes = 1;
                }
                else if (esPendiente == 0)
                {
                    this.numeroPaginaPedidosEntegados = 1;
                }

                this.Mostrar();
            }
            else
            {
                this.Buscar();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Refrescar();
            this.LimpiarMensaje();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (esPendiente == 1)
                {
                    if (this.dataGridViewPedidosPendientes.Rows.Count > 0)
                    {
                        FrmEditarOrdenPendiente editarPedidoPendiente = new FrmEditarOrdenPendiente(this);
                        editarPedidoPendiente.ShowDialog();
                    }
                    else
                    {
                        MensajeError("Debes seleccionar una fila para editar");
                    }
                }

                else if (esPendiente == 0)
                {
                    if (this.dataGridViewPedidosEntregados.Rows.Count > 0)
                    {
                        FrmEditarOrdenEntregado editarPedidoEntregado = new FrmEditarOrdenEntregado(this);
                        editarPedidoEntregado.ShowDialog();
                    }
                    else
                    {
                        MensajeError("Debes seleccionar una fila para editar");
                    }
                }
            }

            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void Eliminar()
        {
            DialogResult confirmacion = MessageBox.Show("¿Seguro deseas eliminar esta Orden?", "Eliminar Orden",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (confirmacion == DialogResult.OK)
            {
                String mensaje = NOrdenes.Eliminar(Convert.ToInt32(ObtenerSeleccionPedidos().Cells["ID"].Value));
                if (mensaje == "Y")
                {
                    Mensaje(String.Format("El Pedido {0} de {1} ha sido ELIMINADO",
                        Convert.ToString(ObtenerSeleccionPedidos().Cells["CÓDIGO"].Value),
                        Convert.ToString(ObtenerSeleccionPedidos().Cells["PROVEEDOR"].Value)));
                    Refrescar();
                }
                else
                {
                    MensajeError(mensaje);
                    Refrescar();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (esPendiente == 1)
                {
                    if (this.dataGridViewPedidosPendientes.Rows.Count > 0)
                    {
                        this.Eliminar();
                    }
                    else
                    {
                        MensajeError("Debes seleccionar una fila para eliminar");
                    }
                }
                else if (esPendiente == 0)
                {
                    if (this.dataGridViewPedidosEntregados.Rows.Count > 0)
                    {
                        this.Eliminar();
                    }
                    else
                    {
                        MensajeError("Debes seleccionar una fila para eliminar");
                    }
                }
            }

            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregarNuevaOrden nuevoPedido = new FrmAgregarNuevaOrden(this);
                nuevoPedido.ShowDialog();
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void dataGridViewPedidosPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    FrmOrdenPendienteDetalles pedidoDetalles = new FrmOrdenPendienteDetalles(this);
                    pedidoDetalles.ShowDialog();
                }
                catch (Exception ex)
                {
                    MensajeError(ex.Message);
                }
            }
        }

        private void dataGridViewPedidosEntregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    FrmOrdenEntregadoDetalles pedidoEntregadoDetalles = new FrmOrdenEntregadoDetalles(this);
                    pedidoEntregadoDetalles.ShowDialog();
                }
                catch (Exception ex)
                {
                    MensajeError(ex.Message);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                if (esPendiente == 1)
                {
                    if (this.dataGridViewPedidosPendientes.Rows.Count > 0)
                    {
                        FrmMarcarEntregado marcarEntregado = new FrmMarcarEntregado(this);
                        marcarEntregado.ShowDialog();
                    }
                    else
                    {
                        MensajeError("Debes seleccionar una fila para marcar como Entregado");
                    }
                }

                else if (esPendiente == 0)
                {
                    if (this.dataGridViewPedidosEntregados.Rows.Count > 0)
                    {
                        FrmMarcarPendiente marcarPendiente = new FrmMarcarPendiente(this);
                        marcarPendiente.ShowDialog();
                    }
                    else
                    {
                        MensajeError("Debes seleccionar una fila para marcar como Pendiente");
                    }
                }
            }

            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewPedidosEntregados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    FrmOrdenEntregadoDetalles pedidoEntregadoDetalles = new FrmOrdenEntregadoDetalles(this);
                    pedidoEntregadoDetalles.ShowDialog();
                }
                catch (Exception ex)
                {
                    MensajeError(ex.Message);
                }
            }
        }
    }
}
