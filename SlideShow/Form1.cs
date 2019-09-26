using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int imageCount = 1;


        private void loadImage()
        {
            if (imageCount > 5)
            {
                imageCount = 1;
            }

            int image_left = imageCount - 1;
            if (image_left < 1)
            {
                image_left = 5;
            }

            int image_right = imageCount + 1;
            if (image_right > 5)
            {
                image_right = 1;
            }

            pictureBox4.ImageLocation = string.Format(@"image\image_0{0}.jpg", imageCount);
            pictureBox6.ImageLocation = string.Format(@"image\image_0{0}.jpg", imageCount);

            pictureBox5.ImageLocation = string.Format(@"image\image_0{0}.jpg", image_left);
            pictureBox7.ImageLocation = string.Format(@"image\image_0{0}.jpg", image_right);

            imageCount++;
        }
            private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

            private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            loadImage();

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
