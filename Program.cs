string operação;
Console.Clear();

do
{
exibeMenu();
operação = Console.ReadLine()!.Trim().ToUpper();

switch (operação)
{
case "1":
calculaSoma();
break;
case "2":
calculaSubtracao();
break;
case "3":
calculaMultiplicacao();
break;
case "4":
calculaDivisao();
break;
case "5":
calculaExponenciacao();
break;
case "6":
calculaRadiciacao();
break;
case "7":
CalcularMDC();
break;
case "8":
CalcularMédiaAritmética();
break;
case "9":
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("\nEsse é um projeto programado em linguagem C#\n de encerramento ao 1º módulo do curso de Informática na ETEC Adolpho Berezin.\nUpado oficialmente por @camilalocatelli na plataforma GitHub.");
Console.ResetColor();
break;
case "0":
Console.WriteLine("\nObrigada por utilizar meu programa :)");
break;
default:
Console.WriteLine("Operação indisponível");
break;
}
Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
Console.ReadKey();
Console.Clear();
}
while (operação != "0");

static void exibeMenu()
{

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄");
Console.WriteLine("▀▄▀▄------------------------▀▄▀▄");
Console.WriteLine("▀▄▀▄      CALCULADORA       ▀▄▀▄");
Console.WriteLine("▀▄▀▄------------------------▀▄▀▄");
Console.WriteLine("▀▄▀▄[1] SOMA                ▀▄▀▄");
Console.WriteLine("▀▄▀▄[2] SUBTRAÇÃO           ▀▄▀▄");
Console.WriteLine("▀▄▀▄[3] MULTIPLICAÇÃO       ▀▄▀▄");
Console.WriteLine("▀▄▀▄[4] DIVISÃO             ▀▄▀▄");
Console.WriteLine("▀▄▀▄[5] EXPONENCIAÇÃO       ▀▄▀▄");
Console.WriteLine("▀▄▀▄[6] RADICIAÇÃO          ▀▄▀▄");
Console.WriteLine("▀▄▀▄[7] MAIOR DIVISOR COMUM ▀▄▀▄");
Console.WriteLine("▀▄▀▄[8] MÉDIA ARITMÉTICA    ▀▄▀▄");
Console.WriteLine("▀▄▀▄[9] SOBRE O PROJETO     ▀▄▀▄");
Console.WriteLine("▀▄▀▄[0] SAIR                ▀▄▀▄");
Console.WriteLine("▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄\n");
Console.ResetColor();
}

static void calculaSoma()
    {
    double a, b, resultado;
    Console.ForegroundColor = ConsoleColor.Magenta;

    Console.WriteLine("\nOperação Soma selecionada.\n");
    Console.WriteLine("Digite os valores para somar: ");
    
    Console.Write("");
    a = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());
    
    resultado = a + b;
    
    Console.WriteLine($"{a} + {b} = {resultado}");
    Console.ResetColor();
    }

static void calculaSubtracao()
    {
    double a, b, resultado;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\nOperação Subtraçao selecionada.\n");
    Console.WriteLine("Digite os valores para subtrair: ");

    Console.Write("");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a - b;

    Console.WriteLine($"{a} - {b} = {resultado}");
    Console.ResetColor();
    }

static void calculaMultiplicacao()
    {
    double a, b, resultado;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\nOperação Multiplicação selecionada. \n");
    Console.WriteLine("Digite os Valores para Multiplicar: \n");

    Console.Write("");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a * b;

    Console.WriteLine($"{a} x {b} = {resultado}");
    Console.ResetColor();
    }

static void calculaDivisao()
    {
    double a, b, resultado;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\nOperação Divisão selecionada. \n");
    Console.Write("Digite os Valores para Divisão: \n");

    Console.Write("");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a / b;
    
    Console.WriteLine($"{a} ÷ {b} = {resultado}");
    Console.ResetColor();
    }

static void calculaExponenciacao()
    {
    double b, p, resultado;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\nOperação Exponenciação Selecionada. \n");
    
    Console.Write("Digite a base: ");
    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a Potência: ");
    Console.Write("");
    p = Convert.ToDouble(Console.ReadLine());

    resultado = Math.Pow(b, p);

    Console.WriteLine($"A potência de {b} elevado a {p} é igual a {resultado:N2}");
    Console.ResetColor();
    }

static void calculaRadiciacao()
{
     double numero, resultado;
     Console.ForegroundColor = ConsoleColor.Magenta; 
     Console.WriteLine("\nOperação Radiciação Selecionada. \n");
     Console.Write("Digite um Número: ");
     Console.Write("");
     numero = Convert.ToDouble(Console.ReadLine());

     if (numero <0)
     {
     Console.WriteLine("Não existem raízes de números negativos!");
     }

     else 
     {
     resultado = Math.Sqrt(numero);
     Console.WriteLine($"A raiz de {numero} é igual a {resultado:N2}");
     Console.ResetColor();
     }
}

static void CalcularMDC()
{
     int a, b, resto;
     Console.ForegroundColor = ConsoleColor.Magenta; 
     Console.WriteLine("\nOperação Maior Divisor Comum Selecionada. \n");
     Console.Write("Digite o 1ª número: ");
     a = Convert.ToInt32(Console.ReadLine());

     Console.Write("Digite o 2ª número: ");
     b = Convert.ToInt32(Console.ReadLine());

     do
     {
        resto = a % b;
        a = b;
        b = resto;
     }
     while (resto != 0);
     Console.WriteLine($"MDC = {a}");
     Console.ResetColor();
}

static void CalcularMédiaAritmética()
{
    double n1, n2, n3, media;
    Console.ForegroundColor = ConsoleColor.Magenta;  
    Console.WriteLine("\nOperação Média Aritmética de 3 números Selecionada \n");   
    Console.Write("Digite o primeiro número: ");
    n1 = Convert.ToDouble(Console.ReadLine())!;
    
    Console.Write("Digite o segundo número: ");
    n2 = Convert.ToDouble(Console.ReadLine())!;
    
    Console.Write("Digite o terceiro número: ");
    n3 = Convert.ToDouble(Console.ReadLine())!;
    
    media = (n1 + n2 + n3) / 3;
    
    Console.WriteLine($"Média: {media:N1}");
    Console.ResetColor();
}