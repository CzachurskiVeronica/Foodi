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
    }
}
