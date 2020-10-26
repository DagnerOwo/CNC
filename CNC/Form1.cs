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
                            if (line.Contains(txtResta.Text))
                            {
                                float coordenada = 0;
                                bool coordEncontrada = false;
                                string coordenadaStr = string.Empty;
                                char[] lineArray = line.ToCharArray();
                                foreach (char ch in lineArray)
                                {
                                    if(ch == char.Parse(txtCoordenada.Text))
                                    {
                                        coordEncontrada = true;
                                    }
                                    else if(ch == '-')
                                    {
                                        coordEncontrada = false;
                                    }
                                    if (coordEncontrada & ch != char.Parse(txtCoordenada.Text))
                                    {
                                        coordenadaStr += ch;
                                    }
                                }
                                coordenada = float.Parse(coordenadaStr, System.Globalization.CultureInfo.InvariantCulture) + float.Parse(txtResta.Text, System.Globalization.CultureInfo.InvariantCulture);
                                
                                line = line.Replace(coordenadaStr + txtResta.Text, coordenada.ToString()).Replace(',', '.');
                                
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
                    Console.WriteLine(ex.Message);
                }
                
            }
            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                folderName += "/nc2.txt";
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(folderName))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(fileContent);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(folderName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        }

        
    }

