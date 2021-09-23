using System;

namespace TiposTriangulos
{
    using System;

    class Desafio
    {

        public static void Main()
        {
            #region Ordem decrescente
            string[] lados = Console.ReadLine().Split();
            double a = double.Parse(lados[0]);
            double b = double.Parse(lados[1]);
            double c = double.Parse(lados[2]);
            double troca;

            if(a < b)
            {
                troca = a;
                a = b;
                b = troca;
            }
            if (a < c)
            {
                troca = a;
                a = c;
                c = troca;
            }
            if (b < c)
            {
                troca = b;
                b = c;
                c = troca;
            }
            #endregion

            #region Tipo de triângulo
            if (a >= b + c)
                Console.WriteLine("NAO FORMA TRIANGULO");
            else
            {
                if (a*a == b*b + c*c)
                    Console.WriteLine("TRIANGULO RETANGULO");
                if (a * a > b * b + c * c)
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (a * a < b * b + c * c)
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                if (a==b && a==c && b==c)
                    Console.WriteLine("TRIANGULO EQUILATERO");
                else
                {
                    if (a==b || a==c || b==c)
                        Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
#endregion
        }
    }
}
