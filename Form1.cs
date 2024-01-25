using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static int second_count = 0; // 일정 값마다 초기화 하지 않는 카운트 수를 선언합니다.

        public Form1()
        {
            InitializeComponent();
            Gradient_Timer.Interval = 18;  // 해당 값을 조정해서 프레임값을 조절합니다.
        }

        private void Gradient_Timer_Tick(object sender, EventArgs e)
        {

            second_count++;
            int pic_x = pictureBox1.Location.X;
            int pic_y = pictureBox1.Location.Y;

            double gradient = 10 * Math.Pow(0.9, second_count); // 그라데이션 효과값을 계산합니다. 10 부분을 조절해서 이동값을 조절합니다.
            Point point = new Point(pic_x, pic_y + (int)gradient); //계산값을 사진 좌표값에 부여합니다. X좌표와 Y좌표 모두 부여 가능합니다.
            pictureBox1.Location = point; 

            if (second_count == 35) // 움직이는 시간을 조절합니다.
            {
                Gradient_Timer.Enabled = false; 
                second_count = 0; // 위 두개의 코드를 사용해 초기화하여 재구현 가능하게 합니다.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gradient_Timer.Enabled = true; // 그라데이션 이펙트을 구현합니다.
        }
    }
}
