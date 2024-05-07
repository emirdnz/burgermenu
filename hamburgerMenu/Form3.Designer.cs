namespace hamburgerMenu
{
    partial class Form3
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
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            // textBox1
            // 
            textBox1.Location = new Point(95, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(95, 147);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(579, 147);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(100, 23);
            numericUpDown2.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(579, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 149);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 8;
            label5.Text = "Sos Fiyatı";
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
            // button1
            // 
            button1.Location = new Point(95, 191);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(579, 191);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "ekle";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(62, 291);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 273);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 14;
            label8.Text = "MENÜLER";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(616, 273);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 15;
            label9.Text = "SOSLAR";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(579, 291);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
        private ComboBox comboBox2;
    }
}