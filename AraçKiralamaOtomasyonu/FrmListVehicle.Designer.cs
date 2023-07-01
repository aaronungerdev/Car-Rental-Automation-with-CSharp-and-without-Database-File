namespace AraçKiralamaOtomasyonu
{
    partial class FrmListVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListVehicle));
            this.Cancel2btn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Updatebtn = new System.Windows.Forms.Button();
            this.ResimEklebtn = new System.Windows.Forms.Button();
            this.ResimBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Yakıttxt = new System.Windows.Forms.ComboBox();
            this.Seritxt = new System.Windows.Forms.ComboBox();
            this.Markatxt = new System.Windows.Forms.ComboBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Kiratxt = new System.Windows.Forms.TextBox();
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AraçListCombo = new System.Windows.Forms.ComboBox();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ResimBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel2btn
            // 
            this.Cancel2btn.ForeColor = System.Drawing.Color.Black;
            this.Cancel2btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel2btn.ImageIndex = 0;
            this.Cancel2btn.ImageList = this.ımageList1;
            this.Cancel2btn.Location = new System.Drawing.Point(134, 519);
            this.Cancel2btn.Name = "Cancel2btn";
            this.Cancel2btn.Size = new System.Drawing.Size(107, 47);
            this.Cancel2btn.TabIndex = 40;
            this.Cancel2btn.Text = "Cancel";
            this.Cancel2btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel2btn.UseVisualStyleBackColor = true;
            this.Cancel2btn.Click += new System.EventHandler(this.Cancel2btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "PikPng.com_exit-icon-png_5910321.png");
            this.ımageList1.Images.SetKeyName(1, "pngkey.com-avast-icon-png-3256831.png");
            this.ımageList1.Images.SetKeyName(2, "PngItem_824067.png");
            // 
            // Updatebtn
            // 
            this.Updatebtn.ForeColor = System.Drawing.Color.Black;
            this.Updatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Updatebtn.ImageIndex = 1;
            this.Updatebtn.ImageList = this.ımageList1;
            this.Updatebtn.Location = new System.Drawing.Point(12, 519);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(102, 47);
            this.Updatebtn.TabIndex = 39;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // ResimEklebtn
            // 
            this.ResimEklebtn.ForeColor = System.Drawing.Color.Black;
            this.ResimEklebtn.Location = new System.Drawing.Point(55, 376);
            this.ResimEklebtn.Name = "ResimEklebtn";
            this.ResimEklebtn.Size = new System.Drawing.Size(146, 24);
            this.ResimEklebtn.TabIndex = 38;
            this.ResimEklebtn.Text = "Change Image";
            this.ResimEklebtn.UseVisualStyleBackColor = true;
            this.ResimEklebtn.Click += new System.EventHandler(this.ResimEklebtn_Click);
            // 
            // ResimBox
            // 
            this.ResimBox.Location = new System.Drawing.Point(39, 406);
            this.ResimBox.Name = "ResimBox";
            this.ResimBox.Size = new System.Drawing.Size(189, 100);
            this.ResimBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResimBox.TabIndex = 37;
            this.ResimBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fuel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(49, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Series";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "LP";
            // 
            // Yakıttxt
            // 
            this.Yakıttxt.FormattingEnabled = true;
            this.Yakıttxt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
            this.Yakıttxt.Location = new System.Drawing.Point(100, 284);
            this.Yakıttxt.Name = "Yakıttxt";
            this.Yakıttxt.Size = new System.Drawing.Size(150, 24);
            this.Yakıttxt.TabIndex = 28;
            // 
            // Seritxt
            // 
            this.Seritxt.FormattingEnabled = true;
            this.Seritxt.Location = new System.Drawing.Point(100, 104);
            this.Seritxt.Name = "Seritxt";
            this.Seritxt.Size = new System.Drawing.Size(150, 24);
            this.Seritxt.TabIndex = 27;
            // 
            // Markatxt
            // 
            this.Markatxt.FormattingEnabled = true;
            this.Markatxt.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.Markatxt.Location = new System.Drawing.Point(100, 63);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.Size = new System.Drawing.Size(150, 24);
            this.Markatxt.TabIndex = 26;
            this.Markatxt.SelectedIndexChanged += new System.EventHandler(this.Markatxt_SelectedIndexChanged);
            // 
            // Yiltxt
            // 
            this.Yiltxt.Location = new System.Drawing.Point(100, 150);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(150, 22);
            this.Yiltxt.TabIndex = 25;
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(100, 192);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(150, 22);
            this.Renktxt.TabIndex = 24;
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(100, 237);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(150, 22);
            this.Kmtxt.TabIndex = 23;
            // 
            // Kiratxt
            // 
            this.Kiratxt.Location = new System.Drawing.Point(100, 330);
            this.Kiratxt.Name = "Kiratxt";
            this.Kiratxt.Size = new System.Drawing.Size(150, 22);
            this.Kiratxt.TabIndex = 22;
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(100, 22);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(150, 22);
            this.Plakatxt.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 427);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // AraçListCombo
            // 
            this.AraçListCombo.FormattingEnabled = true;
            this.AraçListCombo.Items.AddRange(new object[] {
            "ALL VEHICLES",
            "AVAILABLE VEHICLES",
            "BUSY VEHICLES"});
            this.AraçListCombo.Location = new System.Drawing.Point(872, 2);
            this.AraçListCombo.Name = "AraçListCombo";
            this.AraçListCombo.Size = new System.Drawing.Size(142, 24);
            this.AraçListCombo.TabIndex = 42;
            this.AraçListCombo.SelectedIndexChanged += new System.EventHandler(this.AraçListCombo_SelectedIndexChanged);
            // 
            // Clearbtn
            // 
            this.Clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clearbtn.ImageIndex = 2;
            this.Clearbtn.ImageList = this.ımageList1;
            this.Clearbtn.Location = new System.Drawing.Point(1020, 37);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(85, 50);
            this.Clearbtn.TabIndex = 43;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmListVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1133, 732);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.AraçListCombo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel2btn);
            this.Controls.Add(this.Updatebtn);
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
            this.Name = "FrmListVehicle";
            this.Text = "List Vehicle";
            this.Load += new System.EventHandler(this.FrmListVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResimBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel2btn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button ResimEklebtn;
        private System.Windows.Forms.PictureBox ResimBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Yakıttxt;
        private System.Windows.Forms.ComboBox Seritxt;
        private System.Windows.Forms.ComboBox Markatxt;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Kiratxt;
        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox AraçListCombo;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}