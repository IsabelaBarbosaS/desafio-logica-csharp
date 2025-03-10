using System;
using System.Collections.Generic;

class FaturamentoPorEstado {
    static void Main() {
        var estados = new Dictionary<string, double> {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double total = 0;
        foreach (var valor in estados.Values)
            total += valor;

        Console.WriteLine("Percentual por estado:");
        foreach (var estado in estados)
            Console.WriteLine($"{estado.Key}: {(estado.Value / total * 100):F2}%");
    }
}
