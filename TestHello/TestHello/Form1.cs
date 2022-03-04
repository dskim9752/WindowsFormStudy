namespace TestHello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            helloLabel.Text = "Hello";
        }
    }
}