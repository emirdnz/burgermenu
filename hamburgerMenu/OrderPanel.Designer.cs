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
            Listeleme = new ListView();
            menu = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button2 = new Button();
            sossecim1 = new CheckBox();
            sossecim3 = new CheckBox();
            label2 = new Label();
            sossecim2 = new CheckBox();
            sossecim4 = new CheckBox();
            sossecim5 = new CheckBox();
            sossecim6 = new CheckBox();
            button1 = new Button();
            columnHeader4 = new ColumnHeader();
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
            // Listeleme
            // 
            Listeleme.Columns.AddRange(new ColumnHeader[] { columnHeader4, menu, columnHeader2, columnHeader1, columnHeader3 });
            Listeleme.FullRowSelect = true;
            Listeleme.GridLines = true;
            Listeleme.Location = new Point(24, 109);
            Listeleme.Name = "Listeleme";
            Listeleme.Size = new Size(749, 280);
            Listeleme.TabIndex = 9;
            Listeleme.UseCompatibleStateImageBehavior = false;
            Listeleme.View = View.Details;
            Listeleme.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            button2.Click += button2_Click;
            // 
            // sossecim1
            // 
            sossecim1.AutoSize = true;
            sossecim1.Location = new Point(290, 36);
            sossecim1.Name = "sossecim1";
            sossecim1.Size = new Size(65, 19);
            sossecim1.TabIndex = 4;
            sossecim1.Text = "Ketcap ";
            sossecim1.UseVisualStyleBackColor = true;
            // 
            // sossecim3
            // 
            sossecim3.AutoSize = true;
            sossecim3.Location = new Point(290, 84);
            sossecim3.Name = "sossecim3";
            sossecim3.Size = new Size(52, 19);
            sossecim3.TabIndex = 5;
            sossecim3.Text = "BBQ ";
            sossecim3.UseVisualStyleBackColor = true;
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
            // sossecim2
            // 
            sossecim2.AutoSize = true;
            sossecim2.Location = new Point(290, 59);
            sossecim2.Name = "sossecim2";
            sossecim2.Size = new Size(74, 19);
            sossecim2.TabIndex = 13;
            sossecim2.Text = "Mayonez";
            sossecim2.UseVisualStyleBackColor = true;
            // 
            // sossecim4
            // 
            sossecim4.AutoSize = true;
            sossecim4.Location = new Point(370, 36);
            sossecim4.Name = "sossecim4";
            sossecim4.Size = new Size(61, 19);
            sossecim4.TabIndex = 14;
            sossecim4.Text = "Hardal";
            sossecim4.UseVisualStyleBackColor = true;
            // 
            // sossecim5
            // 
            sossecim5.AutoSize = true;
            sossecim5.Location = new Point(370, 59);
            sossecim5.Name = "sossecim5";
            sossecim5.Size = new Size(64, 19);
            sossecim5.TabIndex = 15;
            sossecim5.Text = "Acı Sos";
            sossecim5.UseVisualStyleBackColor = true;
            // 
            // sossecim6
            // 
            sossecim6.AutoSize = true;
            sossecim6.Location = new Point(370, 84);
            sossecim6.Name = "sossecim6";
            sossecim6.Size = new Size(74, 19);
            sossecim6.TabIndex = 16;
            sossecim6.Text = "Cheddar ";
            sossecim6.UseVisualStyleBackColor = true;
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
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            // 
            // OrderPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(button1);
            Controls.Add(sossecim6);
            Controls.Add(sossecim5);
            Controls.Add(sossecim4);
            Controls.Add(sossecim2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(Listeleme);
            Controls.Add(boysecim3);
            Controls.Add(boysecim2);
            Controls.Add(boysecim1);
            Controls.Add(sossecim3);
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
        private ListView Listeleme;
        private Button button2;
        private CheckBox sossecim1;
        private CheckBox sossecim3;
        private Label label2;
        private ColumnHeader menu;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private CheckBox sossecim2;
        private CheckBox sossecim4;
        private CheckBox sossecim5;
        private CheckBox sossecim6;
        private Button button1;
        private ColumnHeader columnHeader4;
    }
}
