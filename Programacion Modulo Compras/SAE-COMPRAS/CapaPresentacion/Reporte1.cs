using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Reporte1 : Form
    {
        public Reporte1()
        {
            InitializeComponent();
        }

        private void Reporte1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBSAEFINALDataSet.v_Productos_NombreCategorias' Puede moverla o quitarla según sea necesario.
            this.v_Productos_NombreCategoriasTableAdapter.Fill(this.dBSAEFINALDataSet.v_Productos_NombreCategorias);

        }
    }
}
