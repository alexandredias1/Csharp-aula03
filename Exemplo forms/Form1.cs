namespace Exemplo_forms
{
    public partial class Form1 : Form
    {
        private object labell;

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            do
            {
                numero++;
            } while (numero <= 3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}