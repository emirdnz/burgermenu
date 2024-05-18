using hamburgermenu.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hamburgerMenu
{
    public partial class OrderListPanel : Form
    {
        public OrderListPanel()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadOrders()
        {
            listView1.Items.Clear();
            using (var context = new HamburgerMenudb())
            {
                var orders = context.Orders.ToList();
                foreach (var order in orders)
                {
                    var item = new ListViewItem(order.ID.ToString());
                    item.SubItems.Add(order.Menu);
                    item.SubItems.Add(order.Soslar);
                    item.SubItems.Add(order.Boyut);
                    item.SubItems.Add(order.Fiyat.ToString());
                    item.SubItems.Add(order.ADDTime.ToString());

                    listView1.Items.Add(item);
                }
            }
        }



        private void OrderListPanel_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
      
        
       
        
    }
}
