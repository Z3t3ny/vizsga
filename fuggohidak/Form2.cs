using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuggohidak
{
    public partial class Form2 : Form
    {
        new List<Fuggohid> lista2;
        public Form2(List<Fuggohid> lista)
        {
            InitializeComponent();
            this.lista2 = lista;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Fuggohid item in lista2)
            {
                if (!comboBox1.Items.Contains(item.Orszag))
                {
                    comboBox1.Items.Add(item.Orszag);
                }
            }
        }

        private void bezarasGOmb_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void keresesGomb_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (checkBox1.Checked)
            {
                foreach (Fuggohid item in lista2)
                {
                    if (item.Hossz > 1000 && item.Orszag == comboBox1.SelectedItem)
                    {
                        listBox1.Items.Add(item.Nev);
                    }
                }
            }
            else
            {
                foreach (Fuggohid item in lista2)
                {
                    if (item.Orszag == comboBox1.SelectedItem.ToString())
                    {
                        listBox1.Items.Add(item.Nev);
                    }
                    
                }
            }
        }
    }
}
