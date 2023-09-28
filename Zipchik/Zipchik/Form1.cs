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

namespace Zipchik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("ProgramName.txt");//беру название проги из фаила
            labelInstall.Text = $"Программа установит {sr.ReadToEnd()} \r\n на ваш компьютер.";//присваиваю
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            DialogResult dres = MessageBox.Show("Хотите отменить установку?",//выход
                "Выход из установки",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dres == DialogResult.Yes) { Application.Exit(); }
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            License license = new License();//переход к след. форме
            license.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Next1.Focus();
        }
    }
}
