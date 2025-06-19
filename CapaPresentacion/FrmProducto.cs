using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Instalaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        // Carga el formulario de productos
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            // Cargar estado en ComboBox
            cboestado.Items.Add(new OpcionesComboButton() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionesComboButton() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;


            List<CapaEntidad.Menu> listaMenu = new CN_Menu().Listar();

            // Valores para ser mostrados de la categoria de la capa de negocio
            List<CapaEntidad.Menu> Menu = new CN_Menu().Listar().Where(c => c.Activo != 0).ToList();

            // Recorre las categorias de productos existentes para elegir al momento de crear un producto
            foreach (CapaEntidad.Menu menus in Menu)
            {
                cbomenu.Items.Add(new OpcionesComboButton() { Valor = menus.Id_Menu, Texto = menus.Nombre });
            }
            cbomenu.DisplayMember = "Texto";
            cbomenu.ValueMember = "Valor";
            cbomenu.SelectedItem = 0;

            
            // Busqueda de datos de productos
            foreach (DataGridViewColumn columns in gridProductos.Columns)
            {
                if (columns.Name == "Nombre" || columns.Name == "Estado" || columns.Name == "Menu")
                {
                    cboBusqueda.Items.Add(new OpcionesComboButton() { Valor = columns.Name, Texto = columns.HeaderText });
                }

                cboBusqueda.DisplayMember = "Texto";
                cboBusqueda.ValueMember = "Valor";
            }
            
            // Mostrar todos los productos
            List<Producto> listaProductos = new CN_Producto().Listar();

            // Recorre los roles de productos existentes para elegir al momento de crear un producto
            foreach (Producto productos in listaProductos)
            {
                gridProductos.Rows.Add(new object[] {"", productos.Id_producto, productos.Nombre,
                                       productos.Descripcion, productos.Precio,
                                       productos.Stock, productos.Stock_min, 
                                       productos.Menu.Id_Menu, productos.Menu.Nombre,
                                       productos.Activo == 1 ? "Activo" : "No Activo",
                                       productos.Activo == 1 ? 1 : 0,
                                       });
            }
        }

        // Botón para guardar los datos del producto
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string mensaje = string.Empty;

            // Crea un objeto de tipo Producto para almacenar los datos
            Producto producto = new Producto()
            {
                Id_producto = Convert.ToInt32(textId.Text),
                Nombre = txtnombre.Text.Trim(),
                Descripcion = txtdescripcion.Text.Trim(),
                Precio = Convert.ToDecimal(txtprecio.Text),
                Stock = Convert.ToInt32(txtstock.Text),
                Stock_min = Convert.ToInt32(txtstockmin.Text),
                Activo = Convert.ToInt32(((OpcionesComboButton)cboestado.SelectedItem).Valor),
                Menu = new CapaEntidad.Menu()
                {
                    Id_Menu = Convert.ToInt32(((OpcionesComboButton)cbomenu.SelectedItem).Valor)
                }
            };

            if (producto.Id_producto == 0)
            {
                // Registro nuevo
                int registroProducto = new CN_Producto().Registrar(producto, out mensaje);

                if (registroProducto != 0)
                {
                    // Agrega el nuevo producto a la grilla
                    gridProductos.Rows.Add(new object[]
                    {"", registroProducto, producto.Nombre, producto.Descripcion, producto.Precio.ToString("N2"),
                                                    producto.Stock,
                                                    producto.Stock_min,
                                                   ((OpcionesComboButton)cbomenu.SelectedItem).Valor.ToString(),
                                                   ((OpcionesComboButton)cbomenu.SelectedItem).Texto.ToString(),
                                                                                                      ((OpcionesComboButton)cboestado.SelectedItem).Texto.ToString(),
                                                   ((OpcionesComboButton)cboestado.SelectedItem).Valor.ToString(),
                    });
                    // Muestra el mensaje de éxito
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Muestra el mensaje de error
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                BorrarDatos();
            }
            else
            {
                // Edición
                bool resultado = new CN_Producto().Editar(producto, out mensaje);

                if (resultado)
                {
                    if (int.TryParse(txtIndice.Text, out int indiceFila) && indiceFila >= 0)
                    {
                        DataGridViewRow row = gridProductos.Rows[indiceFila];
                        row.Cells["Id"].Value = textId.Text;
                        row.Cells["Nombre"].Value = txtnombre.Text;
                        row.Cells["Descripcion"].Value = txtdescripcion.Text;
                        row.Cells["Precio"].Value = txtprecio.Text;
                        row.Cells["Stock"].Value = txtstock.Text;
                        row.Cells["StockMin"].Value = txtstockmin.Text;
                        row.Cells["IdMenu"].Value = ((OpcionesComboButton)cbomenu.SelectedItem).Valor.ToString();
                        row.Cells["Menu"].Value = ((OpcionesComboButton)cbomenu.SelectedItem).Texto.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionesComboButton)cboestado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionesComboButton)cboestado.SelectedItem).Texto.ToString();
                    }
                    // Muestra el mensaje de éxito
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Muestra el mensaje de error
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                BorrarDatos();
            }
        }

        // Botón para limpiar los campos
        private void BorrarDatos()
        {
            txtIndice.Text = "-1";
            textId.Text = "0";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtstockmin.Text = "";
            cbomenu.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

            // Para marcar el producto recien agregado o editado
            txtnombre.Select();
        }

        // Botón para validar los campos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIndice.Text))
            {
                MessageBox.Show("Por favor, ingrese el código del producto.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIndice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del producto.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                MessageBox.Show("Por favor, ingrese la descripción del producto.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdescripcion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtprecio.Text) || !decimal.TryParse(txtprecio.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtprecio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtstock.Text) || !int.TryParse(txtstock.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un stock válido.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtstock.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtstockmin.Text) || !int.TryParse(txtstockmin.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un stock mínimo válido.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtstockmin.Focus();
                return false;
            }

            if (cbomenu.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un menú.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomenu.Focus();
                return false;
            }

            if (cboestado.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un estado.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboestado.Focus();
                return false;
            }

            return true;
        }

        // Botón para buscar productos
        private void iconBusqueda_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una columna para buscar
            if (cboBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir una columna por la cual realizar la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Filtros de busqueda si coinciden debe poder listar la busuqeda realizada
            string filtroColumna = ((OpcionesComboButton)cboBusqueda.SelectedItem).Valor.ToString();

            if (gridProductos.Rows.Count > 0)
            {
                // Recorre cada fila del grid de usuarios
                foreach (DataGridViewRow row in gridProductos.Rows)
                {
                    if (row.Cells[filtroColumna].Value.ToString().Trim().ToUpper().Contains(textBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        // Botón para limpiar el campo de búsqueda
        private void iconBorrar_Click(object sender, EventArgs e)
        {
            // Limpia el texto de busqueda ingresado
            textBusqueda.Text = "";
            cboBusqueda.SelectedItem = null;

            // Recorre cada fila del grid de productos para mostrar todos los productos existentes
            foreach (DataGridViewRow row in gridProductos.Rows)
            {
                row.Visible = true;
            }
        }

        private void limpiarCampos_Click_1(object sender, EventArgs e)
        {
            BorrarDatos();
        }

        private void gridProductos_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {

        }

        // Botón para seleccionar un producto
        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProductos.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                // Almacena la fila seleccionada
                int indice = e.RowIndex;

                // A partir de la fila seleccionada carga en cada uno de los campos, los datos del producto elegido
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    textId.Text = gridProductos.Rows[indice].Cells["Id"].Value.ToString();
                    txtnombre.Text = gridProductos.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtdescripcion.Text = gridProductos.Rows[indice].Cells["Descripcion"].Value.ToString();
                    txtstock.Text = gridProductos.Rows[indice].Cells["Stock"].Value.ToString();
                    txtstockmin.Text = gridProductos.Rows[indice].Cells["StockMin"].Value.ToString();
                    txtprecio.Text = gridProductos.Rows[indice].Cells["Precio"].Value.ToString();

                    // Para obtener el tipo de categoria correspondiente al producto
                    foreach (OpcionesComboButton opciones in cbomenu.Items)
                    {
                        if (Convert.ToInt32(opciones.Valor) == Convert.ToInt32(gridProductos.Rows[indice].Cells["IdMenu"].Value))
                        {
                            int indice_combo = cbomenu.Items.IndexOf(opciones);
                            cbomenu.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    // Para obtener el tipo de estado correspondiente al producto
                    foreach (OpcionesComboButton estado in cboestado.Items)
                    {
                        if (Convert.ToInt32(estado.Valor) == Convert.ToInt32(gridProductos.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(estado);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        // Botón para eliminar un producto
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textId.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el producto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Producto producto = new Producto()
                    {
                        Id_producto = Convert.ToInt32(textId.Text),
                        Activo = 0
                    };

                    bool respuesta = new CN_Producto().Eliminar(producto, out mensaje);

                    if (respuesta)
                    {
                        foreach (DataGridViewRow row in gridProductos.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["Id"].Value) == producto.Id_producto)
                            {
                                row.Cells["EstadoValor"].Value = producto.Activo.ToString();
                                row.Cells["Estado"].Value = "No Activo";
                                break;
                            }
                        }
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        BorrarDatos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // Validación de campos para que solo se ingresen números
        private void txtstock_TextChanged(object sender, EventArgs e)
        {
            // Permite solo números
            string pattern = @"[^\d]";

            // Remover caracteres que no coincidan solo números
            txtstock.Text = System.Text.RegularExpressions.Regex.Replace(txtstock.Text, pattern, "");
        }

        // Validación de campos para que solo se ingresen números y una coma
        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

            // Permite solo números y una coma
            string pattern = @"[^\d,]";

            // Remover caracteres que no sean números o coma
            txtprecio.Text = System.Text.RegularExpressions.Regex.Replace(txtprecio.Text, pattern, "");
        }

        // Validación de campos para que solo se ingresen números
        private void txtstockmin_TextChanged(object sender, EventArgs e)
        {
            // Permite solo números
            string pattern = @"[^\d]";

            // Remover caracteres que no coincidan solo números
            txtstockmin.Text = System.Text.RegularExpressions.Regex.Replace(txtstockmin.Text, pattern, "");
        }
    }
}
