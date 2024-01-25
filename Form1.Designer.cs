namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            value1 = new System.Windows.Forms.Label();
            value2 = new System.Windows.Forms.Label();
            value3 = new System.Windows.Forms.Label();
            value4 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Gradient_Timer = new System.Windows.Forms.Timer(components);
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(539, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 35);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(539, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 35);
            label2.TabIndex = 0;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(539, 170);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 35);
            label3.TabIndex = 0;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(539, 228);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 35);
            label4.TabIndex = 0;
            label4.Text = "label1";
            // 
            // value1
            // 
            value1.AutoSize = true;
            value1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            value1.Location = new System.Drawing.Point(650, 53);
            value1.Name = "value1";
            value1.Size = new System.Drawing.Size(25, 35);
            value1.TabIndex = 0;
            value1.Text = "-";
            // 
            // value2
            // 
            value2.AutoSize = true;
            value2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            value2.Location = new System.Drawing.Point(650, 109);
            value2.Name = "value2";
            value2.Size = new System.Drawing.Size(25, 35);
            value2.TabIndex = 0;
            value2.Text = "-";
            // 
            // value3
            // 
            value3.AutoSize = true;
            value3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            value3.Location = new System.Drawing.Point(650, 170);
            value3.Name = "value3";
            value3.Size = new System.Drawing.Size(25, 35);
            value3.TabIndex = 0;
            value3.Text = "-";
            // 
            // value4
            // 
            value4.AutoSize = true;
            value4.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            value4.Location = new System.Drawing.Point(650, 228);
            value4.Name = "value4";
            value4.Size = new System.Drawing.Size(25, 35);
            value4.TabIndex = 0;
            value4.Text = "-";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(59, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(158, 142);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Gradient_Timer
            // 
            Gradient_Timer.Tick += Gradient_Timer_Tick;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(158, 315);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 58);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(value4);
            Controls.Add(value3);
            Controls.Add(value2);
            Controls.Add(value1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label value1;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.Label value3;
        private System.Windows.Forms.Label value4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Gradient_Timer;
        private System.Windows.Forms.Button button1;
    }
}
