namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                label4.Text = "";
                for (int i = 1; i <= 10; i++)
                {
                    label4.Text += $"{numero} x {i} = {numero * i}\n";
                }
            }
            else
            {
                MessageBox.Show("Insira um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Pretende sair do programa?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                Close();
        }
    }
}
