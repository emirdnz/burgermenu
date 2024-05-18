using hamburgermenu.context;
using hamburgermenu.entites;
using hamburgermenu.entitiy.entites;
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

        }


        private int nextId = 1;

        private void menulisteekleme_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(menusecimlerilistele.Text)) return;


            List<string> selectedSoslar = new List<string>();


            if (sossecim1.Checked) selectedSoslar.Add("Ketçap");
            if (sossecim2.Checked) selectedSoslar.Add("Mayonez");
            if (sossecim3.Checked) selectedSoslar.Add("BBQ");
            if (sossecim4.Checked) selectedSoslar.Add("Hardal");
            if (sossecim5.Checked) selectedSoslar.Add("Acý Sos");
            if (sossecim6.Checked) selectedSoslar.Add("Cheddar");


            string soslar = string.Join(",", selectedSoslar);


            ListViewItem item = new ListViewItem(nextId.ToString());
            item.SubItems.Add(menusecimlerilistele.Text);
            item.SubItems.Add(soslar);

            string boyut = "";
            if (boysecim1.Checked) boyut = "Küçük";
            if (boysecim2.Checked) boyut = "Orta";
            if (boysecim3.Checked) boyut = "Büyük";

            item.SubItems.Add(boyut);


            Listeleme.Items.Add(item);

            nextId++;





        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderListPanel orderListPanel = new OrderListPanel();
            orderListPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new HamburgerMenudb())
            {
                foreach (ListViewItem item in Listeleme.Items)
                {
                    var siparis = new Orders
                    {
                        Menu = item.SubItems[1].Text,
                        Soslar = item.SubItems[2].Text,
                        Boyut = item.SubItems[3].Text,
                        Fiyat = 50.0M,
                        ADDTime = DateTime.Now,
                    };

                    context.Orders.Add(siparis);
                }

                context.SaveChanges();
            }
            MessageBox.Show("Sipariþler onaylandý ve veritabanýna eklendi.");
        }
    }
}

