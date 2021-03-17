using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        //Ejecicio 1

        int[] integerArray1 = { 1, 20, 3, 44, 5, 60, 7, 88, 9, 100 };

        Console.WriteLine($"Posicion 5: [{integerArray1[5]}]\n");
        ///Salida: Posicion 5: [60]


        //Ejercicio 2

        Random aleatorio = new Random();
        int[] array = new int[5];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
            Console.WriteLine($"Arreglo[{i}] = {array[i]}");
        }
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = aleatorio.Next(0, 1000);
            Console.WriteLine($"Arreglo[{i}] = {array[i]}");
        }

        Console.WriteLine();
        //Ejercicio 3

        ArrayObject Arreglo_Objetos = new ArrayObject();
        ArrayObject Arreglo_Objetos2 = new ArrayObject();
        ArrayObject Arreglo_Objetos3 = new ArrayObject();

        String[] miArreglo = new String[] { Arreglo_Objetos.Color, Arreglo_Objetos2.Animal, Arreglo_Objetos3.Maquina };
        ArrayObject[] Arreglo_Objetos4 = new ArrayObject[] { new ArrayObject(), new ArrayObject(), new ArrayObject() };

        for (int i = 0; i < miArreglo.Length; i++)
        {
            Console.WriteLine($"Objetos del arreglo: {miArreglo[i]}");
        }


        Console.WriteLine($"\nObjeto 1: {Arreglo_Objetos4[2].Color}" +
            $"\nObjeto 2: {Arreglo_Objetos4[0].Animal}" +
            $"\nObjeto 3: {Arreglo_Objetos4[1].Maquina}");


        //Ejercicio 4

        Animal[] ObjetoAnimal = new Animal[] { new Animal("Perro", "woof woof"), new Animal("Gato", "miau miau") };
        for (int i = 0; i < ObjetoAnimal.Length; i++)
        {
            Console.WriteLine($"\n El {ObjetoAnimal[i].Nombreanimal} dice '{ ObjetoAnimal[i].Accion}' ");
        }

        //Ejercicio 5
        Mamifero[] ObjetoMamifero = new Mamifero[] { new Mamifero("Pasto", "muu", "Vaca"), new Mamifero("Carne", "grrr", "Tigre")};
        for (int i = 0; i < ObjetoMamifero.Length; i++)
        {
            Console.WriteLine($"\n Mamifero: La/El {ObjetoMamifero[i].Nombreanimal} dice '{ ObjetoMamifero[i].Accion}' y come {ObjetoMamifero[i].Comida}");
        }
        Console.ReadLine();
    }
    
  }
    

       public class ArrayObject
       {
        private String color = "Rojo";
        private String animal = "Perro";
        private String maquina = "Auto";

        public string Color { get => color; set => color = value; }
        public string Animal { get => animal; set => animal = value; }
        public string Maquina { get => maquina; set => maquina = value; }
       }

  public class Animal
  {
        private string nombreanimal;
        private string accion;

    public Animal(string nombreanimal, string accion)
    {
        this.nombreanimal = nombreanimal;
        this.accion = accion;
    }

    public string Nombreanimal { get => nombreanimal; set => nombreanimal = value; }
    public string Accion { get => accion; set => accion = value; }
  }

public class Mamifero : Animal
{
    private string comida;

    public Mamifero(string comida, string accion, string nombreanimal): base(nombreanimal, accion)
    {
        this.comida = comida;
    }

    public string Comida { get => comida; set => comida = value; }
}
        
    

