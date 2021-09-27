using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAutoCeccato.Kernel
{
    public static class FunctionManager
    {
        public static double GetRandomNumber(double minimun, double maximun)
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (maximun - minimun) + minimun, 3);
        }
        public static string GetColour()
            
        {
            
            List<string> lista = new List<string> { "Giallo",
                                                    "Rosso",
                                                    "Bianco",
                                                    "Grigio",
                                                    "Verde",
                                                    "Nero",
                                                    "Scuro",
                                                    "Blue",
                                                    "Arancione",
                                                    "Chiaro" };
            Random rnd = new Random();
            
            int numPos = rnd.Next(lista.Count);


            return lista[numPos];
        }

        public static string GetMarca()

        {

            List<string> list = new List<string> { "Ferrari",
                                                    "Porsche",
                                                    "Bmw",
                                                    "Alfa_Romeo",
                                                    "Fiat",
                                                    "Mutsubisci",
                                                    "Bugati",
                                                    "Gaguar",
                                                    "Opel",
                                                    "Jeep" };
            Random rnd = new Random();

            int numPos = rnd.Next(list.Count);


            return list[numPos];
        }

        public static string GetanagraficaVeicolo()

        {

            List<string> tmp = new List<string> { "Sport",
                                                    "Corsa",
                                                    "Gara_Olimpica",
                                                    "Commerciale",
                                                    "Per_Exposizione"
                                                    };
            Random rnd = new Random();

            int numPos = rnd.Next(tmp.Count);


            return tmp[numPos];
        }




    }


    
}
