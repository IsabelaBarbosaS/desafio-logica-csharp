using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class Faturamento {
    public int dia { get; set; }
    public double valor { get; set; }
}

class Program {
    static void Main() {
        try {
            string caminhoArquivo = "dados.json";
            string json = File.ReadAllText(caminhoArquivo);

            var dados = JsonSerializer.Deserialize<List<Faturamento>>(json);

            var valoresValidos = dados
                .Where(d => d.valor > 0)
                .Select(d => d.valor)
                .ToList();

            double menor = valoresValidos.Min();
            double maior = valoresValidos.Max();
            double media = valoresValidos.Average();
            int diasAcimaMedia = valoresValidos.Count(v => v > media);

            Console.WriteLine($"Menor faturamento: R${menor:F2}");
            Console.WriteLine($"Maior faturamento: R${maior:F2}");
            Console.WriteLine($"Média mensal (sem dias zerados): R${media:F2}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
        } catch (Exception ex) {
            Console.WriteLine("Erro ao processar o arquivo: " + ex.Message);
        }
    }
}
