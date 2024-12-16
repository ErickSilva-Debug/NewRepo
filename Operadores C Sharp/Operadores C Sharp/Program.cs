using System;

namespace operadores 
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100 + 50;// dentro da variável, pode colocar operadores aritmédica 
            int mult = 10 * 10;
            int divisao = 5 / 2; // ele não aredonda, fica resultado 2, mas isso acontece com dois números inteiros. e orbigatório dois ou uns  dos dois seja decimal, e o resultado final vai ser float, não importa que um e float, mas para isso não de errado, tem colocar em float
            int teste = 2 + 4 * mult;// segue a expressão numérica 
            Console.WriteLine( mult);    
            Console.WriteLine(x);
            Console.WriteLine(divisao);
            Console.WriteLine(teste);
        }
    }
}