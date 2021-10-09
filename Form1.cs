using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GokceNurSonmez_210601694
{
    public partial class frmOdev1 : Form
    {
        public frmOdev1()
        {
            InitializeComponent();
        }
        public void EkranHazirla()
        {
            msktxtBaslangic.Text = "1";
            msktxtBitis.Text = "10000";
            msktxtBaslangic.Focus();
        }

        Boolean Dogrula(int baslangic, int bitis)
        {
            return (bitis > baslangic) ? true : false;
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            int baslangic, bitis, tekToplam = 0, ciftToplam = 0, asalToplam = 0, mukemmelToplam = 0;
            double tekCarpim = 1, ciftCarpim = 1, asalCarpim = 1, mukemmelCarpim = 1;
            baslangic = Convert.ToInt32(msktxtBaslangic.Text);
            bitis = Convert.ToInt32(msktxtBitis.Text);
            for (int i = baslangic; i < bitis; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                    tekCarpim *= i;
                    Console.WriteLine(); lvTekSayilar.Items.Add(i.ToString());
                }
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                    ciftCarpim *= i;
                    Console.WriteLine(); lvCiftSayilar.Items.Add(i.ToString());

                }
            }
           
            bool asalsayiKontrol = true;

            for (int sayi = baslangic; sayi <= bitis; sayi++)
            {

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalsayiKontrol = false;
                        break;
                    }

                }

                if ((asalsayiKontrol == true) && (sayi != 1))
                {
                    asalToplam += sayi;
                    asalCarpim *= sayi;

                    lvAsalSayilar.Items.Add(sayi.ToString());

                }

                asalsayiKontrol = true;
            }
            for (int i = baslangic; i < bitis; i++)
            {

                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }

                if (sum == i)
                {
                    mukemmelToplam += i;
                    mukemmelCarpim *= i;
                    Console.WriteLine(); lvMukemmelSayilar.Items.Add(i.ToString());
                }
            }


            lvTekSayilar.Items.Add("Tek sayıların toplamı: " + tekToplam);
            lvTekSayilar.Items.Add("Tek sayıların çarpım: " + tekCarpim);
            lvCiftSayilar.Items.Add("Çift sayıların toplamı: " + ciftToplam);
            lvCiftSayilar.Items.Add("Çift sayıların çarpım: " + ciftCarpim);
            lvAsalSayilar.Items.Add("Asal sayıların toplamı: " + asalToplam);
            lvAsalSayilar.Items.Add("Asal sayıların çarpım: " + asalCarpim);
            lvMukemmelSayilar.Items.Add("Mükemmel sayıların toplamı: " + mukemmelToplam);
            lvMukemmelSayilar.Items.Add("Mükemmel sayıların çarpım: " + mukemmelCarpim);
        }
        private void frmOdev1_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }
        private void frmOdev1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Text = "Programa Hoşgeldiniz!";
            notifyIcon1.BalloonTipText = "Nesneye Yönelimli Programlama Ödev1";
            notifyIcon1.BalloonTipTitle = "tek Cift";
            notifyIcon1.ShowBalloonTip(1000);
        }


    }
}
