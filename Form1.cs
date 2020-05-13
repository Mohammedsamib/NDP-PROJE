/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				   BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: PROJE
**				ÖĞRENCİ ADI............:MOHAMMED SAMI BA HAMID
**				ÖĞRENCİ NUMARASI.......:B171200558
**                         DERSİN ALINDIĞI GRUP...:A
****************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROJECT_2
{

    public partial class Form1 : Form
    {
       /* Burdaki parantez icinde iki değer var 
       soldaki değer her saniye için kandan kaç azaltılır
       ve sağdaki değer üretilen fiyatı temsil ederler */

        Tavuk tavuk = new Tavuk(2, 14);
        inek inek = new inek (2,8 );
        ordek ordek = new ordek( 2, 6);
        keci keci = new keci( 2,10);

        int kasa;
        int kasa_sum;





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


           


        }

        int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;

            tavuk.HP_herSaniye_fu();
            inek.HP_herSaniye_fu();
            ordek.HP_herSaniye_fu();
            keci.HP_herSaniye_fu();
            //Burada hayvanlar üreteceği yem hızlı edebilir ve yavaşlatabilir . 

            if (timer % 7== 0)
                tavuk.Add_uretilen();

            if (timer % 3 == 0)
                inek.Add_uretilen();

            if (timer % 8 == 0)
                ordek.Add_uretilen();

            if (timer % 5 == 0)
                keci.Add_uretilen();





            UI();
        }

        /*user interface*/
        void UI()
        {
            /* Burada hayvanların kanı temsil eder .*/

            progressBar_Ta.Value = tavuk.Hayvan_hayati;
            progressBar_or.Value = ordek.Hayvan_hayati;
            progressBar_in.Value = inek.Hayvan_hayati;
            progressBar_ke.Value = keci.Hayvan_hayati;

            timer_text.Text = timer.ToString();

            // Burada değerler string olarak çeverilir ve kullanıcıya çıkacak .
            label4.Text = tavuk.uretilen.ToString();
            label8.Text = inek.uretilen.ToString();
            label5.Text = ordek.uretilen.ToString();
            label9.Text = keci.uretilen.ToString();


            if (inek.Hayvan_hayati <= 0)
            {
                label13.Text = "ÖLDU";
            }


            if (ordek.Hayvan_hayati <= 0)
            {
                label17.Text = "ÖLDU";
            }


            if (tavuk.Hayvan_hayati <= 0)
            {
                label16.Text = "ÖLDU";
            }


            if (keci.Hayvan_hayati <= 0)
            {
                label19.Text = "ÖLDU";
            }           


            label14.Text = kasa.ToString();

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inek.Add_Hp();
            UI();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tavuk.Add_Hp();
            UI();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordek.Add_Hp();
            UI();

        }


        private void button7_Click(object sender, EventArgs e)
        {
            kasa += ordek.para_ekle();
           kasa_sum = kasa;

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           kasa+= tavuk.para_ekle();
            kasa_sum = kasa;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kasa += inek.para_ekle();
            kasa_sum = kasa;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            kasa += keci.para_ekle();
            kasa_sum = kasa;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            keci.Add_Hp();
            UI();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tavuk.Add_Hp();
            UI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ordek.Add_Hp();
            UI();
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(814, 490);
        }
    }
}
