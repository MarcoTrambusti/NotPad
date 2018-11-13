namespace NotPad
{
    partial class Form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuovo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalva = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStrumenti = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIndenta = new System.Windows.Forms.ToolStripMenuItem();
            this.txtlayer = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnStrumenti});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(803, 24);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuovo,
            this.btnApri,
            this.btnSalva});
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(37, 20);
            this.btnFile.Text = "File";
            // 
            // btnNuovo
            // 
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(158, 22);
            this.btnNuovo.Text = "Nuovo";
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnApri
            // 
            this.btnApri.Name = "btnApri";
            this.btnApri.Size = new System.Drawing.Size(158, 22);
            this.btnApri.Text = "Apri";
            this.btnApri.Click += new System.EventHandler(this.btnApri_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(158, 22);
            this.btnSalva.Text = "Salva con nome";
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnStrumenti
            // 
            this.btnStrumenti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIndenta});
            this.btnStrumenti.Name = "btnStrumenti";
            this.btnStrumenti.Size = new System.Drawing.Size(71, 20);
            this.btnStrumenti.Text = "Strumenti";
            // 
            // btnIndenta
            // 
            this.btnIndenta.Name = "btnIndenta";
            this.btnIndenta.Size = new System.Drawing.Size(152, 22);
            this.btnIndenta.Text = "Indenta";
            this.btnIndenta.Click += new System.EventHandler(this.btnIndenta_Click);
            // 
            // txtlayer
            // 
            this.txtlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlayer.Location = new System.Drawing.Point(12, 38);
            this.txtlayer.Multiline = true;
            this.txtlayer.Name = "txtlayer";
            this.txtlayer.Size = new System.Drawing.Size(779, 324);
            this.txtlayer.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(803, 374);
            this.Controls.Add(this.txtlayer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form";
            this.Text = "NotPad";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnApri;
        private System.Windows.Forms.ToolStripMenuItem btnNuovo;
        private System.Windows.Forms.ToolStripMenuItem btnSalva;
        private System.Windows.Forms.ToolStripMenuItem btnStrumenti;
        private System.Windows.Forms.ToolStripMenuItem btnIndenta;
        private System.Windows.Forms.TextBox txtlayer;
    }
}

