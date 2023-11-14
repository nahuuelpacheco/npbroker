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

namespace prybroker23
{
    public partial class frmeliminar : Form
    {
        string varNombre;
        string varCategoria;

        public frmeliminar(string belgrano, string belgrano1905)
        {
            InitializeComponent();
            varNombre = belgrano;
            varCategoria = belgrano1905;
        }

        OpenFileDialog ofD = new OpenFileDialog();
        string rutaArchivo = string.Empty;
        // Obtiene el directorio actual de la aplicación
        string directorioActual = Application.StartupPath;

        private void frmEliminar_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            //Retrocede dos carpetas 
            for (int i = 0; i < 2; i++)
            {
                directorioActual = System.IO.Directory.GetParent(directorioActual).FullName;
            }
            //al directorio actual le suma/combina la carpeta "resources" + proveedores
            directorioActual = System.IO.Path.Combine(directorioActual, "Resources");

            //marca donde se inicializa el OpenFileDialog
            ofD.InitialDirectory = directorioActual;
            ofD.Filter = "Carpetas|*.folder";


            if (ofD.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = ofD.FileName;
            }

            lblRuta.Text = rutaArchivo;


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿ Está seguro que desea borrar el archivo:  " + rutaArchivo + " ?", "Eliminar archivo", MessageBoxButtons.OKCancel);


            if (result == DialogResult.OK)
            {
                if (File.Exists(rutaArchivo))
                {
                    File.Delete(rutaArchivo);
                }


            }

        }
    }
}




