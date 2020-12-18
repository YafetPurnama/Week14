using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBoxNama.Text;

            if (textBoxNama.Text == "")
            {
                MessageBox.Show("Tolong isi Textbox terlebih dahulu");                
                textBoxNama.Text = "";
            }
            string data = textBoxNama.Text;
            char[] reverse= data.ToCharArray();
            Array.Reverse(reverse);
            int a;
            string empty = string.Empty;
            for (a = 0; a< reverse.Length; a++)
            {
                empty += reverse[a];
            }
            label2.Text = empty.ToString();
            textBoxNama.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNama_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = textBoxNama.Text;
            if (textBoxNama.Text == "")
            {                
                MessageBox.Show("Tolong isi Textbox terlebih dahulu");                
                textBoxNama.Text = "";
            }
            string data = textBoxNama.Text;
            char[] sort = data.ToCharArray();
            //Array.Sort(sort);            
            string kosong = string.Empty;
            string urutan = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789,./!@#$%^&*=+";
            char[] checkisi = urutan.ToCharArray();
            for (int c = 0; c < checkisi.Length; c++)
            {
                for (int b = 0; b < sort.Length; b++)
                {
                    if (sort[b] == checkisi[c])
                    {
                        kosong += sort[b];
                    }                    
                }
            }            
            label2.Text = kosong.ToString();
            textBoxNama.Text = "";
        }
    }
}
