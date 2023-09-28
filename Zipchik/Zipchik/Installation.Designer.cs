namespace Zipchik
{
    partial class Installation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installation));
            this.Back2 = new System.Windows.Forms.Button();
            this.cancel2 = new System.Windows.Forms.Button();
            this.Next2 = new System.Windows.Forms.Button();
            this.groupBoxSelectingFolder = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelUnpacking = new System.Windows.Forms.Label();
            this.textBoxreView = new System.Windows.Forms.TextBox();
            this.labelSelectingFolder2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSelectingFolder = new System.Windows.Forms.Label();
            this.labellicense = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxSelectingFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Back2
            // 
            this.Back2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back2.Location = new System.Drawing.Point(337, 375);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(93, 32);
            this.Back2.TabIndex = 20;
            this.Back2.Text = "< Назад";
            this.Back2.UseVisualStyleBackColor = true;
            this.Back2.Click += new System.EventHandler(this.Back2_Click);
            // 
            // cancel2
            // 
            this.cancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel2.Location = new System.Drawing.Point(535, 375);
            this.cancel2.Name = "cancel2";
            this.cancel2.Size = new System.Drawing.Size(93, 32);
            this.cancel2.TabIndex = 19;
            this.cancel2.Text = "Завершить";
            this.cancel2.UseVisualStyleBackColor = true;
            this.cancel2.Click += new System.EventHandler(this.cancel2_Click);
            // 
            // Next2
            // 
            this.Next2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next2.Location = new System.Drawing.Point(436, 375);
            this.Next2.Name = "Next2";
            this.Next2.Size = new System.Drawing.Size(93, 32);
            this.Next2.TabIndex = 18;
            this.Next2.Text = "Установить";
            this.Next2.UseVisualStyleBackColor = true;
            this.Next2.Click += new System.EventHandler(this.Next2_Click);
            // 
            // groupBoxSelectingFolder
            // 
            this.groupBoxSelectingFolder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxSelectingFolder.Controls.Add(this.checkBox1);
            this.groupBoxSelectingFolder.Controls.Add(this.labelUnpacking);
            this.groupBoxSelectingFolder.Controls.Add(this.textBoxreView);
            this.groupBoxSelectingFolder.Controls.Add(this.labelSelectingFolder2);
            this.groupBoxSelectingFolder.Controls.Add(this.pictureBox1);
            this.groupBoxSelectingFolder.Controls.Add(this.progressBar);
            this.groupBoxSelectingFolder.Location = new System.Drawing.Point(2, 91);
            this.groupBoxSelectingFolder.Name = "groupBoxSelectingFolder";
            this.groupBoxSelectingFolder.Size = new System.Drawing.Size(632, 278);
            this.groupBoxSelectingFolder.TabIndex = 17;
            this.groupBoxSelectingFolder.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(59, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(371, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Использовать отображение этого окна (скорость меньше в 2 раза)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelUnpacking
            // 
            this.labelUnpacking.AutoSize = true;
            this.labelUnpacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnpacking.Location = new System.Drawing.Point(270, 51);
            this.labelUnpacking.Name = "labelUnpacking";
            this.labelUnpacking.Size = new System.Drawing.Size(94, 16);
            this.labelUnpacking.TabIndex = 18;
            this.labelUnpacking.Text = "Распаковка...";
            // 
            // textBoxreView
            // 
            this.textBoxreView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxreView.Location = new System.Drawing.Point(53, 125);
            this.textBoxreView.Multiline = true;
            this.textBoxreView.Name = "textBoxreView";
            this.textBoxreView.ReadOnly = true;
            this.textBoxreView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxreView.Size = new System.Drawing.Size(445, 147);
            this.textBoxreView.TabIndex = 11;
            this.textBoxreView.Text = "После установки здесь отобразится список скопированных фаилов";
            // 
            // labelSelectingFolder2
            // 
            this.labelSelectingFolder2.AutoSize = true;
            this.labelSelectingFolder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectingFolder2.Location = new System.Drawing.Point(124, 51);
            this.labelSelectingFolder2.Name = "labelSelectingFolder2";
            this.labelSelectingFolder2.Size = new System.Drawing.Size(140, 16);
            this.labelSelectingFolder2.TabIndex = 10;
            this.labelSelectingFolder2.Text = "Установка фаилов...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(55, 96);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(443, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.labelSelectingFolder);
            this.groupBox1.Controls.Add(this.labellicense);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 88);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // labelSelectingFolder
            // 
            this.labelSelectingFolder.AutoSize = true;
            this.labelSelectingFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectingFolder.Location = new System.Drawing.Point(32, 39);
            this.labelSelectingFolder.Name = "labelSelectingFolder";
            this.labelSelectingFolder.Size = new System.Drawing.Size(297, 16);
            this.labelSelectingFolder.TabIndex = 8;
            this.labelSelectingFolder.Text = "Дождитесь пока {___} установится на ваш пк";
            // 
            // labellicense
            // 
            this.labellicense.AutoSize = true;
            this.labellicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellicense.Location = new System.Drawing.Point(11, 17);
            this.labellicense.Name = "labellicense";
            this.labellicense.Size = new System.Drawing.Size(86, 16);
            this.labellicense.TabIndex = 7;
            this.labellicense.Text = "Установка";
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
            // Installation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.Back2);
            this.Controls.Add(this.cancel2);
            this.Controls.Add(this.Next2);
            this.Controls.Add(this.groupBoxSelectingFolder);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Installation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Installation_FormClosed);
            this.Load += new System.EventHandler(this.Installation_Load);
            this.groupBoxSelectingFolder.ResumeLayout(false);
            this.groupBoxSelectingFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back2;
        private System.Windows.Forms.Button cancel2;
        private System.Windows.Forms.Button Next2;
        private System.Windows.Forms.GroupBox groupBoxSelectingFolder;
        private System.Windows.Forms.TextBox textBoxreView;
        private System.Windows.Forms.Label labelSelectingFolder2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSelectingFolder;
        private System.Windows.Forms.Label labellicense;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelUnpacking;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}