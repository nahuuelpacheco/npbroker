using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prybroker23
{
    public partial class frmregistroproveedor : BaseForm
    {
        public frmregistroproveedor()
        {
            InitializeComponent();
        }

        private void frmregistroproveedor_Load(object sender, EventArgs e)
        {

        }
        clsdatosproveedor guardar = new clsdatosproveedor();

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar.grabar(txtN.Text, txtEntidad.Text, txtApertura.Text, txtNExpediente.Text, txtJuzg.Text, txtJurisd.Text, txtDireccion.Text, txtLiquidadorResponsable.Text); //llamo al procedimiento de clase que cree anteriormente 

            MessageBox.Show("Datos guardados correctamente");

            //Limpiar campos
            txtN.Text = "";
            txtEntidad.Text = "";
            txtApertura.Text = "";
            txtNExpediente.Text = "";
            txtJuzg.Text = "";
            txtJurisd.Text = "";
            txtDireccion.Text = "";
            txtLiquidadorResponsable.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frminicio frminicio = new frminicio();
            frminicio.Show();
        }
    }
}


