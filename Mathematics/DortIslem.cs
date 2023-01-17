using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    internal class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam=sayi1+ sayi2;    
            Console.WriteLine("sonuç:" + toplam); 

        }
        public void Carp(int sayi1,int sayi2) 
        {
            int carp=sayi1* sayi2;
            Console.WriteLine("sonuc:"+ carp);
        
        }
        public void Bolme(int sayi1,int sayi2)
        {
            int bolme= sayi1/sayi2;
            Console.WriteLine("sonuc:" + bolme);
        }
    }
}
