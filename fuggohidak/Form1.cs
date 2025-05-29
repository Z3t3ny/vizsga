using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace fuggohidak
{

    public partial class Form1 : Form
    {
        public List<Fuggohid> lista = new List<Fuggohid>();
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int db = 0;
                foreach (Fuggohid item in lista)
                {
                    if (item.Ev >= 2000)
                    {
                        db++;
                    }
                }
                darabBox.Text = db.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(lista);
            this.Hide();
            form2.Show();

        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    lista.Clear();
                    listBox1.Items.Clear();

                    string elsosor = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        lista.Add(new Fuggohid(sr.ReadLine()));
                    }

                    foreach(Fuggohid item in lista)
                    {
                        listBox1.Items.Add(item.Nev);
                    }   
                }   
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            helyBox.Text = lista[index].Hely;
            orszagBox.Text = lista[index].Orszag;
            hosszBox.Text = lista[index].Hossz.ToString();
            evBox.Text = lista[index].Ev.ToString();
            
        }

        private void elottButton_CheckedChanged(object sender, EventArgs e)
        {
            int db = 0;

            if (elottButton.Checked)
            {
                foreach (Fuggohid item in lista)
                {
                    if (item.Ev < 2000)
                    {
                        db++;
                    }
                }
                darabBox.Text = db.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kilepesGomb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Fuggohid
    {
        public string Helyezes { get; set; }
        public string Nev { get; set; }
        public string Hely { get; set; }
        public string Orszag { get; set; }
        public int Hossz { get; set; }
        public int Ev { get; set; }

        public Fuggohid(string sor)
        {
            string[] adatok = sor.Split('\t');
            Helyezes = adatok[0];
            Nev = adatok[1];
            Hely = adatok[2];
            Orszag = adatok[3];
            Hossz = Convert.ToInt32(adatok[4]);
            Ev = Convert.ToInt32(adatok[5]);
        }
    }

}
