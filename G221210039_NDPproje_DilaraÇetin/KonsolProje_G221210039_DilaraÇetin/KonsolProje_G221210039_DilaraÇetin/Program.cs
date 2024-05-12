/***************************************************************************************************************************************
**                                                          SAKARYA ÜNİVERSİTESİ
**                                              BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                                    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                                      PROGRAMLAMAYA GİRİŞİ DERSİ
**
**                                                          ÖDEV NUMARASI: 1
**                                                    ÖĞRENCİ ADI: Dilara Çetin
**                                                         ÖĞRENCİ NUMARASI: G221210039
**                                                        DERS GRUBU: 2. öğretim C grubu
**                                                      YOUTUBE LİNKİ… …: https://youtu.be/Bavbr4w8Udo
***************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolProje_G221210039_DilaraÇetin
{
    internal class Program
    {
        static void Main(string[] args)
        {
        baslangic:

            Denetim.Menu();
            string secim = Console.ReadLine();

            Console.Clear();

            // carpismalar sınıfının fonksiyonlarına burada örnek verdim.

            if (secim == "1")
            {
                Console.WriteLine("------ Nokta - Dörtgen Çarpışma Denetimi ------");
                if (carpismalar.NoktaDortgenCarpisma(new Nokta(6, 8), new Dikdortgen(new Nokta(4, 2), 6, 10)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");

            }
            if (secim == "2")
            {
                Console.WriteLine("------ Nokta - Çember Çarpışma Denetimi ------");
                if (carpismalar.NoktaCemberCarpisma(new Nokta(3, 1), new Cember(new Nokta(5, 2), 8)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");

            }
            if (secim == "3")
            {
                Console.WriteLine("------ Dikdörtgen - Dikdörtgen Çarpışma Denetimi ------");
                if (carpismalar.DikdortgenCarpisma(new Dikdortgen(new Nokta(9, 2), 10, 4), new Dikdortgen(new Nokta(3, 7), 14, 8)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");

            }
            if (secim == "4")
            {
                Console.WriteLine("------ Dikdörtgen - Çember Çarpışma Denetimi ------");
                if (carpismalar.DikdortgenCemberCarpisma(new Dikdortgen(new Nokta(8, 3), 4, 18), new Cember(new Nokta(9, 7), 3)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");

            }
            if (secim == "5")
            {
                Console.WriteLine("------ Çember - Çember Çarpışma Denetimi -------");
                if (carpismalar.CemberCarpisma(new Cember(new Nokta(29, 2), 5), new Cember(new Nokta(12, 19), 9)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");
                Console.WriteLine();

            }
            if (secim == "6")
            {
                Console.WriteLine("------ Nokta - Küre Çarpışma Denetimi ------");
                if (carpismalar.NoktaKureCarpisma(new Nokta3d(25, 4, 0), new Kure(new Nokta3d(2, 9, 18), 2)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");

            }
            if (secim == "7")
            {
                Console.WriteLine("------ Nokta - Dörtgen Çarpışma Denetimi ------");
                if (carpismalar.NoktaDikdortgenPrizmaCarpisma(new Nokta3d(5, 2, 9), new DikdortgenPrizma(new Nokta3d(6, 4, 7), 8, 6, 12)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarışma yok.");
            }
            if (secim == "8")
            {
                Console.WriteLine("------ Nokta - Silindir Çarpışma Denetimi ------");
                if (carpismalar.NoktaSilindirCarpisma(new Nokta3d(15, 9, 0), new Silindir(new Nokta3d(7, 8, 0), 6, 10)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");

            }
            if (secim == "9")
            {
                Console.WriteLine("------ Silindir Silindir Çarpışma Denetimi ------");
                if (carpismalar.SilindirCarpisma(new Silindir(new Nokta3d(9, 15, 4), 6, 10), new Silindir(new Nokta3d(7, 10, 8), 8, 6)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");
            }

            if (secim == "10")
            {
                Console.WriteLine("------ Küre - Küre Çarpışma Denetimi ------");
                if (carpismalar.KureCarpisma(new Kure(new Nokta3d(8, 3, 10), 15), new Kure(new Nokta3d(4, 2, 7), 9)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");
            }
            if (secim == "11")
            {
                Console.WriteLine("------ Küre - Silindir Çarpışma Denetimi ------");
                if (carpismalar.KureSilindirCarpisma(new Kure(new Nokta3d(1, 5, 10), 9), new Silindir(new Nokta3d(10, 3, 7), 5, 8)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");
            }
            if (secim == "12")
            {
                Console.WriteLine("------ Yüzey - Küre Çarpışma Denetimi ------");
                if (carpismalar.YuzeyKureCarpisma(new Kure(new Nokta3d(8, 3, 3), 3)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");
            }
            if (secim == "13")
            {
                Console.WriteLine("------ Yüzey - Silindir Çarpışma Denetimine ------");
                if (carpismalar.YuzeySilindirCarpisma(new Silindir(new Nokta3d(2, 9, 10), 3, 20)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");

            }
            if (secim == "14")
            {
                Console.WriteLine("------ Yüzey - Dikdörtgen Prizma Çarpışma Denetimi ------");
                if (carpismalar.YuzeyDikdortgenPrizmaCarpisma(new DikdortgenPrizma(new Nokta3d(23, 9, 15), 6, 30, 6)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");



            }
            if (secim == "15")
            {
                Console.WriteLine("------ Küre - Dikdörtgen Prizma Çarpışma Denetimi ------");
                if (carpismalar.KureDikdortgenPrizmaCarpisma(new Kure(new Nokta3d(3, 7, 8),15), new DikdortgenPrizma(new Nokta3d(9, 10, 16), 7, 4, 6)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");
            }
            if (secim == "16")
            {
                Console.WriteLine("------ Dikdörtgen Prizma - Dikdörtgen Prizma Çarpışma Denetimi ------");
                if (carpismalar.DikdortgenPrizmaCarpisma(new DikdortgenPrizma(new Nokta3d(23, 9, 15), 6, 30, 6),new DikdortgenPrizma(new Nokta3d(8,14,16),2,8,10)))
                    Console.WriteLine("Çarpışma var.");
                else
                    Console.WriteLine("Çarpışma yok.");
            }
            Console.WriteLine();
            Console.WriteLine("Lütfen devam etmek için herhangi bir tuşa basınız.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Menüye geri dönmek için 1' e,");
            Console.WriteLine("Denetimi sonlandırmak için 2' ye basınız.");
            string secim2 = Console.ReadLine();
            Console.Clear();
            if (secim2 == "1")
                goto baslangic;


        }
    }
    
}
