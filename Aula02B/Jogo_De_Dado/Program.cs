Random rnd = new Random();

int Dado01, Dado02, Soma;

Dado01 = rnd.Next(1, 7);
Dado02 = rnd.Next(1, 7);
Soma = Dado01 + Dado02;

Console.WriteLine("Dado 1: " + Dado01);
Console.WriteLine("Dado 2: " + Dado02);

Console.Write("Entre com o seu Nome: ");
String Nome;
Nome = Console.ReadLine();

if (Dado01 + Dado02 == 7 || Dado01 + Dado02 == 11 || Dado01 == Dado02)
{
    Console.WriteLine("Parabéns" + Nome);
    Console.WriteLine("Valor da Soma do: " + Dado01 + " + " + Dado02 + " = " + Soma); 
}

else
{
    Console.WriteLine(Nome + " perdedor");
    Console.WriteLine("Tente Novamente");
    Console.WriteLine("Valor da Soma do: " + Dado01 + " + " + Dado02 + " = " + Soma);
}

