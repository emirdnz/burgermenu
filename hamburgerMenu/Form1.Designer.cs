namespace hamburgerMenu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menusecim = new ComboBox();
            menulisteekleme = new Button();
            sossecim1 = new CheckBox();
            sossecım2 = new CheckBox();
            boysecim1 = new RadioButton();
            boysecim2 = new RadioButton();
            boysecim3 = new RadioButton();
            listView1 = new ListView();
            label1 = new Label();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
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
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menusecim
            // 
            menusecim.FormattingEnabled = true;
            menusecim.Location = new Point(12, 147);
            menusecim.Name = "menusecim";
            menusecim.Size = new Size(121, 23);
            menusecim.TabIndex = 2;
            menusecim.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // menulisteekleme
            // 
            menulisteekleme.Location = new Point(12, 395);
            menulisteekleme.Name = "menulisteekleme";
            menulisteekleme.Size = new Size(185, 43);
            menulisteekleme.TabIndex = 3;
            menulisteekleme.Text = "Menuyu ekleme";
            menulisteekleme.UseVisualStyleBackColor = true;
            // 
            // sossecim1
            // 
            sossecim1.AutoSize = true;
            sossecim1.Location = new Point(12, 195);
            sossecim1.Name = "sossecim1";
            sossecim1.Size = new Size(62, 19);
            sossecim1.TabIndex = 4;
            sossecim1.Text = "Ketcap";
            sossecim1.UseVisualStyleBackColor = true;
            // 
            // sossecım2
            // 
            sossecım2.AutoSize = true;
            sossecım2.Location = new Point(12, 220);
            sossecım2.Name = "sossecım2";
            sossecım2.Size = new Size(49, 19);
            sossecım2.TabIndex = 5;
            sossecım2.Text = "BBQ";
            sossecım2.UseVisualStyleBackColor = true;
            // 
            // boysecim1
            // 
            boysecim1.AutoSize = true;
            boysecim1.Location = new Point(12, 370);
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
            boysecim2.Location = new Point(76, 370);
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
            boysecim3.Location = new Point(130, 370);
            boysecim3.Name = "boysecim3";
            boysecim3.Size = new Size(58, 19);
            boysecim3.TabIndex = 8;
            boysecim3.TabStop = true;
            boysecim3.Text = "Büyük";
            boysecim3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(247, 36);
            listView1.Name = "listView1";
            listView1.Size = new Size(518, 306);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 395);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(657, 372);
            button2.Name = "button2";
            button2.Size = new Size(108, 61);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(boysecim3);
            Controls.Add(boysecim2);
            Controls.Add(boysecim1);
            Controls.Add(sossecım2);
            Controls.Add(sossecim1);
            Controls.Add(menulisteekleme);
            Controls.Add(menusecim);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
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
        private ComboBox menusecim;
        private Button menulisteekleme;
        private CheckBox sossecim1;
        private CheckBox sossecım2;
        private RadioButton boysecim1;
        private RadioButton boysecim2;
        private RadioButton boysecim3;
        private ListView listView1;
        private Label label1;
        private Button button2;
    }
}
