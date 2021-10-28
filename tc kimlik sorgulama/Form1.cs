using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tc_kimlik_sorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int[] tc = new int[11];

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tck = textBox1.Text;

            if (textBox1.Text != " ")
            {
                if (tck.Length == 11)
                {
                    if (long.TryParse(tck, out long result))
                    {
                        for (int i = 0; i < tc.Length; i++)
                        {
                            tc[i] = int.Parse(tck.Substring(i, 1));
                        }

                        if (tc[0] != 0)
                        {

                            int a = ((tc[0] + tc[2] + tc[4] + tc[6] + tc[8]) * 7) + ((tc[1] + tc[3] + tc[5] + tc[7]) * 9);

                            if (a % 10 == tc[9])
                            {
                                int toplam = tc[0] + tc[2] + tc[4] + tc[6] + tc[8] + tc[1] + tc[3] + tc[5] + tc[7] + tc[9];

                                if (toplam % 10 == tc[10])
                                {
                                    int toplam2 = tc[0] + tc[2] + tc[4] + tc[6] + tc[8];

                                    if ((toplam2 * 8) % 10 == tc[10])
                                    {
                                        MessageBox.Show("Girilen TC geçerli");
                                    }
                                    else
                                    {
                                        MessageBox.Show("6.Maddeye uymuyor");
                                    }
                                }
                                else
                                {

                                    MessageBox.Show("5.Maddeye uymuyor");
                                }

                            }
                            else
                            {
                                MessageBox.Show("4.Maddeye uymuyor");
                            }

                        }
                        else
                        {
                            MessageBox.Show("TC sıfır rakamıyla başlayamaz");

                        }


                    }
                    else
                    {
                        MessageBox.Show("TC yalnızca rakamlardan oluşmalı");
                    }

                }
                else
                {
                    MessageBox.Show("Girdiğiniz TC 11 rakamdan oluşmalı");
                }
            }
        }
    }
}
