using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace prybroker23
{
    class clsAccesoDatos
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public string estadoConexion = "";
        public string datosTabla = "";

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "Conectado";

            }
            catch (Exception EX)
            {
                estadoConexion = "Error:" + EX.Message;
            }
        }

        public void TraerDatos(DataGridView grilla)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Apellido", "Apellido");
            grilla.Columns.Add("Pais", "Pais");



            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[0];
                    grilla.Rows.Add(lectorBD[1], lectorBD[2], lectorBD[3]);
                }
            }
        }
    }
}
