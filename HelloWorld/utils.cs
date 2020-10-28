using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class utils
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int GetMaxValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
