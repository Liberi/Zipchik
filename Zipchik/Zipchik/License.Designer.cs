namespace Zipchik
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labellicense = new System.Windows.Forms.Label();
            this.groupBoxLicense = new System.Windows.Forms.GroupBox();
            this.checkBoxLicense = new System.Windows.Forms.CheckBox();
            this.textBoxLicense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel2 = new System.Windows.Forms.Button();
            this.Next2 = new System.Windows.Forms.Button();
            this.Back2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(559, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labellicense);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 88);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пожалуйста, прочтите следующую важную информацию перед тем, как\nпродолжить.";
            // 
            // labellicense
            // 
            this.labellicense.AutoSize = true;
            this.labellicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellicense.Location = new System.Drawing.Point(11, 17);
            this.labellicense.Name = "labellicense";
            this.labellicense.Size = new System.Drawing.Size(210, 16);
            this.labellicense.TabIndex = 7;
            this.labellicense.Text = "Лицензионное Соглашение";
            // 
            // groupBoxLicense
            // 
            this.groupBoxLicense.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxLicense.Controls.Add(this.checkBoxLicense);
            this.groupBoxLicense.Controls.Add(this.textBoxLicense);
            this.groupBoxLicense.Controls.Add(this.label1);
            this.groupBoxLicense.Location = new System.Drawing.Point(1, 80);
            this.groupBoxLicense.Name = "groupBoxLicense";
            this.groupBoxLicense.Size = new System.Drawing.Size(633, 288);
            this.groupBoxLicense.TabIndex = 8;
            this.groupBoxLicense.TabStop = false;
            // 
            // checkBoxLicense
            // 
            this.checkBoxLicense.AutoSize = true;
            this.checkBoxLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLicense.Location = new System.Drawing.Point(39, 250);
            this.checkBoxLicense.Name = "checkBoxLicense";
            this.checkBoxLicense.Size = new System.Drawing.Size(240, 20);
            this.checkBoxLicense.TabIndex = 10;
            this.checkBoxLicense.Text = "Я принимаюусловия соглашения";
            this.checkBoxLicense.UseVisualStyleBackColor = true;
            this.checkBoxLicense.CheckedChanged += new System.EventHandler(this.checkBoxLicense_CheckedChanged);
            // 
            // textBoxLicense
            // 
            this.textBoxLicense.Location = new System.Drawing.Point(35, 41);
            this.textBoxLicense.Multiline = true;
            this.textBoxLicense.Name = "textBoxLicense";
            this.textBoxLicense.ReadOnly = true;
            this.textBoxLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLicense.Size = new System.Drawing.Size(490, 197);
            this.textBoxLicense.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пожалуйста, прочтите следующее Лицензионное Соглашение. Вы должны\nпринять условия" +
    " этого соглашения перед тем, как продолжить.";
            // 
            // cancel2
            // 
            this.cancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel2.Location = new System.Drawing.Point(529, 374);
            this.cancel2.Name = "cancel2";
            this.cancel2.Size = new System.Drawing.Size(93, 32);
            this.cancel2.TabIndex = 11;
            this.cancel2.Text = "Отмена";
            this.cancel2.UseVisualStyleBackColor = true;
            this.cancel2.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // Next2
            // 
            this.Next2.Enabled = false;
            this.Next2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next2.Location = new System.Drawing.Point(430, 374);
            this.Next2.Name = "Next2";
            this.Next2.Size = new System.Drawing.Size(93, 32);
            this.Next2.TabIndex = 10;
            this.Next2.Text = "Далее >";
            this.Next2.UseVisualStyleBackColor = true;
            this.Next2.Click += new System.EventHandler(this.Next2_Click);
            // 
            // Back2
            // 
            this.Back2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back2.Location = new System.Drawing.Point(331, 374);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(93, 32);
            this.Back2.TabIndex = 12;
            this.Back2.Text = "< Назад";
            this.Back2.UseVisualStyleBackColor = true;
            this.Back2.Click += new System.EventHandler(this.Back2_Click);
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.Back2);
            this.Controls.Add(this.cancel2);
            this.Controls.Add(this.Next2);
            this.Controls.Add(this.groupBoxLicense);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.License_FormClosed);
            this.Load += new System.EventHandler(this.License_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxLicense.ResumeLayout(false);
            this.groupBoxLicense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labellicense;
        private System.Windows.Forms.TextBox textBoxLicense;
        private System.Windows.Forms.Button cancel2;
        private System.Windows.Forms.Button Next2;
        private System.Windows.Forms.Button Back2;
        private System.Windows.Forms.CheckBox checkBoxLicense;
    }
}