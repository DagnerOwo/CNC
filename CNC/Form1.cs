using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectArchivo_Click(object sender, EventArgs e)
        {
            string coordenadayxz = "XYZ";
            if (!string.IsNullOrWhiteSpace(txtCoordenada.Text) & !string.IsNullOrWhiteSpace(txtResta.Text) & float.TryParse(txtResta.Text, out float resta) & coordenadayxz.Contains(txtCoordenada.Text.ToUpper())){
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                var filePath = string.Empty;
                var fileContent = string.Empty;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    try
                    {
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            string line = string.Empty;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line.Contains(txtCoordenada.Text.ToUpper()))
                                {
                                    float coordenada = 0;
                                    bool coordEncontrada = false;
                                    string coordenadaStr = string.Empty;
                                    char[] lineArray = line.ToCharArray();
                                    foreach (char ch in lineArray)
                                    {
                                        if (ch == char.Parse(txtCoordenada.Text.ToUpper()))
                                        {
                                            coordEncontrada = true;
                                        }
                                        if (coordEncontrada & ch != char.Parse(txtCoordenada.Text.ToUpper()))
                                        {
                                            bool esNum = float.TryParse(ch.ToString(), out float re);
                                            if (esNum | ch == '.' | ch == '-')
                                            {
                                                coordenadaStr += ch;
                                            }
                                            else
                                            {
                                                coordEncontrada = false;
                                            }
                                        }
                                    }
                                    coordenada = float.Parse(coordenadaStr, System.Globalization.CultureInfo.InvariantCulture) + float.Parse(txtResta.Text, System.Globalization.CultureInfo.InvariantCulture);

                                    line = line.Replace(txtCoordenada.Text.ToUpper() + coordenadaStr, txtCoordenada.Text.ToUpper() + coordenada.ToString()).Replace(',', '.');

                                    fileContent += line + '\n';
                                }
                                else
                                {
                                    fileContent += line + '\n';
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Algo a ido mal.");
                    }

                }
                var folderBrowserDialog1 = new SaveFileDialog();
                folderBrowserDialog1.FileName = "cnc2";
                folderBrowserDialog1.DefaultExt = "txt";
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string folderName = folderBrowserDialog1.FileName;
                    try
                    {
                        // Create the file, or overwrite if the file exists.
                        using (FileStream fs = File.Create(folderName))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(fileContent);
                            // Add some information to the file.
                            fs.Write(info, 0, info.Length);
                        }
                        MessageBox.Show("El archivo se ha generaso correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el archivo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Se deben rellenar los campos, respetando sus restricciones");
            }
        }
        }

        
    }

