using hamburgermenu.context;

namespace hamburgerMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        HamburgerMenudb db;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new HamburgerMenudb();
        }

        private void sipariþYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();


        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        
        }
    }
}
