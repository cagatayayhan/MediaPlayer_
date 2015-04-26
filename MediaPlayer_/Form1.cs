using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer_
{
    public partial class Form1 : Form
    {
        string DosyaYolu;
        string DosyaAdi;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = "C:\\Users\\pc\\Desktop\\1.mp3";
            

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Mp3 dosyası |*.mp3"; 
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Mp3 Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                 DosyaYolu = file.FileName;
                 DosyaAdi = file.SafeFileName;
            }
            axWindowsMediaPlayer1.URL = DosyaYolu ;
            pictureBox1.ImageLocation = "C:\\Users\\Public\\Pictures\\Sample Pictures\\1.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Mp3 dosyası |*.mp3";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Mp3 Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
                DosyaAdi = file.SafeFileName;
            }
            axWindowsMediaPlayer1.URL = DosyaYolu;
            pictureBox1.ImageLocation = "C:\\Users\\Public\\Pictures\\Sample Pictures\\2.jpg";
        }
    }
}
