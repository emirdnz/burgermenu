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
            this.txtMenu = new TextBox();
            this.txtSoslar = new TextBox();
            this.txtBoyut = new TextBox();
            this.txtFiyat = new TextBox();
            this.dtpAddTime = new DateTimePicker();
            this.btnSave = new Button();
            this.SuspendLayout();
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(12, 12);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(260, 20);
            this.txtMenu.TabIndex = 0;
            // 
            // txtSoslar
            // 
            this.txtSoslar.Location = new System.Drawing.Point(12, 38);
            this.txtSoslar.Name = "txtSoslar";
            this.txtSoslar.Size = new System.Drawing.Size(260, 20);
            this.txtSoslar.TabIndex = 1;
            // 
            // txtBoyut
            // 
            this.txtBoyut.Location = new System.Drawing.Point(12, 64);
            this.txtBoyut.Name = "txtBoyut";
            this.txtBoyut.Size = new System.Drawing.Size(260, 20);
            this.txtBoyut.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(12, 90);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(260, 20);
            this.txtFiyat.TabIndex = 3;
            // 
            // dtpAddTime
            // 
            this.dtpAddTime.Location = new System.Drawing.Point(12, 116);
            this.dtpAddTime.Name = "dtpAddTime";
            this.dtpAddTime.Size = new System.Drawing.Size(260, 20);
            this.dtpAddTime.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditOrderForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpAddTime);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtBoyut);
            this.Controls.Add(this.txtSoslar);
            this.Controls.Add(this.txtMenu);
            this.Name = "EditOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}