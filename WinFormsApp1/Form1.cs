namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int resultado = Soma(n1, n2);
            MessageBox.Show($"O resultado da soma � {resultado}");

        }

        public static int Soma (int n1, int n2)
        {
            return n1 + n2; 
        }
    }
}