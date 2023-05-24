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
    public partial class formCompra : UserControl
    {

        Clases.Datos data = new();

        public formCompra()
        {
            InitializeComponent();
            Clases.Datos data = new();


            
            cbProveedor.DataSource = data.CargarProveedores();
            cbProveedor.ValueMember = "IdProvider";
            cbProveedor.DisplayMember = "Nombre";


            cbCompra.DataSource = data.CargarSoloProducto();
            cbCompra.ValueMember = "idProducto";
            cbCompra.DisplayMember = "Descripcion";

            data.CargarInventarioCompra(dgvInventarioCompras);

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            data.InsertarCompra(cbCompra, CantidadCompra ,cbProveedor);

            data.CargarInventarioCompra(dgvInventarioCompras);

        }
    }
}
