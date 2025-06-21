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
    public partial class FrmMesas : Form
    {
        public FrmMesas()
        {
            InitializeComponent();
        }

        // Carga el formulario
        private void FrmMesas_Load(object sender, EventArgs e)
        {
            // Cargar estado en ComboBox
            cboestado.Items.Add(new OpcionesComboButton() { Valor = 1, Texto = "No Ocupado" });
            cboestado.Items.Add(new OpcionesComboButton() { Valor = 0, Texto = "Ocupado" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            cboEstado2.Items.Add(new OpcionesComboButton() { Valor = 1, Texto = "Activo" });
            cboEstado2.Items.Add(new OpcionesComboButton() { Valor = 0, Texto = "No Activo" });
            cboEstado2.DisplayMember = "Texto";
            cboEstado2.ValueMember = "Valor";
            cboEstado2.SelectedIndex = 0;

            // Busqueda de datos de categorias
            foreach (DataGridViewColumn columns in gridCategorias.Columns)
            {
                if (columns.Name == "Estado" || columns.Name == "Nro Mesa")
                {
                    cboBusqueda.Items.Add(new OpcionesComboButton() { Valor = columns.Name, Texto = columns.HeaderText });
                }

                cboBusqueda.DisplayMember = "Texto";
                cboBusqueda.ValueMember = "Valor";
            }

            // Mostrar todos los categorias
            List<Mesa> listaMenu = new CN_Mesa().Listar();

            // Recorre los roles de categorias existentes para elegir al momento de crear un empleado
            foreach (Mesa menu in listaMenu)
            {
                gridCategorias.Rows.Add(new object[] {"", menu.Id_Mesa, menu.Cap_Personas_Max,
                           menu.Ocupado == 1 ? 1 : 0,
                           menu.Ocupado == 1 ? "No Ocupado" : "Ocupado",
                           menu.Activo == 1 ? 1 : 0,
                           menu.Activo == 1 ? "Activo" : "No Activo" });
            }
        }

        // Boton para guardar los datos ingresados
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string mensaje = string.Empty;

            // Obtiene todos los datos ingresados en los diferentes campos
            Mesa mesa = new Mesa()
            {
                Id_Mesa = Convert.ToInt32(textId.Text),
                Cap_Personas_Max = Convert.ToInt32(txtnombre.Text),
                Ocupado = Convert.ToInt32(((OpcionesComboButton)cboestado.SelectedItem).Valor),
                Activo = Convert.ToInt32(((OpcionesComboButton)cboEstado2.SelectedItem).Valor),
            };

            if (mesa.Id_Mesa == 0)
            {
                // Método perteneciente a la capa de negocio
                int registroCategoria = new CN_Mesa().Registrar(mesa, out mensaje);

                if (registroCategoria != 0)
                {
                    // Mostrar los datos ingresados en el DataGridView
                    gridCategorias.Rows.Add(new object[] { "", registroCategoria, txtnombre.Text,
                                                                ((OpcionesComboButton)cboestado.SelectedItem).Valor.ToString(),
                                                                ((OpcionesComboButton)cboestado.SelectedItem).Texto.ToString(),
                                                                ((OpcionesComboButton)cboEstado2.SelectedItem).Valor.ToString(),
                                                                ((OpcionesComboButton)cboEstado2.SelectedItem).Texto.ToString()});

                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                BorrarDatos();
            }
            else
            {
                bool resultado = new CN_Mesa().Editar(mesa, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = gridCategorias.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionesComboButton)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionesComboButton)cboestado.SelectedItem).Texto.ToString();
                    row.Cells["Estado2"].Value = ((OpcionesComboButton)cboEstado2.SelectedItem).Texto.ToString();

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
        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            // Expresión regular que permite solo números enteros (sin letras ni símbolos)
            string pattern = @"[^0-9]";

            // Reemplaza cualquier cosa que no sea número por vacío
            txtnombre.Text = System.Text.RegularExpressions.Regex.Replace(txtnombre.Text, pattern, "");

            // Coloca el cursor al final para evitar que salte al principio
            txtnombre.SelectionStart = txtnombre.Text.Length;
        }

        // Funcion creada para borrar los datos ingresados en los campos
        private void BorrarDatos()
        {
            txtIndice.Text = "-1";
            textId.Text = "0";
            txtnombre.Text = "";
            cboestado.SelectedIndex = 0;
            cboEstado2.SelectedIndex = 0;
            txtnombre.Select();

            // Para marcar la categoria recien agregado o editado
            txtnombre.Select();
        }
        private void limpiarCampos_Click(object sender, EventArgs e)
        {
            BorrarDatos();
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
            bool nombreValido = Regex.IsMatch(txtnombre.Text, @"^[0-9]+$");
            if (!nombreValido)
            {
                MessageBox.Show("La cantidad de personas por mesa no es válido. Debe contener solo numeros.", "Error carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Si todas las validaciones son correctas
            return true;
        }

        // Evento para buscar en el DataGridView
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

        // Evento para limpiar el campo de busqueda
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

                    // Para obtener el tipo de estado correspondiente a la categoria
                    foreach (OpcionesComboButton Estado2 in cboEstado2.Items)
                    {
                        if (Convert.ToInt32(Estado2.Valor) == Convert.ToInt32(gridCategorias.Rows[indice].Cells["EstadoValor2"].Value))
                        {
                            int indice_combo = cboEstado2.Items.IndexOf(Estado2);
                            cboEstado2.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números (y teclas de control como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                MessageBox.Show("Solo se permiten números enteros.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textId.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar la Mesa?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Mesa mesa = new Mesa()
                    {
                        Id_Mesa = Convert.ToInt32(textId.Text),
                        Activo = 0
                    };

                    bool respuesta = new CN_Mesa().Eliminar(mesa, out mensaje);

                    if (respuesta)
                    {
                        foreach (DataGridViewRow row in gridCategorias.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["Id"].Value) == mesa.Id_Mesa)
                            {
                                row.Cells["EstadoValor2"].Value = mesa.Activo.ToString();
                                row.Cells["Estado2"].Value = "No Activo";
                                break;
                            }
                        }
                        // Mensaje de confirmación
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        BorrarDatos();
                    }
                    else
                    {
                        // Mensaje de error
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void limpiarCampos_Click_1(object sender, EventArgs e)
        {
            BorrarDatos();
        }
    }
}
