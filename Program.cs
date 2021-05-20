using System;

namespace testeVariavel
{
    internal class NewBaseType
    {
        static void Main(string[] argumentos)  
        {

            const string constante = "Uma constante que não muda";

            if(argumentos.Length == 0)
            {
                Console.WriteLine("favor informar um número inteiro");
                return;
            }

            int inteiro;
            bool teste = int.TryParse(argumentos[0], out inteiro);

            if(teste == false)
            {
                Console.WriteLine("O argumento informado não é um número inteiro");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi: " + inteiro);

        }             

        
    
    }
}
