using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PieciSkaitli();
            //Text();
            //JaunasZvaigznes();
        }
        static void MasivaParaugs()
        {
            int[] masivs = new int[4];
            masivs[0] = 1;
            masivs[1] = 5;
            masivs[2] = 7;
            masivs[3] = 6;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(masivs[i]);
            }
            Console.ReadLine();
        }
        static void JaunasZvaigznes()
        {
            string[] zvaigznes = new string[4];
            zvaigznes[0] = "*";
            zvaigznes[1] = "**";
            zvaigznes[2] = "***";
            zvaigznes[3] = "****";
            for(int i=0; i<4; i++)
            {
                Console.WriteLine(zvaigznes[i]);
            }
            Console.ReadLine();


        }
        static void Text()
        {
            Console.WriteLine("ievadiet piecus skaitļus, lai tos varētu izvadīt");
            string[] teksts = new string[5];
            teksts[0] = Console.ReadLine();
            teksts[1] = Console.ReadLine();
            teksts[2] = Console.ReadLine();
            teksts[3] = Console.ReadLine();
            teksts[4] = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(teksts[i]);
            }
            Console.ReadLine();
        }
        static void PieciSkaitli()
        {
            string[] ievade = new string[5];
            int[] izvade = new int[5];
            for (int i =0; i<5; i++)
            {
                Console.WriteLine("Ievadiet " + i + " . vertibu!");
                ievade[i] = Console.ReadLine();
                izvade[i] = Convert.ToInt16(ievade[i]);
            }
            Console.WriteLine(izvade[0] + izvade[1] + izvade[2] + izvade[3] + izvade[4]);
            Console.ReadLine();
        }
    }
}
