namespace TwoCars
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
            panel1 = new Panel();
            picObs_R = new PictureBox();
            picPoint_R = new PictureBox();
            picPoint_L = new PictureBox();
            picObs_L = new PictureBox();
            Car_L = new PictureBox();
            Car_R = new PictureBox();
            panel2 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            labelScore = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picObs_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPoint_R).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPoint_L).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picObs_L).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car_L).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car_R).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.DarkGray;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(picObs_R);
            panel1.Controls.Add(picPoint_R);
            panel1.Controls.Add(picPoint_L);
            panel1.Controls.Add(picObs_L);
            panel1.Controls.Add(Car_L);
            panel1.Controls.Add(Car_R);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(210, -18);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 697);
            panel1.TabIndex = 0;
            // 
            // picObs_R
            // 
            picObs_R.Anchor = AnchorStyles.None;
            picObs_R.BackColor = Color.FromArgb(255, 128, 128);
            picObs_R.Location = new Point(363, 138);
            picObs_R.Name = "picObs_R";
            picObs_R.Size = new Size(45, 50);
            picObs_R.TabIndex = 11;
            picObs_R.TabStop = false;
            // 
            // picPoint_R
            // 
            picPoint_R.Anchor = AnchorStyles.None;
            picPoint_R.BackColor = Color.FromArgb(0, 0, 192);
            picPoint_R.Location = new Point(252, 138);
            picPoint_R.Name = "picPoint_R";
            picPoint_R.Size = new Size(45, 50);
            picPoint_R.TabIndex = 10;
            picPoint_R.TabStop = false;
            // 
            // picPoint_L
            // 
            picPoint_L.Anchor = AnchorStyles.None;
            picPoint_L.BackColor = Color.FromArgb(255, 128, 128);
            picPoint_L.Location = new Point(137, 138);
            picPoint_L.Name = "picPoint_L";
            picPoint_L.Size = new Size(45, 50);
            picPoint_L.TabIndex = 9;
            picPoint_L.TabStop = false;
            // 
            // picObs_L
            // 
            picObs_L.Anchor = AnchorStyles.None;
            picObs_L.BackColor = Color.FromArgb(0, 0, 192);
            picObs_L.Location = new Point(31, 138);
            picObs_L.Name = "picObs_L";
            picObs_L.Size = new Size(45, 50);
            picObs_L.TabIndex = 8;
            picObs_L.TabStop = false;
            // 
            // Car_L
            // 
            Car_L.Anchor = AnchorStyles.Bottom;
            Car_L.BackColor = Color.Transparent;
            Car_L.Image = (Image)resources.GetObject("Car_L.Image");
            Car_L.Location = new Point(134, 443);
            Car_L.Name = "Car_L";
            Car_L.Size = new Size(57, 82);
            Car_L.SizeMode = PictureBoxSizeMode.StretchImage;
            Car_L.TabIndex = 13;
            Car_L.TabStop = false;
            // 
            // Car_R
            // 
            Car_R.Anchor = AnchorStyles.Bottom;
            Car_R.BackColor = Color.Transparent;
            Car_R.BackgroundImageLayout = ImageLayout.None;
            Car_R.Image = (Image)resources.GetObject("Car_R.Image");
            Car_R.Location = new Point(246, 443);
            Car_R.Name = "Car_R";
            Car_R.Size = new Size(57, 82);
            Car_R.SizeMode = PictureBoxSizeMode.StretchImage;
            Car_R.TabIndex = 12;
            Car_R.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackColor = Color.White;
            panel2.Location = new Point(214, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 541);
            panel2.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel6.BackColor = Color.White;
            panel6.Location = new Point(328, -2);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 541);
            panel6.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel5.BackColor = Color.White;
            panel5.Location = new Point(110, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 541);
            panel5.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // labelScore
            // 
            labelScore.Anchor = AnchorStyles.Top;
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.Location = new Point(648, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(82, 30);
            labelScore.TabIndex = 1;
            labelScore.Text = "Score: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(854, 519);
            Controls.Add(labelScore);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            KeyPress += Form1_KeyPress;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picObs_R).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPoint_R).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPoint_L).EndInit();
            ((System.ComponentModel.ISupportInitialize)picObs_L).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car_L).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car_R).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private PictureBox picPoint_R;
        private PictureBox picPoint_L;
        private PictureBox picObs_L;
        private PictureBox picObs_R;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Car_R;
        private PictureBox Car_L;
        private Label labelScore;
    }
}
