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
    public class Nokta // 2d koordinat
    {
        int x;
        int y;
        public Nokta()
        {
            X = 0; Y = 0;
        }
        public Nokta(int x, int y)
        {
            X = x; Y = y;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

    }
    public class Nokta3d : Nokta // 3d koordinat
    {
        int z;
        public Nokta3d() : base()
        {
            Z = 0;
        }
        public Nokta3d(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public int Z { get => z; set => z = value; }
    }

    
    public class Cember
    {
        Nokta m; int r;
        public Cember()
        {
            M = new Nokta(); // Merkez noktası
            R = 0; // Yarıçapı

        }
        public Cember(Nokta p, int r)
        {
            M = p; R = r;
        }
        public int R { get => r; set => r = value; }
        internal Nokta M { get => m; set => m = value; }

    }

    public class Silindir
    {
        Nokta3d m; // Merkez noktası
        int r; // Taban yarıçapı
        int h; // Yüksekliği
        public Silindir()
        {
            M = new Nokta3d();
            R = 0;
            H = 0;
        }
        public Silindir(Nokta3d p, int r, int h)
        {
            M = p; R = r; H = h;
        }
        public int R { get => r; set => r = value; }
        public int H { get => h; set => h = value; }
        internal Nokta3d M { get => m; set => m = value; }


    }

    public class Dikdortgen
    {
        Nokta m; // Merkez noktası
        int en; // 1. kenar
        int boy; // 2. kenar
        public Dikdortgen()
        {
            M = new Nokta();
            En = 0;
            Boy = 0;
        }
        public Dikdortgen(Nokta m, int en, int boy)
        {
            M = m; En = en; Boy = boy; ;
        }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
        internal Nokta M { get => m; set => m = value; }

    }

    public class Kure
    {
        Nokta3d m; int r;
        public Kure()
        {
            M = new Nokta3d(); // Merkez noktası
            R = 0; // Yarıçapı

        }
        public Kure(Nokta3d p, int r)
        {
            M = p; R = r;
        }
        public int R { get => r; set => r = value; }
        internal Nokta3d M { get => m; set => m = value; }

    }

    public class DikdortgenPrizma
    {
        Nokta3d m; // Merkez noktası
        int r1;// 1. taban kenarı
        int r2; // 2. taban kenarı
        int h; // Yüksekliği
        public DikdortgenPrizma()
        {
            M = new Nokta3d();
            R1 = 0;
            R2 = 0;
            H = 0;
        }
        public DikdortgenPrizma(Nokta3d m, int r1, int r2, int h)
        {
            M = m; R1 = r2; R2 = r2; H = h;
        }
        public int R1 { get => r1; set => r1 = value; }
        public int R2 { get => r2; set => r2 = value; }
        public int H { get => h; set => h = value; }
        internal Nokta3d M { get => m; set => m = value; }
    }
    public class Yuzey { }
    /*
     * Y=0 olduğunda, x ve z ekseninin oluşturduğu taban alanı yüzey olarak kabul ettim.
     * Yani x ve z'nin ne olduğu farketmeksizin şeklin herhangi bir kenarının veya köşesinin Y koordinatı 0 olduğu sürece yüzeyle çarpışırlar.
     * Bundan kaynaklı Class' ın içini doldurmayıp formülde sadece cismin Y=0 doğrusuyla olan mesafesini ölçtüm.
     */
}
