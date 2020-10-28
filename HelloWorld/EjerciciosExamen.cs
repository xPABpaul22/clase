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
        //
    }
}
