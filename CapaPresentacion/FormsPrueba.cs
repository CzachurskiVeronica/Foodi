using CapaPresentacion.Properties;
//using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace CapaPresentacion
{
    public partial class FormsPrueba : Form
    {
        public FormsPrueba()
        {
            InitializeComponent();
            CargarPdf();
        }

        private void CargarPdf()
        {
            string rutaPDF = @"C:\Users\38137513\source\repos\Foodi\CapaPresentacion\Resources\Manual de Usuario.pdf";

            try
            {
                // Asegúrate de que la ruta del archivo PDF sea correcta
                if (System.IO.File.Exists(rutaPDF))
                {
                    // Cargar el PDF en el WebBrowser
                    webBrowser2.Navigate(rutaPDF);
                }
                else
                {
                    MessageBox.Show("El archivo PDF no se encontró en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el PDF: " + ex.Message);
            }
        }

        private void FormsPrueba_Load(object sender, EventArgs e)
        {

        }
    }
}
