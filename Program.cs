double massa, altura, imc;
string diagnostico;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-- Calculadora de IMC --\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Digite seu peso em kg...: ");
massa = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Digite sua altura em m..: ");
altura = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

imc = massa / Math.Pow(altura, 2);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nSeu IMC é {imc:N2} kg/m².");
Console.ResetColor();

if (imc < 17)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diagnostico = "Muito abaixo do peso";
    Console.ResetColor();
}
else if (imc < 18.5)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diagnostico = "Abaixo do peso";
    Console.ResetColor();
}
else if (imc < 25)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diagnostico = "Peso normal";
    Console.ResetColor();
}
else if (imc < 30)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diagnostico = "Acima do peso";
    Console.ResetColor();
}
else if (imc < 35)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diagnostico = "Obesidade I";
    Console.ResetColor();
}
else if (imc < 40)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diagnostico = "Obesidade II (severa)";
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diagnostico = "Obesidade III (mórbida)";
    Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Diagnóstico: {diagnostico}");
Console.ResetColor();
