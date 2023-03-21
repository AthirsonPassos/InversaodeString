using System;

namespace InversaodeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string r = "", invertido = "";
            Console.WriteLine("Digite uma palavra: ");
            r = Console.ReadLine();
            for (int i = r.Length - 1; i >= 0; i--)
                        {
                            invertido += r[i];

                        }

            Console.WriteLine("Palavra Correta: {0}", r);
            Console.WriteLine("Palavra Invertida: {0}", invertido);
            Console.ReadKey();
            //By Athirson Passos
        }
    }
}
