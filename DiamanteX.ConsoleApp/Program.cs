namespace DiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamante de X");

            decimal numero = ObterNumetroInteiro("Digite um número impar");

            decimal qtdeLinhas = (numero / 2) - 0.5M;

            int contador = 0;            

            while(numero % 2 == 0)
            {
                Console.WriteLine("Digite um número ímpar");
                numero = Convert.ToInt32(Console.ReadLine());                
            }

            int espaco = Convert.ToInt32(qtdeLinhas);

            decimal aux = qtdeLinhas;
            for (int i = 0; i <= aux; i++)
            {
                for(int j = 0;  j <= espaco; j++)
                {                    
                    Console.Write(" ");                    
                }

                for(int k = 0; k <= contador; k++)
                {
                    Console.Write("x");                    
                }

                contador += 2;
                Console.Write("\n");
                espaco--;                
            }

            int novoContador = 2;
            contador--;
            for( int i = 0; i< aux; i++)
            {
                for(int j = 0; j < novoContador; j++)
                {
                    Console.Write(" ");
                }
                novoContador++;
                contador -= 2;

                for(int k = 0; k < contador; k++)
                {
                    Console.Write("x");
                }
                Console.Write("\n");

                
            }
            
            
            






        
        }

        static decimal ObterNumetroInteiro(string texto)
        {
            Console.WriteLine(texto);
            decimal numeroDigitado = Convert.ToInt32(Console.ReadLine());

            return numeroDigitado;

        }
        
    }
}
