namespace Labwork_4_Q2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number = double.Parse(startingNumber.Text);
            double increase = double.Parse(dailyIncrease.Text) / 100;
            double time = double.Parse(numberOfDaysMultiply.Text);

            listBox1.Items.Add($"Day \t Population");
            for (int i = 1; i <= time; i++)
            {
                listBox1.Items.Add($"{i}\t{number.ToString()}");
                number = number*(1+increase);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}