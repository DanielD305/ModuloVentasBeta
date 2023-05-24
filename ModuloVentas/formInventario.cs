using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloVentas
{
    public partial class formInventario : UserControl
    {

        Clases.Datos datos = new();

        public formInventario()
        {
            InitializeComponent();
            Clases.Datos datos = new();

            datos.MostrarInventario(DGVInventario);
        }

        private void formInventario_Load(object sender, EventArgs e)
        {
            datos.MostrarInventario(DGVInventario);
        }
    }
}
