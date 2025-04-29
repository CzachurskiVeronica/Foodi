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
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Instalaciones;
using Menu = CapaEntidad.Menu;
using static System.Net.Mime.MediaTypeNames;


namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            // Cargar estado en ComboBox
            cboestado.Items.Add(new OpcionesComboButton() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionesComboButton() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            // Obtener lista de menús desde la capa de negocio
            List<Menu> listaMenu = new CN_Menu().Listar();

            // Limpiar filas existentes por si acaso
            dataGridView1.Rows.Clear();

            // Cargar filas en el orden correcto: Id, Nombre, Estado
            foreach (Menu menu in listaMenu)
            {
                dataGridView1.Rows.Add(new object[]
                {
            "",                            // Celda vacía (por ejemplo, para botón)
            menu.Id_Menu,                 // Columna "Id"
            menu.Nombre,                 // Columna "Nombre"
            menu.Activo == 1 ? "Activo" : "No Activo"  // Columna "Estado"
                });
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Obtiene todos los datos ingresados en los diferentes campos
            Menu menu = new Menu()
            {
                Nombre = txtnombre.Text,
                Activo = Convert.ToInt32(((OpcionesComboButton)cboestado.SelectedItem).Valor),
            };

            if (menu.Id_Menu == 0)
            {
                // Método perteneciente a la capa de negocio
                int registroCategoria = new CN_Menu().Registrar(menu, out mensaje);

                if (registroCategoria != 0)
                {
                    // Mostrar los datos ingresados en el DataGridView
                    dataGridView1.Rows.Add(new object[] { "", registroCategoria, txtnombre.Text,
                ((OpcionesComboButton)cboestado.SelectedItem).Texto.ToString()
            });

                    MessageBox.Show("¡Registro exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                BorrarDatos();
            }
            else
            {
                bool resultado = new CN_Menu().Editar(menu, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dataGridView1.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["Estado"].Value = ((OpcionesComboButton)cboestado.SelectedItem).Texto.ToString();

                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarDatos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void BorrarDatos()
        {
            txtnombre.Text = "";
            cboestado.SelectedIndex = 0;
            txtnombre.Select();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }
    }
}
