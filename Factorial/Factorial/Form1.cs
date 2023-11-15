namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox1.Text;
                int i = int.Parse(x);
                int f = fact(i);
                MessageBox.Show(x+"!="+f.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public int fact(int i)
        {
            int f = 1;
            for (int j = 1; j <= i; j++)
            {
                f *= j;
            }
            return f;
        }

    }

}