using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Breath_Effect.Enabled = false;
        }
        static int Second_count = 0;

        private void Breath_Effect_Tick(object sender, EventArgs e)
        {
            Second_count++;
            double size = 3 * Math.Sin(Second_count * 0.1); // 정수 3 부분으로 크기를 조절하고, 0.1 부분으로 주기를 조절합니다.
            int size_Width = pictureBox1.Size.Width;
            int size_Height = pictureBox1.Size.Height; // 사진의 크기값들을 불러옵니다.

            int X_point = pictureBox1.Location.X;  // 위치 조정을 위해 사진의 위치값을 받습니다.
            int Y_point = pictureBox1.Location.Y;


            Size tosize = new Size(size_Height + (int)size, size_Width + (int)size); // 사진의 크기값에 계산값을 더합니다.
            Point topoint = new Point(X_point - (int)(size / 1.75), Y_point - (int)(size / 1.75)); // 위치값을 계산하여 조정합니다.

            pictureBox1.Size = tosize; // 사진에 위 계산값의 위치값을 부여해 조정합니다.
            pictureBox1.Location = topoint;
            value1.Text = string.Format("{0:0.###0}", size);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Breath_Effect.Enabled = true;
        }
    }
}
