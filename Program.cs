using System;

namespace Zar_Tahmin_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            tahminStart:
            Random rnd = new Random();
            int rastgele = rnd.Next(1,6);
            Console.Write("1. Tahmininiz : ");
            int tahmin1 = Convert.ToInt32(Console.ReadLine());
            if (tahmin1 == rastgele)
            {
                Console.WriteLine("Tebrikler Bildiniz :)");
                goto tekrarStart;
            }
            else
            {
                Console.WriteLine("2 Hakkınız Kaldı");
            }
            Console.Write("2. Tahmininiz : ");
            int tahmin2 = Convert.ToInt32(Console.ReadLine());
            if (tahmin2 == rastgele)
            {
                Console.WriteLine("Tebrikler Bildiniz :)");
                goto tekrarStart;
            }
            else
            {
                Console.WriteLine("1 Hakkınız Kaldı");
            }
            Console.Write("3. Tahmininiz : ");
            int tahmin3 = Convert.ToInt32(Console.ReadLine());
            if (tahmin3 == rastgele)
            {
                Console.WriteLine("Tebrikler Bildiniz :)");
                goto tekrarStart;
            }
            else
            {
                Console.WriteLine("Hiç Doğru Tahminde Bulunamadınız :(");
            }
            tekrarStart:
            Console.WriteLine("Baştan başlamak ister misiniz ? [E/H]");
            string cevap = Console.ReadLine();
            if (cevap == "E" || cevap == "e")
            {
                goto tahminStart;
            }
            else if (cevap == "H" || cevap == "h")
            {
                return;
            }
        }
    }
}
