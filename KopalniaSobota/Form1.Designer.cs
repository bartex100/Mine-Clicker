namespace KopalniaSobota
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(92, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(37, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(37, 63);
            button1.Name = "button1";
            button1.Size = new Size(145, 36);
            button1.TabIndex = 2;
            button1.Text = "Kilofuj kamień";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(189, 12);
            button2.Name = "button2";
            button2.Size = new Size(137, 87);
            button2.TabIndex = 3;
            button2.Text = "Ulepszenie ostrza:\r\nKamienne\r\n50$";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 4;
            label1.Text = "0$";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(189, 105);
            button3.Name = "button3";
            button3.Size = new Size(137, 55);
            button3.TabIndex = 5;
            button3.Text = "Ulepszenie Rękojeści:\r\nGumowa\r\n50$";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(332, 12);
            button4.Name = "button4";
            button4.Size = new Size(137, 55);
            button4.TabIndex = 6;
            button4.Text = "0 x dynamit\r\n1\U0001f9e8/s\r\n3000$";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(475, 12);
            button5.Name = "button5";
            button5.Size = new Size(137, 55);
            button5.TabIndex = 7;
            button5.Text = "0 x koparka\r\n50$/s\r\n750$";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(618, 12);
            button6.Name = "button6";
            button6.Size = new Size(140, 55);
            button6.TabIndex = 8;
            button6.Text = "Wyrzutnia dynamitu\r\n1\U0001f9e8⇨150$\r\n5000$";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(475, 73);
            button7.Name = "button7";
            button7.Size = new Size(137, 55);
            button7.TabIndex = 9;
            button7.Text = "0 x Duża koparka\r\n150$/s\r\n2000$";
            button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}