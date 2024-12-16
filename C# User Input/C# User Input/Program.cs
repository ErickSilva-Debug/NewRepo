using System;

namespace input
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual e o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Seja Bem-Vindo " + nome);// \n tem que ser dentro das aspas duplas
            /* Console.ReadLine() ele a entrada do usuário.Na variável string colocamos Console.ReadLine() vazia para receber a string*/
            /* Input (Entrada): É quando o programa recebe dados do usuário ou de outra fonte. 
            Output (Saída): É quando o programa mostra ou envia dados para o usuário, como resultados ou mensagens na tela.*/
            //O ReadLine() não verifica se o que você digitou é um nome, número ou qualquer outra coisa. Ele apenas pega o valor como texto e usa conforme programado.
            /* Console.ReadLine() retorna uma string (texto), e você está tentando atribuir diretamente esse valor a uma variável do tipo int sem fazer a conversão necessária. O compilador não consegue converter automaticamente uma string para um inteiro.*/
            // possível converter qualquer tipo explicitamente, usando um dos Convert.Tométodos:
            // O "32" no Int32 se refere à quantidade de bits usados para armazenar o número.Pode colocar outras quantidades de bits no numero inteiro 

            /* Resumo dos Tipos Inteiros em C#:
           Convert.ToSByte(8 bits, -128 a 127): Pequenos números com sinal.
           Convert.ToByte (8 bits, 0 a 255): Pequenos números sem sinal.
            short / Int16 (16 bits, -32.768 a 32.767): Números médios com sinal.
            ushort (16 bits, 0 a 65.535): Números médios sem sinal.
            int / Int32 (32 bits, -2 bi a 2 bi): Padrão para inteiros.
            uint (32 bits, 0 a 4 bi): Sem valores negativos.
            ong / Int64 (64 bits, muito grandes): Números enormes com sinal.
            ulong (64 bits, apenas positivos): Para valores extremamente altos.*/

            Console.WriteLine("Qual e a sua idade:");
            int idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Your age is: " + idade);

        }



    }
}