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
    public partial class FrmEditarProveedor : Form
    {
        Proveedores _owner;
        int Id_Proveedor;

        public FrmEditarProveedor()
        {
            InitializeComponent();
        }

        public FrmEditarProveedor(Proveedores owner)
        {
            _owner = owner;
            InitializeComponent();

            this.Id_Proveedor = Convert.ToInt32(_owner.ObtenerSeleccion().Cells["ID"].Value);
            this.textBoxNombreCliente.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["PROVEEDOR"].Value);
            this.textBoxDireccion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["DIRECCIÓN"].Value);
            this.textBoxNIT.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["NIT"].Value);
            this.textBoxTelefono.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["TELÉFONO"].Value);
            this.textBoxEmail.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["EMAIL"].Value);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String mensaje = NProveedores.Editar(this.Id_Proveedor, this.textBoxNombreCliente.Text, 
               this.textBoxDireccion.Text, this.textBoxNIT.Text, this.textBoxTelefono.Text,  this.textBoxEmail.Text);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Proveedor {0} ha sido EDITADO", this.textBoxNombreCliente.Text));
                this._owner.Refrescar();
                this.Close();
            }
            else
            {
                MensajeError(mensaje);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
