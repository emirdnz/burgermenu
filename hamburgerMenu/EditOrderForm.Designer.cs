namespace hamburgerMenu.UI
{
    partial class EditOrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMenu;
        private TextBox txtSoslar;
        private TextBox txtBoyut;
        private TextBox txtFiyat;
        private DateTimePicker dtpAddTime;
        private Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtMenu = new TextBox();
            txtSoslar = new TextBox();
            txtBoyut = new TextBox();
            txtFiyat = new TextBox();
            dtpAddTime = new DateTimePicker();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtMenu
            // 
            txtMenu.Location = new Point(12, 12);
            txtMenu.Name = "txtMenu";
            txtMenu.Size = new Size(260, 23);
            txtMenu.TabIndex = 0;
            // 
            // txtSoslar
            // 
            txtSoslar.Location = new Point(12, 38);
            txtSoslar.Name = "txtSoslar";
            txtSoslar.Size = new Size(260, 23);
            txtSoslar.TabIndex = 1;
            // 
            // txtBoyut
            // 
            txtBoyut.Location = new Point(12, 64);
            txtBoyut.Name = "txtBoyut";
            txtBoyut.Size = new Size(260, 23);
            txtBoyut.TabIndex = 2;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(12, 90);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(260, 23);
            txtFiyat.TabIndex = 3;
            // 
            // dtpAddTime
            // 
            dtpAddTime.Location = new Point(12, 116);
            dtpAddTime.Name = "dtpAddTime";
            dtpAddTime.Size = new Size(260, 23);
            dtpAddTime.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 142);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditOrderForm
            // 
            ClientSize = new Size(284, 177);
            Controls.Add(btnSave);
            Controls.Add(dtpAddTime);
            Controls.Add(txtFiyat);
            Controls.Add(txtBoyut);
            Controls.Add(txtSoslar);
            Controls.Add(txtMenu);
            Name = "EditOrderForm";
            Load += EditOrderForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}