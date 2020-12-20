using System;
using System.Collections.Generic;
using chen0040.ExpertSystem;
using NUnit.Framework;


namespace ExpertSystem
{class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Jakie obuwie?");

            List<Clause> unproved_conditions = new List<Clause>();
            RoleEngine.getInferenceEngine();
            Clause conclusion = null;
            while (conclusion == null)
            {
                Console.WriteLine("Jaki Sezon? \nWiosna:1\nLato:2\nJesień:3\nZima:4\n");
                int sezon = RoleLoop(new List<int> { 1, 2, 3, 4 });         
                Console.WriteLine("Jaka pogoda? \nSłoneczna:1\nPochmurna:2\nDeszczowa:3\nMroźna:4\n");
                int pogoda = RoleLoop(new List<int> { 1, 2, 3, 4});
                Console.WriteLine("Jaka okazja? \nSpacer:1\nBieg:2\nTurystyka:3\nOficjalna:4\n");
                int okazja = RoleLoop(new List<int> { 1, 2, 3, 4});
                Console.WriteLine("Jaka płeć?\nKobieta:1\nMężczyzna:2\n");
                int plec = RoleLoop(new List<int> { 1, 2 });

                RoleEngine.rie.CheckRule((RoleEngine.Sezon) sezon, (RoleEngine.Pogoda) pogoda, (RoleEngine.Przeznaczenie) okazja, (RoleEngine.Płeć) plec);
                conclusion = RoleEngine.rie.Infer("Rodzaj Buta", unproved_conditions);
                foreach(Clause clause in unproved_conditions)
                {
                    Console.WriteLine($"Brak dopasowania dla:{clause}");
                }
            }

            Console.WriteLine("Konkluzja: " + conclusion.Value);
            Console.ReadLine();
        }
        public static int RoleLoop(List<int> CorrectParams)
        {
            int wybor = 0;
            while (!CorrectParams.Contains(wybor))
            {
                try
                {
                    wybor = Convert.ToInt32(Console.ReadLine());
                    if (CorrectParams.Contains(wybor))
                    {
                        return wybor;
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidlowy wybór");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Nieprawidlowy wybór");
                    continue;
                }
            }
            return -1;
        }

    }
}
