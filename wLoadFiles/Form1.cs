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


namespace wLoadFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stream myStream;
        int counter = 0;
        string line;

        private void cmdPorLineas_Click(object sender, EventArgs e)
        {
            // Este metodo permite cargar el archivo línea a línea,
            // diferente al proyecto anterior donde primero se carga a una variable y luego
            // se lleva a un control tipo texto.

            XmlDocument Doc = new XmlDocument();
            XmlElement raiz = Doc.CreateElement("libros");
            Doc.AppendChild(raiz);
            XmlElement libro = Doc.CreateElement("libro");
            raiz.AppendChild(libro);
            XmlElement titulo = Doc.CreateElement("titulo");
            titulo.AppendChild(Doc.CreateTextNode("si"));
            libro.AppendChild(titulo);

            XmlElement precio = Doc.CreateElement("titulo");
            titulo.AppendChild(Doc.CreateTextNode("si"));
            libro.AppendChild(titulo);

            Doc.Save("c:\\xml\\archivo.xml");
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivos (*.txt)|*.txt|(*xml)|*.xml|*All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                            while ((line = file.ReadLine()) != null)
                            {
                                txtArchivo.Text = txtArchivo.Text + line;
                                counter++;
                            }

                            file.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
          
                }
            }
        }

        private void gparchivo_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCSV_Click(object sender, EventArgs e)
        {
            //Configurar datagridview - Número de columnas
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Columna1";
            col1.Width = 200;
            col1.ReadOnly = true;
            dtGCSV.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Columna2";
            col2.Width = 200;
            col2.ReadOnly = true;
            dtGCSV.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Columna3";
            col3.Width = 200;
            col3.ReadOnly = true;
            dtGCSV.Columns.Add(col3);


            char delimitador = ';';
            string[] valores; 

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivos (*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                            while ((line = file.ReadLine()) != null)
                            {
                                valores = line.Split(delimitador);
                                
                                dtGCSV.Rows.Add(valores.ToArray());
                                //txtArchivo.Text = txtArchivo.Text + line;
                                //counter++;
                            }

                            file.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
