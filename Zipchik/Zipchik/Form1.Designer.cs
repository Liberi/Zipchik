namespace Zipchik
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Next1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Hello = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labeltext = new System.Windows.Forms.Label();
            this.labelInstall = new System.Windows.Forms.Label();
            this.cancel1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Next1
            // 
            this.Next1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next1.Location = new System.Drawing.Point(430, 375);
            this.Next1.Name = "Next1";
            this.Next1.Size = new System.Drawing.Size(93, 32);
            this.Next1.TabIndex = 0;
            this.Next1.Text = "Далее >";
            this.Next1.UseVisualStyleBackColor = true;
            this.Next1.Click += new System.EventHandler(this.Next1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hello.Location = new System.Drawing.Point(7, 20);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(309, 74);
            this.Hello.TabIndex = 2;
            this.Hello.Text = "Вас приветствет \r\nустановщик Zipchik";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.labeltext);
            this.groupBox1.Controls.Add(this.labelInstall);
            this.groupBox1.Controls.Add(this.Hello);
            this.groupBox1.Location = new System.Drawing.Point(216, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 379);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(344, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltext.Location = new System.Drawing.Point(12, 168);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(383, 120);
            this.labeltext.TabIndex = 4;
            this.labeltext.Text = "Рекомендуется закрыть все прочие приложения \r\nперед тем, как продолжить.\r\n\r\nНажми" +
    "те «Далее», чтобы продолжить, \r\nили «Отмена»,\r\nчтобы выйти из программы установк" +
    "и.";
            // 
            // labelInstall
            // 
            this.labelInstall.AutoSize = true;
            this.labelInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstall.Location = new System.Drawing.Point(12, 111);
            this.labelInstall.Name = "labelInstall";
            this.labelInstall.Size = new System.Drawing.Size(222, 40);
            this.labelInstall.TabIndex = 3;
            this.labelInstall.Text = "Программа установит {___} \r\nна ваш компьютер.";
            // 
            // cancel1
            // 
            this.cancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel1.Location = new System.Drawing.Point(529, 375);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(93, 32);
            this.cancel1.TabIndex = 4;
            this.cancel1.Text = "Выход";
            this.cancel1.UseVisualStyleBackColor = true;
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Next1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начало утановки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Next1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.Label labelInstall;
        private System.Windows.Forms.Button cancel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

