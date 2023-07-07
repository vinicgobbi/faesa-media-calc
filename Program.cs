decimal[] notas = new decimal[3];
decimal notasSomadas = 0;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite sua nota:");
    string nota = Console.ReadLine()!;
    if (nota.Contains("."))
    {
        nota = nota.Replace(".", ",");
    }
    notas[i] = Convert.ToDecimal(nota);
}

foreach (int i in notas)
{
    notasSomadas += i;
}

decimal notasDivididas = (decimal) notasSomadas / 3;

string status = notasDivididas > 7 ? "Aprovado" : "Reprovado";

Console.WriteLine($"Você tirou {notasDivididas:F2} e ficou {status}");