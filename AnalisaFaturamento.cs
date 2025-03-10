using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class Faturamento {
    public int dia { get; set; }
    public double valor { get; set; }
}

class AnalisaFaturamento {
    static void Main() {
        var json = File.ReadAllText("dados.json");
        var dados = JsonSerializer.Deserialize<List<Faturamento>>(json);
        var valores = dados.Where(d => d.valor > 0).Select(d => d.valor).ToList();

        double menor = valores.Min();
        double maior = valores.Max();
        double media = valores.Average();
        int acimaMedia = valores.Count(v => v > media);

        Console.WriteLine($"Menor: R${menor:F2}");
        Console.WriteLine($"Maior: R${maior:F2}");
        Console.WriteLine($"Média: R${media:F2}");
        Console.WriteLine($"Dias acima da média: {acimaMedia}");
    }
}
