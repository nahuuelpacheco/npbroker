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
    public partial class frmABMSocios : Form
    {
        public frmABMSocios(string belgrano, string belgrano1905)
        {

            InitializeComponent();
            varNombre = belgrano;
            varCategoria = belgrano1905;
        }
        
        AccesoDatos objBD;

        string varNombre;
        string varCategoria;
        int varID;

        private void frmABMSocios_Load(object sender, EventArgs e)
        {
            {
                objBD = new AccesoDatos();
                objBD.ConectarBD();
                objBD.TraerDatos(dgvMostrar);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            objBD.BuscarPorId(txtID.Text, dgvMostrar);
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            varID = Convert.ToInt32(txtIdEstado.Text);
            objBD.ModificarEstado(varID);
            dgvMostrar.Columns.Clear();
            dgvMostrar.Rows.Clear();
            objBD.TraerDatos(dgvMostrar);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmeliminar frmeliminar = new frmeliminar(varNombre,varCategoria);
            this.Hide();
            frmeliminar.Show();
        }
    }
}
;