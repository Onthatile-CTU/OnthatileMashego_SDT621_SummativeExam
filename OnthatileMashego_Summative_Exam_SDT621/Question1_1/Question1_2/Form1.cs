namespace Question1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
        
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hello " + name + "!", "Greeting",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
