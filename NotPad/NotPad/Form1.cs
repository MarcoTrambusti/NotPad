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

namespace NotPad
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            txtlayer.Clear();
        }

        private void btnApri_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void btnIndenta_Click(object sender, EventArgs e)
        {
            IndentFile();
        }
        public void OpenFile()
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File di test|*.txt";
            openFileDialog1.Title = "Scegli un file di testo";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        txtlayer.Text +=  s+"\r\n";
                    }
                }
            }
        }
        public void SaveFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File di test|*.txt";
            saveFileDialog1.Title = "Salva un file di testo";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                byte[] byteArray = Encoding.UTF8.GetBytes(txtlayer.Text);

                foreach (byte b in byteArray)
                {
                    fs.WriteByte(b);
                }

                fs.Close();
            }
        }
        public void IndentFile() { }
    }
}
