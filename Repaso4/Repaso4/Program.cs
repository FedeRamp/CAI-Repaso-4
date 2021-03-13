using System;
using System.Linq;

namespace Repaso4
{
    class MainClass
    {
        //Chequear si dos ingresos son anagramas

        public static void Main(string[] args)
        {
            Console.Clear();
            bool sonAnagramas(string primer, string segundo)
            {
                if (primer == "" || segundo == "") return false;
                if (primer.Length != segundo.Length) return false;
                char[] letrasPrimer = primer.ToCharArray();
                char[] letrasSegun = segundo.ToCharArray();
                for(int i = 0; i < letrasPrimer.Length; i++)
                {
                    int tamañoSegunda = letrasSegun.Length;
                    for(int j = 0; j < letrasSegun.Length; j++)
                    {
                        if(letrasPrimer[i] == letrasSegun[j])
                        {
                            letrasSegun = letrasSegun.Where((item, index) => index != j).ToArray();
                            break;
                        }
                    }
                    if(letrasSegun.Length == tamañoSegunda)
                    {
                        return false;
                    } else if(letrasSegun.Length == 0)
                    {
                        return true;
                    }
                }
                return true;

            }

            string primerPalabra = "";
            string segundaPalabra = "";

            do
            {
                Console.WriteLine("Ingresar una palabra");
                primerPalabra = Console.ReadLine();
                if (primerPalabra == "") Console.WriteLine("Algo, no vacío");
            } while (primerPalabra == "");


            do
            {
                Console.WriteLine("Ingresar otra palabra");
                segundaPalabra = Console.ReadLine();
                if (segundaPalabra == "") Console.WriteLine("Algo, no vacío");
            } while (segundaPalabra == "");


            if(sonAnagramas(primerPalabra, segundaPalabra))
            {
                Console.WriteLine("Son anagramas");
            } else
            {
                Console.WriteLine("No son anagramas");
            }


        }
    }
}
