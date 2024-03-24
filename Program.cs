using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;



namespace detector_codigo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            decimal numero_aleatorio = random.Next();

            decimal codigo_usuario = 0;


            Console.WriteLine("Escreva um código, de seis dígitos que você acha confiável e aperte enter.");
            Console.WriteLine(" O programa tentará adivinhar qual é o código: ");
            codigo_usuario = Convert.ToDecimal(Console.ReadLine());


            decimal numero_gerado;
            bool codigo_encontrado = false;
            Stopwatch stopwatch = Stopwatch.StartNew();

            do
            {

                stopwatch.Start();
                numero_gerado = random.Next(100000, 1000000);
                // Quanto maior os dígitos, maior será o tempo para o programa encontrar o código digitado,
                // se precisar ver o programa rapidamente,coloque um intervalo 
                // de mínimo e máximo mais curto.
                Console.WriteLine(numero_gerado);

                if (codigo_usuario == numero_gerado)
                {
                    codigo_encontrado = true;
                    break;
                }
            }
            while (!codigo_encontrado);

            if (codigo_encontrado)
            {
                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;
                Console.WriteLine($"Código encontrado: " + codigo_usuario + " | Segundos decorridos para achar: " + elapsedTime.TotalSeconds.ToString("F2"));
                Console.WriteLine("Pressione qualquer tecla para fechar.");
                Console.ReadKey();
            }

        }
    }
}
