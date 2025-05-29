namespace fuggohidak
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.darabLabel = new System.Windows.Forms.Label();
            this.darabBox = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.elottButton = new System.Windows.Forms.RadioButton();
            this.helyLabel = new System.Windows.Forms.Label();
            this.orszagLabel = new System.Windows.Forms.Label();
            this.hosszLabel = new System.Windows.Forms.Label();
            this.evLabel = new System.Windows.Forms.Label();
            this.helyBox = new System.Windows.Forms.TextBox();
            this.orszagBox = new System.Windows.Forms.TextBox();
            this.hosszBox = new System.Windows.Forms.TextBox();
            this.evBox = new System.Windows.Forms.TextBox();
            this.kilepesGomb = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.keresésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitásToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.keresésToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilepesGomb_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 292);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.darabLabel);
            this.groupBox1.Controls.Add(this.darabBox);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.elottButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hidak száma";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // darabLabel
            // 
            this.darabLabel.AutoSize = true;
            this.darabLabel.Location = new System.Drawing.Point(158, 125);
            this.darabLabel.Name = "darabLabel";
            this.darabLabel.Size = new System.Drawing.Size(43, 16);
            this.darabLabel.TabIndex = 5;
            this.darabLabel.Text = "darab";
            this.darabLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // darabBox
            // 
            this.darabBox.Location = new System.Drawing.Point(41, 122);
            this.darabBox.Name = "darabBox";
            this.darabBox.Size = new System.Drawing.Size(100, 22);
            this.darabBox.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(41, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(152, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2000-ben vagy utána";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // elottButton
            // 
            this.elottButton.AutoSize = true;
            this.elottButton.Location = new System.Drawing.Point(41, 39);
            this.elottButton.Name = "elottButton";
            this.elottButton.Size = new System.Drawing.Size(84, 20);
            this.elottButton.TabIndex = 3;
            this.elottButton.TabStop = true;
            this.elottButton.Text = "2000 előtt";
            this.elottButton.UseVisualStyleBackColor = true;
            this.elottButton.CheckedChanged += new System.EventHandler(this.elottButton_CheckedChanged);
            // 
            // helyLabel
            // 
            this.helyLabel.AutoSize = true;
            this.helyLabel.Location = new System.Drawing.Point(372, 68);
            this.helyLabel.Name = "helyLabel";
            this.helyLabel.Size = new System.Drawing.Size(35, 16);
            this.helyLabel.TabIndex = 6;
            this.helyLabel.Text = "Hely";
            // 
            // orszagLabel
            // 
            this.orszagLabel.AutoSize = true;
            this.orszagLabel.Location = new System.Drawing.Point(372, 140);
            this.orszagLabel.Name = "orszagLabel";
            this.orszagLabel.Size = new System.Drawing.Size(50, 16);
            this.orszagLabel.TabIndex = 7;
            this.orszagLabel.Text = "Ország";
            // 
            // hosszLabel
            // 
            this.hosszLabel.AutoSize = true;
            this.hosszLabel.Location = new System.Drawing.Point(372, 219);
            this.hosszLabel.Name = "hosszLabel";
            this.hosszLabel.Size = new System.Drawing.Size(45, 16);
            this.hosszLabel.TabIndex = 8;
            this.hosszLabel.Text = "Hossz";
            // 
            // evLabel
            // 
            this.evLabel.AutoSize = true;
            this.evLabel.Location = new System.Drawing.Point(372, 293);
            this.evLabel.Name = "evLabel";
            this.evLabel.Size = new System.Drawing.Size(23, 16);
            this.evLabel.TabIndex = 9;
            this.evLabel.Text = "Év";
            // 
            // helyBox
            // 
            this.helyBox.Location = new System.Drawing.Point(467, 65);
            this.helyBox.Name = "helyBox";
            this.helyBox.Size = new System.Drawing.Size(135, 22);
            this.helyBox.TabIndex = 10;
            // 
            // orszagBox
            // 
            this.orszagBox.Location = new System.Drawing.Point(467, 134);
            this.orszagBox.Name = "orszagBox";
            this.orszagBox.Size = new System.Drawing.Size(135, 22);
            this.orszagBox.TabIndex = 11;
            // 
            // hosszBox
            // 
            this.hosszBox.Location = new System.Drawing.Point(467, 213);
            this.hosszBox.Name = "hosszBox";
            this.hosszBox.Size = new System.Drawing.Size(135, 22);
            this.hosszBox.TabIndex = 12;
            // 
            // evBox
            // 
            this.evBox.Location = new System.Drawing.Point(467, 287);
            this.evBox.Name = "evBox";
            this.evBox.Size = new System.Drawing.Size(135, 22);
            this.evBox.TabIndex = 13;
            // 
            // kilepesGomb
            // 
            this.kilepesGomb.Location = new System.Drawing.Point(436, 436);
            this.kilepesGomb.Name = "kilepesGomb";
            this.kilepesGomb.Size = new System.Drawing.Size(86, 29);
            this.kilepesGomb.TabIndex = 14;
            this.kilepesGomb.Text = "Kilépés";
            this.kilepesGomb.UseVisualStyleBackColor = true;
            this.kilepesGomb.Click += new System.EventHandler(this.kilepesGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 545);
            this.Controls.Add(this.kilepesGomb);
            this.Controls.Add(this.evBox);
            this.Controls.Add(this.hosszBox);
            this.Controls.Add(this.orszagBox);
            this.Controls.Add(this.helyBox);
            this.Controls.Add(this.evLabel);
            this.Controls.Add(this.hosszLabel);
            this.Controls.Add(this.orszagLabel);
            this.Controls.Add(this.helyLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Függőhidak";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton elottButton;
        private System.Windows.Forms.Label darabLabel;
        private System.Windows.Forms.TextBox darabBox;
        private System.Windows.Forms.Label helyLabel;
        private System.Windows.Forms.Label orszagLabel;
        private System.Windows.Forms.Label hosszLabel;
        private System.Windows.Forms.Label evLabel;
        private System.Windows.Forms.TextBox helyBox;
        private System.Windows.Forms.TextBox orszagBox;
        private System.Windows.Forms.TextBox hosszBox;
        private System.Windows.Forms.TextBox evBox;
        private System.Windows.Forms.Button kilepesGomb;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
    }
}

