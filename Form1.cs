using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafıza_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //karısık sayı uretırıruoruz (kodu yazuyoruz)
        Random rastgele = new Random();
        int sure = 8;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer1.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = true;
            //int degerleri gırıyoruz
            int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10, sayi11, sayi12, sayi13, sayi14, sayi15;
            
            //karıstırma ıslemı yapıyoruz
            sayi1 = rastgele.Next(0, 51);
            sayi2 = rastgele.Next(0, 51);
            sayi3 = rastgele.Next(0, 51);
            sayi4 = rastgele.Next(0, 51);
            sayi5 = rastgele.Next(0, 51);
            sayi6 = rastgele.Next(0, 51);
            sayi7 = rastgele.Next(0, 51);
            sayi8 = rastgele.Next(0, 51);
            sayi9 = rastgele.Next(0, 51); //(Öcellıkle yazdırmadıgımız ıcın soluk gozukuyordu)
            sayi10 = rastgele.Next(0, 51);
            sayi11 = rastgele.Next(0, 51);
            sayi12 = rastgele.Next(0, 51);
            sayi13 = rastgele.Next(0, 51);
            sayi14 = rastgele.Next(0, 51);
            sayi15 = rastgele.Next(0, 51);//(  yazdırılanlar normal sekılde  gozukuyor)

            //yazdırıyoruz..
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();
            label7.Text = sayi7.ToString();
            label8.Text = sayi8.ToString();
            label9.Text = sayi9.ToString();
            label10.Text = sayi9.ToString();
            label11.Text = sayi11.ToString();
            label12.Text = sayi12.ToString();
            label13.Text = sayi13.ToString();
            label14.Text = sayi14.ToString();
            label15.Text = sayi15.ToString();



            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text && label6.Text == textBox6.Text && label7.Text == textBox7.Text && label8.Text == textBox8.Text && label9.Text == textBox9.Text && label10.Text == textBox10.Text && label11.Text == textBox11.Text && label12.Text == textBox12.Text && label13.Text == textBox13.Text && label14.Text == textBox14.Text && label15.Text == textBox15.Text)
            {
                MessageBox.Show("Maşallah Hafızanız çok iyi :)");
                pictureBox1.ImageLocation = @"D:\VB\images\işretler\sevinme.gif";
            }
            else
            {
                MessageBox.Show("Hafızanın o kadarda iyi degil :(");
                pictureBox1.ImageLocation = @"D:\VB\images\işretler\kizgin.gif";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label32sure.Text = sure.ToString();


            if (sure == 0)
            {
                timer1.Enabled = false;
                groupBox1.Visible = true;
                pictureBox1.Visible = true;
                //button3.Enabled = false;
                button2.Visible = true;
                sure = 8;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            //timer1.Enabled = true;
            pictureBox1.Visible = false;
            button1.Enabled = true;
            button3.Enabled = false;

            label1.Text = "1";
            label2.Text = "2";
            label3.Text = "3";
            label4.Text = "4";
            label5.Text = "5";
            label6.Text = "6";
            label7.Text = "7";
            label8.Text = "8";
            label9.Text = "9";
            label10.Text = "10";
            label11.Text = "11";
            label12.Text = "12";
            label13.Text = "13";
            label14.Text = "14";
            label15.Text = "15";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }
    }
}
