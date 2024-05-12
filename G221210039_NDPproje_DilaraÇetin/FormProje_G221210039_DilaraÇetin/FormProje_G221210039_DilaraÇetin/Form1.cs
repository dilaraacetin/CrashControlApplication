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
namespace FormProje_G221210039_DilaraÇetin
{
    public partial class Form1 : Form
    {
        private List<Cisimler> objects; //Oluşturduğum cisimler class'ından bir List oluşturdum
        public Form1()
        {
            InitializeComponent();
            objects = new List<Cisimler>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateObjects();
            AddObjectsToComboBox();
        }
        private void AddObjectsToComboBox() //List'deki nesneleri combobox a aktardım
        {
            // Nesneleri ComboBox'a ekleme
            foreach (Cisimler obj in objects)
            {
                cmbSekil1.Items.Add(obj.GetType().Name);
            }
            foreach (Cisimler obj in objects)
            {
                cmbSekil2.Items.Add(obj.GetType().Name);
            }
        }


        private void CreateObjects() //Nesneler oluşturdum ve Liste e ekledim
        {
            Cember cember = new Cember(190, 176, 129);
            Dikdortgen dikdortgen = new Dikdortgen(120, 140, 323, 122);
            Kure kure = new Kure(180, 150, 123);
            DikdortgenPrizma dprizma = new DikdortgenPrizma(199, 152, 185, 170, 30);
            Yuzey yuzey = new Yuzey(15, 50, 1000, 1);
            Silindir silindir = new Silindir(145, 150, 145, 90, 30);
            Nokta nokta = new Nokta(34, 23);
            objects.Add(cember);
            objects.Add(dikdortgen);
            objects.Add(kure);
            objects.Add(dprizma);
            objects.Add(yuzey);
            objects.Add(silindir);
            objects.Add(nokta);

        }
        public abstract class Cisimler //Cisimler adında bir class oluşturdum ve kalan cisimleri bu classstan kalıtım alarak oluşturdum.
        {
            protected int x;
            protected int y;

            public Cisimler(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public abstract void Draw(Graphics g);

        }
        public class Nokta : Cisimler
        {


            public Nokta(int x, int y) : base(x, y)
            {

            }

            public override void Draw(Graphics g)
            {
                Brush brush = new SolidBrush(Color.Black);
                g.FillEllipse(brush, x, y, 5, 5);
            }
        }


        public class Cember : Cisimler
        {
            private int Yaricap;

            public Cember(int x, int y, int Yaricap) : base(x, y)
            {
                this.Yaricap = Yaricap;
            }

            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 5);
                g.DrawEllipse(pen, x - Yaricap, y - Yaricap, 2 * Yaricap, 2 * Yaricap);

            }
        }
        public class Kure : Cisimler
        {

            private int Yaricap;

            public Kure(int x, int y, int Yaricap) : base(x, y)
            {
                this.Yaricap = Yaricap;
            }
            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 5);
                g.DrawEllipse(pen, x - Yaricap, y - Yaricap, 2 * Yaricap, 2 * Yaricap);
                g.DrawEllipse(pen, x - Yaricap, y - Yaricap / 2, 2 * Yaricap, Yaricap);
            }


        }

        public class Dikdortgen : Cisimler
        {
            private int Genislik;
            private int Yukseklik;

            public Dikdortgen(int x, int y, int Genislik, int Yukseklik) : base(x, y)
            {
                this.Genislik = Genislik;
                this.Yukseklik = Yukseklik;
            }

            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.DarkBlue, 5);
                g.DrawRectangle(pen, x, y, Genislik, Yukseklik);
            }
        }
        public class DikdortgenPrizma : Cisimler
        {
            private int Genislik;
            private int Yukseklik;
            private int Derinlik;

            public DikdortgenPrizma(int x, int y, int Genislik, int Yukseklik, int Derinlik) : base(x, y)
            {
                this.Genislik = Genislik;
                this.Yukseklik = Yukseklik;
                this.Derinlik = Derinlik;
            }

            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.LightPink, 5);
                g.DrawRectangle(pen, x, y, Genislik, Yukseklik);
                g.DrawRectangle(pen, x - Derinlik / 2, y - Derinlik / 2, Genislik, Yukseklik);
                g.DrawLine(pen, x, y, x - Derinlik / 2, y - Derinlik / 2);
                g.DrawLine(pen, x + Genislik, y, x + Genislik - Derinlik / 2, y - Derinlik / 2);
                g.DrawLine(pen, x, y + Yukseklik, x - Derinlik / 2, y + Yukseklik - Derinlik / 2);
                g.DrawLine(pen, x + Genislik, y + Yukseklik, x + Genislik - Derinlik / 2, y + Yukseklik - Derinlik / 2);

            }
        }
        public class Yuzey : Cisimler
        {

            private int Genislik;
            private int Yukseklik;

            public Yuzey(int x, int y, int Genislik, int Yukseklik) : base(x, y)
            {
                this.Genislik = Genislik;
                this.Yukseklik = Yukseklik;
            }

            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 5);
                g.DrawRectangle(pen, x, y, Genislik, Yukseklik);
                Brush brush = new SolidBrush(Color.DeepPink);
                g.FillRectangle(brush, x, y, Genislik, Yukseklik);
            }
        }
        public class Silindir : Cisimler
        {
            private int Genislik;
            private int Yukseklik;
            private int Cap;


            public Silindir(int x, int y, int Genislik, int Yukseklik, int Cap) : base(x, y)
            {
                this.Genislik = Genislik;
                this.Yukseklik = Yukseklik;
                this.Cap = Cap;
            }

            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 5);

                g.DrawEllipse(pen, x, y + Cap, Genislik, Cap);
                g.DrawEllipse(pen, x, y - Cap, Genislik, Cap);


                g.DrawLine(pen, x, y - Cap / 2, x, y + Yukseklik - Cap - Cap / 2);
                g.DrawLine(pen, x + Genislik, y - Cap / 2, x + Genislik, y + Yukseklik - Cap - Cap / 2);

            }
        }

        private void btnDraw_Click(object sender, EventArgs e)// Çiz butonuna basıldığına ekrana seçilen cisimlerin çizdirilmesini sağladım
        {
            int selectedIndex = cmbSekil1.SelectedIndex;
            int selectedIndex2 = cmbSekil2.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < objects.Count)
            {
                Graphics g = CreateGraphics();



                Cisimler selectedObject = objects[selectedIndex];
                selectedObject.Draw(g);


            }
            if (selectedIndex2 >= 0 && selectedIndex2 < objects.Count)
            {
                Graphics g = CreateGraphics();



                Cisimler selectedObject2 = objects[selectedIndex2];
                selectedObject2.Draw(g);


            }

        }
    }
}