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
    public partial class frmElClub : Form
    {
        clsAccesoDatos objBaseDatos;
        public frmElClub()
        {
            InitializeComponent();
        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmElClub_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsAccesoDatos();
            objBaseDatos.ConectarBD();
            lblEstadoConexion.Text = objBaseDatos.estadoConexion;
            lblDatos.Text = objBaseDatos.datosTabla;
            objBaseDatos.TraerDatos(dgvGrilla);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarPorID(int.Parse(txtBuscar.Text));
        }
    }
}
