using System;

class Inversor {
    static void Main() {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();
        string invertido = "";

        for (int i = texto.Length - 1; i >= 0; i--) {
            invertido += texto[i];
        }

        Console.WriteLine($"Invertido: {invertido}");
    }
}
