using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace prybroker23
{
    public partial class frminicio : BaseForm
    {
        public frminicio()
        {
            InitializeComponent();
        }
        //metodo para crear nodos
        private TreeNode CrearArbol(DirectoryInfo directoryInfo)
        {
            TreeNode treeNode = new TreeNode(directoryInfo.Name);

            foreach (var item in directoryInfo.GetDirectories())
            {
                treeNode.Nodes.Add(CrearArbol(item));
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                treeNode.Nodes.Add(new TreeNode(item.Name));
            }
            return treeNode;
          
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelControlador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarradeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnapagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmregistrousuario frmregistrousuario = new frmregistrousuario();
            frmregistrousuario.Show();
            this.Hide();
        }

        private void verRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgrid frmgrid = new frmgrid();
            frmgrid.Show();
            this.Hide();
        }

        private void nuevoRegistroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmregistroproveedor frmregistroproveedor = new frmregistroproveedor();
            frmregistroproveedor.Show();
            this.Hide();
        }

        private void verRegistrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmgridproveedores frmgridproveedores = new frmgridproveedores();
            frmgridproveedores.Show();
            this.Hide();
        }
    }
}



