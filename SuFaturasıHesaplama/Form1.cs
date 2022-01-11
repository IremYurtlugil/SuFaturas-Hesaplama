using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuFaturasıHesaplama
{
    public partial class suFaturasi : Form
    {
        public suFaturasi()
        {
            InitializeComponent();
        }

        private void suFaturasi_Load(object sender, EventArgs e)
        {
            rdbtnUmumi.Checked = true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                //Doldurulması gereken alanları kontrol edeceğiz.

                int bosKontrol = 0;

                if (txtAdiSoyadi.Text == string.Empty)
                    bosKontrol = 1;
                if (bosKontrol==1)
                {
                    MessageBox.Show("Adı Soyadı boş geçilemez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                                  
                }

                if (txtSonIndex.Text == string.Empty)
                    bosKontrol = 1;
                if (bosKontrol==1)
                {
                    MessageBox.Show("Son ındex boş geçilemez.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }
                if (txtIlkIndex.Text == string.Empty)
                    bosKontrol = 1;
                if (bosKontrol==1)
                {
                    MessageBox.Show("Ilk ındex boş geçilemez.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                       
                }

                else if (bosKontrol!=1)
                {
                    //Ad soyad text box AdiSoyadi ol tanımladık forech ile kontrol ettik. Her bir karakter uygun mu diye
                    string AdiSoyadi = (txtAdiSoyadi.Text);

                    foreach (char karakter in AdiSoyadi)
                    {
                        if (char.IsDigit(karakter) || char.IsPunctuation(karakter))
                        {
                            MessageBox.Show("Ad ve soyad bölümüne rakam ve noktalama işareti girilemez. ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            return;

                        }
                    }

                    double sonIndex = Convert.ToDouble(txtSonIndex.Text);
                    double ilkIndex = Convert.ToDouble(txtIlkIndex.Text);

                    if (sonIndex<ilkIndex)
                    {
                        MessageBox.Show("Girdiğiniz index bilgileri hatalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else
                    {
                        double meskenBirimFiyatı = 0.7;
                        double umumiBirimFiyatı = 0.3;
                        double atikSuBirimFiyati = 0.2;
                        double atikSuYüzdeMiktari = 0.3;

                        double suMiktari = sonIndex - ilkIndex;
                        double atikSuÜcreti = suMiktari * atikSuYüzdeMiktari * atikSuBirimFiyati;

                        if (rdbtnUmumi.Checked==true)
                        {
                            lstSuMiktari.Items.Add($"{suMiktari} m3");
                            double umumiFiyat = suMiktari * umumiBirimFiyatı;
                            lstFaturaTutari.Items.Add($"{umumiFiyat} TL");
                        }
                        else if (rdbtnMesken.Checked==true)
                        {
                            lstSuMiktari.Items.Add($"{suMiktari} m3");
                            double meskenFiyat = (suMiktari * meskenBirimFiyatı)+atikSuÜcreti;
                            lstFaturaTutari.Items.Add($"{meskenFiyat} TL");
                        }

                        lstAdSoyad.Items.Add($"{AdiSoyadi.ToUpper()}");
                        MessageBox.Show("Hesaplama Tamamlanmıştır.", "İŞLEM SONU", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("İlk ve son index kontrollerine harf girmeyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
