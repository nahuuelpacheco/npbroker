using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declaro libreia de escritura y lectura de archivos//
using System.IO;
using System.Windows.Forms;


namespace prybroker23
{
    class clsdatosproveedor
    {
        public string NombreArchivoAsegurados = @"../../bin/Debug/Proveedores/datosProveedor.csv";
        public void grabar(string numero, string entidad, string Apertura, string numexpediente, string juzg, string jurisd, string direccion, string liquidador)
        {
            StreamWriter Archivo = new StreamWriter(NombreArchivoAsegurados, true); //ABRIR ARCHIVO

            Archivo.Write(numero);
            Archivo.Write(";");
            Archivo.Write(entidad);
            Archivo.Write(";");
            Archivo.Write(Apertura);
            Archivo.Write(";");
            Archivo.Write(numexpediente);
            Archivo.Write(";");
            Archivo.Write(juzg);
            Archivo.Write(";");
            Archivo.Write(jurisd);
            Archivo.Write(";");
            Archivo.Write(direccion);
            Archivo.Write(";");
            Archivo.WriteLine(liquidador); //WRITELINE PARA QUE SALTE LA LINEA SIGUIENTE 
            Archivo.Close(); //CIERRO ARCHIVO
            Archivo.Dispose();//Liberar Memoria 
        }
        public void listar(DataGridView Grilla)
        {
            //creo vector para poder vizualisar correctamente los datos en la grilla 
            string[] vecdatos = new string[8];
            //variable vacio
            string Leerdatos = "";
            //Limpieza de grilla
            Grilla.Rows.Clear();
            //lectura de archivo 
            StreamReader Archivo = new StreamReader(NombreArchivoAsegurados);
            //Lectura por linea 
            Leerdatos = Archivo.ReadLine();

            while (Leerdatos != null)
            {
                //cargo los datos en el vector
                vecdatos = Leerdatos.Split(';');
                //cargar datos en grilla
                Grilla.Rows.Add(vecdatos[0], vecdatos[1], vecdatos[2], vecdatos[3], vecdatos[4], vecdatos[5], vecdatos[6], vecdatos[7]);
                //leer archivo
                Leerdatos = Archivo.ReadLine();
            }
            Archivo.Close(); //CIERRO ARCHIVO
            Archivo.Dispose();//Liberar Memoria 
        }

    }
}
