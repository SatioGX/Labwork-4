namespace Labwork_4_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "On")
            {
                label1.Text = "Off";
                lightOnPicture.Visible = false;
                lightOffPicture.Visible = true;
            }
            else
            {
                label1.Text = "On";
                lightOnPicture.Visible = true;
                lightOffPicture.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}