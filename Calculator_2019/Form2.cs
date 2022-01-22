using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator_2019
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);             //1. textBox'a yazılan sayıyı bir integer'a atıyoruz.
            int b = Convert.ToInt32(textBox2.Text);             //2. textBox'a yazılan sayıyı bir integer'a atıyoruz.
            int min, div = 1;
            if (a > b)                                          //Küçük sayının hangisi olduğunu belirliyoruz.
                min = b;
            else
                min = a;
            for (int i = 1; i < min; i++)
            {
                if (a % i == 0 && b % i == 0)                   //Sayıların ortak kalansız bölünebildiği en büyük sayıyı bulmak için i değerini arttırma döngüsüne alıyoruz.
                    div = i;
                if (a % b == 0)                                 //Eğer iki sayıdan biri ebob'un kendisiyse, bu sayıyı bulmak için sayıların birbirine kalansız bölünüp bölünmediğine bakıyoruz.
                    div = min;
            }
            labelEbob.Text = Convert.ToString(div);             //Bulduğumuz ebob değerini arayüzdeki gerekli yere yazıyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);             //1. textBox'a yazılan sayıyı bir integer'a atıyoruz.
            int b = Convert.ToInt32(textBox2.Text);             //2. textBox'a yazılan sayıyı bir integer'a atıyoruz.
            int max, kat = 1;
            max = a > b ? a : b;                                //Büyük sayının hangisi olduğunu buluyoruz.
            for (int i = max; i <= a * b; i++)
            {
                if (i % a == 0 && i % b == 0)                   //Sayıların kendisinden büyük olan ortak en küçük hangi sayıya bölündüğünü buluyoruz.
                {
                    kat = i;                                    //Bulduğumuz değeri bir değişkene atıyoruz.
                    break;
                }
            }
            labelEkok.Text = Convert.ToString(kat);             //Bulduğumuz ekok değerini arayüzdeki gerekli yere yazıyoruz.
        }
    }
}
