using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Instalaciones;
using CapaPresentacion.Modales;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVentas : Form
    {
        private Usuario _usuario;
        private int stockDisponible; // Variable local para el stock disponible

        public FrmVentas(Usuario usuario = null)
        {
            _usuario = usuario; // Facilita el usuario que esta registrado y que se encuentra haciendo la venta

            InitializeComponent();

            textVendedor.Text = _usuario.Nombre + ' ' + _usuario.Apellido;
            textVendedor.ReadOnly = true;
            textfecha.ReadOnly = true;
            textProducto.ReadOnly = true;
            textPrecio.ReadOnly = true;
            txtStockDisponible.ReadOnly = true;
            textTotal.ReadOnly = true;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            // Valores para ser mostrados de los pagos de la capa de negocio
            List<Pago> pagos = new CN_Pago().Listar();

            // Recorre las formas de pagos existentes para elegir al momento de realizar una compra
            foreach (Pago pago in pagos)
            {
                cboPago.Items.Add(new OpcionesComboButton() { Valor = pago.Id_pago, Texto = pago.Nombre });
            }

            cboPago.DisplayMember = "Texto";
            cboPago.ValueMember = "Valor";
            cboPago.SelectedIndex = 0;

            textfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIndice.Text = "0";
        }

        // Actualiza el stock disponible que visualiza el vendedor
        private void ActualizarStock()
        {
            txtStockDisponible.Text = stockDisponible.ToString();
        }
        private void BorrarDatos()
        {
            txtIndice.Text = "-1";
            textProducto.Text = "";
            cantidad.Value = 1;
            textPrecio.Text = "";
            txtStockDisponible.Text = "";
            idMesa2.Text = "";
            idMesa.Text = "-1";
            cant.Text = "";
        }

        // Para calcular el total existente
        private void CalcularTotal()
        {
            decimal total = 0;
            // Si se agregan productos a la compra
            if (gridVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gridVentas.Rows)
                {
                    if (row.Cells["Subtotal"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["Subtotal"].Value.ToString());
                    }
                }
                textTotal.Text = total.ToString("0.00");
            }

            if (gridVentas.Rows.Count == 0)
            {
                total = 0;
                textTotal.Text = total.ToString("0.00");
            }
        }

        // Valida que solo sea caracteres numericos los de cantidad
        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '0')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void RestaurarStock()
        {
            // Asignar el stock inicial a txtStockDisponible
            txtStockDisponible.Text = stockDisponible.ToString();
        }

        private void textProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Busca en la lista de productos el codigo de producto y a su vez que este activo
                Producto producto = new CN_Producto().Listar().Where(p => p.Nombre == (textProducto.Text) && p.Activo == 1).FirstOrDefault();

                if (producto != null)
                {
                    txtIndice.Text = producto.Id_producto.ToString();
                    textProducto.Text = producto.Nombre.ToString();
                    textPrecio.Text = producto.Precio.ToString();
                    txtStockDisponible.Text = producto.Stock.ToString();

                    // Asigna el stock inicial a la variable local
                    stockDisponible = producto.Stock;
                    ActualizarStock(); // Muestra el valor en txtStockDisponible

                    textProducto.ReadOnly = true;
                    textPrecio.ReadOnly = true;

                    cantidad.Select();
                }
                else
                {
                    textProducto.BackColor = Color.MistyRose;
                    txtIndice.Text = "0";
                    textProducto.Text = "";
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridVentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Manejo para icono en cada una de las filas de los usuarios
            // Tamaño para adaptar a la fila
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            };
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new cdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIndice.Text = modal._Productos.Id_producto.ToString();
                    textProducto.Text = modal._Productos.Nombre.ToString();
                    textPrecio.Text = modal._Productos.Precio.ToString();
                    txtStockDisponible.Text = modal._Productos.Stock.ToString();

                    // Asigna el stock inicial a la variable local
                    stockDisponible = modal._Productos.Stock;
                    ActualizarStock(); // Muestra el valor en txtStockDisponible
                }
                else
                {
                    textProducto.Select();
                }
            }
        }

        private void gridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridVentas.Columns[e.ColumnIndex].Name == "btnSeleccion")
            {
                // Almacena la fila seleccionada
                int indice = e.RowIndex;

                // A partir de la fila seleccionada carga en cada uno de los campos, los datos del usuario elegido
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    textProducto.Text = gridVentas.Rows[indice].Cells["Producto"].Value.ToString();
                    textPrecio.Text = gridVentas.Rows[indice].Cells["Precio"].Value.ToString();
                    cantidad.Value = Convert.ToDecimal(gridVentas.Rows[indice].Cells["Stock"].Value);
                    txtStockDisponible.Text = stockDisponible.ToString();
                }
            }

            if (gridVentas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                // Almacena la fila seleccionada
                int indice = e.RowIndex;

                // A partir de la fila seleccionada carga en cada uno de los campos, los datos del usuario elegido
                if (indice >= 0)
                {
                    //Obtiene la cantidad del producto que se elimina
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(gridVentas.Rows[indice].Cells["Id"].Value.ToString()),
                        Convert.ToInt32(gridVentas.Rows[indice].Cells["Stock"].Value.ToString()));

                    if (respuesta)
                    {
                        txtStockDisponible.Text = "";
                        gridVentas.Rows.RemoveAt(indice);
                        CalcularTotal();
                        BorrarDatos();
                    }
                }
            }
        }

        private void textProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y teclas de control (como borrar)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (gridVentas.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos para generar una venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable detalle_factura = new DataTable();

            // Corresponde a la estructura de la tabla que he creado en la base de datos
            detalle_factura.Columns.Add("id_producto", typeof(int));
            detalle_factura.Columns.Add("cantidad", typeof(int));
            detalle_factura.Columns.Add("subtotal", typeof(decimal));
            detalle_factura.Columns.Add("precio", typeof(float));

            // Una vez efectuado la compra, agrega los valores del datatable en la bd
            foreach (DataGridViewRow row in gridVentas.Rows)
            {
                detalle_factura.Rows.Add(
                    new object[] {
                        Convert.ToInt32(row.Cells["Id"].Value.ToString()),
                        row.Cells["Stock"].Value.ToString(),
                        row.Cells["Subtotal"].Value.ToString(),
                        row.Cells["Precio"].Value.ToString(),
                    });
            }

            var selectedPago = cboPago.SelectedItem as OpcionesComboButton;

            Pedido oCompra = new Pedido()
            {
                Id_Usuario = new Usuario() { Id_Usuario = _usuario.Id_Usuario },
                Id_Pago = new Pago()
                {
                    Id_pago = Convert.ToInt32(selectedPago.Valor),
                    Nombre = selectedPago.Texto
                },
                Total = (float)Convert.ToDouble(textTotal.Text),
                Fecha = textfecha.Text,
                Id_Mesa = new Mesa()
                {
                    Id_Mesa = Convert.ToInt32(idMesa.Text),
                    Cap_Personas_Max = Convert.ToInt32(cant.Text)
                }
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oCompra, detalle_factura, out mensaje);
            if (respuesta)
            {
                var result = MessageBox.Show("Compra generada:\n" + "\n\n¿Desea descargar el ticket?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    string Texto_Html = Properties.Resources.plantilla.ToString();

                    Texto_Html = Texto_Html.Replace("@MOZO", textVendedor.Text);
                    Texto_Html = Texto_Html.Replace("@FECHA", textfecha.Text);
                    Texto_Html = Texto_Html.Replace("@PAGO", oCompra.Id_Pago.Nombre);
                    Texto_Html = Texto_Html.Replace("@PAGO", oCompra.Id_Pago.Nombre);

                    string filas = string.Empty;
                    foreach (DataGridViewRow row in gridVentas.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.Cells["Stock"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                        filas += "</tr>";
                    }

                    Texto_Html = Texto_Html.Replace("@FILAS", filas);
                    Texto_Html = Texto_Html.Replace("@TOTAL", textTotal.Text);

                    System.Windows.Forms.SaveFileDialog guardar = new System.Windows.Forms.SaveFileDialog();
                    guardar.FileName = string.Format("Venta_{0}.pdf", oCompra.Id_Pedido);
                    guardar.Filter = "PDF Files | *.pdf";

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                        {
                            Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdf, stream);
                            pdf.Open();

                            // Agregar los datos al documento pdf
                            using (StringReader sr = new StringReader(Texto_Html))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, sr);
                            }

                            pdf.Close();
                            stream.Close();
                            MessageBox.Show("PDF Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pedido generado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gridVentas.Rows.Clear();
                CalcularTotal();
                textTotal.Text = "0.00";
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            int cantSeleccionada = Convert.ToInt32(cantidad.Value.ToString());
            bool producto_existe = false;

            // Verifica previo a la carga del producto para la venta
            if (string.IsNullOrWhiteSpace(textProducto.Text))
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Valida que la cantidad ingresada no sea mayor al stock existente
            if (stockDisponible < cantSeleccionada)
            {
                MessageBox.Show("Stock insuficiente para la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida que la cantidad ingresada sea mayor a cero
            if (cantSeleccionada <= 0)
            {
                MessageBox.Show("La cantidad agregada debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Una vez que el mismo ya se haya agregado
            foreach (DataGridViewRow fila in gridVentas.Rows)
            {
                // Verifica que el producto ya haya sido agregado
                if (fila.Cells["Producto"].Value.ToString() == textProducto.Text)
                {
                    producto_existe = true;
                    MessageBox.Show("Producto ya existente modifique la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            if (!producto_existe)
            {
                decimal precioUnitarioAgregar = decimal.Parse(textPrecio.Text);
                decimal subtotalAgregar = cantidad.Value * precioUnitarioAgregar;
                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtIndice.Text),
                    cantSeleccionada);

                if (respuesta)
                {
                    gridVentas.Rows.Add(new object[] {
                        "", // Column1: puede ser el índice interno o un campo vacío
                        txtIndice.Text, // Id
                        textProducto.Text, // Producto
                        cantidad.Value.ToString(), // Stock (cantidad)
                        precioUnitarioAgregar.ToString("0.00"), // Precio
                        subtotalAgregar.ToString("0.00"), // Subtotal
                    });

                    CalcularTotal();
                    BorrarDatos();
                }
            }
        }

        private void cancelarCompra_Click(object sender, EventArgs e)
        {
            BorrarDatos();

            foreach (DataGridViewRow row in gridVentas.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                int cantidad = Convert.ToInt32(row.Cells["Stock"].Value.ToString());

                // Llama a la capa de negocio para sumar el stock
                bool resultado = new CN_Venta().SumarStock(idProducto, cantidad);

                if (!resultado)
                {
                    MessageBox.Show($"No se pudo restaurar el stock del producto con ID: {idProducto}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            gridVentas.Rows.Clear();
            textTotal.Text = "0.00";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var modal = new cdMesas())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    idMesa.Text = modal._Mesas.Id_Mesa.ToString();
                    idMesa2.Text = modal._Mesas.Id_Mesa.ToString();
                    cant.Text = modal._Mesas.Cap_Personas_Max.ToString();

                    // Asigna el stock inicial a la variable local
                }
            }
        }
    }
}
