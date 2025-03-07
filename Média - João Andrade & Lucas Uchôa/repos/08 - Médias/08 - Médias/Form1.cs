namespace _08___Médias
{
    public partial class Form1 : Form
    {
        private List<double> numeros = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = double.Parse(textBox1.Text);

                numeros.Add(numero);

                label4.Text = string.Join("\n", numeros);
                double media = numeros.Average();
                label5.Text = media.ToString("F2");
                textBox1.Clear();
                textBox1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Pretende sair do programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Close();
        }
    }
}
