using ModuloVentas.Clases;

namespace ModuloVentas
{
    public partial class ModuloVenta : Form
    {
        public ModuloVenta()
        {
            InitializeComponent();
            Datos data = new();

            login1.Visible = true;
            formVenta1.Visible = false;
            formCompra1.Visible = false;
            formInventario1.Visible = false;
            //data.MostrarInventario(DGVInventario);
        }
        Datos data = new();
        

        private void Form1_Load(object sender, EventArgs e)
        {
           /* 

            cbCompra.DataSource = data.CargarCB();
            cbCompra.DisplayMember = "Descripcion";
            cbCompra.ValueMember = "idProducto";

            cbFactura.DataSource = data.CargarCBFacturas();
            cbFactura.DisplayMember = "Numero";
            cbFactura.ValueMember = "Numero";*/

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            formVenta1.Visible = false;
            formCompra1.Visible = false;
            formInventario1.Visible = true;
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            formVenta1.Visible = false;
            formCompra1.Visible = true;
            formInventario1.Visible = false;

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {


            formVenta1.Visible = true;
            formCompra1.Visible = false;
            formInventario1.Visible = false;

        }

        private void panelCompras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
           /* data.InsertarVenta(cbVenta, CantidadVenta, cbFactura, numSerie);
            data.MostrarInventario(DGVInventario);*/
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            /*data.InsertarCompra(cbCompra,CantidadCompra);
            data.MostrarInventario(DGVInventario);*/
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }
    }
}