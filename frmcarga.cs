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
    public partial class frmcarga : BaseForm

    {
        string Nombre;
        string categoria;
        public frmcarga(string varNombre, string varCat)
        {
            InitializeComponent();
            InitializeComponent();
            categoria = varCat;
            Nombre = varNombre;
            

        }

        private void frmcarga_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                progressBar1.Increment(5);

                if (progressBar1.Value == progressBar1.Maximum)
                {
                    timer1.Stop();

                      this.Hide();
                    frmlogin formlogin = new frmlogin();
                   formlogin.Show();
                }
            }
        }
    }
}
 

