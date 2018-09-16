using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_8._1_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> Ogrencilerimiz =new List<Ogrenci>();


            Ogrencilerimiz.Add(new Ogrenci(){OgrenciId = 1,IsimSoyisim = "deneme soydeneme",Yas = 15});
            Ogrencilerimiz.Add(new Ogrenci(){OgrenciId = 2,IsimSoyisim = "john doe",Yas = 16});
            Ogrencilerimiz.Add(new Ogrenci(){OgrenciId = 3,IsimSoyisim = "asldasd",Yas = 56});
            Ogrencilerimiz.Add(new Ogrenci() { OgrenciId = 3, IsimSoyisim = "bldasd", Yas = 15 });
            Ogrencilerimiz.Add(new Ogrenci() { OgrenciId = 3, IsimSoyisim = "ysldasd", Yas = 11 });
            Ogrencilerimiz.Add(new Ogrenci() { OgrenciId = 3, IsimSoyisim = "dsldasd", Yas = 12 });

            //aşağıda list ogrenci tipi yerine 'var' da kullanılabilir. 
            List<Ogrenci> sonuc = Ogrencilerimiz.Where(x => x.Yas > 14 && x.Yas < 20).ToList();
            foreach (var item  in sonuc)
            {
                Console.WriteLine(item.IsimSoyisim);
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*************************");
            //where ile yaş aralığı sıralaması yaptık .
            //orderBy ile ise isimsoyisim değişkenine göre sıralama yaptık.
            var siralama = sonuc.OrderBy(x => x.IsimSoyisim);
            foreach (var item in siralama)
            {

                Console.WriteLine(item.IsimSoyisim);

            }









            Console.ReadLine();
        }
    }

    class Ogrenci
    {

        public int  OgrenciId { get; set; }

        public string IsimSoyisim { get; set; }

        public int  Yas { get; set; }

    }
}
