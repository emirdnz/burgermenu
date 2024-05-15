namespace hamburgerMenu
{
    partial class OrderPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPanel));
            menuStrip1 = new MenuStrip();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menusecimlerilistele = new ComboBox();
            menulisteekleme = new Button();
            boysecim1 = new RadioButton();
            boysecim2 = new RadioButton();
            boysecim3 = new RadioButton();
            listView1 = new ListView();
            menu = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button2 = new Button();
            sossecim1 = new CheckBox();
            sossecım2 = new CheckBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(843, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(103, 20);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            siparişYönetimiToolStripMenuItem.Click += siparişYönetimiToolStripMenuItem_Click;
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(95, 20);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            ürünYönetimiToolStripMenuItem.Click += ürünYönetimiToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menusecimlerilistele
            // 
            menusecimlerilistele.FormattingEnabled = true;
            menusecimlerilistele.Location = new Point(152, 71);
            menusecimlerilistele.Name = "menusecimlerilistele";
            menusecimlerilistele.Size = new Size(121, 23);
            menusecimlerilistele.TabIndex = 2;
            menusecimlerilistele.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // menulisteekleme
            // 
            menulisteekleme.Location = new Point(677, 34);
            menulisteekleme.Name = "menulisteekleme";
            menulisteekleme.Size = new Size(154, 69);
            menulisteekleme.TabIndex = 3;
            menulisteekleme.Text = "Menuyu ekleme";
            menulisteekleme.UseVisualStyleBackColor = true;
            menulisteekleme.Click += menulisteekleme_Click;
            // 
            // boysecim1
            // 
            boysecim1.AutoSize = true;
            boysecim1.Location = new Point(590, 33);
            boysecim1.Name = "boysecim1";
            boysecim1.Size = new Size(58, 19);
            boysecim1.TabIndex = 6;
            boysecim1.TabStop = true;
            boysecim1.Text = "Küçük";
            boysecim1.UseVisualStyleBackColor = true;
            // 
            // boysecim2
            // 
            boysecim2.AutoSize = true;
            boysecim2.Location = new Point(590, 58);
            boysecim2.Name = "boysecim2";
            boysecim2.Size = new Size(48, 19);
            boysecim2.TabIndex = 7;
            boysecim2.TabStop = true;
            boysecim2.Text = "Orta";
            boysecim2.UseVisualStyleBackColor = true;
            // 
            // boysecim3
            // 
            boysecim3.AutoSize = true;
            boysecim3.Location = new Point(590, 83);
            boysecim3.Name = "boysecim3";
            boysecim3.Size = new Size(58, 19);
            boysecim3.TabIndex = 8;
            boysecim3.TabStop = true;
            boysecim3.Text = "Büyük";
            boysecim3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { menu, columnHeader2, columnHeader1, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(24, 109);
            listView1.Name = "listView1";
            listView1.Size = new Size(749, 280);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // menu
            // 
            menu.Text = "Menu ";
            menu.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Soslar";
            columnHeader2.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Menu Boy Seçimi";
            columnHeader1.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Toplam Fiyat";
            columnHeader3.Width = 120;
            // 
            // button2
            // 
            button2.Location = new Point(699, 395);
            button2.Name = "button2";
            button2.Size = new Size(132, 50);
            button2.TabIndex = 11;
            button2.Text = "Siparişi Onayla";
            button2.UseVisualStyleBackColor = true;
            // 
            // sossecim1
            // 
            sossecim1.AutoSize = true;
            sossecim1.Location = new Point(290, 59);
            sossecim1.Name = "sossecim1";
            sossecim1.Size = new Size(65, 19);
            sossecim1.TabIndex = 4;
            sossecim1.Text = "Ketcap ";
            sossecim1.UseVisualStyleBackColor = true;
            // 
            // sossecım2
            // 
            sossecım2.AutoSize = true;
            sossecım2.Location = new Point(290, 84);
            sossecım2.Name = "sossecım2";
            sossecım2.Size = new Size(52, 19);
            sossecım2.TabIndex = 5;
            sossecım2.Text = "BBQ ";
            sossecım2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 53);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 12;
            label2.Text = "MENU SEÇİMİ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(290, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Mayonez";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(370, 36);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(61, 19);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Hardal";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(370, 59);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(64, 19);
            checkBox3.TabIndex = 15;
            checkBox3.Text = "Acı Sos";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(370, 84);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(74, 19);
            checkBox4.TabIndex = 16;
            checkBox4.Text = "Cheddar ";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(24, 395);
            button1.Name = "button1";
            button1.Size = new Size(129, 43);
            button1.TabIndex = 17;
            button1.Text = "Siparişleri Yönet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OrderPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(button1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(boysecim3);
            Controls.Add(boysecim2);
            Controls.Add(boysecim1);
            Controls.Add(sossecım2);
            Controls.Add(sossecim1);
            Controls.Add(menulisteekleme);
            Controls.Add(menusecimlerilistele);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "OrderPanel";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private PictureBox pictureBox1;
        private ComboBox menusecimlerilistele;
        private Button menulisteekleme;
        private RadioButton boysecim1;
        private RadioButton boysecim2;
        private RadioButton boysecim3;
        private ListView listView1;
        private Button button2;
        private CheckBox sossecim1;
        private CheckBox sossecım2;
        private Label label2;
        private ColumnHeader menu;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
    }
}
