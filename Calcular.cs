namespace CalculadoraConsole
{
    internal class Calcular : ICalcular
    {
        public void Adicao(double operando1, double operando2)
        {
            double resultado = operando1 + operando2;
            Console.WriteLine($"\nResultado: {operando1} + {operando2} = {resultado.ToString("N2")}");
        }


        public void Subtracao(double operando1, double operando2)
        {
            double resultado = operando1 - operando2;
            Console.WriteLine($"\nResultado: {operando1} - {operando2} = {resultado.ToString("N2")}");
        }

        public void Multiplicacao(double operando1, double operando2)
        {
            double resultado = operando1 * operando2;
            Console.WriteLine($"\nResultado: {operando1} * {operando2} = {resultado.ToString("N2")}");
        }
        public void Divisao(double operando1, double operando2)
        {
            if (operando2 == 0) { Console.WriteLine("Não é possível dividir por zero!"); }
            else
            {
                double resultado = operando1 / operando2;
                Console.WriteLine($"\nResultado: {operando1} / {operando2} = {resultado.ToString("N2")}");
            }
        }
    }
}
