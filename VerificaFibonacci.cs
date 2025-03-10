using System;

class VerificaFibonacci {
    static void Main() {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int a = 0, b = 1;
        while (b < numero) {
            int proximo = a + b;
            a = b;
            b = proximo;
        }

        if (numero == 0 || numero == b) {
            Console.WriteLine($"{numero} está na sequência de Fibonacci.");
        } else {
            Console.WriteLine($"{numero} não está na sequência de Fibonacci.");
        }
    }
}
