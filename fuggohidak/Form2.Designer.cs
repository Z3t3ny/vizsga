namespace fuggohidak
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bezarasGOmb = new System.Windows.Forms.Button();
            this.keresesGomb = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.orszag2Box = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(539, 260);
            this.listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bezarasGOmb);
            this.groupBox1.Controls.Add(this.keresesGomb);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.orszag2Box);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bezarasGOmb
            // 
            this.bezarasGOmb.Location = new System.Drawing.Point(349, 152);
            this.bezarasGOmb.Name = "bezarasGOmb";
            this.bezarasGOmb.Size = new System.Drawing.Size(75, 23);
            this.bezarasGOmb.TabIndex = 5;
            this.bezarasGOmb.Text = "Bezárás";
            this.bezarasGOmb.UseVisualStyleBackColor = true;
            this.bezarasGOmb.Click += new System.EventHandler(this.bezarasGOmb_Click);
            // 
            // keresesGomb
            // 
            this.keresesGomb.Location = new System.Drawing.Point(99, 152);
            this.keresesGomb.Name = "keresesGomb";
            this.keresesGomb.Size = new System.Drawing.Size(75, 23);
            this.keresesGomb.TabIndex = 4;
            this.keresesGomb.Text = "Keresés";
            this.keresesGomb.UseVisualStyleBackColor = true;
            this.keresesGomb.Click += new System.EventHandler(this.keresesGomb_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "1km-nél hosszabbak";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // orszag2Box
            // 
            this.orszag2Box.AutoSize = true;
            this.orszag2Box.Location = new System.Drawing.Point(35, 46);
            this.orszag2Box.Name = "orszag2Box";
            this.orszag2Box.Size = new System.Drawing.Size(48, 16);
            this.orszag2Box.TabIndex = 2;
            this.orszag2Box.Text = "ország";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Keresés";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bezarasGOmb;
        private System.Windows.Forms.Button keresesGomb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label orszag2Box;
    }
}