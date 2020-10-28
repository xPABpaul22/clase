using System;

namespace HelloWorld
{
    class Ejercicios
    {
        // Ejercicio: Haz una función que imprima por pantalla los números desde el 0 hasta el 99
        public static void Ejercicio1()
        {
            int contador = 0;
            while (contador < 100)
            {
                Console.WriteLine(contador);
                contador = contador + 1;
            }
        }
        public static void Ejercicio2()
        {
            int i = 0;
            while (i < 100)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }
        public static void Ejercicio3()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i * 3 + 1);
                i = i + 1;
            }
        }
        public static void Ejercicio4()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i * i);
                i = i + 1;
            }
        }
        public static void Ejercicio5()
        {
            int i = 0;
            while (i < 100)
            {
                if (utils.IsEven(i))
                {
                    System.Console.WriteLine(i);
                }
                else
                {
                    System.Console.WriteLine(-i);
                }
                i++;
            }
        }
        public static void Ejercicio6()
        {
            int i = 0;
            int a, aa;
            aa = 0;
            a = 1;
            while (i < 100)
            {
                System.Console.WriteLine(a + aa);
                a = a + aa;
                aa = a - aa;
                i++;
            }

        }

















        public static void Ejercicio999()
        {
            int x, suma, promedio;
            string linea;
            x = 1;
            suma = 0;
            while (x <= 8)
            {
                Console.Write("Ingrese el valor " + x + ": ");
                linea = Console.ReadLine();
                suma = suma + 1;
                x = x + 1;
            }
            promedio = suma / 8;
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
