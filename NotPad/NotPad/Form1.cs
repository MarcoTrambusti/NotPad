using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotPad
{
    public partial class Form : System.Windows.Forms.Form
    {
        string filePath;
        public Form()
        {
            InitializeComponent();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Pulire l'area di testo?", "Continuare?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Text = "NotPad";
                txtlayer.Clear();
            }
            
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
            openFileDialog1.Filter = "File di testo|*.txt|Tutti i file|*.*";
            openFileDialog1.Title = "Scegli un file di testo";
            if (filePath != null && filePath != string.Empty)
            {
                openFileDialog1.InitialDirectory = Path.GetDirectoryName(filePath);
                openFileDialog1.FileName = Path.GetFileNameWithoutExtension(filePath);
            }

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                    {
                        string s = "", ss = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            ss +=  s+"\r\n";
                        }
                        txtlayer.Text = ss;
                        filePath = openFileDialog1.FileName;
                        this.Text = "NotPad - " + filePath;
                    }
                }
                catch { MessageBox.Show("Si è verificato un errore"); }

            }
        }
        public bool SaveFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File di testo|*.txt|Tutti i file|*.*";
            saveFileDialog1.Title = "Salva un file di testo";
            if(filePath != null && filePath != string.Empty)
            {
                string driectry = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                saveFileDialog1.InitialDirectory = driectry;
                saveFileDialog1.FileName = fileName;
            }
                
            DialogResult result = saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    if(result==DialogResult.OK)
                    {
                        System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                        byte[] byteArray = Encoding.UTF8.GetBytes(txtlayer.Text);

                        foreach (byte b in byteArray)
                        {
                            fs.WriteByte(b);
                        }

                        fs.Close();
                        filePath = saveFileDialog1.FileName;
                        this.Text = "NotPad - " + filePath;
                        return true;
                    }
                        
                }catch
                { MessageBox.Show("File non salvato");}
             }
            return false;
        }
        public void IndentFile()
        {
            StringReader reader = new StringReader(txtlayer.Text);
            RichTextBox rchTemp = new RichTextBox();
            string riga;
            while ((riga = reader.ReadLine()) != null)
            {
                rchTemp.AppendText("\r\n" + riga.Trim());
            }

            string indentedText = "";
            int indentCount = 0;
            bool shouldIndent = false;
            foreach (string line in rchTemp.Lines)
            {
                if (shouldIndent)
                    indentCount++;

                if (line.Contains("}"))
                    indentCount--;

                if (indentCount == 0)
                {
                    indentedText += (line);
                    shouldIndent = line.Contains("{");
                    continue;
                }

                string blankSpace = string.Empty;
                for (int i = 0; i < indentCount; i++)
                {
                    blankSpace += "    ";
                }
                indentedText += ("\r\n" + blankSpace + line);
                shouldIndent = line.Contains("{");
            }
            txtlayer.Text = indentedText;
        }

    private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show( "Salvare le modifiche al documento?","Esci",MessageBoxButtons.YesNoCancel);
            if (window == DialogResult.Yes)
            { if(!SaveFile()) e.Cancel = true; }
            else
                e.Cancel = (window == DialogResult.Cancel);
        }
    }
}
