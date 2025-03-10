using System;

class ChecaFibonacci {
    static void Main() {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(EhFibonacci(num)
            ? $"{num} pertence à sequência de Fibonacci."
            : $"{num} NÃO pertence à sequência de Fibonacci.");
    }

    static bool EhFibonacci(int n) {
        int a = 0, b = 1;
        while (b < n) (a, b) = (b, a + b);
        return n == 0 || b == n;
    }
}
