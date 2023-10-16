namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro e o segundo número separando por espaço:");
            string[] inputs = Console.ReadLine().Split(" ");

            if (inputs.Length >= 2)
            {
                float firstNumber = int.Parse(inputs[0]);
                float secondNumber = int.Parse(inputs[1]);
                Calculadora calculadora = new Calculadora(firstNumber, secondNumber);

                Console.WriteLine("""
                Selecione a opção desejada:
                0-Somar
                1-Diminuir
                2-Multiplicar
                3-Dividir
            """);

                int options = int.Parse(Console.ReadLine());
                bool isValid = true;
                string opt = "+";
                float result = calculadora.Somar();
                switch (options)
                {
                    case 0:
                        break;
                    case 1:
                        result = calculadora.Diminuir();
                        opt = "-";
                        break;
                    case 2:
                        result = calculadora.Multiplicar();
                        opt = "*";
                        break;
                    case 3:
                        result = calculadora.Dividir();
                        opt = "/";
                        break;
                    default:
                        isValid = false;
                        break;
                }

                if (isValid) Console.WriteLine($"{firstNumber} {opt} {secondNumber} = {result} ");
                else Console.WriteLine("Opção inválida!");
            }
            else Console.WriteLine("Entrada inválida. Certifique-se de digitar dois números separados por espaço.");
        }
    }
}