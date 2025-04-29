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
using Menu = CapaEntidad.Menu;

namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            // Cargar estado en ComboBox
            cboestado.Items.Add(new OpcionesComboButton() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionesComboButton() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            // Busqueda de datos de categorias
            foreach (DataGridViewColumn columns in gridCategorias.Columns)
            {
                if (columns.Name == "Estado" || columns.Name == "Nombre")
                {
                    cboBusqueda.Items.Add(new OpcionesComboButton() { Valor = columns.Name, Texto = columns.HeaderText });
                }

                cboBusqueda.DisplayMember = "Texto";
                cboBusqueda.ValueMember = "Valor";
            }

            // Mostrar todos los categorias
            List<Menu> listaMenu = new CN_Menu().Listar();

            // Recorre los roles de categorias existentes para elegir al momento de crear un empleado
            foreach (Menu menu in listaMenu)
            {
                gridCategorias.Rows.Add(new object[] {"", menu.Id_Menu, menu.Nombre,
                           menu.Activo == 1 ? 1 : 0,
                           menu.Activo == 1 ? "Activo" : "No Activo" });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string mensaje = string.Empty;

            // Obtiene todos los datos ingresados en los diferentes campos
            Menu menu = new Menu()
            {
                Id_Menu = Convert.ToInt32(textId.Text),
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
                    gridCategorias.Rows.Add(new object[] { "", registroCategoria, txtnombre.Text,
                                                                ((OpcionesComboButton)cboestado.SelectedItem).Valor.ToString(),
                                                                ((OpcionesComboButton)cboestado.SelectedItem).Texto.ToString()});

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
                    DataGridViewRow row = gridCategorias.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionesComboButton)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionesComboButton)cboestado.SelectedItem).Texto.ToString();

                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BorrarDatos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                BorrarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textId.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el Menu?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Menu categoria = new Menu()
                    {
                        Id_Menu = Convert.ToInt32(textId.Text),
                        Activo = 0
                    };

                    bool respuesta = new CN_Menu().Eliminar(categoria, out mensaje);

                    if (respuesta)
                    {
                        foreach (DataGridViewRow row in gridCategorias.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["Id"].Value) == categoria.Id_Menu)
                            {
                                row.Cells["EstadoValor"].Value = categoria.Activo.ToString();
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

        // Funcion creada para borrar los datos ingresados en los campos
        private void BorrarDatos()
        {
            txtIndice.Text = "-1";
            textId.Text = "0";
            txtnombre.Text = "";
            cboestado.SelectedIndex = 0;
            txtnombre.Select();

            // Para marcar la categoria recien agregado o editado
            txtnombre.Select();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            // Expresión para permitir solo letras (incluyendo acentos y la ñ) y espacios
            string pattern = @"[^a-zA-ZñÑáéíóúÁÉÍÓÚ\s]";

            // Remover caracteres que no coincidan con lo requerido
            txtnombre.Text = System.Text.RegularExpressions.Regex.Replace(txtnombre.Text, pattern, "");
        }

        private void limpiarCampos_Click(object sender, EventArgs e)
        {
            BorrarDatos();
        }

        private void gridCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCategorias.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                // Almacena la fila seleccionada
                int indice = e.RowIndex;

                // A partir de la fila seleccionada carga en cada uno de los campos, los datos del usuario elegido
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    textId.Text = gridCategorias.Rows[indice].Cells["Id"].Value.ToString();
                    txtnombre.Text = gridCategorias.Rows[indice].Cells["Nombre"].Value.ToString();

                    // Para obtener el tipo de estado correspondiente a la categoria
                    foreach (OpcionesComboButton estado in cboestado.Items)
                    {
                        if (Convert.ToInt32(estado.Valor) == Convert.ToInt32(gridCategorias.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(estado);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

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

            if (gridCategorias.Rows.Count > 0)
            {
                // Recorre cada fila del grid de usuarios
                foreach (DataGridViewRow row in gridCategorias.Rows)
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
            foreach (DataGridViewRow row in gridCategorias.Rows)
            {
                row.Visible = true;
            }
        }

        // Funcion creada que permite validar cada uno de los campos
        private bool ValidarCampos()
        {
            // Verificar si hay campos vacíos
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Todos los campos deben ser rellenados.", "Error carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Validar nombre
            bool nombreValido = System.Text.RegularExpressions.Regex.IsMatch(txtnombre.Text, @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+$");
            if (!nombreValido)
            {
                MessageBox.Show("El nombre no es válido. Debe contener solo letras.", "Error carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Si todas las validaciones son correctas
            return true;
        }
    }
}
