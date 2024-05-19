using hamburgermenu.context;
using hamburgermenu.entitiy.entites;
using hamburgerMenu.UI;
using Microsoft.EntityFrameworkCore;
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



        HamburgerMenudb db = new HamburgerMenudb(); 


        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (int.TryParse(listView1.SelectedItems[0].Text, out int orderId))
                {
                    var order = db.Orders.Find(orderId);
                    if (order != null)
                    {
                        db.Orders.Remove(order);
                        db.SaveChanges();
                        LoadOrders();
                    }
                    else
                    {
                        MessageBox.Show("Silinmek istenen sipariş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz sipariş ID.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz siparişi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
       

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (int.TryParse(listView1.SelectedItems[0].Text, out int orderId))
                {
                    var order = db.Orders.Find(orderId);
                    if (order != null)
                    {
                        using (var editForm = new EditOrderForm(order))
                        {
                            if (editForm.ShowDialog() == DialogResult.OK)
                            {
                                db.SaveChanges();
                                LoadOrders();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Düzenlemek istenen sipariş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz sipariş ID.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz siparişi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}