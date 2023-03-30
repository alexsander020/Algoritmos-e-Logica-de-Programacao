String Nome;
Double NI, PI, PO, Media;

Console.Write("Entre com o seu Nome: ");
Nome = Console.ReadLine();
Console.WriteLine("Bem Vindo: ");
Console.WriteLine(Nome + " Como aluno Fecap!!");
Console.WriteLine("Catraca Livre no Metrô!!");

Console.Write("Entre com de NI: ");
NI = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com o valor da sua PI: ");
PI = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com o valor da sua PO: ");
PO = Convert.ToDouble(Console.ReadLine());

Media = 0.20 * NI + 0.30 * PI + 0.50 * PO;
Console.WriteLine("Sua Média Final : " + Media);

if (Media >= 6.0)
{
    Console.WriteLine("Meus Parabens : " + Nome + " você foi Aprovado com a Nota: " + Media);
}
else if (Media >= 4.0)
{
    Console.WriteLine(Nome + " você esta de EXMA e presisa tirar 6");
}

else if (Media >= 2)
{
    Console.WriteLine(Nome + " você esta de Exame e Presisa tirar 7");
}

else
{
    Console.WriteLine(Nome + " você esta Reprovado (a)");
}