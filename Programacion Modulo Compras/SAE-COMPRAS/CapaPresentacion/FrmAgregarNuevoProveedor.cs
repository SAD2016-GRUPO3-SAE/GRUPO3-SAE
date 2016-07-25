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
    public partial class FrmAgregarNuevoProveedor : Form
    {
        Proveedores _owner;
        public FrmAgregarNuevoProveedor()
        {
            InitializeComponent();
        }

        public FrmAgregarNuevoProveedor(Proveedores owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String mensaje = NProveedores.Insertar(this.textBoxNombreCliente.Text, this.textBoxDireccion.Text,
                this.textBoxNIT.Text, this.textBoxTelefono.Text, this.textBoxEmail.Text);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Proveedor {0} ha sido AGREGADO",
                    this.textBoxNombreCliente.Text));
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
