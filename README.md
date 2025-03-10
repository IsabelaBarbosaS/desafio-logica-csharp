# Desafio Técnico - Lógica de Programação em C#

Este repositório contém as soluções para 5 questões de lógica em **C#**, com foco em estruturas de repetição, condicionais, leitura de arquivos e manipulação de strings e dados.

---

## Questão 1 - Soma de 1 até 13

**Arquivo:** `SomaSimples.cs`

Calcula a soma dos números inteiros de 1 até 13 usando um laço de repetição `for`.

---

## Questão 2 - Verificação de número na sequência de Fibonacci

**Arquivo:** `VerificaFibonacci.cs`

Recebe um número e informa se ele pertence à sequência de Fibonacci.

---

## Questão 3 - Análise de Faturamento Diário

**Arquivo:** `AnalisaFaturamento.cs`  
**Dados:** `dados.json`

Lê os dados do faturamento diário de uma distribuidora e retorna:

- Menor valor de faturamento
- Maior valor de faturamento
- Média mensal (ignorando dias com valor zero)
- Número de dias com faturamento acima da média

---

## Questão 4 - Percentual de Faturamento por Estado

**Arquivo:** `PercentualPorEstado.cs`

Calcula o percentual de participação de cada estado dentro do valor total mensal da distribuidora.

---

## Questão 5 - Inversão de String

**Arquivo:** `Inversor.cs`

Recebe uma string (palavra ou frase) e imprime ela invertida, sem utilizar funções prontas como `.Reverse()`.

---

## Como Executar

Certifique-se de ter o .NET SDK instalado.

Para compilar e executar:

```bash
csc NomeDoArquivo.cs
NomeDoArquivo.exe
```

**Exemplo:**

```bash
csc AnalisaFaturamento.cs
AnalisaFaturamento.exe
```

Coloque o arquivo `dados.json` no mesmo diretório para a Questão 3.

---

Desenvolvido para fins de avaliação de raciocínio lógico e domínio básico da linguagem C#.
