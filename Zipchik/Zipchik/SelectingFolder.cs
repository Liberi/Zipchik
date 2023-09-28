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
using System.Threading;
using System.Security.Cryptography;

namespace Zipchik
{
    public partial class SelectingFolder : Form
    {

        public SelectingFolder()
        {
            InitializeComponent();
            StreamReader sr1 = new StreamReader("ProgramName.txt");//беру название проги из фаила
            NameSpase = sr1.ReadToEnd();
            StreamReader sr2 = new StreamReader("standardLocation.txt");//беру стандартный путь из фаила
            labelSelectingFolder.Text = $"В какую папку вы хотите установить {NameSpase}?";//присваиваю
            labelSelectingFolder2.Text = $"Программа установит {NameSpase} в следующую папку.";//присваиваю
            FileDirectory = sr2.ReadToEnd();
            textBoxreView.Text = FileDirectory;//присваиваю
        }

        private void SelectingFolder_Load(object sender, EventArgs e)
        {
            /*StreamReader sr4 = new StreamReader("standardLocation.txt");//беру путь из фаила
            FileDirectory = sr4.ReadToEnd();
            textBoxreView.Lines = File.ReadAllLines("standardLocation.txt");//вставляю стандартный путь в текстбокс*/
            Next2.Focus();
        }

        private void Back2_Click(object sender, EventArgs e)
        {
            License license = new License();//переход формы
            license.Show();
            this.Hide();
        }

        private void cancel2_Click(object sender, EventArgs e)
        {
            DialogResult dres = MessageBox.Show("Хотите отменить установку?",
                "Выход из установки",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dres == DialogResult.Yes) { Application.Exit(); }

            //Application.Exit();
        }
        string FileDirectory, NameSpase; //задю переменную для присваивания пути фаила
       // bool FileDirectoryFT = true; //для проверки был ли выбран путь через обзор
        private void buttonrVeiew_Click(object sender, EventArgs e)
        {
            //работа кнопки обзор
           /* FolderBrowserDialog — это обычная форма, а значит метод ShowDialog будет возвращать перечисление DialogResult. 
            * В нашем случае если пользователь в окне выбора папки, нажмет кнопку «Отмена», то метод вернет DialogResult.Cancel, если же папку выберут и нажмут «ОК», то DialogResult.OK.
            Таким образом наше условие, показывает нам выбранный путь только тогда, когда мы выбрали нужную директорию и нажали кнопку «ОК».
            По умолчанию окно FolderBrowserDialog позволяет создать новую папку «налету». Для того чтобы убрать данную возможность, 
            перед вызовом метода ShowDialog необходимо задать свойство ShowNewFolderButton = false.*/
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                textBoxreView.Text = FBD.SelectedPath;
                FileDirectory = FBD.SelectedPath;
                //FileDirectoryFT = false;//для проверки был ли выбран путь через обзор
            }
            Next2.Focus();

        }
        private void Next2_Click(object sender, EventArgs e)
        {
            //if (FileDirectoryFT) FileDirectory = textBoxreView.Text;//для проверки был ли выбран путь через обзор
            StreamWriter streamwriter = new StreamWriter("filePath.txt");//запоминаем путь в фаиле
            streamwriter.Write(FileDirectory);
            streamwriter.Close();//закрываем поток 

            Installation installation = new Installation();//переход к след. форме
            installation.Show();
            this.Hide();
        }

        private void SelectingFolder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
