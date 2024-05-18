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

namespace hamburgerMenu.UI
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }


        HamburgerMenudb Db;

        private void UserLogin_Load(object sender, EventArgs e)
        {
            Db = new HamburgerMenudb();
            PasswordText.PasswordChar = '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Db.Users.FirstOrDefault(x => x.UserName == UsernameText.Text && x.Password == PasswordText.Text)!= null)
            {
                OrderPanel orderPanel = new OrderPanel();   
                orderPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Invalid", "try again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UsernameText.Text = PasswordText.Text="";
                UsernameText.Focus();   
            }
           
        }

    }

    
}
