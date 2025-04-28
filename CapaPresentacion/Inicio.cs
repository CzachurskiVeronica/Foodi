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

        public Inicio(Usuario obj_user)
        {
            actualUser = obj_user;

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // Concatena los datos referentes al usuario
            labelUsuario.Text = actualUser.Nombre + " " + actualUser.Apellido;
        }
    }
}
