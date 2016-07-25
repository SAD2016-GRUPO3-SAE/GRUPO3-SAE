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
    public partial class FrmEditarOrdenPendiente : Form
    {
        Ordenes _owner;

        public FrmEditarOrdenPendiente()
        {
            InitializeComponent();
        }

        public FrmEditarOrdenPendiente(Ordenes owner)
        {
            InitializeComponent();

            try
            {
                this._owner = owner;

                CargarSocio();
         
                CargarProductos();

                this.labelNumeroPedido.Text = Convert.ToString(_owner.ObtenerSeleccionPedidos().Cells["CÓDIGO"].Value);
                this.comboBoxClientes.Text = Convert.ToString(_owner.ObtenerSeleccionPedidos().Cells["PROVEEDOR"].Value);
               
                this.dateTimePickerFechaOrdenado.Value = Convert.ToDateTime(_owner.ObtenerSeleccionPedidos().Cells["ORDENADO"].Value);
               

                if (String.IsNullOrWhiteSpace(_owner.ObtenerSeleccionPedidos().Cells["REQUERIDO"].Value.ToString()))
                {
                    this.checkBoxSinFecha.Checked = true;
                }

                else
                {
                    this.checkBoxSinFecha.Checked = false;
                    this.dateTimePickerFechaRequerido.Value = Convert.ToDateTime(_owner.ObtenerSeleccionPedidos().Cells["REQUERIDO"].Value);
                }

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
         
            catch (Exception ex)
            {
                MensajeError("Datos incompletos. " + ex.Message);
                this._owner.Refrescar();
            }
        }

        public void CargarSocio()
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

        private void comboBoxProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBoxProductos.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                this.textBoxPrecio.Text = (NProductos.PrecioProducto(Convert.ToInt32(this.comboBoxProductos.SelectedValue.ToString()))).ToString("0.00##");
            }
        }
        

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
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


        private void checkBoxSinFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxSinFecha.Checked)
            {
                this.dateTimePickerFechaRequerido.Hide();
            }
            else
            {
                this.dateTimePickerFechaRequerido.Show();
            }
        }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTipAgregarProducto_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTipEliminarProducto_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            String fecha_requerido = "";

            try
            {

                if (this.checkBoxSinFecha.Checked)
                {
                    fecha_requerido = null;
                }

                else
                {
                    fecha_requerido = this.dateTimePickerFechaRequerido.Value.ToString("dd/MM/yyyy");
                }

                if (this.dataGridViewProductos.Rows.Count > 0)
                {
                    mensaje = NOrdenes.Editar(Convert.ToInt32(_owner.ObtenerSeleccionPedidos().Cells[1].Value), this.comboBoxClientes.Text, this.dateTimePickerFechaOrdenado.Text,
                    fecha_requerido, null);

                    if (mensaje == "Y")
                    {
                        for (int fila = 0; fila < dataGridViewProductos.Rows.Count; fila++)
                        {
                            mensaje = NOrdenDetalles.Editar(Convert.ToInt32(_owner.ObtenerSeleccionPedidos().Cells[1].Value),
                                dataGridViewProductos.Rows[fila].Cells["producto"].Value.ToString(),
                                Convert.ToInt32(dataGridViewProductos.Rows[fila].Cells["cantidad"].Value.ToString()),
                                Convert.ToDecimal(dataGridViewProductos.Rows[fila].Cells["precio"].Value.ToString().Replace("Q", "")),
                                Convert.ToDecimal(dataGridViewProductos.Rows[fila].Cells["descuento"].Value.ToString().Replace("%", "")));
                        }

                        if (mensaje == "Y")
                        {
                            this._owner.Mensaje(String.Format("El Pedido {0} para {1} ha sido EDITADO",
                                this._owner.ObtenerSeleccionPedidos().Cells["CÓDIGO"].Value,
                                this.comboBoxClientes.Text));
                            this._owner.Refrescar();
                            this.Close();
                        }
                        else
                        {
                            MensajeError(mensaje);
                        }
                    }

                    else
                    {
                        MensajeError(mensaje);
                    }

                }
                else
                {
                    MensajeError("Debes añadir algún producto al pedido");
                }

            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
