namespace HelloWorld
{
    class EjerciciosExamen
    {
        //Hacer una función que reciba como parámetros 2 enteros y devuelva la suma de ellos
        public static int EjercicioExamen1(int value1, int value2)
        {
            return value1 + value2;
        }
        //Hacer una función que reciba 2 reales y devuelva la resta de esos 2 reales
        public static double EjercicioExamen2(double value1, double value2)
        {
            return value1 - value2;
        }
        //Hacer una función que devuelva el menor de 2 reales
        public static double EjercicioExamen3(double value1, double value2)
        {
            return (value1 > value2) ? value2 : value1;
        }
        //Hacer una función que reciba 3 strings y devuelva la concatenación de los 3 strings
        public static string EjercicioExamen4(string text1, string text2, string text3)
        {
            return text1 + text2 + text3;
        }
        //Hacer una función que reciba como parámetros 3 enteros y devuelva si el primero es menor que el segundo
        public static bool EjercicioExamen5(int value1, int value2, int value3)
        {
            return value1 < value2;
        }
        //Hacer una función que reciba 2 enteros y me devuelva: -1 si el primero es menor que el segundo, +1 si el segundo es menor que el primero y 0 si los 2 son iguales o en cualquier otro caso
        public static int EjercicioExamen6(int value1, int value2)
        {
            return (value1 < value2) ? -1 : (value1 > value2) ? 1 : 0;
        }
        //Hacer una función que reciba por entrada 2 reales y devuelva: si el primero es menor que el segundo, el segundo al cuadrado. En cualquier otro caso, que devuelva el doble del primero + el segundo
        public static double EjercicioExamen7(double value1, double value2)
        {
            return (value1 < value2) ? value2 * value2 : (value1 * 2) + value2;
        }
        //Hacer una función con switch que reciba un código de error y muestre por pantalla lo siguiente: 
        //"Error grave si el código de error es 0
        //Error moderado si el código de error es 1
        //Error leve si el código de error es 2
        //Error desconocido en cualquier otro caso
        public static void EjercicioExamen8()
        {
            System.Console.WriteLine("Introduzca un código de error");
            int value = System.Convert.ToInt32(System.Console.ReadLine());
            switch (value)
            {
                case 0: 
                    System.Console.WriteLine("Error grave");
                    break;
                case 1: 
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;
            }
        }
        //Hacer una función que se le pase un número e imprima la siguiente serie: 0, 3, 6, 9, 12, ... hasta llegar al número
        //Ejemplo -> función(10) imprime 0, 3, 6, 9,
        public static void EjercicioExamen9(int value)
        {
            int counter = 0;
            while (counter <= value / 3)
            {
                System.Console.Write(counter * 3 + ", ");
                counter++;
            }
        }
        /*                                                                              CORRECCIÓN MÁS ÓPTIMA:
        public static void EjercicioExamen9(int value)
        {
            int counter = 0;
            while (counter <= value)
            {
                System.Console.Write(counter + ", ");
                counter+=3;
            }
        }
        */
        //Hacer una función que se le pase un número e imprima por pantalla todos los números desde 0 hasta ese número
        //Ejemplo -> funcion(10) -> 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        public static void EjercicioExamen10(int value)
        {
            for (int counter = 0; counter <= value; counter++)
                System.Console.Write(counter + ", ");
        }
        //Mismo sin que salga la "," del final
        //SOLUCIÓN 1 (falla si da numero negativo, hay que proteger la ultima instrucción con un if)
        public static void EjercicioExamen11(int value)
        {
            for (int counter = 0; counter < value; counter++)
            {
                    System.Console.Write(counter + ", ");
            }
            System.Console.Write(value);
        }
        //SOLUCIÓN 2 (No falla, pero ejecuta muchos ifs)
        public static void EjercicioExamen11Part2(int value)
        {
            for (int counter = 0; counter < value; counter++)
            {
                System.Console.Write(counter);
                    if (counter < value)
                    System.Console.Write(", ");
            }
        }
        //Hacer una función que se le pase un número e imprima por pantalla una linea de asteriscos
        //ejemplo -> funcion(3) -> *** | funcion(10) -> **********
        public static void EjercicioExamen12(int value)
        {
            for (int counter = 0; counter < value; counter++)
                System.Console.Write("*");
        }
        //Hacer una función que se le pase un número e imprima el siguiente patrón:
        //Ejemplo -> funcion (3) -> +*+ | funcion (10) +*+*+*+*+*
        public static void EjercicioExamen13(int value)
        {
            for (int counter = 0; counter < value; counter++)
            {
                if (counter % 2 == 0)
                    System.Console.Write("+");
                else
                    System.Console.Write("*");
            }
        }
        /* Lo mismo de arriba pero con operador "? y :"
        public static void EjercicioExamenlol(int value)
        {
            for (int counter = 0; counter < value; counter++)
            {
                string s = (counter % 2 == 0) ? "+" : "*";
                System.Console.Write(s);
            }
        }
        */
        //lo mismo pero tiene que imprimir el patrón "-+*/-+*/"
        public static void EjercicioExamen14(int value)
        {
            for (int counter = 0; counter < value; counter++)
            {
                int resto = counter % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.Write("-");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("*");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }
            }
        }
    }
}
