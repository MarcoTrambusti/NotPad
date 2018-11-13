using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public void OpenFile() { }
        public void SaveFile() { }
        public void IndentFile() { }
    }
}
