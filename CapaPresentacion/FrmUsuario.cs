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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            textDocumento.KeyPress += textDocumento_KeyPress;
        }

        // INICIALIZACION DE FORMULARIO
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // Valores para ser mostrados en el estado de un empleado
            cboEstado.Items.Add(new OpcionesComboButton() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionesComboButton() { Valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;


            // Valores para ser mostrados en el rol de un empleado de la capa de negocio
            List<CapaEntidad.Rol> listaRoles = new CN_Rol().Listar();

            // Recorre los roles de usuarios existentes para elegir al momento de crear un empleado
            List<CapaEntidad.Rol> Rol = new CN_Rol().Listar().Where(c => c.Activo != 0).ToList();

            // Recorre las categorias de productos existentes para elegir al momento de crear un producto
            foreach (CapaEntidad.Rol roles in Rol)
            {
                cboRol.Items.Add(new OpcionesComboButton() { Valor = roles.Id_Rol, Texto = roles.Nombre });
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedItem = 0;


            // Busqueda de datos de usuarios
            foreach (DataGridViewColumn columns in gridProductos.Columns)
            {
                if (columns.Name == "Nombre" || columns.Name == "Estado" || columns.Name == "Rol")
                {
                    cboBusqueda.Items.Add(new OpcionesComboButton() { Valor = columns.Name, Texto = columns.HeaderText });
                }

                cboBusqueda.DisplayMember = "Texto";
                cboBusqueda.ValueMember = "Valor";
            }

            // Mostrar todos los productos
            List<Usuario> listaUsuarios = new CN_Usuario().Listar();

            // Recorre los roles de productos existentes para elegir al momento de crear un producto
            foreach (Usuario usuario in listaUsuarios)
            {
                gridProductos.Rows.Add(new object[] {"", usuario.Id_Usuario, usuario.DNI,
                                       usuario.Nombre, usuario.Apellido,
                                       usuario.Fecha_Incorporación.ToString("dd/MM/yyyy"),
                                       usuario.rol.Id_Rol,
                                       usuario.rol.Nombre,
                                       usuario.Activo == 1 ? "Activo" : "No Activo",
                                       usuario.Activo == 1 ? 1 : 0,
                                       });
            }
        }

        // METODO DE CREAR Y EDITAR USUARIO
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string mensaje = string.Empty;

            // Obtiene todos los datos ingresados en los diferentes campos
            Usuario usuario = new Usuario()
            {
                    Id_Usuario = Convert.ToInt32(textId.Text),
                    Nombre = textNombre.Text,
                    Apellido = textApellido.Text,
                    Contraseña = textContrasenia.Text,
                    DNI = Convert.ToInt32(textDocumento.Text),
                    rol = new Rol() { Id_Rol = Convert.ToInt32(((OpcionesComboButton)cboRol.SelectedItem).Valor) },
                    Activo = Convert.ToInt32(((OpcionesComboButton)cboEstado.SelectedItem).Valor),
                    Fecha_Incorporación = Convert.ToDateTime(gridProductos.Rows[Convert.ToInt32(txtIndice.Text)].Cells["Fecha"].Value),
            };

            // Para crear un usuario
            if (usuario.Id_Usuario == 0)
            {
                // Metodo pertenenciente a la capa de negocio
                int registroUsuario = new CN_Usuario().Registrar(usuario, out mensaje);

                if (registroUsuario != 0)
                {

                    // Muestra los datos ingresados en el data grid view
                    gridProductos.Rows.Add(new object[] {"", registroUsuario, textDocumento.Text, textNombre.Text, textApellido.Text,
                                                   usuario.Fecha_Incorporación = DateTime.Now.Date,
                                                   ((OpcionesComboButton)cboRol.SelectedItem).Valor.ToString(),
                                                   ((OpcionesComboButton)cboRol.SelectedItem).Texto.ToString(),
                                                   ((OpcionesComboButton)cboEstado.SelectedItem).Texto.ToString(),
                                                   ((OpcionesComboButton)cboEstado.SelectedItem).Valor.ToString(),});
                    BorrarDatos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                bool resultado = new CN_Usuario().Editar(usuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = gridProductos.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = textId.Text;
                    row.Cells["DNI"].Value = textDocumento.Text;
                    row.Cells["Nombre"].Value = textNombre.Text;
                    row.Cells["Apellido"].Value = textApellido.Text;
                    row.Cells["IdRol"].Value = ((OpcionesComboButton)cboRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionesComboButton)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionesComboButton)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionesComboButton)cboEstado.SelectedItem).Texto.ToString();

                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    BorrarDatos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    BorrarDatos();
                }
            }
        }

        // Funcion creada que permite validar cada uno de los campos
        private bool ValidarCampos()
        {
            // Verificar si hay campos vacíos
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textDocumento.Text) ||
                string.IsNullOrWhiteSpace(textApellido.Text) ||
                string.IsNullOrWhiteSpace(textContrasenia.Text))
            {
                MessageBox.Show("Todos los campos deben ser rellenados.", "Error carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Validar nombre
            bool nombreValido = System.Text.RegularExpressions.Regex.IsMatch(textNombre.Text, @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+$");
            if (!nombreValido)
            {
                MessageBox.Show("El nombre no es válido. Debe contener solo letras.", "Error carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Validar contraseña
            bool contraseñaValida = Regex.IsMatch(textContrasenia.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");

            if (!contraseñaValida)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir una letra mayúscula, una minúscula, un número y un carácter especial.",
                                "Error en la contraseña",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return false;
            }

            // Validar apellido
            bool apellidoValido = System.Text.RegularExpressions.Regex.IsMatch(textApellido.Text, @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+$");
            if (!apellidoValido)
            {
                MessageBox.Show("El apellido no es válido. Debe contener solo letras.", "Error carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Validar nombre de usuario (exactamente 5 caracteres)
            bool usuarioValido = textDocumento.Text.Length == 8;
            if (!usuarioValido)
            {
                MessageBox.Show("El DNI del usuario debe tener exactamente 8 caracteres.", "Error carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Si todas las validaciones son correctas
            return true;
        }

        // Funcion creada para borrar los datos ingresados en los campos
        private void BorrarDatos()
        {
            txtIndice.Text = "-1";
            textId.Text = "0";
            textNombre.Text = "";
            textApellido.Text = "";
            textDocumento.Text = "";
            cboRol.SelectedIndex = 0;
            cboRol.SelectedIndex = 0;
            cboBusqueda.SelectedItem = null;
            textContrasenia.Text = "";

            // Para marcar el usuario recien agregado o editado
            textDocumento.Select();
        }

        // Boton para limpiar los campos cargados
        private void limpiarCampos_Click(object sender, EventArgs e)
        {
            BorrarDatos();
        }

        // FUNCION PARA BUSQUEDAS
        private void iconBusqueda_Click(object sender, EventArgs e)
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

        private void iconBorrar_Click(object sender, EventArgs e)
        {
            // Limpia el texto de busqueda ingresado
            textBusqueda.Text = "";
            cboBusqueda.SelectedItem = null;

            // Recorre cada fila del grid de usuarios para mostrar todos los usuarios existentes
            foreach (DataGridViewRow row in gridProductos.Rows)
            {
                row.Visible = true;
            }
        }

        // METODO PARA ELIMINAR UN USUARIO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textId.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el usuario?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Usuario usuario = new Usuario()
                    {
                        Id_Usuario = Convert.ToInt32(textId.Text),
                        Activo = 0
                    };

                    bool respuesta = new CN_Usuario().Eliminar(usuario, out mensaje);

                    if (respuesta)
                    {
                        foreach (DataGridViewRow row in gridProductos.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["Id"].Value) == usuario.Id_Usuario)
                            {
                                row.Cells["EstadoValor"].Value = usuario.Activo.ToString();
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

        private void textApellido_TextChanged(object sender, EventArgs e)
        {
            // Expresión para permitir solo letras (incluyendo acentos y la ñ) y espacios
            string pattern = @"[^a-zA-ZñÑáéíóúÁÉÍÓÚ\s]";

            // Remover caracteres que no coincidan con la expresión
            textApellido.Text = System.Text.RegularExpressions.Regex.Replace(textApellido.Text, pattern, "");
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            // Expresión para permitir solo letras(incluyendo acentos y la ñ) y espacios
            string pattern = @"[^a-zA-ZñÑáéíóúÁÉÍÓÚ\s]";

            // Remover caracteres que no coincidan con la expresión
            textNombre.Text = System.Text.RegularExpressions.Regex.Replace(textNombre.Text, pattern, "");
        }

        private void textContrasenia_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";

            bool esValida = System.Text.RegularExpressions.Regex.IsMatch(textContrasenia.Text, pattern);

            if (esValida)
            {
                textContrasenia.BackColor = System.Drawing.Color.White;  // válido
            }
            else
            {
                textContrasenia.BackColor = System.Drawing.Color.LightCoral;  // inválido
            }
        }

        private void textDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y tecla de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

            // Limitar la longitud máxima a 8 caracteres
            if (char.IsDigit(e.KeyChar) && textDocumento.Text.Length >= 8)
            {
                e.Handled = true; // No permite más caracteres
            }
        }

        // Botón para seleccionar un producto
        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && gridProductos.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                // Almacena la fila seleccionada
                int indice = e.RowIndex;

                // A partir de la fila seleccionada carga en cada uno de los campos, los datos del producto elegido
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    textId.Text = gridProductos.Rows[indice].Cells["Id"].Value.ToString();
                    textNombre.Text = gridProductos.Rows[indice].Cells["Nombre"].Value.ToString();
                    textApellido.Text = gridProductos.Rows[indice].Cells["Apellido"].Value.ToString();
                    textDocumento.Text = gridProductos.Rows[indice].Cells["DNI"].Value.ToString();

                    // Para obtener el tipo de categoria correspondiente al producto
                    foreach (OpcionesComboButton opciones in cboEstado.Items)
                    {
                        if (Convert.ToInt32(opciones.Valor) == Convert.ToInt32(gridProductos.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(opciones);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    // Para obtener el tipo de estado correspondiente al producto
                    foreach (OpcionesComboButton estado in cboRol.Items)
                    {
                        if (Convert.ToInt32(estado.Valor) == Convert.ToInt32(gridProductos.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cboRol.Items.IndexOf(estado);
                            cboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void gridProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Manejo para icono en cada una de las filas de las categorias
            // Tamaño para adaptar a la fila
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.comprobado.Width;
                var h = Properties.Resources.comprobado.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.comprobado, new Rectangle(x, y, w, h));
                e.Handled = true;
            };
        }
    }
}
