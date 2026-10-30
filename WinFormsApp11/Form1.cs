using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPlaneImage();
        }

        bool isSystemOn = false;

        SoundPlayer spBeep = new SoundPlayer("beep.wav");
        SoundPlayer spEnis = new SoundPlayer("inishazirliklari.wav");
        SoundPlayer spKemer = new SoundPlayer("kemerler.wav");
        SoundPlayer spTurbulans = new SoundPlayer("turbulans.wav");
        SoundPlayer spTesekkur = new SoundPlayer("tesekkurler.wav");
        SoundPlayer spOnOff = new SoundPlayer("isikacmakapamasesi.wav");

        private void LoadPlaneImage()
        {
            try
            {
                if (File.Exists("teyyarə.png"))
                {
                    pictureBox1.Image = Image.FromFile("teyyarə.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şəkil yüklənərkən xəta: " + ex.Message);
            }
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            spOnOff.Play();
            isSystemOn = !isSystemOn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isSystemOn) { spEnis.Play(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isSystemOn) { spTurbulans.Play(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isSystemOn) { spKemer.Play(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isSystemOn) { spTesekkur.Play(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isSystemOn) { spBeep.Play(); }
        }

        private void buttonGas_Click(object sender, EventArgs e)
        {
            if (isSystemOn)
            {
                timer1.Start(); 
            }
        }

        private void buttonBreak_Click(object sender, EventArgs e)
        {
            if (isSystemOn)
            {
                timer1.Stop(); 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;

            if (pictureBox1.Top < -pictureBox1.Height)
            {
                pictureBox1.Top = this.ClientSize.Height;
            }
        }
    }
}