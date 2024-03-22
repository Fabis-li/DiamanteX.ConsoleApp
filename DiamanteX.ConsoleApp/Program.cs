using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamante de X");
            decimal numero = ObterNumetroInteiro("Digite um número impar");
            decimal numeroVerificado = VerificarNumeroDigitado(numero);
            decimal qtdeLinhas = (numeroVerificado / 2) - 0.5M;
            int contador = 0;            
            int espaco = Convert.ToInt32(qtdeLinhas);
            decimal aux = qtdeLinhas;

            ExibirParteSuperiorEMeio(ref contador, ref espaco, aux);
            
            int novoContador = 2;
            ExibirParteInferior(ref contador, aux, ref novoContador);
        }

        static decimal ObterNumetroInteiro(string texto)
        {
            Console.WriteLine(texto);
            decimal numeroDigitado = Convert.ToDecimal(Console.ReadLine());

            return numeroDigitado;
        }   
        static decimal VerificarNumeroDigitado(decimal numero)
        {
            while (numero % 2 == 0)
            {
                Console.WriteLine("Digite um número ímpar");
                numero = Convert.ToDecimal(Console.ReadLine());
            }
            return numero;
        }
        static void ExibirParteSuperiorEMeio(ref int contador, ref int espaco, decimal aux)
        {
            for (int i = 0; i <= aux; i++)
            {
                for (int j = 0; j <= espaco; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= contador; k++)
                {
                    Console.Write("x");
                }

                contador += 2;
                Console.Write("\n");
                espaco--;
            }
        }
        static void ExibirParteInferior(ref int contador, decimal aux, ref int novoContador)
        {            
            contador--;

            for (int i = 0; i < aux; i++)
            {
                for (int j = 0; j < novoContador; j++)
                {
                    Console.Write(" ");
                }
                novoContador++;
                contador -= 2;

                for (int k = 0; k < contador; k++)
                {
                    Console.Write("x");
                }
                Console.Write("\n");
            }
        }
                
    }
}
