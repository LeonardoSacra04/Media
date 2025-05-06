double P1, P2, P3, L1, L2, L3, L4, L5, L6, mediaFinal, mediaListas, mediaProvas;
const double mediaAprovacao = 6.0;

Console.Clear();


Console.WriteLine("Informe a nota da Lista 1: ");
L1 = Convert.ToDouble(Console.ReadLine());

if (L1 < 0 || L1 > 10)
{
    Console.WriteLine("Nota da lista 1 inválida!");
    return;
}

Console.WriteLine("Informe a nota da Lista 2: ");
L2 = Convert.ToDouble(Console.ReadLine());

if (L2 < 0 || L2 > 10)
{
    Console.WriteLine("Nota da lista 2 inválida!");
    return;
}

Console.WriteLine("Informe a nota da Lista 3: ");
L3 = Convert.ToDouble(Console.ReadLine());

if (L3 < 0 || L3 > 10)
{
    Console.WriteLine("Nota da lista 3 inválida!");
    return;
}

Console.WriteLine("Informe a nota da Lista 4: ");
L4 = Convert.ToDouble(Console.ReadLine());

if (L4 < 0 || L4 > 10)
{
    Console.WriteLine("Nota da lista 4 inválida!");
    return;
}

Console.WriteLine("Informe a nota da Lista 5: ");
L5 = Convert.ToDouble(Console.ReadLine());

if (L5 < 0 || L5 > 10)
{
    Console.WriteLine("Nota da lista 5 inválida!");
    return;
}

Console.WriteLine("Informe a nota da Lista 6: ");
L6 = Convert.ToDouble(Console.ReadLine());

if (L6 < 0 || L6 > 10)
{
    Console.WriteLine("Nota da lista 6 inválida!");
    return;
}

Console.Clear();

Console.WriteLine("Informe a nota da P1: ");
P1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a nota da P2: ");
P2 = Convert.ToDouble(Console.ReadLine());

//if (!(P2 >= 0 && P2 <= 10))
//{
//    Console.WriteLine("Nota da P2 inválida!");
//    return;
//}

if (P1 < 0 || P1 > 10 || P2 < 0 || P2 > 10)
{
    Console.WriteLine("Nota da P1 ou P2 inválida!");
    return;
}

mediaListas = (L1 + L2 + L3 + L4 + L5 + L6) / 6 * 2;
mediaProvas = (P1 + P2) / 2 * 8;
mediaFinal = (mediaListas + mediaProvas) / 100;

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