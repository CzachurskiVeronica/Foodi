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
using CapaDatos;
using System.Windows.Controls;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Asigna el evento KeyDown a los TextBox
            //this.textUsuario.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            //this.textPassword.KeyDown += new KeyEventHandler(TextBox_KeyDown);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Permite cerrar el formulario de login
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            IngresarAlSistema();
        }

        private void IngresarAlSistema()
        {
            // Permite ingresar a la pagina inicio con el boton de ingresar
            try
            {
                // Verifica que los campos no esten vacios
                if (!string.IsNullOrEmpty(textUsuario.Text) && !string.IsNullOrEmpty(textPassword.Text))
                {
                    var listaUsuarios = new CN_Usuario().Listar();

                    Usuario userData = listaUsuarios.Where(user => user.DNI == Convert.ToInt32(textUsuario.Text)).FirstOrDefault();

                    // Si se ha encontrado el usuario
                    if (userData != null)
                    {
                        // En caso de que el usuario no se halle activo
                        if (userData.Activo == 0)
                        {
                            MessageBox.Show("Usuario dado de baja", "Baja de Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            // Encriptar la contraseña ingresada
                            string encriptarPasswordIngresado = new CD_Usuario().EncriptarPassword(textPassword.Text);

                            if (userData.Contraseña == encriptarPasswordIngresado)
                            {
                                Inicio form = new Inicio(userData);
                                form.Show();
                                this.Hide();
                                form.FormClosing += Frm_close;
                            } // Si se halla activo pero la contraseña se ha ingresado de forma incorrecta
                            else
                            {
                                MessageBox.Show("Contraseña Incorrecta", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else // Si no se encuentra el usuario
                    {
                        MessageBox.Show("Usuario no registrado", "Error de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    // Muestra mensaje de error en caso de que los campos se hallen vacios
                    MessageBox.Show("Debe completar todos los campos", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void Frm_close(object sender, FormClosingEventArgs e)
        {
            // Limpia los datos cargados en los TextBox
            textPassword.Text = "";
            textUsuario.Text = "";

            // Vuelve a mostrar el formulario de login
            this.Show();
        }

        private void textUsuario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnIngresar.PerformClick(); // Simula el clic del botón
                e.Handled = true;
            }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            string original = textUsuario.Text;
            string soloNumeros = System.Text.RegularExpressions.Regex.Replace(original, @"[^\d]", "");

            if (original != soloNumeros)
            {
                int cursorPos = textUsuario.SelectionStart - 1;
                textUsuario.Text = soloNumeros;
                textUsuario.SelectionStart = Math.Max(cursorPos, 0);
            }
        }

        private void BtnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnIngresar.PerformClick();  // Simula el clic del botón
                e.Handled = true;
            }
        }
    }
}
