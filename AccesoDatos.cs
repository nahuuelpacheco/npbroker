﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace prybroker23
{
    public class AccesoDatos
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        public string varNom;
        string varEstado;
        string varSexo;
        public string estadoDeConexion;

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";
        int varContador;

        public AccesoDatos()
        {
            varContador = 0;
        }

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoDeConexion = "Conectado";

            }
            catch (Exception EX)
            {
                estadoDeConexion = "Error:" + EX.Message;
            }
        }

        public void TraerDatos(DataGridView grilla)
        {

            ConectarBD();
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();

            grilla.Columns.Add("ID", "ID");
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Apellido", "Apellido");
            grilla.Columns.Add("Pais", "Pais");
            grilla.Columns.Add("Edad", "Edad");
            grilla.Columns.Add("Sexo", "Sexo");
            grilla.Columns.Add("Ingreso", "Ingreso");
            grilla.Columns.Add("Puntaje", "Puntaje");
            grilla.Columns.Add("Estado", "Estado");

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    //cargo la grilla con valores de activo/inactivo para que no aparezca true o false
                    if ((bool)lectorBD[8] == true)
                    {
                        varEstado = "Activo";
                    }
                    else
                    {
                        varEstado = "Inactivo";
                    }

                    //cargo la grilla con valores de Masculino/Femenino para que no aparezca true o false
                    if ((bool)lectorBD[5] == true)
                    {
                        varSexo = "Masculino";
                    }
                    else
                    {
                        varSexo = "Femenino";
                    }

                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], varSexo, lectorBD[6], lectorBD[7], varEstado);
                }
            }
        }
        public void ValidarUsuario(string varNombre, string varContraseña, Form frm)
        {

            comandoBD = new OleDbCommand();
            int intentosMaximos = 3;
            bool usuarioEncontrado = false;

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "USERS";

            lectorBD = comandoBD.ExecuteReader();

            while (lectorBD.Read())
            {
                string nombreDB = lectorBD[1].ToString();
                string contraseñaDB = lectorBD[2].ToString();


                if (nombreDB == varNombre && contraseñaDB == varContraseña)
                {
                    string varCat = lectorBD[3].ToString();

                    varNom = varNombre;
                    MessageBox.Show("Datos correctos");
                    frm.Hide();
                    frmcarga frmcarga = new frmcarga(varNombre, varCat);
                    frmcarga.Show();
                    usuarioEncontrado = true;
                    break;
                }
            }

            if (!usuarioEncontrado)
            {
                varContador++;
                MessageBox.Show("Datos de inicio de sesión incorrectos");

                if (varContador >= intentosMaximos)
                {
                    MessageBox.Show("Demasiados intentos de inicio de sesión, el sistema se cerrará");
                    Application.Exit();
                }
            }
        }
        public void BuscarPorId(string codigo, DataGridView dgvMostrar)
        {
            comandoBD = new OleDbCommand();
            //bandera=false;
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();


            if (lectorBD.HasRows) //SI TIENE FILAS
            {
                bool bandera = false;
                if (codigo == "")
                {
                    MessageBox.Show("ingrese un numero");
                    bandera = true;
                }
                else
                {
                    while (lectorBD.Read()) //mientras pueda leer que ejecute el sig codigo
                    {
                        if ((lectorBD[0].ToString()) == codigo) //Si el codigo ingresado por pantalla es igual a la primera posicion del registro
                        {
                            //cargo la grilla con valores de activo/inactivo para que no aparezca true o false
                            if ((bool)lectorBD[8] == true)
                            {
                                varEstado = "Activo";
                            }
                            else
                            {
                                varEstado = "Inactivo";
                            }

                            //cargo la grilla con valores de Masculino/Femenino para que no aparezca true o false
                            if ((bool)lectorBD[5] == true)
                            {
                                varSexo = "Masculino";
                            }
                            else
                            {
                                varSexo = "Femenino";
                            }

                            dgvMostrar.Rows.Clear();
                            dgvMostrar.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], varSexo, lectorBD[6], lectorBD[7], varEstado);
                            bandera = true;
                            break;
                        }

                    }
                }

                if (bandera == false)
                {

                    MessageBox.Show("el ID ingresado no existe", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
            }
        }
        public void ModificarEstado(int id)
        {

            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter objda;
            DataSet objds = new DataSet();// objeto DataSetas usar

            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            // establecer las propiedades al objeto comando
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            // crear el objeto DataAdapter pasando como parámetroel objeto comando que queremos vincular
            objda = new OleDbDataAdapter(comandoBD);

            // ejecutar la lectura de la tabla y almacenarsu contenido en el dataAdapter

            objda.Fill(objds, "SOCIOS");


            // obtenemos una referencia a la tabla de SOCIOS
            DataTable dt = objds.Tables["SOCIOS"];

            // recorrer los registros de la tabla

            foreach (DataRow registro in dt.Rows)
            { // buscar el Socio con el ID ingresado por pantalla

                if ((int)registro["CODIGO_SOCIO"] == id)
                {
                    // establecer el modo de edición del DataRow
                    registro.BeginEdit();

                    // asignamos el nuevo valor al estado del socio 
                    if ((bool)registro["ESTADO"])
                    {
                        registro["ESTADO"] = false;
                    }
                    else
                    {
                        registro["ESTADO"] = true;
                    }

                    // finalizamos el modo edición sobre delDataRow
                    registro.EndEdit();
                    break;// salir del foreach
                }


            }
            // creamos el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
            OleDbCommandBuilder cb = new OleDbCommandBuilder(objda);

            // actualizamos la base con los cambios realizados

            objda.Update(objds, "SOCIOS");

            MessageBox.Show("Estado cambiado con éxito!!");

        }
        public void AgregarUsuario(string varNombreUs, string contraseñaUs, string rolUs)
        {
            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter objda;
            DataSet objds = new DataSet();// objeto DataSetas usar

            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            // establecer las propiedades al objeto comando
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "USERS";

            // crear el objeto DataAdapter pasando como parámetroel objeto comando que queremos vincular
            objda = new OleDbDataAdapter(comandoBD);

            // ejecutar la lectura de la tabla y almacenar su contenido en el dataAdapter

            objda.Fill(objds, "USERS");

            // obtenemos una referencia a la tabla de USERS
            DataTable tabla = objds.Tables["USERS"];

            // creamos el nuevo DataRow con la estructurade campos de la tabla USERS

            DataRow nuevoRegistro = tabla.NewRow();

            // asignamos los valores a todos los campos delDataRow
            nuevoRegistro["nombreUsuario"] = varNombreUs;
            nuevoRegistro["contraseña"] = contraseñaUs;
            nuevoRegistro["perfil"] = rolUs;

            // agregamos el DataRow a la tabla USERS
            tabla.Rows.Add(nuevoRegistro);

            // creamos el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
            OleDbCommandBuilder cb = new OleDbCommandBuilder(objda);
            // actualizamos la base con los cambios realizados
            objda.Update(objds, "USERS");

            MessageBox.Show("Usuario creado con exito");
        }
    }

}



