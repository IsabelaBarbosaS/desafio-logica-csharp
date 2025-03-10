using System;

class SomaSimples {
    static void Main() {
        int soma = 0;
        for (int i = 1; i <= 13; i++) {
            soma += i;
        }
        Console.WriteLine($"Soma final: {soma}");
    }
}
