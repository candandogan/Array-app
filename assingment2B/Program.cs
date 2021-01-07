using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment2B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 13, 56, -9, 0, 75 };
            int enKucuk = sayilar[0]; //başlangıçta en küçük değerini dizinin ilk indeksindeki değere eşitledik
            int enBuyuk = sayilar[0]; //başlangıçta en büyük değerini dizinin ilk indeksindeki değere eşitledik
            double toplam = 0; // dizide bulunan değerlerin toplamını tutacak değişkeni tanımladık

            for (int i=0; i<sayilar.Length; i++)
            {
                if (enBuyuk < sayilar[i]) // eğer dizide enBuyuk değerinden daha büyük bir değer varsa, enBuyuk değerini bu yeni değere eşitliyoruz
                {
                    enBuyuk = sayilar[i];
                }
                if (enKucuk > sayilar[i]) // eğer dizide enKucuk değerinden daha küçük bir değer varsa, enKucuk değerini bu yeni değere eşitliyoruz
                {
                    enKucuk = sayilar[i];
                }
                toplam += sayilar[i]; // dizideki tüm değerlerin toplamını gerçekleştiriyoruz
            }
            Console.WriteLine("En büyük sayı= " + enBuyuk);
            Console.WriteLine("En küçük sayı= " + enKucuk);
            Console.WriteLine("Dizide bulunan sayıların ortalaması= " + toplam / (sayilar.Length)); //dizideki tüm değerlerin toplamını dizinin uzunluğuna bölerek ortalamayı elde ediyoruz
            
            Console.ReadLine();
        }
    }
}
