using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueV2
{
    public partial class Form1 : Form
    {
        Queue<String> musteri = new Queue<String>();
        public Form1()
        {
            InitializeComponent();
        }
        private void musteriCagir(Label lbl)
        {
            if (musteri.Count > 0)
            {
                lbl.Text = musteri.Dequeue();
            }
            else
            {
                MessageBox.Show("Müsteriler Bitti !!!!!!!!!");
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Enqueue(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriCagir(lbl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriCagir(lbl2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteriCagir(lbl3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Enqueue("Nursevim");
            musteri.Enqueue("Hilal");
            musteri.Enqueue("Yezda");
            musteri.Enqueue("Ravza");
        }
    }
}
