namespace ThreadingProject.Copy.App
{
    partial class Form1
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
            this.threadingOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnFileSelecttion = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFrom1 = new System.Windows.Forms.TextBox();
            this.textBoxFrom2 = new System.Windows.Forms.TextBox();
            this.textBoxFrom3 = new System.Windows.Forms.TextBox();
            this.textBoxFrom4 = new System.Windows.Forms.TextBox();
            this.buttonFrom1 = new System.Windows.Forms.Button();
            this.buttonFrom2 = new System.Windows.Forms.Button();
            this.buttonFrom3 = new System.Windows.Forms.Button();
            this.buttonFrom4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTo1 = new System.Windows.Forms.TextBox();
            this.buttonTo4 = new System.Windows.Forms.Button();
            this.textBoxTo2 = new System.Windows.Forms.TextBox();
            this.buttonTo3 = new System.Windows.Forms.Button();
            this.textBoxTo3 = new System.Windows.Forms.TextBox();
            this.buttonTo2 = new System.Windows.Forms.Button();
            this.textBoxTo4 = new System.Windows.Forms.TextBox();
            this.buttonTo1 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // threadingOpenFileDialog
            // 
            this.threadingOpenFileDialog.FileName = "openFileDialog1";
            this.threadingOpenFileDialog.Multiselect = true;
            // 
            // btnFileSelecttion
            // 
            this.btnFileSelecttion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileSelecttion.Location = new System.Drawing.Point(1015, 418);
            this.btnFileSelecttion.Name = "btnFileSelecttion";
            this.btnFileSelecttion.Size = new System.Drawing.Size(135, 50);
            this.btnFileSelecttion.TabIndex = 0;
            this.btnFileSelecttion.Text = "کپی فایل";
            this.btnFileSelecttion.UseVisualStyleBackColor = true;
            this.btnFileSelecttion.Click += new System.EventHandler(this.BtnFileSelecttion_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(874, 418);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 50);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "بروزرسانی فرم";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // textBoxFrom1
            // 
            this.textBoxFrom1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrom1.Location = new System.Drawing.Point(6, 38);
            this.textBoxFrom1.Name = "textBoxFrom1";
            this.textBoxFrom1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFrom1.Size = new System.Drawing.Size(533, 22);
            this.textBoxFrom1.TabIndex = 3;
            // 
            // textBoxFrom2
            // 
            this.textBoxFrom2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrom2.Location = new System.Drawing.Point(6, 118);
            this.textBoxFrom2.Name = "textBoxFrom2";
            this.textBoxFrom2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFrom2.Size = new System.Drawing.Size(533, 22);
            this.textBoxFrom2.TabIndex = 4;
            // 
            // textBoxFrom3
            // 
            this.textBoxFrom3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrom3.Location = new System.Drawing.Point(6, 196);
            this.textBoxFrom3.Name = "textBoxFrom3";
            this.textBoxFrom3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFrom3.Size = new System.Drawing.Size(533, 22);
            this.textBoxFrom3.TabIndex = 5;
            // 
            // textBoxFrom4
            // 
            this.textBoxFrom4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrom4.Location = new System.Drawing.Point(6, 281);
            this.textBoxFrom4.Name = "textBoxFrom4";
            this.textBoxFrom4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFrom4.Size = new System.Drawing.Size(533, 22);
            this.textBoxFrom4.TabIndex = 6;
            // 
            // buttonFrom1
            // 
            this.buttonFrom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFrom1.Location = new System.Drawing.Point(405, 66);
            this.buttonFrom1.Name = "buttonFrom1";
            this.buttonFrom1.Size = new System.Drawing.Size(134, 33);
            this.buttonFrom1.TabIndex = 7;
            this.buttonFrom1.Text = "انتخاب فایل ۱";
            this.buttonFrom1.UseVisualStyleBackColor = true;
            this.buttonFrom1.Click += new System.EventHandler(this.ButtonFrom1_Click);
            // 
            // buttonFrom2
            // 
            this.buttonFrom2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFrom2.Location = new System.Drawing.Point(405, 146);
            this.buttonFrom2.Name = "buttonFrom2";
            this.buttonFrom2.Size = new System.Drawing.Size(134, 33);
            this.buttonFrom2.TabIndex = 8;
            this.buttonFrom2.Text = "انتخاب فایل ۲";
            this.buttonFrom2.UseVisualStyleBackColor = true;
            this.buttonFrom2.Click += new System.EventHandler(this.ButtonFrom2_Click);
            // 
            // buttonFrom3
            // 
            this.buttonFrom3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFrom3.Location = new System.Drawing.Point(405, 224);
            this.buttonFrom3.Name = "buttonFrom3";
            this.buttonFrom3.Size = new System.Drawing.Size(134, 33);
            this.buttonFrom3.TabIndex = 9;
            this.buttonFrom3.Text = "انتخاب فایل ۳";
            this.buttonFrom3.UseVisualStyleBackColor = true;
            this.buttonFrom3.Click += new System.EventHandler(this.ButtonFrom3_Click);
            // 
            // buttonFrom4
            // 
            this.buttonFrom4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFrom4.Location = new System.Drawing.Point(405, 309);
            this.buttonFrom4.Name = "buttonFrom4";
            this.buttonFrom4.Size = new System.Drawing.Size(134, 33);
            this.buttonFrom4.TabIndex = 10;
            this.buttonFrom4.Text = "انتخاب فایل ۴";
            this.buttonFrom4.UseVisualStyleBackColor = true;
            this.buttonFrom4.Click += new System.EventHandler(this.ButtonFrom4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFrom1);
            this.groupBox1.Controls.Add(this.buttonFrom4);
            this.groupBox1.Controls.Add(this.textBoxFrom2);
            this.groupBox1.Controls.Add(this.buttonFrom3);
            this.groupBox1.Controls.Add(this.textBoxFrom3);
            this.groupBox1.Controls.Add(this.buttonFrom2);
            this.groupBox1.Controls.Add(this.textBoxFrom4);
            this.groupBox1.Controls.Add(this.buttonFrom1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 352);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فایل‌های مورد نیاز برای کپی";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxTo1);
            this.groupBox2.Controls.Add(this.buttonTo4);
            this.groupBox2.Controls.Add(this.textBoxTo2);
            this.groupBox2.Controls.Add(this.buttonTo3);
            this.groupBox2.Controls.Add(this.textBoxTo3);
            this.groupBox2.Controls.Add(this.buttonTo2);
            this.groupBox2.Controls.Add(this.textBoxTo4);
            this.groupBox2.Controls.Add(this.buttonTo1);
            this.groupBox2.Location = new System.Drawing.Point(611, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 352);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "محل ذخیره کردن فایل‌ها";
            // 
            // textBoxTo1
            // 
            this.textBoxTo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTo1.Location = new System.Drawing.Point(6, 38);
            this.textBoxTo1.Name = "textBoxTo1";
            this.textBoxTo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTo1.Size = new System.Drawing.Size(533, 22);
            this.textBoxTo1.TabIndex = 3;
            // 
            // buttonTo4
            // 
            this.buttonTo4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTo4.Location = new System.Drawing.Point(404, 309);
            this.buttonTo4.Name = "buttonTo4";
            this.buttonTo4.Size = new System.Drawing.Size(135, 33);
            this.buttonTo4.TabIndex = 10;
            this.buttonTo4.Text = "انتخاب پوشه ۴";
            this.buttonTo4.UseVisualStyleBackColor = true;
            this.buttonTo4.Click += new System.EventHandler(this.ButtonTo4_Click);
            // 
            // textBoxTo2
            // 
            this.textBoxTo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTo2.Location = new System.Drawing.Point(6, 118);
            this.textBoxTo2.Name = "textBoxTo2";
            this.textBoxTo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTo2.Size = new System.Drawing.Size(533, 22);
            this.textBoxTo2.TabIndex = 4;
            // 
            // buttonTo3
            // 
            this.buttonTo3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTo3.Location = new System.Drawing.Point(404, 224);
            this.buttonTo3.Name = "buttonTo3";
            this.buttonTo3.Size = new System.Drawing.Size(135, 33);
            this.buttonTo3.TabIndex = 9;
            this.buttonTo3.Text = "انتخاب پوشه ۳";
            this.buttonTo3.UseVisualStyleBackColor = true;
            this.buttonTo3.Click += new System.EventHandler(this.ButtonTo3_Click);
            // 
            // textBoxTo3
            // 
            this.textBoxTo3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTo3.Location = new System.Drawing.Point(6, 196);
            this.textBoxTo3.Name = "textBoxTo3";
            this.textBoxTo3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTo3.Size = new System.Drawing.Size(533, 22);
            this.textBoxTo3.TabIndex = 5;
            // 
            // buttonTo2
            // 
            this.buttonTo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTo2.Location = new System.Drawing.Point(404, 146);
            this.buttonTo2.Name = "buttonTo2";
            this.buttonTo2.Size = new System.Drawing.Size(135, 33);
            this.buttonTo2.TabIndex = 8;
            this.buttonTo2.Text = "انتخاب پوشه ۲";
            this.buttonTo2.UseVisualStyleBackColor = true;
            this.buttonTo2.Click += new System.EventHandler(this.ButtonTo2_Click);
            // 
            // textBoxTo4
            // 
            this.textBoxTo4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTo4.Location = new System.Drawing.Point(6, 281);
            this.textBoxTo4.Name = "textBoxTo4";
            this.textBoxTo4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTo4.Size = new System.Drawing.Size(533, 22);
            this.textBoxTo4.TabIndex = 6;
            // 
            // buttonTo1
            // 
            this.buttonTo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTo1.Location = new System.Drawing.Point(404, 66);
            this.buttonTo1.Name = "buttonTo1";
            this.buttonTo1.Size = new System.Drawing.Size(135, 33);
            this.buttonTo1.TabIndex = 7;
            this.buttonTo1.Text = "انتخاب پوشه ۱";
            this.buttonTo1.UseVisualStyleBackColor = true;
            this.buttonTo1.Click += new System.EventHandler(this.ButtonTo1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(733, 418);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(135, 50);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "بستن فرم";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 515);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.btnFileSelecttion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ورود فایل";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog threadingOpenFileDialog;
        private System.Windows.Forms.Button btnFileSelecttion;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxFrom1;
        private System.Windows.Forms.TextBox textBoxFrom2;
        private System.Windows.Forms.TextBox textBoxFrom3;
        private System.Windows.Forms.TextBox textBoxFrom4;
        private System.Windows.Forms.Button buttonFrom1;
        private System.Windows.Forms.Button buttonFrom2;
        private System.Windows.Forms.Button buttonFrom3;
        private System.Windows.Forms.Button buttonFrom4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTo1;
        private System.Windows.Forms.Button buttonTo4;
        private System.Windows.Forms.TextBox textBoxTo2;
        private System.Windows.Forms.Button buttonTo3;
        private System.Windows.Forms.TextBox textBoxTo3;
        private System.Windows.Forms.Button buttonTo2;
        private System.Windows.Forms.TextBox textBoxTo4;
        private System.Windows.Forms.Button buttonTo1;
        private System.Windows.Forms.Button buttonClose;
    }
}

