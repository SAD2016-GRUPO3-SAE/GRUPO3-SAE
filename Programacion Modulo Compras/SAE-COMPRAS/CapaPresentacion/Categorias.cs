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
    public partial class Categorias : Form
    {
        int numeroPagina = 1;
        int registrosPorPagina = 25;
        int cantidadPaginas;

        public Categorias()
        {
            InitializeComponent();
            Mostrar();
        }

        public void Mostrar()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewCategorias.DataSource = NCategorias.Mostrar(numeroPagina, registrosPorPagina);
                this.dataGridViewCategorias.Columns[0].Visible = false;
                cantidadPaginas = NCategorias.Tamaño(registrosPorPagina);
                this.labelPagina.Text = String.Format("Página {0} de {1}", numeroPagina, cantidadPaginas);
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
                this.dataGridViewCategorias.DataSource = NCategorias.Buscar(this.textBoxBuscarNombre.Text);
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        public void Refrescar()
        {
            this.numeroPagina = 1;
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

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.dataGridViewCategorias.Rows[this.dataGridViewCategorias.CurrentRow.Index];
            return filaSeleccionada;
        }

        private void textBoxBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxBuscarNombre.Text == String.Empty)
            {
                this.numeroPagina = 1;
                this.Mostrar();
                
            }
            else
            {
                this.Buscar();
              
            }
        }

  
        private void dataGridViewCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Categorias1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewCategorias.Rows.Count > 0)
                {
                    FrmEditarCategoria editarCategoria = new FrmEditarCategoria(this);
                    editarCategoria.ShowDialog();
                }
                else
                {
                    MensajeError("Debes seleccionar una fila para editar");
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Refrescar();
            this.LimpiarMensaje();
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewCategorias.Rows.Count > 0)
                {
                    DialogResult confirmacion = MessageBox.Show("¿Seguro deseas eliminar esta categoría?", "Eliminar Categoría",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (confirmacion == DialogResult.OK)
                    {
                        String mensaje = NCategorias.Eliminar(Convert.ToInt32(ObtenerSeleccion().Cells["ID"].Value));
                        if (mensaje == "Y")
                        {
                            Mensaje(String.Format("La Categoría {0} ha sido ELIMINADA",
                                Convert.ToString(ObtenerSeleccion().Cells["NOMBRE"].Value)));
                            Refrescar();
                        }
                        else
                        {
                            MensajeError(mensaje);
                            Refrescar();
                        }
                    }
                }
                else
                {
                    MensajeError("Debes seleccionar una fila para eliminar");
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevaCategoria nuevoCategoria = new FrmAgregarNuevaCategoria(this);
            nuevoCategoria.ShowDialog();
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (numeroPagina > 1)
            {
                numeroPagina = numeroPagina - 1;
                Mostrar();
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (numeroPagina < cantidadPaginas)
            {
                numeroPagina = numeroPagina + 1;
                Mostrar();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelPagina_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
