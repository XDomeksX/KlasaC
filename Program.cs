using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj, redniBroj=1;
            int[] niz = new int[5];  //kreiranje niza za upis kkorisnika

            int zbroj;  //nema "int prosjeka" jer smo u donjem djelu glavnog programa ispisali rezultat odmah prizivom prosjek-a iz klase KlasaC pomoću objekta

            Console.WriteLine("Upiši broj: ");
            for (int b=0;b<niz.Length; b++)
            {
                Console.Write(redniBroj + ". broj: ");  //"Write" ispisuje u isti red, dokle "WriteLine" ispisuje u novi red
                niz[b] = Convert.ToInt32(Console.ReadLine());  //konvertamo "ReadLine" u inteđer, jer inace čita samo string
                redniBroj++;
            }
            KlasaC objekt = new KlasaC();
            zbroj = objekt.Zbroj(niz);
            Console.WriteLine("Zbroj članova niza je: " + zbroj);  //ispisuje zbroj iz klase KlasaC prizivom objekta
            Console.WriteLine("Prosjek članova niza je: " + objekt.Prosjek(niz));  //isto priziva no na kraci nacin te ustedom memorije

            Console.ReadKey();
        }
    }
    class KlasaC
    {
        public int Zbroj(int[] niz)
        {
            int zbroj = 0;
            for (int b = 0; b < niz.Length; b++)
            {
                zbroj += niz[b];
            }
            return zbroj;
        }
        public double Prosjek(int[] niz)
        {
            double zbroj = Zbroj(niz);  //sejva rezultat niza dobivenog iz gornje metode "Zbroj"
            double prosjek = zbroj / niz.Length;
            return prosjek;
        }
    }
}
