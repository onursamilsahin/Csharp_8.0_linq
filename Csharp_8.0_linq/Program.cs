using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_8._0_linq
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> sayilar= new List<int>(){1,2,3,4,5};
            //List<int> BulunanSayilar=sayilar.FindAll(CiftsayiBul);
            //List<int> LambdaSayilar = sayilar.FindAll(I => I % 2 == 0);
             //predicate delegate genelde mantıksal işlemler de kullanılır 


            //Sorgulama yapı inceleme 
            List<string> Isimler =new List<string>();

            Isimler.Add("ahmet ");
            Isimler.Add("mehmet");
           Isimler.Add("kafkas");

            // iki farklı sorgu tipi kullanılmıştır.
            var sonuc = from I in Isimler where I.Contains("kafkas") select I;
            var sonuc2 = Isimler.Where(x => x.Contains("kafkas")).ToList();


            foreach (var item  in sonuc2)
            {
                Console.WriteLine(item);
            }
            foreach (var VARIABLE in sonuc)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadLine();
        }

        //static bool CiftsayiBul(int I)
        //{


        //    return I % 2 == 0 ? true : false;
        //}
    }
}
