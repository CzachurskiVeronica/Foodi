using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        // Variable global con datos de user actual
        private static Usuario actualUser;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        // Toma los valores del usuario actual
        public Inicio(Usuario obj_user)
        {
            actualUser = obj_user;

            InitializeComponent();
            SetDoubleBuffered(contenedor);
        }

        // Método auxiliar para habilitar el doble buffer en cualquier control
        public void SetDoubleBuffered(Control control)
        {
            System.Reflection.PropertyInfo doubleBufferPropertyInfo =
                  control.GetType().GetProperty("DoubleBuffered",
                  System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            doubleBufferPropertyInfo.SetValue(control, true, null);
        }

        // Carga el formulario de inicio
        private void Inicio_Load(object sender, EventArgs e)
        {
            // Asigna el cursor de mano a los íconos del menú
            usuario.MouseEnter += Icon_MouseEnter;
            reportes.MouseEnter += Icon_MouseEnter;
            productos.MouseEnter += Icon_MouseEnter;
            carta.MouseEnter += Icon_MouseEnter;
            pedidos.MouseEnter += Icon_MouseEnter;
            mesas.MouseEnter += Icon_MouseEnter;
            pagos.MouseEnter += Icon_MouseEnter;
            menuacerca.MouseEnter += Icon_MouseEnter;

            // Se obtiene la funcion de poder obtener los roles que el usuario actual posee
            List<Rol> rolesUsuario = new CN_Rol().Permisos(actualUser.rol.Id_Rol);

            usuario.Visible = false;
            productos.Visible = false;
            pedidos.Visible = false;
            mesas.Visible = false;
            pagos.Visible = false;
            carta.Visible = false;
            reportes.Visible = false;

            // Rutas que el usuario podra navegar si es Administrador
            if (rolesUsuario.Any(rol => rol.Id_Rol == 3))
            {
                usuario.Visible = true;
                reportes.Visible = true;
            }

            // Rutas que el usuario podra navegar si es Encargado
            if (rolesUsuario.Any(rol => rol.Id_Rol == 2))
            {
                carta.Visible = true;
                mesas.Visible = true;
                pagos.Visible = true;
                pedidos.Visible = true;
                productos.Visible = true;
            }

            // Rutas que el usuario podra navegar si es Mozo
            if (rolesUsuario.Any(rol => rol.Id_Rol == 1))
            {
                pedidos.Visible = true;
            }

            // Concatena los datos referentes al usuario
            labelUsuario.Text = actualUser.Nombre + " " + actualUser.Apellido;
        }

        // Abre el formulario
        private void AbrirForm(IconMenuItem menu, Form formulario)
        {
            // Antes de cerrar el formulario activo, restauramos el stock
            if (FormularioActivo is FrmVentas formVentas)
            {
                // gridVentas es accesible desde formVentas
                for (int i = 0; i < formVentas.gridVentas.Rows.Count; i++)
                {
                    // Obtener el id y el stock del producto actual
                    int idProducto = Convert.ToInt32(formVentas.gridVentas.Rows[i].Cells["idproducto"].Value);
                    int stockActual = Convert.ToInt32(formVentas.gridVentas.Rows[i].Cells["Stock"].Value);

                    // Restaurar el stock
                    bool respuesta = new CN_Venta().SumarStock(idProducto, stockActual);
                }
            }

            // Cuando no se selecciona un menu no se modifica el BackColor
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            // Si se ha seleccionado un menu especifico se modifica el BackColor
            menu.BackColor = Color.White;
            MenuActivo = menu;

            // En caso de cambiar la vista de los formularios, los mismos se cierran
            FormularioActivo?.Close();

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            // Abre la pestaña de empleados
            AbrirForm((IconMenuItem)sender, new FrmUsuario());
        }

        private void menumenu_Click(object sender, EventArgs e)
        {
            AbrirForm((IconMenuItem)sender, new FrmMenu());
        }

        private void menuproductos_Click(object sender, EventArgs e)
        {
            AbrirForm((IconMenuItem)sender, new FrmProducto());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Icon_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el cursor a mano cuando pase el mouse sobre el ítem
            this.Cursor = Cursors.Hand;
        }

        private void Icon_MouseLeave(object sender, EventArgs e)
        {
            // Vuelve el cursor a su estado predeterminado cuando salga del ítem
            this.Cursor = Cursors.Default;
        }
        private void menuacerca_MouseEnter(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void menuproductos_MouseEnter(object sender, EventArgs e)
        {

        }

        private void menumenu_MouseEnter(object sender, EventArgs e)
        {

        }

        private void menuusuario_MouseEnter(object sender, EventArgs e)
        {

        }

        private void iconMesas_Click(object sender, EventArgs e)
        {
            AbrirForm((IconMenuItem)sender, new FrmMesas());
        }

        private void iconPagos_Click(object sender, EventArgs e)
        {
            AbrirForm((IconMenuItem)sender, new FrmPago());
        }

        private void iconVenta_Click(object sender, EventArgs e)
        {
            AbrirForm((IconMenuItem)sender, new FrmVentas(actualUser));
        }

        private void reportes_Click(object sender, EventArgs e)
        {
            AbrirForm((IconMenuItem)sender, new FormNegocio());
        }
    }
}
