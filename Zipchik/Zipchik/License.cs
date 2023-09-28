using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zipchik
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
            
        }

        private void License_Load(object sender, EventArgs e)
        {
            textBoxLicense.Lines = (File.ReadAllLines("license.txt"));//берем текст лицензии из фаила
            textBoxLicense.SelectionStart = 0;//отмена выделения текста в текстбоксе
            Next2.Focus();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            DialogResult dres = MessageBox.Show("Хотите отменить установку?",
                "Выход из установки",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dres == DialogResult.Yes) { Application.Exit(); }

            //Application.Exit();

        }

        private void checkBoxLicense_CheckedChanged(object sender, EventArgs e)
        {
            //проверяем принятие лицензии
            if (checkBoxLicense.Checked)
            {
                Next2.Enabled = true;
            }
            else
            {
                Next2.Enabled = false;
            }
        }

        private void Back2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();//переход назад
            form1.Show();
            this.Hide();
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            SelectingFolder newForm = new SelectingFolder();//переход к след. форме
            newForm.Show();
            this.Hide();
        }

        private void License_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
