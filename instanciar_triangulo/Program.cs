using System;

namespace instanciar_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo triangulo1;
            triangulo1 = new triangulo();
            Console.WriteLine(triangulo1.calculararea());
            triangulo triangulo2 = new triangulo();
           triangulo2.Base = 40;
           triangulo2.Altura = 80;
            Console.WriteLine(triangulo2.calculararea());
            Console.ReadKey(true);
        }
    }

    class triangulo
    {
        public int Base = 20;
        public int Altura = 30;

        public int calculararea()
        {
            return Base * Altura / 2;
        }
    }
}
