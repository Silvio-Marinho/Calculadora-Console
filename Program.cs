// See https://aka.ms/new-console-template for more information


using CalculadoraConsole;
List<char> identificadorOperadoresValidos = new List<char>();
identificadorOperadoresValidos.Add('+');
identificadorOperadoresValidos.Add('-');
identificadorOperadoresValidos.Add('*');
identificadorOperadoresValidos.Add('/');
List<char> identificadorNumerosValidos = new List<char>();
identificadorNumerosValidos.Add('0');
identificadorNumerosValidos.Add('1');
identificadorNumerosValidos.Add('2');
identificadorNumerosValidos.Add('3');
identificadorNumerosValidos.Add('4');
identificadorNumerosValidos.Add('5');
identificadorNumerosValidos.Add('6');
identificadorNumerosValidos.Add('7');
identificadorNumerosValidos.Add('8');
identificadorNumerosValidos.Add('9');
identificadorNumerosValidos.Add('.');
identificadorNumerosValidos.Add(',');
bool ValidarConta(string operando1, string operador, string operando2)
{

    for (int i = 0; i < operando1.Length; i++)
    {
        if (!identificadorNumerosValidos.Contains(operando1[i]))
        {
            return false;
        }
    }
    for (int i = 0; i < operando2.Length; i++)
    {
        if (!identificadorNumerosValidos.Contains(operando2[i]))
        {
            return false;
        }
    }
    for (int i = 0; i < operador.Length; i++)
    {
        if (!identificadorOperadoresValidos.Contains(operador[i]))
        {
            return false;
        }
    }
    return true;
}


while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("\nCaracteres aceitos para operadores:");
        
        Console.WriteLine("\n\tCalculador .NET 6 C#\n");
        Console.Write("1° número: ");
        string operando1 = Console.ReadLine().ToLower();
        Console.WriteLine("".PadLeft(38, '-'));
        Console.Write("Digite o operador | ");
        for (int i = 0; i < identificadorOperadoresValidos.Count; i++)
        {
            Console.Write($"'{identificadorOperadoresValidos[i]}' ");
        }
        Console.Write("|: ");
        string operador = Console.ReadLine().ToLower();
        Console.WriteLine("".PadLeft(38, '-'));

        Console.Write("2° número: ");
        string operando2 = Console.ReadLine().ToLower();
        if (ValidarConta(operando1, operador, operando2))
        {
            Calcular calcular = new Calcular();
            switch (operador)
            {
                case "+":
                    calcular.Adicao(double.Parse(operando1), double.Parse(operando2));
                    break;
                case "-":
                    calcular.Subtracao(double.Parse(operando1), double.Parse(operando2));
                    break;
                case "*":
                    calcular.Multiplicacao(double.Parse(operando1), double.Parse(operando2));
                    break;
                case "/":
                    calcular.Divisao(double.Parse(operando1), double.Parse(operando2));
                    break;
            }
        }
        else
        {
            Console.WriteLine("\nConta inválida");
        }
        Console.Write("\nDeseja [continuar=enter/sair=s] ?:");

        if (Console.ReadLine().ToLower() == "s")
        {
            Console.WriteLine("Programar encerrado!");
            break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message); ;
    }
}

