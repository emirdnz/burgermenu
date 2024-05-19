namespace hamburgerMenu
{
    partial class OrderListPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "SİPARİŞ YÖNETİMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "TÜM SİPARİŞLER";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader6, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LabelEdit = true;
            listView1.Location = new Point(12, 119);
            listView1.Name = "listView1";
            listView1.Size = new Size(887, 296);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Siparisler";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soslar";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Sipariş Boy Seçimi";
            columnHeader4.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Toplam Fiyat";
            columnHeader6.Width = 200;
            // 
            // button1
            // 
            button1.Location = new Point(15, 463);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 6;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 463);
            button2.Name = "button2";
            button2.Size = new Size(100, 42);
            button2.TabIndex = 7;
            button2.Text = "DÜZENLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Eklenme Tarihi";
            columnHeader5.Width = 200;
            // 
            // OrderListPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 618);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderListPanel";
            Text = "Form2";
            Load += OrderListPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private Button button2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader5;
    }
}