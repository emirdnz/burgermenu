namespace hamburgerMenu
{
    partial class AddPanel
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
            label3 = new Label();
            label4 = new Label();
            menueklemetextbox = new TextBox();
            menufiyateklemebox = new NumericUpDown();
            soseklemetextbox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            menueklemebutton = new Button();
            soseklemebutonu = new Button();
            ((System.ComponentModel.ISupportInitialize)menufiyateklemebox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "ÜRÜN YÖNETİMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 89);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "MENU EKLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Menu adı ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Menu Fiyatı";
            // 
            // menueklemetextbox
            // 
            menueklemetextbox.Location = new Point(95, 117);
            menueklemetextbox.Name = "menueklemetextbox";
            menueklemetextbox.Size = new Size(100, 23);
            menueklemetextbox.TabIndex = 4;
            // 
            // menufiyateklemebox
            // 
            menufiyateklemebox.Location = new Point(95, 147);
            menufiyateklemebox.Name = "menufiyateklemebox";
            menufiyateklemebox.Size = new Size(100, 23);
            menufiyateklemebox.TabIndex = 5;
            // 
            // soseklemetextbox
            // 
            soseklemetextbox.Location = new Point(579, 117);
            soseklemetextbox.Name = "soseklemetextbox";
            soseklemetextbox.Size = new Size(100, 23);
            soseklemetextbox.TabIndex = 9;
            soseklemetextbox.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 120);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 7;
            label6.Text = "Sos adı ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 89);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 6;
            label7.Text = "Sos Ekleme";
            // 
            // menueklemebutton
            // 
            menueklemebutton.Location = new Point(95, 191);
            menueklemebutton.Name = "menueklemebutton";
            menueklemebutton.Size = new Size(75, 23);
            menueklemebutton.TabIndex = 11;
            menueklemebutton.Text = "ekle";
            menueklemebutton.UseVisualStyleBackColor = true;
            menueklemebutton.Click += button1_Click;
            // 
            // soseklemebutonu
            // 
            soseklemebutonu.Location = new Point(579, 171);
            soseklemebutonu.Name = "soseklemebutonu";
            soseklemebutonu.Size = new Size(100, 43);
            soseklemebutonu.TabIndex = 12;
            soseklemebutonu.Text = "ekle";
            soseklemebutonu.UseVisualStyleBackColor = true;
            soseklemebutonu.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(soseklemebutonu);
            Controls.Add(menueklemebutton);
            Controls.Add(soseklemetextbox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(menufiyateklemebox);
            Controls.Add(menueklemetextbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)menufiyateklemebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox menueklemetextbox;
        private NumericUpDown menufiyateklemebox;
        private TextBox soseklemetextbox;
        private Label label6;
        private Label label7;
        private Button menueklemebutton;
        private Button soseklemebutonu;
    }
}