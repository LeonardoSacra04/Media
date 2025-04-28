double P1, P2, P3, L1, L2, L3, L4, L5, L6, mediaFinal, mediaListas, mediaProvas;
const double mediaAprovacao = 6.0;

Console.Clear();

Console.WriteLine("Informe a nota da P1: ");
P1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a nota da P2: ");
P2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a nota da Lista 1: ");
L1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a nota da Lista 2: ");
L2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a nota da Lista 3: ");
L3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a nota da Lista 4: ");
L4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a nota da Lista 5: ");
L5 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a nota da Lista 6: ");
L6 = Convert.ToDouble(Console.ReadLine());

mediaListas = ((L1 + L2 + L3 + L4 + L5 + L6) / 6) * 0.2;
mediaProvas = ((P1 + P2) / 2) * 0.8;
mediaFinal = mediaListas + mediaProvas;

//Console.WriteLine($"Média: {media:N1}");

bool aprovado = mediaFinal >= mediaAprovacao;

if(aprovado)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Aprovado com média {mediaFinal:N1}");
}
else
{
    Console.WriteLine("Informe a nota da P3: ");
    P3 = Convert.ToDouble(Console.ReadLine());

    mediaProvas = (Math.Max(P1, P2) + P3) / 2 * 0.8;
    mediaFinal = mediaListas + mediaProvas;

    if (mediaFinal >= mediaAprovacao)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Aprovado com média {mediaFinal:N1}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Reprovado!");
    }
}

Console.ResetColor();

Console.WriteLine($"Listas: {mediaListas} / Provas: {mediaFinal:N1}");