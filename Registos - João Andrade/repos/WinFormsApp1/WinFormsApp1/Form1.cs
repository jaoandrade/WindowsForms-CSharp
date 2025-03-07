namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<int> Câmera = new List<int>();
        private List<int> SMS = new List<int>();
        private List<int> Teclado = new List<int>();
        private List<int> RedesSociais = new List<int>();
        private List<int> Bluetooth = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "Tem certeza de que deseja apagar o item selecionado?",
                    "Confirmar Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    MessageBox.Show("Item apagado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o código do item da lista para apagar.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            string codigo = textBoxCodigo.Text;
            string modelo = textBoxModelo.Text;

            string marca = comboBox1.SelectedItem?.ToString() ?? "N/A";
            string operadora = comboBox2.SelectedItem?.ToString() ?? "N/A";
            string sistemaOperativo = comboBox3.SelectedItem?.ToString() ?? "N/A";
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(modelo) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha os campos Código, Marca e Modelo.");
                return;
            }
            string camera = checkBox1.Checked ? "Sim" : "Não";
            string sms = checkBox3.Checked ? "Sim" : "Não";
            string wifi = checkBox5.Checked ? "Sim" : "Não";
            string redesSociais = checkBox2.Checked ? "Sim" : "Não";
            string teclado = checkBox4.Checked ? "Sim" : "Não";
            string bluetooth = checkBox6.Checked ? "Sim" : "Não";
            var item = new ListViewItem(new[] { codigo, marca, modelo });
            item.Tag = new
            {
                Operadora = operadora,
                SistemaOperativo = sistemaOperativo,
                Camera = camera,
                SMS = sms,
                WiFi = wifi,
                RedesSociais = redesSociais,
                Teclado = teclado,
                Bluetooth = bluetooth
            };
            listView1.Items.Add(item);
            MessageBox.Show("Dados guardados com sucesso!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            textBoxCodigo.Clear();
            textBoxModelo.Clear();
            comboBox1.SelectedIndex = -1; 
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            listView1.SelectedItems.Clear();
            MessageBox.Show("Pronto para criar um novo registro.");
        }

    }
}
