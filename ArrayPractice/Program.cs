using System;
namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10]; // 10 elemanlı array dizisi tanımlıyoruz.
            int[] numbers1 = new int[11]; // 11 elemanlı array dizisi tanımlıyoruz. 11. eleman için içinde 10 eleman bulunan diziye sonradan ekleme yapamıyoruz.
            int sira = 1;

            for (int i = 0; i < numbers.Length; i++) { // 2 diziyede 10 adet aynı elemanları ekliyoruz. 
                Random rnd = new Random();
                int num = rnd.Next(1,21); // 1,21 arası rastgele sayılar ekliyoruz.
                numbers[i] = num;
                numbers1[i] = num;
            }
            foreach (int number in numbers) // number dizisindeki elemanları ekrana yazdırıyoruz.
            {
                Console.WriteLine($"{sira}. eleman {number}"); 
                sira++;
            }

            Console.WriteLine("Diziye eklenecek 11. elemanı giriniz."); // Kullanıcıdan 11. eleman için giriş istiyoruz.
            numbers1[10] = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Dizinin büyükten küçüğe sıralaması"); // Array.Sort(numbers1) ile dizi elemanlarını sıralıyoruz. Array.Reverse(numbers1) ile elemanların sıralamasını tersten alıyoruz.
            Array.Sort(numbers1);
            Array.Reverse(numbers1);
            for (int i = 0; i < numbers1.Length; i++) // numbers1 dizisini ekrana yazdırıyoruz.
            {
                Console.WriteLine($"{i+1}. eleman {numbers1[i]}");
            }
        }
    }
}