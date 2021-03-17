using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {

        Pajaro[] equipo = new Pajaro[] { new Pajaro("Rojo"), new Pajaro("Negro"), new Pajaro("Amarillo")}; //Objetos anonimos

        Console.WriteLine("\n Pajaros del juego:  ");
        for (int i = 0; i <equipo.Length ; i++)
            {
            Console.WriteLine($" {equipo[i].Color}");
            }

        Console.WriteLine();

        Juego[] game = new Juego[] { new Juego("Rojo", "Golpeo"), new Juego("Negro", "Exploto"), //Objetos anonimos
                                     new Juego("Amarillo", "Golpeo rapido y fuerte") };

        for (int i = 0; i < game.Length; i++)
        {
            Console.WriteLine($"El Pajaro {game[i].Color} se lanzo y {game[i].Habilidad}");
        }

        Console.ReadLine();

        }
    }

