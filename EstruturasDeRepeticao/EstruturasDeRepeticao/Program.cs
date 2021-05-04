using System;

namespace EstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] argumentos)

        if(argumentos.Length == 0)
        {
            Console.WriteLine("Favor informar palavras no argumento");
            return;
        }

         // for
            for(var indice = 0; indice < argumentos.Length; indice++)
            {
                Console.WriteLine($"Estrutura for indice e valor: {indice}, {argumentos[indice] }");
            }

            //while
            var argumentosLidos = 0;
            while(argumentosLidos < argumentos.Length)
            {
                Console.WriteLine($"Estrutura for, indice e valor:  {argumentosLidos}, {argumentos[argumentosLidos]}")
                argumentosLidos++;
            }

            // do while
            var loopsEfetuados = 0;
            do
            {
                Console.WriteLine($"Estrutura do while  e valor lido")
            }while()
        }

    }
}
