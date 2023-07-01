namespace AraçKiralamaOtomasyonu
{
    partial class CustomerAddPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAddPage));
            this.Tctxt = new System.Windows.Forms.TextBox();
            this.Surnametxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tctxt
            // 
            this.Tctxt.Location = new System.Drawing.Point(135, 61);
            this.Tctxt.Name = "Tctxt";
            this.Tctxt.Size = new System.Drawing.Size(141, 22);
            this.Tctxt.TabIndex = 0;
            // 
            // Surnametxt
            // 
            this.Surnametxt.Location = new System.Drawing.Point(135, 139);
            this.Surnametxt.Name = "Surnametxt";
            this.Surnametxt.Size = new System.Drawing.Size(141, 22);
            this.Surnametxt.TabIndex = 1;
            this.Surnametxt.TextChanged += new System.EventHandler(this.NameSurnametxt_TextChanged);
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(135, 180);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(141, 22);
            this.Phonetxt.TabIndex = 2;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(135, 221);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(141, 22);
            this.Addresstxt.TabIndex = 3;
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(135, 268);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.Size = new System.Drawing.Size(141, 22);
            this.Mailtxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = " Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(70, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(59, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(77, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // AddBtn
            // 
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.ImageIndex = 1;
            this.AddBtn.ImageList = this.imageList1;
            this.AddBtn.Location = new System.Drawing.Point(59, 327);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(91, 36);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "PikPng.com_exit-icon-png_5910321.png");
            this.imageList1.Images.SetKeyName(1, "pngwing.com (2).png");
            // 
            // CancelBtn
            // 
            this.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBtn.ImageIndex = 0;
            this.CancelBtn.ImageList = this.imageList1;
            this.CancelBtn.Location = new System.Drawing.Point(178, 327);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(98, 36);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(135, 101);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(141, 22);
            this.Nametxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(74, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name";
            // 
            // CustomerAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(396, 399);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mailtxt);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.Surnametxt);
            this.Controls.Add(this.Tctxt);
            this.Name = "CustomerAddPage";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.CustomerAddPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tctxt;
        private System.Windows.Forms.TextBox Surnametxt;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label6;
    }
}