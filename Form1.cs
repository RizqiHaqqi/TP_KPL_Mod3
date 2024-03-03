namespace TP3_KPL
{
    public partial class Form1 : Form
    {
        public string Output { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            Output.Text = "Hi " + input;
        }
    }
}
