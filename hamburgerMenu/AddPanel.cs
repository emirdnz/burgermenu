using hamburgermenu.context;
using hamburgermenu.entites;
using hamburgermenu.entitiy.entites;
using Microsoft.Data.SqlClient;
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
    public partial class AddPanel : Form
    {

        public AddPanel()
        {

            InitializeComponent();


        }



        private void button1_Click(object sender, EventArgs e)
        {


            #region ado net 
            //db.Open();

            //SqlCommand komut = new SqlCommand("INSERT INTO hamburgermenu (Name,price) VALUES (@Name,@Price)", db);

            //komut.Parameters.AddWithValue("@Name", menuname);
            //komut.Parameters.AddWithValue("@Price", menuprice);


            //komut.ExecuteNonQuery();
            //db.Close();

            #endregion



            #region efcore 

            using (var context = new HamburgerMenudb())
            {
                var menu = new HamburgerMenuName()
                {
                    Name = menueklemetextbox.Text,
                    Price = Convert.ToInt16(menufiyateklemebox.Text),

                };

                context.Add<HamburgerMenuName>(menu);

                context.SaveChanges();

            }

            MessageBox.Show("Menü Listeye EKlenmiştir.");










            #endregion

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region ado net
            //string sosname = soseklemebox.Text;


            //db.Open();
            //SqlCommand komut = new SqlCommand("INSERT INTO sosekleme (Name) VALUES (@Name)", db);

            //komut.Parameters.AddWithValue("@Name", sosname);


            //komut.ExecuteNonQuery();
            //db.Close();

            //MessageBox.Show("Sos Eklenmiştir."); 
            #endregion


            using (var context = new HamburgerMenudb())
            {
                var sos = new Sauce()
                {
                    Name = soseklemetextbox.Text
                };


                context.Sauces.Add(sos);    

                context.SaveChanges();
            }

            MessageBox.Show("Sos Listeye Eklenmiştir.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
