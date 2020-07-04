using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCompare
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String Word1, Word2;
                var P = new Program();

                Console.Write("Lütfen ilk kelimeyi yazınız : ");
                Word1 = Console.ReadLine();

                Console.Write("Lütfen ikinci kelimeyi yazınız : ");
                Word2 = Console.ReadLine();

                System.Console.WriteLine(P.StringCompare(Word1, Word2));
            }
        }

        public bool StringCompare(String Word1, String Word2) // İki kelimeyi karşılaştıran fonksiyon
        {
            if (Word1.Length != Word2.Length)// Aynı uzunlukta değilseler false dön birşey yapma
                return false;

            Word1 = OrderString(Word1);// kelimeleri alfabetik sırala
            Word2 = OrderString(Word2);

            for (int i = 0; i < Word1.Length; i++)
            {
                if (Word1[i] != Word2[i])// herhangi bir karater aynı değil ise false dön
                    return false;
            }

            return true;
        }

        public String OrderString(String Word)// kelimeleri alfabetik sıralayan fonksiyon
        {
            List<char> CharArray = Word.OrderBy(x => x).ToList();
            return new string(CharArray.ToArray());
        }
    }
}
