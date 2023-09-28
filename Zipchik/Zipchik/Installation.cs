using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.IO.Compression;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using IWshRuntimeLibrary;
using System.Xml.Linq;

namespace Zipchik
{
    public partial class Installation : Form
    {
        public Installation()
        {
            InitializeComponent();
        }
        string NameSpase;
        private void Installation_Load(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Нажмите _Установить_ для загрузки компонентов",
                "Начало установки",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();//подсказка на чекбоксе
            ToolTip.SetToolTip(this.checkBox1, "Отображение фаилов ПОСЛЕ установки, но при этом скорость загруки снижена в ~2 раза");
            textBoxreView.Text = "После установки здесь отобразится список скопированных фаилов";
            textBoxreView.SelectionStart = 0;//отмена выделения текста в текстбоксе
            Next2.Focus();
            StreamReader sr1 = new StreamReader("ProgramName.txt");//беру название проги из фаила
            NameSpase = sr1.ReadToEnd();
            labelSelectingFolder.Text = $"Дождитесь пока {NameSpase} установится на ваш пк";//присваиваю
            StreamReader sr = new StreamReader("filePath.txt");//беру путь из фаила
            FileDirectory = sr.ReadToEnd();//присваиваю


        }
        public int installationProcess = 0;

        public void Copy(string sourceDirectory, string targetDirectory)//главный метод для копирования
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }
        bool checkBox1ft = false; //для проверки будет ли использоваться панель отображения фаилов
        public void CopyAll(DirectoryInfo source, DirectoryInfo target, int installationProcess = 0)
        {
            // Если директория target.FullName не существует, создать ее
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Копируем файлы из sourceDirectory в targetDirectory
            foreach (FileInfo fi in source.GetFiles())
            {
                if (checkBox1ft) textBoxreView.Text += $@"Копирование из {target.FullName} в\ {fi.Name}"; //для проверки будет ли использоваться панель отображения фаилов
                try { fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true); }
                catch
                {
                    DialogResult res = MessageBox.Show("Возникли ошибки при копировнии фаилов, отключите антивирус и повторите установку",
                                                           "Ошибка уствноыки",
                                                           MessageBoxButtons.OK,
                                                           MessageBoxIcon.Error);
                    Application.Exit();
                }; //если возникает ошибка при перекидывании (например если найден вирус), вызов сообщения об этом
                installationProcess++;//не используется 
                progressBar.Value++; //увеличиваю шкалу загрузки
            }
            //копируем поддиректории
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
                installationProcess++;
            }
        }

        private void cancel2_Click(object sender, EventArgs e)
        {
            Directory.Delete(nameExtractionfile, true);
            Application.Exit();//выход
        }

        private void Back2_Click(object sender, EventArgs e)
        {
            //возврат на пред. форму
            SelectingFolder newForm = new SelectingFolder();
            newForm.Show();
            this.Hide();
        }
        string FileDirectory, extractPath, nameExtractionfile;
        private void Next2_Click(object sender, EventArgs e)
        {
            Next2.Enabled = false;//делю невозможным нажать Установить
            if (!checkBox1ft) { textBoxreView.Visible = false; }
            checkBox1.Visible = false;
            extractPath = @".\Files";//получаю путь к папке с фаилами
            nameExtractionfile = "Files";//получаю просто название папки c фаилами

            try { ZipFile.ExtractToDirectory("fileArchive.zip", nameExtractionfile); }//распаковываю zip папку по названию папки и названию новой папки и игнорю распакоку если фаилы уже есть
            catch { }

            labelUnpacking.Visible = false; //скрываю текст "распаковка..."
            Thread.Sleep(1000);//жду секунду для начала копирования
            int fileCount = Directory.GetFiles(extractPath, "*.*", SearchOption.AllDirectories).Length;//рассчитываю колл фаилов папке
            progressBar.Maximum = fileCount;//задаю макс знач шкалы загрузки

            Copy(extractPath, FileDirectory);//копирую фаилы откуда,куда

            StreamReader sr = new StreamReader("filePath.txt");//достаю 1-ю чать пути из фаила
            string filePath = sr.ReadToEnd();//присваиваю
            StreamReader sr1 = new StreamReader("wayLink.txt");//достаю 2-ю чать пути из фаила
            string wayLink = sr1.ReadToEnd();//присваиваю
            //начинаю создавать ярлык
            // Создание объекта оболочки Windows Script Host
            WshShell shell = new WshShell();
            //путь к ярлыку
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\{NameSpase}.lnk";
            //создаем объект ярлыка
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
            //задаем свойства для ярлыка
            //описание ярлыка в всплывающей подсказке
            shortcut.Description = $"Ярлык для программы {NameSpase}";
            //горячая клавиша
                //shortcut.Hotkey = "Ctrl+Shift+N";
            //путь к самой программе
            shortcut.TargetPath = $@"{filePath}{wayLink}";
            //Создаем ярлык
            shortcut.Save();
            DialogResult res = MessageBox.Show("Установка компонентов завершена",//сообщение о завершении
                            "Выход из установки",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Question);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //проверка будет ли использоваться панель отображения фаилов
            if (checkBox1.Checked)
            {
                checkBox1ft = true;
            }
            else
            {
                checkBox1ft = false;
            }
        }

        private void Installation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
