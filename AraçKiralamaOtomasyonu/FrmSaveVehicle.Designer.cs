namespace AraçKiralamaOtomasyonu
{
    partial class FrmSaveVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaveVehicle));
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.Kiratxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Markatxt = new System.Windows.Forms.ComboBox();
            this.Seritxt = new System.Windows.Forms.ComboBox();
            this.Yakıttxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ResimBox = new System.Windows.Forms.PictureBox();
            this.ResimEklebtn = new System.Windows.Forms.Button();
            this.Kayıtbtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.İptal2btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ResimBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(142, 40);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(150, 22);
            this.Plakatxt.TabIndex = 0;
            // 
            // Kiratxt
            // 
            this.Kiratxt.Location = new System.Drawing.Point(142, 348);
            this.Kiratxt.Name = "Kiratxt";
            this.Kiratxt.Size = new System.Drawing.Size(150, 22);
            this.Kiratxt.TabIndex = 1;
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(142, 255);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(150, 22);
            this.Kmtxt.TabIndex = 2;
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(142, 210);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(150, 22);
            this.Renktxt.TabIndex = 3;
            // 
            // Yiltxt
            // 
            this.Yiltxt.Location = new System.Drawing.Point(142, 168);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(150, 22);
            this.Yiltxt.TabIndex = 4;
            // 
            // Markatxt
            // 
            this.Markatxt.FormattingEnabled = true;
            this.Markatxt.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.Markatxt.Location = new System.Drawing.Point(142, 81);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.Size = new System.Drawing.Size(150, 24);
            this.Markatxt.TabIndex = 6;
            this.Markatxt.SelectedIndexChanged += new System.EventHandler(this.Markatxt_SelectedIndexChanged);
            // 
            // Seritxt
            // 
            this.Seritxt.FormattingEnabled = true;
            this.Seritxt.Location = new System.Drawing.Point(142, 122);
            this.Seritxt.Name = "Seritxt";
            this.Seritxt.Size = new System.Drawing.Size(150, 24);
            this.Seritxt.TabIndex = 7;
            // 
            // Yakıttxt
            // 
            this.Yakıttxt.FormattingEnabled = true;
            this.Yakıttxt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
            this.Yakıttxt.Location = new System.Drawing.Point(142, 302);
            this.Yakıttxt.Name = "Yakıttxt";
            this.Yakıttxt.Size = new System.Drawing.Size(150, 24);
            this.Yakıttxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "LP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Series";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(84, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(84, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fuel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(84, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Price";
            // 
            // ResimBox
            // 
            this.ResimBox.Location = new System.Drawing.Point(374, 62);
            this.ResimBox.Name = "ResimBox";
            this.ResimBox.Size = new System.Drawing.Size(261, 214);
            this.ResimBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResimBox.TabIndex = 17;
            this.ResimBox.TabStop = false;
            // 
            // ResimEklebtn
            // 
            this.ResimEklebtn.ForeColor = System.Drawing.Color.Black;
            this.ResimEklebtn.Location = new System.Drawing.Point(436, 302);
            this.ResimEklebtn.Name = "ResimEklebtn";
            this.ResimEklebtn.Size = new System.Drawing.Size(133, 43);
            this.ResimEklebtn.TabIndex = 18;
            this.ResimEklebtn.Text = "Add Image";
            this.ResimEklebtn.UseVisualStyleBackColor = true;
            this.ResimEklebtn.Click += new System.EventHandler(this.ResimEklebtn_Click);
            // 
            // Kayıtbtn
            // 
            this.Kayıtbtn.ForeColor = System.Drawing.Color.Black;
            this.Kayıtbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kayıtbtn.ImageIndex = 1;
            this.Kayıtbtn.ImageList = this.ımageList1;
            this.Kayıtbtn.Location = new System.Drawing.Point(60, 400);
            this.Kayıtbtn.Name = "Kayıtbtn";
            this.Kayıtbtn.Size = new System.Drawing.Size(102, 47);
            this.Kayıtbtn.TabIndex = 19;
            this.Kayıtbtn.Text = "Save";
            this.Kayıtbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Kayıtbtn.UseVisualStyleBackColor = true;
            this.Kayıtbtn.Click += new System.EventHandler(this.Kayıtbtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "PikPng.com_exit-icon-png_5910321.png");
            this.ımageList1.Images.SetKeyName(1, "PinClipart.com_car-repair-clip-art_740794.png");
            // 
            // İptal2btn
            // 
            this.İptal2btn.ForeColor = System.Drawing.Color.Black;
            this.İptal2btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.İptal2btn.ImageIndex = 0;
            this.İptal2btn.ImageList = this.ımageList1;
            this.İptal2btn.Location = new System.Drawing.Point(194, 400);
            this.İptal2btn.Name = "İptal2btn";
            this.İptal2btn.Size = new System.Drawing.Size(107, 47);
            this.İptal2btn.TabIndex = 20;
            this.İptal2btn.Text = "Cancel";
            this.İptal2btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.İptal2btn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmSaveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(686, 499);
            this.Controls.Add(this.İptal2btn);
            this.Controls.Add(this.Kayıtbtn);
            this.Controls.Add(this.ResimEklebtn);
            this.Controls.Add(this.ResimBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yakıttxt);
            this.Controls.Add(this.Seritxt);
            this.Controls.Add(this.Markatxt);
            this.Controls.Add(this.Yiltxt);
            this.Controls.Add(this.Renktxt);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.Kiratxt);
            this.Controls.Add(this.Plakatxt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmSaveVehicle";
            this.Text = "Save Vehicle";
            this.Load += new System.EventHandler(this.FrmSaveVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResimBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.TextBox Kiratxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.ComboBox Markatxt;
        private System.Windows.Forms.ComboBox Seritxt;
        private System.Windows.Forms.ComboBox Yakıttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ResimBox;
        private System.Windows.Forms.Button ResimEklebtn;
        private System.Windows.Forms.Button Kayıtbtn;
        private System.Windows.Forms.Button İptal2btn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}