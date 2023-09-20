using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class FrmYarisma : Form
    {
        public FrmYarisma()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

 

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            LblSoruNo.Text = soruno.ToString();
            

            if (soruno == 1)
            {
                
                richTextBox1.Text = "Sakarya Meydan Muharebesi hangi tarihte yapılmıştır?";
                BtnA.Text = "1920";
                BtnB.Text = "1924";
                BtnC.Text = "1922";
                BtnD.Text = "1923";

                label4.Text = "1922";

                
            }
            

            if (soruno == 2)
            {
                richTextBox1.Text = "Dünyanın toplam yüzölçümü kaçtır?";
                BtnA.Text = "610.100.000 km²";
                BtnB.Text = "510.100.000 km²";
                BtnC.Text = "410.100.000 km²";
                BtnD.Text = "310.100.000 km²";

                label4.Text = "510.100.000 km²";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Yedi renkten oluşan gökkuşağının ortasındaki renk?";
                BtnA.Text = "Mavi";
                BtnB.Text = "Sarı";
                BtnC.Text = "Yeşil";
                BtnD.Text = "Kırmızı";

                label4.Text = "Yeşil";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Dede Korkut'un Türk Desyanlarının özgün kopyaları hangi iki şehirde bulunmaktadır? ";
                BtnA.Text = "Lizbon-Roma";
                BtnB.Text = "Dresden-Vatikan";
                BtnC.Text = "Londra-Budapeşte";
                BtnD.Text = "Paris-Varşova";

                label4.Text = "Dresden-Vatikan";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Her yüzyılda 7 cm yere yaklaşan Pisa Kulesi hangi yöne doğru eğilmektedir ? ";
                BtnA.Text = "Batı";
                BtnB.Text = "Kuzey";
                BtnC.Text = "Güney";
                BtnD.Text = "Doğu";

                label4.Text = "Güney";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Heredotun yazdığı, Mısır firavununun dilin kökeni deneyinde, doğunca çobana verilerek, kapatılan  o dahil kimseyle konuşturulmayan  çocuğun söylediği ilk kelime nedir ? ";
                BtnA.Text = "Ver";
                BtnB.Text = "Anne";
                BtnC.Text = "Ekmek";
                BtnD.Text = "Su";

                label4.Text = "Ekmek";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Barış Manço 1982'de kimin mezarının yeni baştan yapılmasına katkıda bulunmuştur?? ";
                BtnA.Text = "Sarı Çizmeli Mehmet Ağa'nın";
                BtnB.Text = "Kul Ahmet'in";
                BtnC.Text = "Gülpembe'nin";
                BtnD.Text = "Hala kızı Zehra'nın";

                label4.Text = "Sarı Çizmeli Mehmet Ağa'nın";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "16. yüzyılda Avrupa'da Türk buğdayı ve Türk tahılı olarak da bilinen hangisidir? ";
                BtnA.Text = "Mısır";
                BtnB.Text = "Yulaf";
                BtnC.Text = "Susam";
                BtnD.Text = "Susam";

                label4.Text = "Mısır";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "2013'te Birleşik Krallık'ta yaklaşık 2000 kişiyle yapılan bir araştırmada, bekar kadınlar yatak çarşaflarını temiziyle yılda ortalama 26 kez değiştirirken bekar erkekler bunu yılda ortalama kaç kez yapmaktadır?";
                BtnA.Text = "2";
                BtnB.Text = "4";
                BtnC.Text = "10";
                BtnD.Text = "13";

                label4.Text = "4";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Hangisi tarafından saldırıya uğrayıp öldürüldüğü kayda geçen bir insan olmamıştır? ";
                BtnA.Text = "Piranalar";
                BtnB.Text = "Karıncalar";
                BtnC.Text = "Katil balinalar";
                BtnD.Text = "Pandalar";

                label4.Text = "Pandalar";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "En güçlü teleskopla bakıyor olsanız dahi Türkiye'de gecenin tam ortasında gökyüzünde hangi iki gezegeni göremezsiniz? ";
                BtnA.Text = "Merkür ve Venüs";
                BtnB.Text = "Mars ve Venüs";
                BtnC.Text = "Satürn ve Uranüs";
                BtnD.Text = "Neptün ve Satürn";

                label4.Text = "Merkür ve Venüs";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Marşal Adaları, hangisine sahip olmayan, Birleşmiş Milletlere üye olan bir ülkedir? ";
                BtnA.Text = "Milli futbol takımı";
                BtnB.Text = "Milli marş";
                BtnC.Text = "Bayrak";
                BtnD.Text = "Başkent";

                label4.Text = "Milli futbol takımı";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Geçtiğimiz aylarda yayımlanan akademik bir çalışmaya göre, kadınlara gösterilen 40 farklı erkek suratından elde edilen verilerden hangi durumdaki erkeklerin daha çekici olduğu sonucuna varılmıştır? ";
                BtnA.Text = "Desenli bez maske takmış";
                BtnB.Text = "Ağzı burnu siyah bir kitapla kapatılmış";
                BtnC.Text = "Yüzü tamamen açık";
                BtnD.Text = "Cerrahi maske takmış";

                label4.Text = "Cerrahi maske takmış";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "1887'de bir grup erkeğin şaka amaçlı kendisini belediye başkanı adayı olarak göstermesinin ardından oyların üçte ikisini alan aday hangi ülkenin seçilen ve görev yapan ilk kadın belediye başkanı olmuştur? ";
                BtnA.Text = "Japonya";
                BtnB.Text = "ABD";
                BtnC.Text = "Fransa";
                BtnD.Text = "Çin";

                label4.Text = "ABD";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Hangi ülke, 1946'dan beri Birleşmiş Milletlerin dört ana merkezinden birine ev sahipliği yapmasına rağmen organizasyona 2002'de üye olmuştur? ";
                BtnA.Text = "ABD";
                BtnB.Text = "Mısır";
                BtnC.Text = "İsviçre";
                BtnD.Text = "Hindistan";

                label4.Text = "İsviçre";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Ebleh buna inanmış şeklinde biten atasözünün başı nasıldır ? ";
                BtnA.Text = "İki kardeş savaşmış";
                BtnB.Text = "Gelin kaynana anlaşmış";
                BtnC.Text = "Gelin görümce barışmış";
                BtnD.Text = "İki aşık darılmış";

                label4.Text = "İki kardeş savaşmış";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "2008 Pekin Olimpiyatları'nda 9,69'luk derecesiyle 100 metre finalinde dünya rekoru kıran Usain Bolt bu rekoru hangi durumdayken kırmıştır? ";
                BtnA.Text = "Sağ ayakkabısının içinde taş varken";
                BtnB.Text = "Sol ayak başparmak tırnağı batıyorken";
                BtnC.Text = "Sağ ayakkabısının altına sakız yapışmışken";
                BtnD.Text = "Sol ayakkabısının bağı çözülmüşken";

                label4.Text = "Sol ayakkabısının bağı çözülmüşken";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "1959'da New York'taki bir şampiyonaya erkek kılığında katılan Rena Kanogoki, hangi alanda altın madalya kazanmış ve kadın olduğu anlaşılınca madalyasını iade etmek zorunda kalmıştır? ";
                BtnA.Text = "Satranç";
                BtnB.Text = "Judo";
                BtnC.Text = "Eskrim";
                BtnD.Text = "Okçuluk";

                label4.Text = "Judo";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "TİAK'ın yaptığı araştırmaya göre Türkiye'nin üç büyük ilinin 2020'de kişi başı günlük ortalama televizyon izleme süresi en fazla olandan en az olana doğru sırası nasıldır? ";
                BtnA.Text = "İstabul, Ankara, İzmir";
                BtnB.Text = "Ankara, İstanbul, İzmir";
                BtnC.Text = "İzmir, İstanbul, Ankara";
                BtnD.Text = "İstanbul, İzmir Ankara";

                label4.Text = "İzmir, İstanbul, Ankara";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Meteoroloji Genel Müdürlüğünün verilerine göre 9 Ocak 1990'da -46,4 santigrat dereceyle Türkiye'deki en düşük sıcaklık hangi ilin sınırları içerisinde ölçülmüştür? ";
                BtnA.Text = "Van";
                BtnB.Text = "Muş";
                BtnC.Text = "Ankara ";
                BtnD.Text = "Erzurum";

                label4.Text = "Van";

                BtnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 21)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }

        }
    }
}
