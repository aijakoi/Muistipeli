
namespace testi2
{
    partial class frmMuistipeli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuistipeli));
            this.lblAika = new System.Windows.Forms.Label();
            this.lblLoydetty1 = new System.Windows.Forms.Label();
            this.btnVasen = new System.Windows.Forms.Button();
            this.btnOikea = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTaso = new System.Windows.Forms.Label();
            this.btnAloita = new System.Windows.Forms.Button();
            this.lblPelaaja1 = new System.Windows.Forms.Label();
            this.lblPelaaja2 = new System.Windows.Forms.Label();
            this.tbPelaaja1 = new System.Windows.Forms.TextBox();
            this.tbPelaaja2 = new System.Windows.Forms.TextBox();
            this.lblLoydetty2 = new System.Windows.Forms.Label();
            this.lblVuoro = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsLopeta = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTilastot = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAika
            // 
            this.lblAika.AutoSize = true;
            this.lblAika.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAika.Location = new System.Drawing.Point(606, 24);
            this.lblAika.Name = "lblAika";
            this.lblAika.Size = new System.Drawing.Size(55, 18);
            this.lblAika.TabIndex = 0;
            this.lblAika.Text = "Aika: ";
            // 
            // lblLoydetty1
            // 
            this.lblLoydetty1.AutoSize = true;
            this.lblLoydetty1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoydetty1.Location = new System.Drawing.Point(449, 24);
            this.lblLoydetty1.Name = "lblLoydetty1";
            this.lblLoydetty1.Size = new System.Drawing.Size(91, 18);
            this.lblLoydetty1.TabIndex = 1;
            this.lblLoydetty1.Text = "Löydetty: ";
            // 
            // btnVasen
            // 
            this.btnVasen.BackgroundImage = global::testi2.Properties.Resources.vasen;
            this.btnVasen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVasen.FlatAppearance.BorderSize = 3;
            this.btnVasen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVasen.Location = new System.Drawing.Point(12, 64);
            this.btnVasen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVasen.Name = "btnVasen";
            this.btnVasen.Size = new System.Drawing.Size(97, 56);
            this.btnVasen.TabIndex = 2;
            this.btnVasen.UseVisualStyleBackColor = true;
            this.btnVasen.Click += new System.EventHandler(this.btnVasen_Click);
            // 
            // btnOikea
            // 
            this.btnOikea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOikea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOikea.BackgroundImage")));
            this.btnOikea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOikea.FlatAppearance.BorderSize = 3;
            this.btnOikea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOikea.Location = new System.Drawing.Point(115, 64);
            this.btnOikea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOikea.Name = "btnOikea";
            this.btnOikea.Size = new System.Drawing.Size(97, 56);
            this.btnOikea.TabIndex = 3;
            this.btnOikea.UseVisualStyleBackColor = false;
            this.btnOikea.Click += new System.EventHandler(this.btnOikea_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "taustakuva.jpg");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "8.png");
            this.imageList1.Images.SetKeyName(9, "9.png");
            this.imageList1.Images.SetKeyName(10, "10.png");
            this.imageList1.Images.SetKeyName(11, "11.png");
            this.imageList1.Images.SetKeyName(12, "12.png");
            this.imageList1.Images.SetKeyName(13, "13.png");
            this.imageList1.Images.SetKeyName(14, "14.png");
            this.imageList1.Images.SetKeyName(15, "15.png");
            this.imageList1.Images.SetKeyName(16, "16.png");
            this.imageList1.Images.SetKeyName(17, "17.png");
            this.imageList1.Images.SetKeyName(18, "18.png");
            this.imageList1.Images.SetKeyName(19, "19.png");
            this.imageList1.Images.SetKeyName(20, "20.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTaso
            // 
            this.lblTaso.AutoSize = true;
            this.lblTaso.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaso.Location = new System.Drawing.Point(12, 38);
            this.lblTaso.Name = "lblTaso";
            this.lblTaso.Size = new System.Drawing.Size(64, 22);
            this.lblTaso.TabIndex = 4;
            this.lblTaso.Text = "Taso:";
            // 
            // btnAloita
            // 
            this.btnAloita.BackColor = System.Drawing.Color.Snow;
            this.btnAloita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAloita.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAloita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAloita.Location = new System.Drawing.Point(233, 87);
            this.btnAloita.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAloita.Name = "btnAloita";
            this.btnAloita.Size = new System.Drawing.Size(75, 30);
            this.btnAloita.TabIndex = 5;
            this.btnAloita.Text = "Aloita";
            this.btnAloita.UseVisualStyleBackColor = false;
            this.btnAloita.Click += new System.EventHandler(this.btnAloita_Click);
            // 
            // lblPelaaja1
            // 
            this.lblPelaaja1.AutoSize = true;
            this.lblPelaaja1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja1.Location = new System.Drawing.Point(229, 22);
            this.lblPelaaja1.Name = "lblPelaaja1";
            this.lblPelaaja1.Size = new System.Drawing.Size(93, 18);
            this.lblPelaaja1.TabIndex = 6;
            this.lblPelaaja1.Text = "Pelaaja 1: ";
            // 
            // lblPelaaja2
            // 
            this.lblPelaaja2.AutoSize = true;
            this.lblPelaaja2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja2.Location = new System.Drawing.Point(229, 56);
            this.lblPelaaja2.Name = "lblPelaaja2";
            this.lblPelaaja2.Size = new System.Drawing.Size(93, 18);
            this.lblPelaaja2.TabIndex = 7;
            this.lblPelaaja2.Text = "Pelaaja 2: ";
            // 
            // tbPelaaja1
            // 
            this.tbPelaaja1.Location = new System.Drawing.Point(329, 22);
            this.tbPelaaja1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPelaaja1.Name = "tbPelaaja1";
            this.tbPelaaja1.Size = new System.Drawing.Size(100, 20);
            this.tbPelaaja1.TabIndex = 8;
            // 
            // tbPelaaja2
            // 
            this.tbPelaaja2.Location = new System.Drawing.Point(329, 56);
            this.tbPelaaja2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPelaaja2.Name = "tbPelaaja2";
            this.tbPelaaja2.Size = new System.Drawing.Size(100, 20);
            this.tbPelaaja2.TabIndex = 9;
            // 
            // lblLoydetty2
            // 
            this.lblLoydetty2.AutoSize = true;
            this.lblLoydetty2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoydetty2.Location = new System.Drawing.Point(449, 56);
            this.lblLoydetty2.Name = "lblLoydetty2";
            this.lblLoydetty2.Size = new System.Drawing.Size(91, 18);
            this.lblLoydetty2.TabIndex = 10;
            this.lblLoydetty2.Text = "Löydetty: ";
            // 
            // lblVuoro
            // 
            this.lblVuoro.AutoSize = true;
            this.lblVuoro.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuoro.Location = new System.Drawing.Point(606, 56);
            this.lblVuoro.Name = "lblVuoro";
            this.lblVuoro.Size = new System.Drawing.Size(0, 18);
            this.lblVuoro.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLopeta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsLopeta
            // 
            this.tsLopeta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lopetaPeliToolStripMenuItem});
            this.tsLopeta.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLopeta.Name = "tsLopeta";
            this.tsLopeta.Size = new System.Drawing.Size(62, 20);
            this.tsLopeta.Text = "Valitse";
            // 
            // lopetaPeliToolStripMenuItem
            // 
            this.lopetaPeliToolStripMenuItem.Name = "lopetaPeliToolStripMenuItem";
            this.lopetaPeliToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.lopetaPeliToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.lopetaPeliToolStripMenuItem.Text = "Lopeta peli";
            this.lopetaPeliToolStripMenuItem.Click += new System.EventHandler(this.lopetaPeliToolStripMenuItem_Click);
            // 
            // btnTilastot
            // 
            this.btnTilastot.BackColor = System.Drawing.Color.Snow;
            this.btnTilastot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTilastot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTilastot.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTilastot.Location = new System.Drawing.Point(609, 87);
            this.btnTilastot.Name = "btnTilastot";
            this.btnTilastot.Size = new System.Drawing.Size(75, 30);
            this.btnTilastot.TabIndex = 14;
            this.btnTilastot.Text = "Tilastot";
            this.btnTilastot.UseVisualStyleBackColor = false;
            this.btnTilastot.Click += new System.EventHandler(this.btnTilastot_Click);
            // 
            // frmMuistipeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(721, 693);
            this.Controls.Add(this.btnTilastot);
            this.Controls.Add(this.lblVuoro);
            this.Controls.Add(this.lblLoydetty2);
            this.Controls.Add(this.tbPelaaja2);
            this.Controls.Add(this.tbPelaaja1);
            this.Controls.Add(this.lblPelaaja2);
            this.Controls.Add(this.lblPelaaja1);
            this.Controls.Add(this.btnAloita);
            this.Controls.Add(this.lblTaso);
            this.Controls.Add(this.btnOikea);
            this.Controls.Add(this.btnVasen);
            this.Controls.Add(this.lblLoydetty1);
            this.Controls.Add(this.lblAika);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMuistipeli";
            this.Text = "Heroes vs Villains";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAika;
        private System.Windows.Forms.Label lblLoydetty1;
        private System.Windows.Forms.Button btnVasen;
        private System.Windows.Forms.Button btnOikea;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTaso;
        private System.Windows.Forms.Button btnAloita;
        private System.Windows.Forms.Label lblPelaaja1;
        private System.Windows.Forms.Label lblPelaaja2;
        private System.Windows.Forms.TextBox tbPelaaja1;
        private System.Windows.Forms.TextBox tbPelaaja2;
        private System.Windows.Forms.Label lblLoydetty2;
        private System.Windows.Forms.Label lblVuoro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsLopeta;
        private System.Windows.Forms.ToolStripMenuItem lopetaPeliToolStripMenuItem;
        private System.Windows.Forms.Button btnTilastot;
    }
}

