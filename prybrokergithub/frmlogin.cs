using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace prybroker23
{
    public partial class frmlogin : BaseForm
    {
        public frmlogin()
        {
            InitializeComponent();
            this.AcceptButton = btnIngresar;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            {
                if (txtUsuario.Text == "Usuario")
                {
                    txtUsuario.Text = "";
                    txtUsuario.ForeColor = Color.Silver;
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            {
                if (txtUsuario.Text == "")
                {
                    txtUsuario.Text = "Usuario";
                    txtUsuario.ForeColor = Color.Silver;
                }
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            {
                if (txtContraseña.Text == "Contraseña")
                {
                    txtContraseña.Text = "";
                    txtContraseña.ForeColor = Color.LightGray;
                    txtContraseña.UseSystemPasswordChar = true;
                }
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            {
                if (txtContraseña.Text == "")
                {
                    txtContraseña.Text = "Contraseña";
                    txtContraseña.ForeColor = Color.Silver;
                    txtContraseña.UseSystemPasswordChar = true;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            {
                Int32 Intentos = 0;
                if (txtUsuario.Text == "Administrador" && txtContraseña.Text == "Administrador")
                {
                    this.Hide();
                    frminicio frmmain = new frminicio();
                    frmmain.Show();
                }
                else
                {
                    MessageBox.Show("DATOS INCORRECTOS.");
                    Intentos++;
                    if (Intentos == 5)
                    {
                        this.Close();
                    }
                }

            }
        }
    }
}

