namespace C_232410101094_utspbo
{
    public partial class WELCOME : Form
    {
        public WELCOME()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                WELCOME welcome = new WELCOME();
                radioButton1.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Form3 form3 = new Form3();
                radioButton2.Show();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WELCOME_Load(object sender, EventArgs e)
        {

        }
    }
}