using hamburgermenu.entitiy.entites;
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
    public partial class EditOrderForm : Form
    {
        private readonly Orders _order;

        public EditOrderForm(Orders order)
        {
            InitializeComponent();
            _order = order;

            txtMenu.Text = _order.Menu;
            txtSoslar.Text = _order.Soslar;
            txtBoyut.Text = _order.Boyut;
            txtFiyat.Text = _order.Fiyat.ToString();
            dtpAddTime.Value = _order.ADDTime;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            _order.Menu = txtMenu.Text;
            _order.Soslar = txtSoslar.Text;
            _order.Boyut = txtBoyut.Text;
            _order.Fiyat = decimal.Parse(txtFiyat.Text);
            _order.ADDTime = dtpAddTime.Value;

            // Formu kapat
            this.DialogResult = DialogResult.OK;
            this.Close();
            MessageBox.Show("Sipariş başarılı bir şekilde kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void EditOrderForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
