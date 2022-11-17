using System;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random rnd = new Random();

            const char KAR = '█';


            int pozX = Console.WindowWidth / 2;
            int pozY = Console.WindowHeight / 2;
            Console.SetCursorPosition(pozX, pozY);
            Console.WriteLine(KAR);


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Black;
                char bill = Console.ReadKey().KeyChar;
                if (bill == 'w' || bill == 's' || bill == 'a' || bill == 'd')
                {
                    Console.SetCursorPosition(pozX, pozY);
                    Console.Write(' ');
                    if (pozY > 0 && bill == 'w')
                        pozY = pozY - 1;
                    else if (bill == 'a')
                        pozX = pozX - 1;
                    else if (pozY < Console.WindowHeight - 1 && bill == 's')
                        pozY = pozY + 1;
                    else if (bill == 'd')
                        pozX = pozX + 1;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(pozX, pozY);
                    Console.WriteLine(KAR);
                }

            }
            */


            int[,] szamok = { { 1, -2, 3, 4, 5 },
                               { 9, 8, 7, 6, -3 },
                               { 12, 13, 15, 17, 18 },
                               { 98, 76, 54, 32, 21 }};

            // 1) Hány negatív érték van a mátrixban?

            int negativ = 0;
            for (int sor = 0; sor < szamok.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < szamok.GetLength(0); oszlop++)
                {
                    if (szamok[sor,oszlop] < 0)
                    {
                        negativ++;
                    }
                }
            }
            Console.WriteLine("1) feladat A tömbben {0} db negatív stám van", negativ);

            // 2) Mennyi a 3. sorban szereplő számok összértéke?
            int osszeg = 0;
            for (int sor = 0; sor < szamok.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < szamok.GetLength(1); oszlop++)
                {
                    if (sor == 2)
                    {
                        osszeg += szamok[sor,oszlop];
                    }
                }
            }
            Console.WriteLine("2) feladat: A harmadik sor összege : {0}", osszeg);
            // 3) Az első oszlopban vagy az utolsó oszlopban lévő számok összege a nagyobb?
            int elsoOszlop = 0;
            int utolsoOszlop = 0;
            for (int sor = 0; sor < szamok.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < szamok.GetLength(1); oszlop++)
                {
                    if (oszlop == 0)
                    {
                        elsoOszlop += szamok[sor, oszlop];
                    }

                    if (oszlop == 4)
                    {
                        utolsoOszlop += szamok[sor, oszlop];
                    }
                }
            }

            if (elsoOszlop > utolsoOszlop)
            {
                Console.WriteLine("3) feladat: Az első oszlop összege nagyobb");
            }

            else
            {
                Console.WriteLine("3) feladat: Az utolsó oszlop összege nagyobb");
            }
            // 4) A 3-mal osztható számokat helyezze egy új int[] osztható névvel rendelkező tömbbe!
            int harommalOszthato = 0;

            for (int sor = 0; sor < szamok.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < szamok.GetLength(1); oszlop++)
                {
                    if (szamok[sor, oszlop] % 3 == 0)
                    {
                        harommalOszthato++;
                    }
                }
            }

            int[] tomb = new int[harommalOszthato];
            int index = 0;
            for (int sor = 0; sor < szamok.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < szamok.GetLength(1); oszlop++)
                {
                    if (szamok[sor,oszlop] % 3==0)
                    {
                        tomb[index] = szamok[sor, oszlop];
                        index++;
                    }

                }
            }
            Console.WriteLine("4) feladat: "+String.Join(";",tomb));
        }
    }
}
