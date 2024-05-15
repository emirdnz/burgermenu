using hamburgermenu.context;
using hamburgermenu.entites;
using Microsoft.Data.SqlClient;
using Microsoft.Web.WebView2.Core;

namespace hamburgerMenu
{
    public partial class OrderPanel : Form
    {
        SqlConnection connection = new SqlConnection("Server=DESKTOP-R937SDA\\TEW_SQLEXPRESS;Database=HamburgerMenudb;Trusted_Connection=True;TrustServerCertificate=true");

        public OrderPanel()
        {
            InitializeComponent();

        }


        HamburgerMenudb db;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new HamburgerMenudb();

            SqlCommand komut = new SqlCommand("SELECT * FROM hamburgermenunames", connection);

            SqlDataReader dr;

            connection.Open();

            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                menusecimlerilistele.Items.Add(dr["Name"]);
            }

            connection.Close();

        }

        private void sipariþYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderListPanel form2 = new OrderListPanel();
            form2.Show();


        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel form3 = new AddPanel();
            form3.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedItem = menusecimlerilistele.SelectedItem.ToString();
            listView1.Items.Add(selectedItem);
        }

        private void menulisteekleme_Click(object sender, EventArgs e)
        {


            //if (sossecim1.Checked)
            //{
            //    listView1.Items.Add("Ketçap");
            //}
            //if (sossecým2.Checked)
            //{
            //    listView1.Items.Add("BBQ");
            //}
            //if (boysecim1.Checked)
            //{
            //    listView1.Items.Add("Küçük Boy");
            //}
            //if (boysecim2.Checked)
            //{
            //    listView1.Items.Add("Orta Boy");
            //}
            //if (boysecim3.Checked)
            //{
            //    listView1.Items.Add("Büyük Boy");
            //}

           



            //ListViewItem item1 = new ListViewItem("item1", 0);
            //// Place a check mark next to the item.
            //item1.Checked = true;
            //item1.SubItems.Add("");
           
            //ListViewItem item2 = new ListViewItem("item2", 1);
            //item2.SubItems.Add("");

          
            //ListViewItem item3 = new ListViewItem("item3", 0);
            //// Place a check mark next to the item.
            //item3.Checked = true;
            //item3.SubItems.Add("7");
            //item3.SubItems.Add("8");
            //item3.SubItems.Add("9");

           



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderListPanel orderListPanel = new OrderListPanel();
            orderListPanel.Show();
        }
    }
}

