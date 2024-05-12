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
    public class carpismalar
    {

        public static bool CemberCarpisma(Cember c1, Cember c2)
        {
            // Eğer çemberlerin merkezleri arasındaki mesafe yarıçapları toplamından küçük veya eşit ise çarpışma vardır.

            float d = (float)Math.Sqrt(Math.Pow((c1.M.X - c2.M.X), 2) + Math.Pow((c1.M.Y - c2.M.Y), 2));

            if (c1.R + c2.R >= d)
                return true;
            else
                return false;
        }
        public static bool SilindirCarpisma(Silindir s1, Silindir s2)
        {

            //Eğer silindirlerin merkezlerinin Y koordinatları arasındaki mesafe yüksekliklerinin yarısından küçük veya eşitse
            // ve merkezlerinin X ve Z koordinatları üzerindeki mesafesi yarıçapları toplamından küçük veya eşitse çarpışma vardır.

            float d = (float)Math.Sqrt(Math.Pow((s1.M.X - s2.M.X), 2) + Math.Pow((s1.M.Z - s1.M.Z), 2));

            if ((s1.R + s2.R) >= d && Math.Abs(s1.M.Y - s2.M.Y) <= ((s1.H + s2.H) / 2))
                return true;
            else
                return false;
        }
        public static bool NoktaSilindirCarpisma(Nokta3d n1, Silindir s1)
        {

            // Eğer noktanın ve silindirin merkezinin Y koordinatları arasındaki mesafe silindirin yüksekliğinin yarısından küçük veya eşitse
            // ve nokta ve silindirin merkezinin X ve Z koordinatları üzerindeki mesafesi silindirin yarıçapından küçük veya eşitse çarpışma vardır.

            float d = (float)Math.Sqrt(Math.Pow((n1.X - s1.M.X), 2) + Math.Pow((n1.Z - s1.M.Z), 2));
            if (s1.R >= d && Math.Abs(s1.M.Y - n1.Y) <= (s1.H / 2))
                return true;
            else
                return false;

        }
        public static bool KureSilindirCarpisma(Kure k1, Silindir s1)
        {
            // Eğer kürenin ve silindirin merkezlerinin Y koordinatları arasındaki mesafe, kürenin yarıçapı ve silindiri yüksekliğinin yarısının 
            // toplamından küçük veya eşitse ve merkezlerinin X ve Z koordinatları üzerindeki mesafe yarıçapları toplamından küçük veya eşitse çarpışma vardır .

            float d = (float)Math.Sqrt(Math.Pow((k1.M.X - s1.M.X), 2) + Math.Pow((k1.M.Z - s1.M.Z), 2));
            if ((Math.Abs(k1.M.Y - s1.M.Y) <= k1.R + s1.H / 2) && d <= k1.R + s1.R)
                return true;
            else
                return false;
        }
        public static bool NoktaDortgenCarpisma(Nokta n1, Dikdortgen d1)
        {
            // Noktanın koordinatları dörtgenin sınır koordinatları arasındaysa çarpışma vardır.

            int x1 = d1.M.X + d1.En / 2;
            int x2 = d1.M.X - d1.En / 2;
            int y1 = d1.M.Y + d1.Boy / 2;
            int y2 = d1.M.Y - d1.Boy / 2;
            if ((n1.X <= x1) && (n1.X >= x2) && (n1.Y <= y1) && (n1.Y >= y2))
                return true;
            else
                return false;
        }
        public static bool NoktaCemberCarpisma(Nokta n1, Cember c1)
        {
            // Noktanın ve çemberin X ve Y koordinatları arasındaki mesafe çemberin yarıçapından küçük veya eşit ise çarpışma vardır.

            float d = (float)Math.Sqrt(Math.Pow((n1.X - c1.M.X), 2) + Math.Pow((n1.Y - c1.M.Y), 2));
            if (c1.R >= d)
                return true;
            else
                return false;

        }
        public static bool DikdortgenCarpisma(Dikdortgen d1, Dikdortgen d2)
        {
            // Dikdörtgenlerin merkezlerinin Y koordinatları arasındaki mesafe, boyları toplamının yarısından küçük veya eşitse
            // ve X koordinatları arasındaki mesafe enleri toplamının yarısından küçük veya eşitse çarpışma vardır.

            float dx = (float)Math.Abs(d1.M.X - d2.M.X);
            float dy = (float)Math.Abs(d2.M.Y - d2.M.Y);
            if ((dx <= d1.En + d2.En / 2) && (dy <= (d1.Boy + d1.Boy) / 2))
                return true;
            else
                return false;
        }
        public static bool DikdortgenCemberCarpisma(Dikdortgen d1, Cember c1)
        {
            // Eğer dikdörtgenin ve çemberin merkezlerinin Y koordinatları arsındaki mesafe çemberin yarıçapının ve dikdörtgenin boyunun yarısının toplamından 
            // küçük veya eşit ise ve merkezlerinin X koordinatları arasındaki mesafe çemberin yarıçapının ve dikdörtgenin eninin yarısının toplamından küçük veya eşit ise çarpışma vardır.

            if ((Math.Abs(c1.M.X - d1.M.X)) <= (c1.R + d1.En / 2) && (Math.Abs(c1.M.Y - d1.M.Y)) <= (c1.R + d1.Boy / 2))
                return true;
            else
                return false;
        }
        public static bool NoktaKureCarpisma(Nokta3d n1, Kure k1)
        {
            // Eğer kürenin merkezinin ve noktanın X, Y ve Z koordinatları arasındaki mesafe kürenin yarıçapından küçük veya eşitse çarpışma vardır.

            float d = (float)Math.Sqrt(Math.Pow((n1.X - k1.M.X), 2) + Math.Pow((n1.Y - k1.M.Y), 2) + Math.Pow((n1.Z - k1.M.Z), 2));
            if (d <= k1.R)
                return true;
            else
                return false;
        }
        public static bool NoktaDikdortgenPrizmaCarpisma(Nokta3d n1, DikdortgenPrizma d1)
        {

            float x1 = (float)d1.M.X + d1.R1 / 2; // Prizmanın x eksenindeki en büyük sınır noktası
            float x2 = (float)d1.M.X - d1.R1 / 2; // Prizmanın x eksenindeki en küçük sınır noktası
            float y1 = (float)d1.M.Y + d1.H / 2; // Prizmanın y eksenindeki en büyük sınır noktası
            float y2 = (float)d1.M.Y - d1.H / 2; // Prizmanın y eksenindeki en küçük sınır noktası
            float z1 = (float)d1.M.Z + d1.R2 / 2; // Prizmanın z eksenindeki en büyük sınır noktası
            float z2 = (float)d1.M.Z - d1.R2 / 2; // Prizmanın z eksenindeki en küçük sınır noktası 

            // Eğer nokta, bu sınırlar içerisinde kalıyor ise çarpışma vardır

            if ((n1.X <= x1) && (n1.X >= x2) && (n1.Y <= y1) && (n1.Y >= y2) && (n1.Z <= z1) && (n1.Z >= z2))
                return true;
            else
                return false;

        }

        public static bool KureCarpisma(Kure k1, Kure k2)
        {
            // Eğer kürelerin merkezlerinin X, Y ve Z koordinatları arasındaki mesafe yarıçapları toplamından küçük veya eşitse çarpışma vardır.

            float d = (float)Math.Sqrt(Math.Pow((k1.M.X - k2.M.X), 2) + Math.Pow((k1.M.Y - k2.M.Y), 2) + Math.Pow((k1.M.Z - k2.M.Z), 2));
            if (d <= k1.R + k2.R)
                return true;
            else
                return false;
        }

        public static bool YuzeyKureCarpisma(Kure k1)
        {
            // Yüzeyi Y=0 olacak şekilde X ve Z koordinatı olarak kabul ettiğimiz için kürenin merkezinin y=0 doğrusuna olan dikey mesafesi yarıçapından 
            // küçük veya eşitse çarpışma vardır.

            float d = (float)Math.Abs(k1.M.Y - 0);
            if (d <= k1.R)
                return true;
            else
                return false;
        }
        public static bool YuzeyDikdortgenPrizmaCarpisma(DikdortgenPrizma d1)

        {
            // Yüzeyi Y=0 olacak şekilde X ve Z koordinatı olarak kabul ettiğimiz için dikdörtgen prizmanın merkezinin y=0 doğrusuna olan dikey mesafesi yüksekliğinin yarısıdan  
            // küçük veya eşitse çarpışma vardır.

            float d = (float)Math.Abs(d1.M.Y - 0);
            if (d <= d1.H / 2)
                return true;
            else
                return false;
        }
        public static bool YuzeySilindirCarpisma(Silindir s1)
        {
            // Yüzeyi Y=0 olacak şekilde X ve Z koordinatı olarak kabul ettiğimiz için silindirin merkezinin y=0 doğrusuna olan dikey mesafesi yüksekliğinin yarısından 
            // küçük veya eşitse çarpışma vardır.

            float d = (float)Math.Abs(s1.M.Y - 0);
            if (d <= s1.H / 2)
                return true;
            else
                return false;
        }
        public static bool KureDikdortgenPrizmaCarpisma(Kure k1, DikdortgenPrizma d1)
        {
            float d = (float)Math.Sqrt(Math.Pow((k1.M.X - d1.M.X), 2) + Math.Pow((k1.M.Z - d1.M.Z), 2));
            float dy = Math.Abs(k1.M.Y - d1.M.Y);
            if (d <= k1.R + d1.R1 / 2 && dy <= k1.R + d1.H / 2)
                return true;
            else
                return false;
        }
        public static bool DikdortgenPrizmaCarpisma(DikdortgenPrizma d1, DikdortgenPrizma d2)
        {
            float d = (float)Math.Sqrt(Math.Pow((d1.M.X - d2.M.X), 2) + Math.Pow((d1.M.Z - d2.M.Z), 2));
            float dy = Math.Abs(d1.M.Y - d2.M.Y);
            if (dy <= (d1.H + d2.H) / 2 && d <= (d1.R1 + d2.R1) / 2)
                return true;
            else
                return false;
        }
    }
}
