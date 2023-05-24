namespace Distance_Calculator
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
            double speed = double.Parse(textBox1.Text);
            double hours = double.Parse(textBox2.Text);
            double total = 0;

            for (double i = 1; i <= hours; i++)
            {
                total += speed;
                listBox1.Items.Add($"Total hours: {i}\tTotal Distance: {total.ToString()}");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}