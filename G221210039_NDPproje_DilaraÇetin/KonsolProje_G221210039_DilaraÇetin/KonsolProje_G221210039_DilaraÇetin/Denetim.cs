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
    internal class Denetim
    {
        public static void Menu()
        {
            Console.WriteLine("---------- Çarpışma Denetimi (Collision Detection)----------");
            Console.WriteLine();
            Console.WriteLine("1-  Nokta, dikdörtgen çarpışma denetimi.");
            Console.WriteLine("2-  Nokta, çember çarpışma denetimi.");
            Console.WriteLine("3-  Dikdörtgen, dikdörtgen çarpışma denetimi.");
            Console.WriteLine("4-  Dikdörtgen, çember çarpışma denetimi.");
            Console.WriteLine("5-  Çember, çember çarpışma denetimi.");
            Console.WriteLine("6-  Nokta, küre çarpışma dnetimi.");
            Console.WriteLine("7-  Nokta, dikdörtgen prizma çarpışma denetimi.");
            Console.WriteLine("8-  Nokta, silindir çarpışma denetimi.");
            Console.WriteLine("9-  Silindir, silindir çarpışma denetimi.");
            Console.WriteLine("10- Küre, küre çarpışma denetimi.");
            Console.WriteLine("11- Küre, silindir çarpışma denetimi.");
            Console.WriteLine("12- Yüzey, küre çarpışma denetimi.");
            Console.WriteLine("13- Yüzey, dikdörtgen prizma çarpışma denetimi.");
            Console.WriteLine("14- Yüzey, silindir çarpışma denetimi.");
            Console.WriteLine("15- Küre, dikdörtgen prizma çarpışma denetimi.");
            Console.WriteLine("16- Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi.");
            Console.WriteLine();
            Console.Write("Lütfen menüden bir seçim yapınız:");
        }
    }
}
