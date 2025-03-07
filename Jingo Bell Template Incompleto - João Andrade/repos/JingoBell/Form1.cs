using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Threading.Timer;
namespace JingoBell
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private readonly Color[] cores = { Color.Red, Color.Green, Color.Blue, Color.Gold };
        private int contadorCores = 0;
        public Form1()
        {
            InitializeComponent();
            AudioManager.PlayBackgroundMusic();
            label1.Font = new Font("Heyam", 40, FontStyle.Bold);
            label1.Text = "Jingo Bell";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.AutoSize = true;
            label1.Location = new Point(
                       (this.ClientSize.Width - label1.Width) / 2,
                       (this.ClientSize.Height - label1.Height) / 2
                   );
            label1.Paint += Label1_Paint;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            titlebar.MouseDown += titlebar_MouseDown;
            titlebar.MouseMove += titlebar_MouseMove;
            titlebar.MouseUp += titlebar_MouseUp;
            CenterLabelAboveCenter();
            timer = new System.Windows.Forms.Timer
            {
                Interval = 300
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private Point clickOffset;
        private bool isDragging = false;
        private void Timer_Tick(object sender, EventArgs e)
        {
            contadorCores = (contadorCores + 1) % cores.Length;
            string texto = label1.Text;
            string textoColorido = "";
            for (int i = 0; i < texto.Length; i++)
            {
                int corAtual = (contadorCores + i) % cores.Length;
                textoColorido += $"<span style='color: {cores[corAtual].Name}'>{texto[i]}</span>";
            }
            label1.ForeColor = cores[contadorCores];
        }
        private void CenterLabelAboveCenter()
        {
            int deslocamento = 50;
            label1.Location = new Point(
                (this.ClientSize.Width - label1.Width) / 2,
                (this.ClientSize.Height - label1.Height) / 2 - deslocamento
            );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Purple;
            this.TransparencyKey = Color.Purple;
        }

        private void Barra_Click(object sender, EventArgs e)
        {

        }
        private void Label1_Paint(object sender, PaintEventArgs e)
        {
            string texto = label1.Text;
            Font fonte = label1.Font;
            Brush brushTexto = new SolidBrush(label1.ForeColor);
            Brush brushContorno = new SolidBrush(Color.Black);
            SizeF tamanhoTexto = e.Graphics.MeasureString(texto, fonte);
            float x = (label1.Width - tamanhoTexto.Width) / 2;
            float y = (label1.Height - tamanhoTexto.Height) / 2;
            e.Graphics.DrawString(texto, fonte, brushContorno, x - 1, y);
            e.Graphics.DrawString(texto, fonte, brushContorno, x + 1, y);
            e.Graphics.DrawString(texto, fonte, brushContorno, x, y - 1);
            e.Graphics.DrawString(texto, fonte, brushContorno, x, y + 1);
            e.Graphics.DrawString(texto, fonte, brushContorno, x - 1, y - 1);
            e.Graphics.DrawString(texto, fonte, brushContorno, x + 1, y - 1);
            e.Graphics.DrawString(texto, fonte, brushContorno, x - 1, y + 1);
            e.Graphics.DrawString(texto, fonte, brushContorno, x + 1, y + 1);
            e.Graphics.DrawString(texto, fonte, brushTexto, x, y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MusicSettings newForm = new MusicSettings();
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal newForm = new Principal();
            newForm.Show();
        }
    }
}
