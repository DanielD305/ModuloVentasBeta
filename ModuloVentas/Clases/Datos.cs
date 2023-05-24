using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Font = iTextSharp.text.Font;

namespace ModuloVentas.Clases
{
    public class Datos
    {
        CConexion con = new CConexion();

        public DataTable CargarCategorias()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarCategorias", con.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable CargarArticulos(int Categoria)
        {
            SqlCommand cmd = new SqlCommand("CargarArticulosxCategoria ", con.LeerCadena());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCategoria", Categoria  );

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable CargarProveedores()
        {
            SqlCommand cmd = new SqlCommand("CargarProveedor ", con.LeerCadena());
            cmd.CommandType = CommandType.StoredProcedure;
            

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void CargarInventarioCompra(DataGridView tablaInventario)
        {
            try
            {


                tablaInventario.DataSource = null;

                SqlDataAdapter adapter = new SqlDataAdapter("CargarCompras", con.ConectarBD());
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaInventario.DataSource = dt;

                con.CerrarConeccion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cargar los registros al inventario : " + ex);
            }

        }

        public DataTable CargarSoloProducto()
        {
            string query = "select idProducto, Descripcion from products";

            SqlCommand cmd = new SqlCommand(query, con.LeerCadena());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

       


        public DataTable CargarNitEmpresa()
        {
            string query = "select Nit, Nombre from company";

            SqlCommand cmd = new SqlCommand(query, con.LeerCadena());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable CargarClientes()
        {
            string query = "select CodigoCliente,Nombre from customer ";

            SqlCommand cmd = new SqlCommand(query, con.LeerCadena());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        


        public DataTable PrecioxArticulo(int articulo)
        {
            SqlCommand cmd = new SqlCommand("PrecioxArticulo ", con.LeerCadena());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdArticulo", articulo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }



        public void MostrarInventario(DataGridView tablaInventario)
        {
            try
            {
                

                tablaInventario.DataSource = null;

                SqlDataAdapter adapter = new SqlDataAdapter("CargarInventario",con.ConectarBD());
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaInventario.DataSource = dt;

                con.CerrarConeccion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cargar los registros al inventario : " + ex);
            }

        }




        public int InsertarVenta(int Serie, int CodigoCliente, int NitEmpresa)
        {
            int idVenta = 0;

            try
            {
                String query = "INSERT INTO sales_h (Serie, Fecha, Codigo_Cliente, Nit) " +
                               "VALUES (" + Serie + ", '" + DateTime.Now + "', " + CodigoCliente + ", " + NitEmpresa + "); " +
                               "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con.ConectarBD());
                idVenta = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Se realizó la venta correctamente. ID de venta: " + idVenta);

                con.CerrarConeccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la venta correctamente: " + ex);
            }

            return idVenta;
        }


        public int ObtenerIdProducto(string descripcion)
        {
            int idProducto = 0;

            try
            {
                string query = "SELECT idProducto FROM products WHERE Descripcion = @Descripcion";

                SqlCommand cmd = new SqlCommand(query, con.ConectarBD());
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    idProducto = Convert.ToInt32(result);
                }

                con.CerrarConeccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del producto: " + ex.Message);
            }

            return idProducto;
        }



        public void InsertarDetalleVenta( int Cantidad, int IdArticulo, int idFactura, int Serie )
        {
            try
            {

                

                String query = " insert into sales_d(Cantidad,Articulo,Factura,Serie) values(" + Cantidad + ","+IdArticulo+","+idFactura + ","+Serie+");"; 
                
                SqlCommand cmd = new SqlCommand(query, con.ConectarBD());
                SqlDataReader dr = cmd.ExecuteReader();

                



                con.CerrarConeccion();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la venta correctamente " + ex);
            }
        }

        public void InsertarCompra( ComboBox articulo, NumericUpDown cantidad, ComboBox proveedor )
        {

            try
            {

                

                String query = "insert into shopping(Articulo, Cantidad, Proveedor) values(" + articulo.SelectedValue + "," + cantidad.Value + "," + proveedor.SelectedValue  +  ")";

                SqlCommand cmd = new SqlCommand(query, con.ConectarBD());
                SqlDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("Se realizo la compra correctamente ");



                con.CerrarConeccion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la compra correctamente " + ex);
            }
        }


        public DataTable EncabezadoxVenta(int idFactura)
        {
            SqlCommand cmd = new SqlCommand("EncabezadoxVenta ", con.LeerCadena());
            

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable DetalleRegistrosxVenta(int idFactura)
        {
            SqlCommand cmd = new SqlCommand("DetalleRegistrosxVenta ", con.LeerCadena());


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }



        public void GenerarFactura(int IdFactura)
        {    // Crear el documento
            Document documento = new Document(PageSize.LETTER, 50, 50, 25, 25);

            // Mostrar pantalla de selección de ruta
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.FileName = "Factura.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;

                // Crear el escritor PDF con la ruta seleccionada
                PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));

                // Abrir el documento
                documento.Open();

                // Agregar contenido al documento
                AgregarEncabezado(documento);
                AgregarInformacionCliente(documento, IdFactura);
                AgregarDetalleFactura(documento, IdFactura);

                // Cerrar el documento
                documento.Close();

                MessageBox.Show("Archivo guardado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se seleccionó ninguna ruta de archivo.");
            }
        }

        private void AgregarEncabezado(Document documento)
        {
            // Crear una tabla para el encabezado
            PdfPTable tabla = new PdfPTable(1);
            tabla.WidthPercentage = 100;

            // Crear la celda del encabezado
            PdfPCell celda = new PdfPCell(new Phrase("FACTURA", new Font(Font.FontFamily.HELVETICA, 20, Font.BOLD)));
            celda.HorizontalAlignment = Element.ALIGN_CENTER;
            celda.Border = iTextSharp.text.Rectangle.NO_BORDER;

            // Agregar la celda a la tabla
            tabla.AddCell(celda);
            tabla.AddCell("\n");
            
            // Agregar la tabla al documento
            documento.Add(tabla);
        }

        private void AgregarInformacionCliente(Document documento, int IdFactura)
        {
            // Crear una tabla para la información del cliente
            PdfPTable tabla = new PdfPTable(4);
            tabla.WidthPercentage = 100;
            tabla.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tabla.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            

            DataTable data = EncabezadoxVenta(IdFactura);

            foreach (DataRow row in data.Rows)
            {


                tabla.AddCell(new Phrase($"Nit: {row[0]}", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));
                tabla.AddCell(new Phrase($"Serie: {row["Serie"]}", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));
                tabla.AddCell(new Phrase($"Factura: {row["Numero"]}", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));
                tabla.AddCell(new Phrase($"Fecha: {row["Fecha"]}", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));

                // Agregar la tabla al documento
                documento.Add(tabla);

                PdfPTable tabla2 = new PdfPTable(3);
                tabla2.WidthPercentage = 100;
                tabla2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                tabla2.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
  

                tabla2.AddCell(new Phrase($"Cliente: {row["Nombre"]}" , new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));
                tabla2.AddCell(new Phrase($"Nit: {row[5]}", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));
                tabla2.AddCell(new Phrase($"Direccion: {row["Direccion"]}", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));

                documento.Add(tabla2);


            }

        }

        private void AgregarDetalleFactura(Document documento, int IdFactura)
        {
            Paragraph titulo = new Paragraph();//definimos el titulo
            titulo = new Paragraph("\n", new Font(Font.FontFamily.HELVETICA, 14, Font.BOLD));
            titulo.Alignment = Element.ALIGN_CENTER; // Alinear el título al centro de la página
            // Agregar el título al documento
            documento.Add(titulo);

            // Crear una tabla para el detalle de la factura
            var tablaEncabezadoRegistros = new PdfPTable(5);

            #region Encabezado  
            tablaEncabezadoRegistros.WidthPercentage = 100f;
            tablaEncabezadoRegistros.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaEncabezadoRegistros.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            tablaEncabezadoRegistros.DefaultCell.BorderColor = new BaseColor(40, 40, 40);
            tablaEncabezadoRegistros.DefaultCell.BackgroundColor = new BaseColor(0, 0, 0);


            tablaEncabezadoRegistros.AddCell(new Phrase("Cantidad", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.WHITE)));
            tablaEncabezadoRegistros.AddCell(new Phrase("Articulo", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.WHITE)));
            tablaEncabezadoRegistros.AddCell(new Phrase("Descripcion", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.WHITE)));
            tablaEncabezadoRegistros.AddCell(new Phrase("Precio Unitario", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.WHITE)));
            tablaEncabezadoRegistros.AddCell(new Phrase("Total", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.WHITE))); 
            #endregion

