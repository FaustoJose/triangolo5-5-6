using System;

namespace triangolo5_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            triangulo("f",10);
        }
        public static void triangulo(string letra,int num)
        {
            int u = 0;
            for (int i=0;i<=num-1;i++)
            {
                for (int k = 1;k<num-u; k++)
                {
                    

                    Console.Write(letra);
                }
                Console.WriteLine(letra);
                u = u + 1;
            }

        }
    }
}
