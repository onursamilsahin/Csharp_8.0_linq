using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_8._2.Linquyg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<personel> PersonelListesi=new List<personel>();

            //Öncelikle fakedata nuget ten projeye eklendi fakedata fonksiyonlar aracılıpı ile bizlere rastgele isim soyisim numara vs kayıtlar 
            //oluşturmamıza yarıyor.
            for (int i = 0; i < 1000; i++)
            {
                
                personel temp =new personel();


                temp.Isim = FakeData.NameData.GetFirstName();
                temp.Soyisim = FakeData.NameData.GetSurname();
                temp.Yas = FakeData.NumberData.GetNumber(20,50);
                temp.EmailAdresi = temp.Isim + "." + temp.Soyisim + "@" + FakeData.NetworkData.GetDomain();
                temp.CalistigiBolge = FakeData.PlaceData.GetCity();
                PersonelListesi.Add(temp);

            }


            //yası 25 veya 25 den büyük ve yası 50 den küçük olan kayıtları getirelim.

            //var sonuc2 = from I in PersonelListesi where I.Yas >= 25 && I.Yas < 50 select I;
            var sonuc = PersonelListesi.Where(x=>x.Yas>=25 && x.Yas<50).ToList();
            foreach (var item  in sonuc)
            {

                Console.WriteLine(item.Yas+"----"+item.Isim);

       
                
            }

            Console.ReadLine();

        }
    }


    class personel
    {

        public static int PersonelSayac { get; set; }

        static personel()
        {
            PersonelSayac = 10001;

        }
        public int PersonelId { get; set; }
        public string Isim { get; set; }

        public string Soyisim { get; set; }

        public string EmailAdresi { get; set; }
        public int  Yas { get; set; }

        public string CalistigiBolge { get; set; }


        public personel()
        {


            PersonelId = PersonelSayac;
            PersonelSayac++;

        }
    }
}
