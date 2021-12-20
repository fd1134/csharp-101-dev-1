using System;
namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {

           /* soru1();
            soru2();
            soru3(); */
            soru4();

        }
        static void soru1()
        {
            Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz: ");
            int kacSayiGirilecek = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[kacSayiGirilecek];
            for (int i = 0; i < kacSayiGirilecek; i++)
            {
                Console.WriteLine((i + 1) + ".Sayıyı Giriniz :");

                int sayi = int.Parse(Console.ReadLine());

                dizi[i] = sayi;

            }
            foreach (int item in dizi)
            {
                if (item % 2 == 0)
                    Console.WriteLine(item);
            }

        }

        static void soru2()
        {

            Console.WriteLine("Kaç Sayı Girilecek : ");
            int kacSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Hangi Sayının Katlarını Arıyorsunuz:");
            int katsayi = int.Parse(Console.ReadLine());
            int[] dizi = new int[kacSayi];
            for (int i = 0; i < kacSayi; i++)
            {
                Console.WriteLine((i + 1) + ".Sayıyı Giriniz :");

                int sayi = int.Parse(Console.ReadLine());

                dizi[i] = sayi;

            }

            foreach (int sayi in dizi)
            {

                if (sayi % katsayi == 0)
                    Console.WriteLine(sayi);


            }




        }

        static void soru3()

        {

            Console.WriteLine("Lütfen pozitif Bir Sayı Giriniz :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} Tane Kelime Giriniz", n);
            string kelime = Console.ReadLine();
            string[] kelimedizisi = kelime.Split(" ");
            for (int i = kelimedizisi.Length - 1; i >= 0; i--)
            {

                Console.WriteLine(kelimedizisi[i]);


            }



        }
        static void soru4()
        {
               Console.WriteLine("Lütfen Bir Cümle Giriniz : ");
               string cumle=Console.ReadLine();           
              
               char [] harfeler=cumle.ToCharArray();
               string[] kelimedizisi = cumle.Split(" ");
                int harfsayisi=0;
               foreach (char item in harfeler)
               {
                   if(item!=' ')
                   harfsayisi+=1;
                   
               }
 
            
            
            
            Console.WriteLine(" Girdiğiniz Cümlede toplam {0} tane kelime vardır.",kelimedizisi.Length);
            Console.WriteLine(" Girdiğiniz Cümlede toplam {0} tane harf vardır.",harfsayisi);
        }




        }

    }
