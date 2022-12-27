using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        dön3:
            Console.Clear();
            Console.WriteLine("Uygulamımıza Hoş Geldiniz. Uygulamayı kullanabilmek için oturum açmanız gerekmektedir. " +
                "Kaydınız varsa 'Giriş Yap', yok ise 'Kayıt Ol' yazınız.");
            string sifre = "";
            string kullanici_adi = "";
            string uygulamaya_giriş = Console.ReadLine();
            if (uygulamaya_giriş == "Kayıt Ol")
            {
                dön5:
                Console.Clear();
                Console.Write("Kullanıcı Adı : ");
                kullanici_adi = Console.ReadLine();
                Console.Write("Şifre : ");
                sifre = Convert.ToString(Console.ReadLine());
                Console.Write("Şifre Tekrar : ");
                string kayit_sifre_tekrar = Convert.ToString(Console.ReadLine());

                if (sifre == kayit_sifre_tekrar)
                {
                    Console.WriteLine("Kaydınız Başarılı Bir Şekilde Oluşturulmuştur. Giriş Yapabilirsiniz.");
                    Console.ReadKey();
                    Console.Clear();
                    goto dön3;

                }
                else
                {
                    Console.WriteLine("Girdiğiniz Şifreler Aynı Olmalıdır.");
                    Console.ReadKey();
                    Console.Clear();
                    goto dön5;
                }
               
                if (sifre.Length == 4)
                {
                    Console.WriteLine("Kayıt Başarılı");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("- UYARI ! Şifreniz 4 haneli olmalıdır. -");
                    goto dön5;
                }

            }
            else if (uygulamaya_giriş == "Giriş Yap")
            {
            dön2:
                Console.Clear();
                Console.Write("Kullanıcı Adı : ");
                string kullanici_adi2 = Console.ReadLine();
                Console.Write("Şifre : ");
                string sifre2 = Console.ReadLine();
                if (sifre == sifre2 && kullanici_adi2 == kullanici_adi)
                {
                    Console.WriteLine("Girişiniz Başarılı.");
                }
                else if (sifre != sifre2 || kullanici_adi2 != kullanici_adi)
                {
                    Console.WriteLine("Girişiniz Başarısız.");
                    goto dön2;
                }
                else
                {
                    goto dön3;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Lütfen 'Giriş Yap' yada 'Kayıt OL' seçemeklerinden birini giriniz");
                Console.ReadKey();
                goto dön3;
            }
            Console.ReadKey();
            double odenecekTutar = 0;

            dön:
            Console.WriteLine("Araç Tipleri Taksi : 1, Minübüs : 2");
            Console.WriteLine("                                    ");
            Console.WriteLine("                                    ");
            Console.WriteLine("Lütfen Araç Tipini Giriniz : ");
            int aracTipi = Convert.ToInt32(Console.ReadLine());
           
            if(aracTipi == 1)
            {
                Console.Clear();
                Console.WriteLine(" ------------ Bineceğiniz yeri ekrandan Seçiniz ------------ ");
                Console.WriteLine("                                    ");
                Console.WriteLine("                                    ");
                Console.WriteLine("==============================================");
                Console.WriteLine("                                              ");
                Console.WriteLine("                 1-Hadımköy              ");
                Console.WriteLine("                 2-Haraççı               ");
                Console.WriteLine("                 3-Taşoluk               ");
                Console.WriteLine("                 4-Bolluca               ");
                Console.WriteLine("                 5-Çatalca              ");
                Console.WriteLine("                                              ");
                Console.WriteLine("==============================================");
                Console.Write("Seçiminiz : ");
                int binilecekyer = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(" ------------ Gidiceğiniz yeri EKrandan Seçiniz ------------ ");
                Console.WriteLine("                                    ");
                Console.WriteLine("                                    ");
                Console.WriteLine("==============================================");
                Console.WriteLine("                                              ");
                Console.WriteLine("                 1-Hadımköy              ");
                Console.WriteLine("                 2-Haraççı               ");
                Console.WriteLine("                 3-Taşoluk               ");
                Console.WriteLine("                 4-Bolluca               ");
                Console.WriteLine("                 5-Çatalca              ");
                Console.WriteLine("                                              ");
                Console.WriteLine("==============================================");
                Console.Write("Seçiminiz : ");
                int gidilecekyer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bineceğiniz yer ile gideceğiniz yer arası metre başına 10 kuruştur   ");
                Console.ReadKey();
                Console.Clear();
                if (binilecekyer == 1 && gidilecekyer == 1)
                {

                    Console.WriteLine("------------ Yol güzergahı Başarısız ------------ ");
                    Console.WriteLine(" *********** Lütfen baska bir istikamet seçiniz *********** ");
                    Console.ReadKey();
                    Console.Clear();
                    goto dön;
                }
                else if (binilecekyer == 1 && gidilecekyer == 2)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 870 metre `dir *********** ");
                    odenecekTutar = 8700 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar +" TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.Clear();
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 1 && gidilecekyer == 3)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 120 metre `dir *********** ");
                    odenecekTutar = 1200 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.Clear();
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 1 && gidilecekyer == 4)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 1900 metre `dir *********** ");
                    odenecekTutar = 19000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }


                }
                else if (binilecekyer == 1 && gidilecekyer == 5)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 22000 metre `dir *********** ");
                    odenecekTutar = 22000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }


                }
                else if (binilecekyer == 2 && gidilecekyer == 1)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 9000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }


                }
                else if (binilecekyer == 2 && gidilecekyer == 2)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarısız ------------ ");
                    Console.WriteLine(" *********** Lütefn baska bir istikamet seçiniz *********** ");
                    Console.ReadKey();
                    Console.Clear();
                    goto dön;

                }
                else if (binilecekyer == 2 && gidilecekyer == 3)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 9000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 2 && gidilecekyer == 4)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 10000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }

                }
                else if (binilecekyer == 2 && gidilecekyer == 5)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 28000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 3 && gidilecekyer == 1)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 12000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 3 && gidilecekyer == 2)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 50000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 3 && gidilecekyer == 3)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarısız ------------ ");
                    Console.WriteLine(" *********** Lütefn baska bir istikamet seçiniz *********** ");
                    Console.ReadKey();
                    Console.Clear();
                    goto dön;
                }
                else if (binilecekyer == 3 && gidilecekyer == 4)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 8000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 3 && gidilecekyer == 5)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 18000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 4 && gidilecekyer == 1)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 19000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 4 && gidilecekyer == 2)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 10000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 4 && gidilecekyer == 3)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 8000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 4 && gidilecekyer == 4)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarısız ------------ ");
                    Console.WriteLine(" *********** Lütefn baska bir istikamet seçiniz *********** ");
                    Console.ReadKey();
                    Console.Clear();
                    goto dön;
                }
                else if (binilecekyer == 4 && gidilecekyer == 5)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 48000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 5 && gidilecekyer == 1)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 22000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 5 && gidilecekyer == 2)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 9000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 5 && gidilecekyer == 3)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 12000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 5 && gidilecekyer == 4)
                {
                    Console.Clear();
                    Console.WriteLine("------------ Yol güzergahı Başarılı ------------ ");
                    Console.WriteLine(" *********** bineceğiniz yer ile Gideceğiniz yer arası 9000 metre `dir *********** ");
                    odenecekTutar = 48000 / 10;
                    Console.WriteLine(" Ödeyeceğiniz Tutar : " + odenecekTutar + " TL");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("------------ Görüşmek Üzere ----------");
                    Console.WriteLine("Başa dönmek için ENTER `a basınız");

                    if (Console.ReadLine() == "")
                    {
                        Console.Clear();
                        goto dön;
                    }
                }
                else if (binilecekyer == 5 && gidilecekyer == 5)
                {
                    Console.WriteLine("------------ Yol güzergahı Başarısız ------------ ");
                    Console.WriteLine(" *********** Lütfen baska bir istikamet seçiniz *********** ");
                    Console.ReadKey();
                    Console.Clear();
                    goto dön;
                }
            }
            if (aracTipi == 2)
            {
                int inmekistediğiyer = 0;
                int yolcuseçim = 0;
                Console.Clear();
                Console.WriteLine("Öğrenci iseniz 1 `e Tıklayınız");
                Console.WriteLine("Yetişkin iseniz 2 `e Tıklayınız");
                yolcuseçim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Evet için 1 `e Tıklayınız ");
                Console.WriteLine("Hayır için 2 `ye Tıklayınız ");
                Console.WriteLine("                                ");
                Console.WriteLine("                                ");
                Console.WriteLine("1.Durakta inmek istermisiniz :");
                inmekistediğiyer =Convert.ToInt32( Console.ReadLine());
                Console.Clear();

                if (inmekistediğiyer==1 && yolcuseçim==1)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 5 TL "); 
                    
                }
                else if (inmekistediğiyer == 1 && yolcuseçim == 2)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 10 TL ");
                }
                else if (inmekistediğiyer == 2 && yolcuseçim == 1)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 8 TL ");
                }
                else if (inmekistediğiyer == 2 && yolcuseçim == 2)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 14 TL ");
                }
                else if (inmekistediğiyer == 3 && yolcuseçim == 1)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 12 TL ");
                }
                else if (inmekistediğiyer == 3 && yolcuseçim == 2)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 16 TL ");
                }
                else if (inmekistediğiyer == 4 && yolcuseçim == 1)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 15 TL ");
                }
                else if (inmekistediğiyer == 4 && yolcuseçim == 2)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 19 TL ");
                }
                else if (inmekistediğiyer == 5 && yolcuseçim == 1)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 17 TL ");
                }
                else if (inmekistediğiyer == 5 && yolcuseçim == 2)
                {
                    Console.WriteLine("Ödeyeceğiniz Tutar 22 TL ");
                }
                Console.ReadKey();
            }



                Console.ReadKey();

        }
    }
}
