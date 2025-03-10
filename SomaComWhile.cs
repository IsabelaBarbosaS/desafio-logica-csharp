using System;

class SomaComWhile {
    static void Main() {
        int soma = 0;
        for (int k = 1; k <= 13; k++)
            soma += k;

        Console.WriteLine($"Resultado da soma de 1 até 13: {soma}");
    }
}
