namespace DatGiaoThucAn
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.pass_textbox.UseSystemPasswordChar)
            {
                this.pass_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                this.pass_textbox.UseSystemPasswordChar = true;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}