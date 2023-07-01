namespace AraçKiralamaOtomasyonu
{
    partial class FrmListCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListCustomer));
            this.Updatebtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.İptalbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Tctxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Updatebtn
            // 
            this.Updatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Updatebtn.ImageIndex = 0;
            this.Updatebtn.ImageList = this.ımageList1;
            this.Updatebtn.Location = new System.Drawing.Point(48, 340);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(103, 44);
            this.Updatebtn.TabIndex = 10;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "pngkey.com-avast-icon-png-3256831.png");
            this.ımageList1.Images.SetKeyName(1, "PikPng.com_exit-icon-png_5910321.png");
            this.ımageList1.Images.SetKeyName(2, "PngItem_824067.png");
            // 
            // İptalbtn
            // 
            this.İptalbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.İptalbtn.ImageIndex = 1;
            this.İptalbtn.ImageList = this.ımageList1;
            this.İptalbtn.Location = new System.Drawing.Point(190, 340);
            this.İptalbtn.Name = "İptalbtn";
            this.İptalbtn.Size = new System.Drawing.Size(102, 44);
            this.İptalbtn.TabIndex = 11;
            this.İptalbtn.Text = "Cancel";
            this.İptalbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.İptalbtn.UseVisualStyleBackColor = true;
            this.İptalbtn.Click += new System.EventHandler(this.İptalbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 417);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Clearbtn
            // 
            this.Clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clearbtn.ImageIndex = 2;
            this.Clearbtn.ImageList = this.ımageList1;
            this.Clearbtn.Location = new System.Drawing.Point(969, 64);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(106, 51);
            this.Clearbtn.TabIndex = 13;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(91, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(73, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(84, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(84, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(142, 282);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.Size = new System.Drawing.Size(161, 22);
            this.Mailtxt.TabIndex = 18;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(142, 235);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(161, 22);
            this.Addresstxt.TabIndex = 17;
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(142, 189);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(161, 22);
            this.Phonetxt.TabIndex = 16;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(142, 109);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(161, 22);
            this.Nametxt.TabIndex = 15;
            // 
            // Tctxt
            // 
            this.Tctxt.Location = new System.Drawing.Point(142, 66);
            this.Tctxt.Name = "Tctxt";
            this.Tctxt.Size = new System.Drawing.Size(161, 22);
            this.Tctxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(702, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "SearchID";
            // 
            // Searchtxt
            // 
            this.Searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Searchtxt.Location = new System.Drawing.Point(802, 30);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(161, 26);
            this.Searchtxt.TabIndex = 24;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // Surnametxt
            // 
            this.Surnametxt.Location = new System.Drawing.Point(142, 148);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.Size = new System.Drawing.Size(161, 22);
            this.Surnametxt.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(68, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Surname";
            // 
            // FrmListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1120, 604);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Surnametxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mailtxt);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Tctxt);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.İptalbtn);
            this.Controls.Add(this.Updatebtn);
            this.Name = "FrmListCustomer";
            this.Text = "List Customer";
            this.Load += new System.EventHandler(this.FrmListCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button İptalbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Tctxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.TextBox Surnametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList ımageList1;
    }
}