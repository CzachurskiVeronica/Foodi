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
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

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

            /*
            // Busqueda de datos de productos
            foreach (DataGridViewColumn columns in gridProductos.Columns)
            {
                if (columns.Name == "Nombre" || columns.Name == "Codigo Producto" || columns.Name == "Estado" || columns.Name == "Categoria")
                {
                    cboBusqueda.Items.Add(new OpcionesComboButton() { Valor = columns.Name, Texto = columns.HeaderText });
                }

                cboBusqueda.DisplayMember = "Texto";
                cboBusqueda.ValueMember = "Valor";
            }
            */

            // Mostrar todos los productos
            List<Producto> listaProductos = new CN_Producto().Listar();

            // Recorre los roles de productos existentes para elegir al momento de crear un producto
            foreach (Producto productos in listaProductos)
            {
                gridProductos.Rows.Add(new object[] {"", productos.Id_producto, productos.Nombre,
                                       productos.Descripcion, productos.Precio, productos.Activo == 1 ? 1 : 0,
                                       productos.Activo == 1 ? "Activo" : "No Activo", productos.Stock, productos.Stock_min, 
                                       productos.Menu.Id_Menu, productos.Menu.Nombre,
                                        });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string mensaje = string.Empty;

            Producto producto = new Producto()
            {
                Id_producto = Convert.ToInt32(txtcodigo.Text),
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
                int idGenerado = new CN_Producto().Registrar(producto, out mensaje);

                if (idGenerado != 0)
                {
                    gridProductos.Rows.Add(new object[]
                    {
                "",
                idGenerado,
                producto.Nombre,
                producto.Descripcion,
                producto.Precio.ToString("N2"),
                producto.Activo,
                producto.Activo == 1 ? "Activo" : "No Activo",
                producto.Stock,
                producto.Stock_min,
                producto.Menu.Id_Menu,
                ((OpcionesComboButton)cbomenu.SelectedItem).Texto
                    });

                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
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
                    if (int.TryParse(txtindice.Text, out int indiceFila) && indiceFila >= 0)
                    {
                        DataGridViewRow row = gridProductos.Rows[indiceFila];
                        row.Cells["Id"].Value = txtcodigo.Text;
                        row.Cells["Nombre"].Value = txtnombre.Text;
                        row.Cells["Descripcion"].Value = txtdescripcion.Text;
                        row.Cells["Precio"].Value = txtprecio.Text;
                        row.Cells["Stock"].Value = txtstock.Text;
                        row.Cells["Stock_min"].Value = txtstockmin.Text;
                        row.Cells["Id_Menu"].Value = ((OpcionesComboButton)cbomenu.SelectedItem).Valor.ToString();
                        row.Cells["Menu"].Value = ((OpcionesComboButton)cbomenu.SelectedItem).Texto.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionesComboButton)cboestado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionesComboButton)cboestado.SelectedItem).Texto.ToString();
                    }

                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                BorrarDatos();
            }
        }

        private void BorrarDatos()
        {
            txtindice.Text = "-1";
            //txtid.Text = "0";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtstockmin.Text = "";
            cbomenu.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

            txtnombre.Select();
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtcodigo.Text))
            {
                MessageBox.Show("Por favor, ingrese el código del producto.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcodigo.Focus();
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


















    }
}
