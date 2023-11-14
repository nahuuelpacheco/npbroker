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
    public partial class frmregistrousuario : Form
    {
        string varNombre;
        string varCategoria;
        AccesoDatos objBD;
        string varNombreUs, varContraseña;

        public frmregistrousuario(string belgrano, string belgrano1905)
        {
            InitializeComponent();
            varNombre = belgrano;
            varCategoria = belgrano1905;
            varNombre = belgrano;
        }

        private void frmregistrousuario_Load(object sender, EventArgs e)
            {
                // TODO: esta línea de código carga datos en la tabla 'eL_CLUBDataSet.USERS' Puede moverla o quitarla según sea necesario.
                this.sociosTableAdapter1.Fill(this.eL_CLUBDataSet1.SOCIOS);
                objBD = new AccesoDatos();
                objBD.ConectarBD();
            }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener el objeto DataRowView seleccionado
            DataRowView selectedDataRowView = cmbPerfiles.SelectedItem as DataRowView;

            if (selectedDataRowView != null)
            {
                if (varNombreUs != "" && varContraseña != "")
                {
                    // Acceder al valor de la columna deseada (en este caso, "perfil
                    string valorSeleccionado = selectedDataRowView["perfil"].ToString();
                    varNombreUs = txtNomUs.Text;
                    varContraseña = txtContUs.Text;
                    objBD.AgregarUsuario(varNombreUs, varContraseña, valorSeleccionado);
                }
                else
                {
                    MessageBox.Show("Todos los campos deben ser completados");
                    txtNomUs.Focus();
                }

            }
        }
    }
}
