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
    public partial class frmgrid : BaseForm
    {
        public frmgrid()
        {
            InitializeComponent();
        }
        //declaro objeto
        clsdatos x = new clsdatos();

        private void frmgrid_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerRegistro_Click(object sender, EventArgs e)
        {
            x.listar(Dgv);
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frminicio frminicio = new frminicio();
            frminicio.Show();
        }
    }
}
