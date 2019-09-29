using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Practica2.ArchivosTextoYBinarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtener numero decimal equivalente a un cierto numero de bytes en Archivo
        /// </summary>
        /// <param name="nombreArchivo"> Archivo del cual se obtendra el numero</param>
        /// <param name="numeroBytesDeDato"> Numero de bytes que se tomaran en cuenta</param>
        /// <param name="byteInicioEnArchivo"> Numero del Byte a partir del cual se obtendra el numero</param>
        /// <returns></returns>
        private UInt32 obtenerDato(string nombreArchivo, int numeroBytesDeDato, int byteInicioEnArchivo)
        {
            UInt32 dato = 0;
            FileStream archivo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            BinaryReader leer = new BinaryReader(archivo);
            for (int x = numeroBytesDeDato - 1; x >= 0 ; x--)
                {
                    archivo.Seek(byteInicioEnArchivo + x, SeekOrigin.Begin);
                    dato <<= 8;
                    dato += leer.ReadByte();
                }
            leer.Close();
            archivo.Close();
            return dato;
        }

        /// <summary>
        /// Generar archivo XML
        /// </summary>
        /// <param name="file"> Nombre del Archivo que tendra el XML</param>
        /// <param name="datos"> Value´s de todos los campos ingresados</param>
        /// <param name="campos"> Campos solicitados</param>
        private void crearXML(string file, string[] datos, string[] campos)
        {
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true; // aplicar sangria al archivo
            xmlSettings.NewLineOnAttributes = true; // se escribiran en nueva linea
            XmlWriter xmlWriter = XmlWriter.Create(file, xmlSettings);

            xmlWriter.WriteStartDocument(); // header de XML

            xmlWriter.WriteStartElement("Agenda"); //etiqueta de apertura

            xmlWriter.WriteStartElement("Registro"); //subetiquta

            for (int x = 0; x < campos.Length; x++)
            {
                xmlWriter.WriteStartElement(campos[x]); //subetiqueta
                xmlWriter.WriteString(datos[x]);
                xmlWriter.WriteEndElement(); //cierre de subetiqueta
            }

            xmlWriter.WriteEndElement(); //cierre subetiqueta

            xmlWriter.WriteEndElement(); //cierre etiqueta de apertura

            xmlWriter.Close();

        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            txtbxArchivoBMP.Clear();
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Abrir Archivo";
            abrir.Filter = "Archivos BMP (*.bmp)|*.bmp";
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                byte BMP = 0; 

                FileStream archivo = new FileStream(abrir.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader leer = new BinaryReader(archivo);

                for (int x = 0; x < 2; x++) BMP += leer.ReadByte(); // leemos los dos primeros bytes

                leer.Close();
                archivo.Close();

                if (BMP == 0x8F) // validamos si los dos primeros bytes son BM
                {
                    txtbxArchivoBMP.Text = abrir.FileName;
                    txtbxTamaño.Text = obtenerDato(abrir.FileName, 4, 2).ToString();
                    txtbxAncho.Text = obtenerDato(abrir.FileName, 4, 18).ToString();
                    txtbxAlto.Text = obtenerDato(abrir.FileName, 4, 22).ToString();
                    txtbxBPP.Text = obtenerDato(abrir.FileName, 2, 28).ToString();
                }
                else
                    MessageBox.Show("Archivo seleccionado no es tipo BMP", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerarXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo xml (*.xml)|*.xml";
            save.ShowDialog();

            string[] campos = { "nombre", "apellido", "telefono", "codigo_postal", "Edad" };
            string[] datos = { txtbxNombre.Text, txtbxApellido.Text, txtbxTelefono.Text, txtbxCP.Text, txtbxEdad.Text };

            crearXML(save.FileName, datos, campos);
        }
    }
}
