using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biricik.aleyna.cok.güzel.cokta.tatlı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sen bittin!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
            groupBox2.BackColor = Color.Yellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button6.Visible = false;
            timer1.Interval = 1000;
            timer2.Start();
            timer2.Interval=500;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            button5.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = "";
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    a += i.ToString() + "x" + j + "=" + (i * j) + "\n";
                }
            }
            MessageBox.Show(a);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            for (int a = 1; a <= 10; a++)
            {
                for (int u = 1; u <= 10; u++)
                {
                    listBox1.Items.Add(a.ToString() + "x" + u + "=" + (a * u) + "\n");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "Tekler" + "\n";
            for (int a = 1; a <= 10; a++)
            {

                if (a % 2 == 1)
                {
                    label1.Text += a + "\n";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "Çiftler" + "\n";
            for (int b = 1; b <= 10; b++)
            {
                if (b % 2 == 0)
                {
                    label2.Text += b + "\n";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string fi = "";
            int s1 = 1;
            int s2 = 2;
            int s3 = 0;

            for (int i = 1; i <= 50; i++)
            {
                s3 = (s1 + s2);
                fi += s3.ToString() + "/";
                s1 = s2;
                s2 = s3;


            }
            MessageBox.Show(fi);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "aleyna" || textBox1.Text == "ALEYNA")
            {
                if (textBox2.Text == "1234")
                {
                    groupBox10.BackColor = Color.Green;
                    radioButton1.Visible = true;
                    radioButton1.Checked = true;
                    radioButton1.Text = "Giriş Başarılı.";
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                }

            }
            else
            {
                groupBox10.BackColor = Color.Red;
                radioButton1.Visible = true;
                radioButton1.Checked = true;
                radioButton1.Text = "Giriş Başarısız.";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int s1, s2, tpl, ckr, carp, blm, mod;
            s1 = Convert.ToInt32(textBox3.Text);
            s2 = Convert.ToInt32(textBox4.Text);
            tpl = s1 + s2;
            ckr = s1 - s2;
            carp = s1 * s2;
            blm = s1 / s2;
            mod = s1 % s2;
            if (radioButton2.Checked == true)
            {
                label5.Text = "Cevap=" + tpl;
            }
            if (radioButton3.Checked == true)
            {
                label5.Text = "Cevap=" + ckr;
            }
            if (radioButton4.Checked == true)
            {
                label5.Text = "Cevap=" + carp;
            }
            if (radioButton5.Checked == true)
            {
                label5.Text = "Cevap" + blm;
            }
            if (radioButton6.Checked == true)
            {
                label5.Text = "Cevap" + mod;
            }

        }


        private void button14_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            if (checkBox1.Checked == true)
            {
                label6.Text += checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)
            {
                label6.Text += checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                label6.Text += checkBox3.Text + "\n";
            }
            if (checkBox4.Checked == true)
            {
                label6.Text += checkBox4.Text + "\n";
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                if (checkBox5.Checked == true)
                {
                    MessageBox.Show("Kayıt Başarılı" + " " + textBox5.Text);

                }
            }
            else
            {
                MessageBox.Show("Lütfen eksik alanları doldrurun.");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Form2 kvkk = new Form2();
            kvkk.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            string a = textBox7.Text;
            int b = Convert.ToInt32(textBox8.Text);
            for (int c = 1; c <= b; c++)
            {
                label9.Text += a + "\n";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 10);
            label12.Text = a.ToString();
        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            syc--;
            label13.Text = syc.ToString();
            Random ran = new Random();
            int a = ran.Next(1,10000);
            label14.Text = a.ToString();
        }

        int syc = 30;
        private void button18_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            string[] isimler = {"", "ERDİNÇ", "EGE", "ALTAN", "AYNUR", "FAHRİYE", "ALEYNA" };
            int a = Convert.ToInt32(textBox9.Text);
            label17.Text = isimler[a].ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            button20.Enabled = false;
            textBox10.Enabled = true;
            
        }
        Random t2 = new Random();
        int t;
        private void timer2_Tick(object sender, EventArgs e)
        {
            t = t2.Next(2, 10);
            label18.Text = t.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox10.Text);
            if(sayi < t)
            {
                MessageBox.Show("DAHA BÜYÜK SAYI GİR!");
                textBox10.Focus();
            }
            if(sayi > t)
            {
                MessageBox.Show("DAHA KÜ.ÜK SAYI GİR");
                textBox10.Focus();
            }
            if(sayi == t)
            {
                MessageBox.Show("YAŞASIN BULDUN!");
                timer2.Start();
                button20.Enabled = true;
                textBox10.Enabled = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int[] sayi = {1,2,3,4,5,6,7,8,9,10};
            for(int i = 0; i<=9; i++)
            {
                int kare = sayi[i] * sayi[i];
                listBox2.Items.Add(kare + "\n");
            }
        }
    }
}
