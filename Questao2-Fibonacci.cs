using System;

class Program {
    static void Main() {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());
        bool pertence = VerificaFibonacci(numero);

        if (pertence)
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
    }

    static bool VerificaFibonacci(int numero) {
        int a = 0, b = 1;

        while (b < numero) {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return numero == 0 || b == numero;
    }
}