            documento.Add(tablaEncabezadoRegistros);



            #region Registros  
            var tablaRegistros = new PdfPTable(5);
            tablaRegistros.WidthPercentage = 100f;
            tablaRegistros.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaRegistros.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            tablaRegistros.DefaultCell.BorderColor = new BaseColor(128, 128, 128);
            tablaRegistros.DefaultCell.BorderWidthTop = 0;

            DataTable registros = DetalleRegistrosxVenta(IdFactura);

            decimal Total = 0;

            foreach (DataRow data in registros.Rows)
            {

                tablaRegistros.AddCell(new Phrase($"{data["Cantidad"]} ", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));
                tablaRegistros.AddCell(new Phrase($"{data["idProducto"]}", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));
                tablaRegistros.AddCell(new Phrase($"{data["Descripcion"]}", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));
                tablaRegistros.AddCell(new Phrase($"Q.{data["Precio"] }", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));
                tablaRegistros.AddCell(new Phrase($"Q.{ Convert.ToDecimal(data["Cantidad"]) * Convert.ToDecimal(data["Precio"]) }  ", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL)));

                Total += Convert.ToDecimal(data["Cantidad"]) * Convert.ToDecimal(data["Precio"]);

            }

            documento.Add(tablaRegistros);



            #endregion




            Paragraph titulo2 = new Paragraph();//definimos el titulo
            titulo2 = new Paragraph("\nTOTAL EN LETRAS: \n\n", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD));
            titulo2.Alignment = Element.ALIGN_LEFT; // Alinear el título al centro de la página
            // Agregar el título al documento
            documento.Add(titulo2);


            var tablatotal = new PdfPTable(5);
            tablatotal.WidthPercentage = 100f;
            tablatotal.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablatotal.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            tablatotal.DefaultCell.BorderColor = new BaseColor(128, 128, 128);
            tablatotal.DefaultCell.BorderWidth = 0;


            tablatotal.AddCell(new Phrase("", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL)));
            tablatotal.AddCell(new Phrase("", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL)));
            tablatotal.AddCell(new Phrase("", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL)));
            tablatotal.AddCell(new Phrase("Total:", new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD)));
            tablatotal.AddCell(new Phrase($"Q.{Total}", new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD)));

            documento.Add(tablatotal);
        }







    }
}
