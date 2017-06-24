using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gauss_jordan
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 0, n, k = 0;
            double[,] matriz;
            double termi = 0;
            Console.WriteLine("INGRESE EL NUMERO DE INCÓGNITAS  DE LA ECUACIÓN");
            n = int.Parse(Console.ReadLine());
            matriz = new double[n, n + 1];
            Console.WriteLine();

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("INGRESE EL COEFICIENTE DE LA ECUACIÓN  " + (i + 1) + "  :");
                    matriz[i, j] = double.Parse(Console.ReadLine());


                }

                Console.Write("INGRESE EL VALOR INDEPENDIENTE  " + (i + 1) + " :");
                matriz[i, n] = double.Parse(Console.ReadLine());

            }

            for (i = 0; i < n; i++)
            {
                if (matriz[i, i] == 0.0)
                {
                    Console.Write("error : No se puede realizar esta operación ");
                    Console.ReadKey();
                }

                for (k = 0; k < n; k++)
                    if (k != i)
                    {
                        termi = matriz[k, i] / matriz[i, i];
                        for (j = 0; j <= n; j++)

                            matriz[k, j] -= termi * matriz[i, j];



                    }

            }
          
            Console.WriteLine();
            Console.WriteLine("<<  RESULTADOS DE LAS INCÓGNITAS INGRESADAS >>   ");

            Console.WriteLine("solución");
            for (i = 0; i < n; i++)
            {
                termi = matriz[i, n] / matriz[i, i];


                Console.WriteLine(" RESULTADO : " + termi);
                Console.WriteLine();
            }

            Console.ReadKey();

           
        }
    }
}
