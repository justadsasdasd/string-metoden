using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_methoden_ausgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string all = textBox1.Text;
            labellänge.Text = all.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char zeichen;
            int i;
            string eingabe, anzeige;
            
            eingabe = textBox1.Text;
            anzeige = "";

            for (i=0; i<eingabe.Length;i++)
            {
                zeichen = eingabe[i];
                anzeige += i + ":" + zeichen + "\n";
            }
            labelzeichen.Text = anzeige;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string eingabe, getrimmt, anzeige;
            eingabe = textBox1.Text;

            getrimmt = eingabe.Trim(' ', ';', '#');
            labeltrim.Text = getrimmt;  
        }

        private void spltitten_Click(object sender, EventArgs e)
        {
            string eingabe = textBox1.Text;
            string[] teil;
            int i;

            teil = eingabe.Split('.');
            for (i = 0 ;i < teil.Length; i++)
            {
                labelsplit.Text += "Wort " + i + ": " + teil[i] + "\n";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string eingabe, such;
            int position;

            eingabe = textBox1.Text;
            such = textBox2.Text;

            position = eingabe.IndexOf(such);

            label6.Text = position.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string eingabe, such, anzeige = "";
            int position, suchstart = 0, anzahl = 0;

            eingabe = textBox1.Text;
            such = textBox2.Text;

            do
            {
                position = eingabe.IndexOf(such, suchstart);
                suchstart = position + 1;
                if (position != -1)
                {
                    anzeige += position + "\n";
                    anzahl++;
                }
            }
            while (position != -1);
            {
                anzeige += "Anzahl: " + anzahl;
                label6.Text = anzeige;
            }
            

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string eingabe, einfügen, anzeige;
            eingabe = textBox1.Text;
            einfügen = textBox3.Text;

            try
            {
                anzeige = eingabe.Insert((int)guna2NumericUpDown1.Value, einfügen);
                label10.Text = anzeige;
            }             
            catch (ArgumentOutOfRangeException)
            {
                label10.Text = "Position ist außerhalb";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string eingabe, anzeige;
            eingabe = textBox1.Text;

            try
            {
                anzeige = eingabe.Remove((int)guna2NumericUpDown3.Value,(int)guna2NumericUpDown2.Value);
                label16.Text = anzeige;
            }
            catch (ArgumentOutOfRangeException)
            {
                label16.Text = "Position ist außerhalb";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            labelsplit.Text = "";
            labelzeichen.Text = "";
            labeltrim.Text = "";
            labellänge.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            label6.Text = "";
            label10.Text = "";
            label16.Text = "";
            label20.Text = "";
            label24.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string eingabe, ersetzen, suchen, anzeige;
            eingabe = textBox1.Text;
            suchen = textBox4.Text;
            ersetzen = textBox5.Text;

            anzeige = eingabe.Replace(suchen, ersetzen);
            label20.Text = anzeige;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string eingabe, anzeige;

            eingabe = textBox1.Text;
            try
            {
                anzeige = eingabe.Substring((int)guna2NumericUpDown4.Value, (int)guna2NumericUpDown5.Value);
                label24.Text = anzeige;
            }
            catch (ArgumentOutOfRangeException)
            {
                label24.Text = "FEHLER!";
                
            }
        }
    }
}
