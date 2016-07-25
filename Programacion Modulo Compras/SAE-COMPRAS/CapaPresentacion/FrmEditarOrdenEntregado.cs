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

namespace CapaPresentacion
{
    public partial class FrmEditarOrdenEntregado : Form
    {
        Ordenes _owner;
        public FrmEditarOrdenEntregado()
        {
            InitializeComponent();
        }

        public FrmEditarOrdenEntregado(Ordenes owner)
        {
            InitializeComponent();
            this._owner = owner;

            CargarProveedor();
            CargarProductos();

            this.labelNumeroPedido.Text = Convert.ToString(_owner.ObtenerSeleccionPedidos().Cells["CÓDIGO"].Value);
            this.comboBoxClientes.Text = Convert.ToString(_owner.ObtenerSeleccionPedidos().Cells["PROVEEDOR"].Value);
            this.dateTimePickerFechaOrdenado.Text = Convert.ToDateTime(_owner.ObtenerSeleccionPedidos().Cells["ORDENADO"].Value).ToString("dd/MM/yyyy");
            this.dateTimePickerFechaEntregado.Text = Convert.ToDateTime(_owner.ObtenerSeleccionPedidos().Cells["ENTREGADO"].Value).ToString("dd/MM/yyyy");
            //Creamos otra grilla porque no podemos agregar filas a una grilla binded por un data source
            this.dataGridViewOrigen.Hide();
            this.dataGridViewOrigen.DataSource = NOrdenDetalles.MostrarOrdenDetalles(Convert.ToInt32(_owner.ObtenerSeleccionPedidos().Cells[1].Value));

            for (int fila = 0; fila < (this.dataGridViewOrigen.Rows.Count - 1); fila++)
            {
                this.dataGridViewProductos.Rows.Add("", Convert.ToString(this.dataGridViewOrigen.Rows[fila].Cells["PRODUCTO"].Value),
                    Convert.ToInt32(this.dataGridViewOrigen.Rows[fila].Cells["CANT."].Value),
                    Convert.ToDecimal(this.dataGridViewOrigen.Rows[fila].Cells["PRECIO"].Value),
                    Convert.ToDecimal(this.dataGridViewOrigen.Rows[fila].Cells["DESC."].Value));
            }

            this.dataGridViewProductos.Columns[3].DefaultCellStyle.Format = "0.00# 'Q'";
            this.dataGridViewProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns[4].DefaultCellStyle.Format = "0.00# '%'";
            this.dataGridViewProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void CargarProveedor()
        {
            this.comboBoxClientes.DataSource = NProveedores.ListaProveedores();
            this.comboBoxClientes.ValueMember = "ID";
            this.comboBoxClientes.DisplayMember = "NOMBRE";
        }

        public void CargarProductos()
        {
            this.comboBoxProductos.DataSource = NProductos.ListaProductos();
            this.comboBoxProductos.ValueMember = "ID";
            this.comboBoxProductos.DisplayMember = "NOMBRE";
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.dataGridViewProductos.Rows[this.dataGridViewProductos.CurrentRow.Index];
            return filaSeleccionada;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                int bandera = 0;

                for (int fila = 0; fila < dataGridViewProductos.Rows.Count; fila++)
                {
                    if (dataGridViewProductos.Rows[fila].Cells["producto"].Value.ToString() == this.comboBoxProductos.Text)
                    {
                        bandera = 1;
                    }
                }

                if (bandera == 1)
                {
                    MensajeError("Este producto ya fue ingresado");
                }

                else
                {
                    if (String.IsNullOrWhiteSpace(this.textBoxCantidad.Text) ||
                        (String.IsNullOrWhiteSpace(this.textBoxPrecio.Text)) ||
                        (String.IsNullOrWhiteSpace(this.textBoxDescuento.Text)))
                    {
                        MensajeError("No puedes dejar vacíos los campos Cantidad, Precio o Descuento");
                    }

                    else if (Convert.ToInt32(this.textBoxCantidad.Text) == 0)
                    {
                        MensajeError("La Cantidad no puede ser igual a 0");
                    }

                    else if (Convert.ToDecimal(this.textBoxPrecio.Text) == 0)
                    {
                        MensajeError("El Precio no puede ser igual a 0");
                    }

                    else if (Convert.ToDecimal(this.textBoxDescuento.Text) > 100)
                    {
                        MensajeError("El Descuento no puede ser mayor al 100%");
                    }

                    else
                    {
                        this.dataGridViewProductos.Rows.Add("", this.comboBoxProductos.Text,
                        this.textBoxCantidad.Text, Convert.ToDecimal(this.textBoxPrecio.Text).ToString("0.00## Q"),
                        Convert.ToDecimal(this.textBoxDescuento.Text).ToString("0.00## '%'"));
                        this.comboBoxProductos.Text = String.Empty;
                        this.textBoxCantidad.Text = String.Empty;
                        this.textBoxDescuento.Text = "0";
                    }
                }
            }

            catch (Exception ex)
            {
                MensajeError("Los valores ingresados son incorrectos. " + ex.Message);
            }
        }

        private void comboBoxProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBoxProductos.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                this.textBoxPrecio.Text = (NProductos.PrecioProducto(Convert.ToInt32(this.comboBoxProductos.SelectedValue.ToString()))).ToString("0.00##");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridViewProductos.Rows.Count) > 0)
            {
                this.dataGridViewProductos.Rows.Remove(this.dataGridViewProductos.Rows[this.dataGridViewProductos.CurrentRow.Index]);
            }

            else
            {
                MensajeError("Debes seleccionar una fila para eliminar");
            }
        }

        private void dataGridViewProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            this.dataGridViewProductos.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void textBoxCostoEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
