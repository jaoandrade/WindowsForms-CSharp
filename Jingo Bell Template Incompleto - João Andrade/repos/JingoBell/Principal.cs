using System;
using System.Windows.Forms;

namespace JingoBell
{
    internal class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.preview1;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(737, 466);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            BackgroundImage = Properties.Resources.preview1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 461);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Principal";
            Load += Principal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;

        private void Principal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
            this.TransparencyKey = Color.DarkRed;
        }
    }
}
