using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insanlar insanlar = new Insanlar("Ayşe","Kara",2516);

            //insanlar.İsim = "Ayşe";
            //insanlar.Soyisim = "Yılmaz";
            //insanlar.Yas = 15;
            insanlar.Ekle();

            
        }
    }


    class Insanlar
    {
        public string İsim;
        public string Soyisim;
        public int Yas;

      
        public Insanlar(string isim,string soyisim,int yas)
        {
            this.İsim = isim;
            this.Soyisim = soyisim;
            this.Yas = yas;
            
        }

        public Insanlar(){}
        public void Ekle()
        {
            Console.WriteLine("İsim: {0}", İsim);
            Console.WriteLine("Soyismi {0}", Soyisim);
            Console.WriteLine("Numarası: {0}", Yas);
        }

    }

 
}