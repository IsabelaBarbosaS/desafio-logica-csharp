using System;

class InversorDeString {
    static void Main() {
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();
        Console.Write("Invertida: ");
        for (int i = texto.Length - 1; i >= 0; i--)
            Console.Write(texto[i]);
        Console.WriteLine();
    }
}
