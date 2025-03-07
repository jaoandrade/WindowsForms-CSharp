using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JingoBell
{
    internal class MusicSettings : Form
    {
        public MusicSettings()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            titlebar.MouseDown += titlebar_MouseDown;
            titlebar.MouseMove += titlebar_MouseMove;
            titlebar.MouseUp += titlebar_MouseUp;
        }
        private bool isDragging = false;
        private Label label1;
        private PictureBox StopMusicPicbox;
        private PictureBox PreviousMusicPicbox;
        private PictureBox NextMusicPicbox;
        private PictureBox UnpauseMusicPicbox;
        private PictureBox pictureBox1;
        private Point clickOffset;
        private void InitializeComponent()
        {
            titlebar = new PictureBox();
            label1 = new Label();
            StopMusicPicbox = new PictureBox();
            PreviousMusicPicbox = new PictureBox();
            NextMusicPicbox = new PictureBox();
            UnpauseMusicPicbox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)titlebar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StopMusicPicbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PreviousMusicPicbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NextMusicPicbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnpauseMusicPicbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titlebar
            // 
            titlebar.BackColor = Color.Transparent;
            titlebar.BackgroundImageLayout = ImageLayout.Stretch;
            titlebar.Image = Properties.Resources.image_1_;
            titlebar.Location = new Point(-1, -2);
            titlebar.Name = "titlebar";
            titlebar.Size = new Size(410, 50);
            titlebar.SizeMode = PictureBoxSizeMode.StretchImage;
            titlebar.TabIndex = 0;
            titlebar.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Heyam", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(397, 34);
            label1.TabIndex = 1;
            label1.Text = "Music Settings";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // StopMusicPicbox
            // 
            StopMusicPicbox.BackColor = Color.Transparent;
            StopMusicPicbox.ErrorImage = Properties.Resources.Play;
            StopMusicPicbox.Image = Properties.Resources.Play;
            StopMusicPicbox.Location = new Point(191, 98);
            StopMusicPicbox.Name = "StopMusicPicbox";
            StopMusicPicbox.Size = new Size(35, 40);
            StopMusicPicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            StopMusicPicbox.TabIndex = 2;
            StopMusicPicbox.TabStop = false;
            StopMusicPicbox.Visible = false;
            StopMusicPicbox.Click += StopMusicPicbox_Click;
            // 
            // PreviousMusicPicbox
            // 
            PreviousMusicPicbox.BackColor = Color.Transparent;
            PreviousMusicPicbox.Image = Properties.Resources.Previous;
            PreviousMusicPicbox.Location = new Point(138, 103);
            PreviousMusicPicbox.Name = "PreviousMusicPicbox";
            PreviousMusicPicbox.Size = new Size(35, 35);
            PreviousMusicPicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            PreviousMusicPicbox.TabIndex = 4;
            PreviousMusicPicbox.TabStop = false;
            PreviousMusicPicbox.Click += PreviousMusicPicbox_Click;
            // 
            // NextMusicPicbox
            // 
            NextMusicPicbox.BackColor = Color.Transparent;
            NextMusicPicbox.Image = Properties.Resources.Next;
            NextMusicPicbox.Location = new Point(244, 103);
            NextMusicPicbox.Name = "NextMusicPicbox";
            NextMusicPicbox.Size = new Size(35, 35);
            NextMusicPicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            NextMusicPicbox.TabIndex = 5;
            NextMusicPicbox.TabStop = false;
            NextMusicPicbox.Click += NextMusicPicbox_Click;
            // 
            // UnpauseMusicPicbox
            // 
            UnpauseMusicPicbox.BackColor = Color.Transparent;
            UnpauseMusicPicbox.ErrorImage = Properties.Resources.Play;
            UnpauseMusicPicbox.Image = Properties.Resources.Pause;
            UnpauseMusicPicbox.Location = new Point(191, 98);
            UnpauseMusicPicbox.Name = "UnpauseMusicPicbox";
            UnpauseMusicPicbox.Size = new Size(35, 40);
            UnpauseMusicPicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            UnpauseMusicPicbox.TabIndex = 6;
            UnpauseMusicPicbox.TabStop = false;
            UnpauseMusicPicbox.Click += UnpauseMusicPicbox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(14, 14, 14);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Chevron_Arrow_Down;
            pictureBox1.Location = new Point(316, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MusicSettings
            // 
            BackgroundImage = Properties.Resources.teste;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(406, 388);
            Controls.Add(pictureBox1);
            Controls.Add(NextMusicPicbox);
            Controls.Add(PreviousMusicPicbox);
            Controls.Add(StopMusicPicbox);
            Controls.Add(label1);
            Controls.Add(titlebar);
            Controls.Add(UnpauseMusicPicbox);
            DoubleBuffered = true;
            Name = "MusicSettings";
            Load += MusicSettings_Load;
            ((System.ComponentModel.ISupportInitialize)titlebar).EndInit();
            ((System.ComponentModel.ISupportInitialize)StopMusicPicbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PreviousMusicPicbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NextMusicPicbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnpauseMusicPicbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                clickOffset = e.Location;
            }
        }

        private void titlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - clickOffset.X;
                this.Top += e.Y - clickOffset.Y;
            }
        }

        private void titlebar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            this.TransparencyKey = Color.Purple;
        }
        private PictureBox titlebar;

        private void StopMusicPicbox_Click(object sender, EventArgs e)
        {
            AudioManager.ResumeBackgroundMusic();
            StopMusicPicbox.Visible = false;
            UnpauseMusicPicbox.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UnpauseMusicPicbox_Click(object sender, EventArgs e)
        {
            AudioManager.PauseBackgroundMusic();
            StopMusicPicbox.Visible = true;
            UnpauseMusicPicbox.Visible = false;
        }

        private void NextMusicPicbox_Click(object sender, EventArgs e)
        {
            AudioManager.NextTrack();
        }

        private void PreviousMusicPicbox_Click(object sender, EventArgs e)
        {
            AudioManager.PreviousTrack();
        }

        private void MusicSettings_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
