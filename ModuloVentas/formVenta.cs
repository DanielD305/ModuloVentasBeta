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
    public partial class formVenta : UserControl
    {
        Clases.Datos datos = new();

        public formVenta()
        {
            InitializeComponent();
            Clases.Datos data = new();

            cbCategoria.DataSource = data.CargarCategorias();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "IdCategoria";


            

            cbNombre.DataSource = data.CargarNitEmpresa();
            cbNombre.ValueMember = "Nit";
            cbNombre.DisplayMember = "Nombre";



            cbNombreCliente.DataSource = data.CargarClientes();
            cbNombreCliente.ValueMember = "CodigoCliente";
            cbNombreCliente.DisplayMember = "Nombre";

            txtfecha.Text = DateTime.Now.ToString();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CantidadVenta.Value != 0 && cbVenta.SelectedIndex != -1 )
            {
                dtDetVenta.Rows.Add(CantidadVenta.Value, cbCategoria.Text, txtMarca.Text, cbVenta.Text, txtPrecio.Text, txtTotal.Text);


                decimal sumaTotal = 0;

                foreach (DataGridViewRow fila in dtDetVenta.Rows)
                {

                    if( fila.Cells[5].Value != null ) { 

                            string valor = fila.Cells[5].Value.ToString();
                
                            decimal total;

                            if(decimal.TryParse(valor, out total))
                            {
                                sumaTotal += total;
                            }
                    }
                }

                rtxTotal.Text = sumaTotal.ToString();
            }



        }

        private void formVenta_Load(object sender, EventArgs e)
        {

            

        }

       

        private void cbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {


          

            int numero;
            bool bandera = (int.TryParse(cbCategoria.SelectedValue.ToString(), out numero));

            if (bandera)
            {
                cbVenta.DataSource = datos.CargarArticulos(numero);
                cbVenta.DisplayMember = "Descripcion";
                cbVenta.ValueMember = "idProducto";
            }

        }

        private void cbVenta_SelectedValueChanged(object sender, EventArgs e)
        {
            int numero;
            bool bandera = (int.TryParse(cbVenta.SelectedValue.ToString(), out numero));

           

            if ( bandera)
            {
                DataTable tabla = datos.PrecioxArticulo(numero);

                foreach (DataRow fila in tabla.Rows)
                {
                  
                    txtPrecio.Text = fila["Precio"].ToString();
                    txtMarca.Text = fila["Nombre"].ToString();

                }



            }


            if (txtPrecio.Text != "" && CantidadVenta.Value != 0)
            {

                txtTotal.Text = (Convert.ToDecimal(txtPrecio.Text) * CantidadVenta.Value).ToString();

            }




        }

        private void CantidadVenta_ValueChanged(object sender, EventArgs e)
        {

            if (txtPrecio.Text != "" && CantidadVenta.Value != 0)
            {

                txtTotal.Text = (Convert.ToDecimal(txtPrecio.Text) * CantidadVenta.Value).ToString();

            }

        }

        private void rtxTotal_TextChanged(object sender, EventArgs e)
        {
            if(rtxMonto.Text != "") 
            {

                rtxCambio.Text = (Convert.ToDecimal(rtxMonto.Text) - Convert.ToDecimal(rtxTotal.Text)).ToString() ;
            
            }

        }

        private void rtxMonto_TextChanged(object sender, EventArgs e)
        {
            if (rtxMonto.Text != "")
            {

                rtxCambio.Text = ( Convert.ToDecimal(rtxMonto.Text)  - Convert.ToDecimal(rtxTotal.Text) ).ToString();

            }

        }

        private void cbNombre_TextChanged(object sender, EventArgs e)
        {
            bool bandera = (   int.TryParse(cbNombre.SelectedValue.ToString(), out _) );


            if (bandera) { 
                 txtNitEmp.Text = cbNombre.SelectedValue.ToString();
            }
        }

        private void cbNombreCliente_TextChanged(object sender, EventArgs e)
        {
            int numero;
            bool bandera = (int.TryParse(cbNombreCliente.SelectedValue.ToString(), out numero));

            

            if (bandera) 
            { 
                txtIdCliente.Text = cbNombreCliente.SelectedValue.ToString();
                txtNitCliente.Text = numero.ToString();
            }

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try 
            {
            
                int serie =  Convert.ToInt32(  numSerie.Value );
                int CodCliente = Convert.ToInt32(txtIdCliente.Text);
                int nitEmpresa = Convert.ToInt32(txtNitEmp.Text);

                int idFactura;

                int idArticulo;
                int Cantidad;


                if (dtDetVenta.Rows.Count > 1)
                {
                    

                    idFactura = datos.InsertarVenta(serie, CodCliente, nitEmpresa);

                    
                    foreach (DataGridViewRow fila in dtDetVenta.Rows)
                    {

                        
                        if(fila != null && fila.Cells[3].Value != null ) 
                        { 
                            idArticulo = datos.ObtenerIdProducto( fila.Cells[3].Value.ToString()) ;

                            Cantidad =  Convert.ToInt32(  fila.Cells[0].Value );

                            datos.InsertarDetalleVenta(Cantidad, idArticulo, idFactura, serie);

                            
                        }
                    }


                    datos.GenerarFactura(idFactura);
                }
                else
                {
                    
                    MessageBox.Show("Debe de insertar articulos para la venta.");
                }



                MessageBox.Show( "Venta realizada con exito, Factura Generada en PDF");

                dtDetVenta.DataSource = null;

            }
            catch (Exception exce)
            {

                MessageBox.Show("Asegurese de ingresar los datos correspondientes a la venta " + exce);
            }

        }
    }
}
