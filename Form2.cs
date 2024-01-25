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


            Size tosize = new Size(size_Height + (int)size, size_Width + (int)size); // 사진의 크기값에 계산값을 더합니다.
            pictureBox1.Size = tosize; // 사진에 위 계산값의 위치값을 부여합니다.

            value1.Text = size.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Breath_Effect.Enabled = true;
        }
    }
}
