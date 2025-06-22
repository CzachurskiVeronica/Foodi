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

namespace CapaPresentacion.Modales
{
    public partial class cdProducto : Form
    {
        public Producto _Productos { get; set; }
        public cdProducto()
        {
            InitializeComponent();
        }

        private void cdProducto_Load(object sender, EventArgs e)
        {
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

            // Recorre los roles de productos existentes para elegir al momento de comprar un producto
            // Productos que se hallen activos
            foreach (Producto productos in listaProductos)
            {
                if (productos.Activo == 1)
                {
                    gridProductos.Rows.Add(new object[] {productos.Id_producto, productos.Nombre, productos.Stock, productos.Stock_min,
                                                    productos.Precio, productos.Menu.Nombre});
                }
            }
        }

        private void iconBusqueda_Click_1(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una columna para buscar
            if (cboBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir una columna por la cual realizar la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Termina el método si no se selecciona una columna
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

        private void iconBorrar_Click_1(object sender, EventArgs e)
        {
            // Limpia el texto de busqueda ingresado
            textBusqueda.Text = "";

            // Recorre cada fila del grid de usuarios para mostrar todos los usuarios existentes
            foreach (DataGridViewRow row in gridProductos.Rows)
            {
                row.Visible = true;
            }
        }

        private void gridProductos_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol >= 0)
            {
                _Productos = new Producto()
                {
                    Id_producto = Convert.ToInt32(gridProductos.Rows[iRow].Cells["Id"].Value.ToString()),
                    Nombre = gridProductos.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(gridProductos.Rows[iRow].Cells["Stock"].Value.ToString()),
                    Stock_min = Convert.ToInt32(gridProductos.Rows[iRow].Cells["Stock_min"].Value.ToString()),
                    Precio = Convert.ToDecimal(gridProductos.Rows[iRow].Cells["Precio"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
