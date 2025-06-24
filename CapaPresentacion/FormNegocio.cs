using CapaDatos;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
//using System.Componentnegocio;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormNegocio : Form
    {
        private CD_Negocio negocio;
        public FormNegocio()
        {
            InitializeComponent();
            //Default - Last 7 days
            fechaInicio.Value = DateTime.Today.AddDays(-7);
            fechaFin.Value = DateTime.Now;
            boton7.Select();
            negocio = new CD_Negocio();
            LoadData();
        }

        private void FormNegocio_Load(object sender, EventArgs e)
        {

        }

        //Private methods
        private void LoadData()
        {
            var refreshData = negocio.CargaDatos(fechaInicio.Value, fechaFin.Value);
            if (refreshData == true)
            {
                lblNumOrders.Text = negocio.TotalVentas.ToString();
                lblTotalRecaudado.Text = "$" + negocio.TotalRecaudado.ToString();

                lblProductos.Text = negocio.NumProductos.ToString();

                chartRecaudacion.DataSource = negocio.Recaudacion;
                chartRecaudacion.Series[0].XValueMember = "Date";
                chartRecaudacion.Series[0].YValueMembers = "Importe_total";
                chartRecaudacion.DataBind();

                chartProductos.DataSource = negocio.ProductosVendidos;
                chartProductos.Series[0].XValueMember = "Key";
                chartProductos.Series[0].YValueMembers = "Value";
                chartProductos.DataBind();

                prodFaltantes.DataSource = negocio.ProductosFaltantes;
                prodFaltantes.Columns[0].HeaderText = "Nombre";
                prodFaltantes.Columns[1].HeaderText = "Stock";

                chartEmpleado.DataSource = negocio.Empleado;
                chartEmpleado.Series[0].XValueMember = "Key";
                chartEmpleado.Series[0].YValueMembers = "Value";
                chartEmpleado.DataBind();

                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void DisableCustomDates()
        {
            fechaInicio.Enabled = false;
            fechaFin.Enabled = false;
            OK.Visible = false;
        }
        //Event methods

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            fechaInicio.Enabled = true;
            fechaFin.Enabled = true;
            OK.Visible = true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            // Verifica que la fecha de fin no sea menor que la fecha de inicio
            if (fechaFin.Value >= fechaInicio.Value)
            {
                LoadData();
            }
            else
            {
                // Muestra un mensaje de error si la fecha de fin es menor que la fecha de inicio
                MessageBox.Show("La fecha de fin no puede ser menor que la fecha de inicio.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            fechaInicio.Value = DateTime.Today.AddDays(-7);
            fechaFin.Value = DateTime.Now;
            LoadData();
        }

        private void boton30_Click(object sender, EventArgs e)
        {
            fechaInicio.Value = DateTime.Today.AddDays(-30);
            fechaFin.Value = DateTime.Now;
            LoadData();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Restablece los valores de fecha al rango de los últimos 7 días
            fechaInicio.Value = DateTime.Today.AddDays(-7);
            fechaFin.Value = DateTime.Now;

            // Vuelve a seleccionar el botón por defecto
            boton7.Select();

            // Recarga los datos
            LoadData();
        }
    }
}
