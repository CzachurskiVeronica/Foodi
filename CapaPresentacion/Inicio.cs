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
        }

        // Carga el formulario de inicio
        private void Inicio_Load(object sender, EventArgs e)
        {
            // Concatena los datos referentes al usuario
            labelUsuario.Text = actualUser.Nombre + " " + actualUser.Apellido;
        }

        // Abre el formulario
        private void AbrirForm(IconMenuItem menu, Form formulario)
        {
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
    }
}
