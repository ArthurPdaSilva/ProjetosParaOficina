namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string over = "4";
            string[] options = { "0", "1", "2", "3", "4" };
            string opera = "";
            float result = 0.0f;
            string menu = @"
                    0-Somar
                    1-Diminuir
                    2-Multiplicar
                    3-Dividir
                    4-Fechar Programa
                ";

            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine(menu);
            string opt = Console.ReadLine();

            while (opt != over)
            {
                if (!options.Contains(opt)) {
                    Console.WriteLine("Opção inválida e não consta no menu, digite uma opção válida");
                    opt = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Digite o primeiro e o segundo número separando por espaço:");
                    string[] inputs = Console.ReadLine().Split(" ");
                    if (inputs.Length == 2)
                    {
                        float firstNumber = int.Parse(inputs[0]);
                        float secondNumber = int.Parse(inputs[1]);
                        calculadora.AdicionarNumeros(firstNumber, secondNumber);

                        switch (opt)
                        {
                            case "0":
                                opera = "+";
                                result = calculadora.Somar();
                                break;
                            case "1":
                                result = calculadora.Diminuir();
                                opera = "-";
                                break;
                            case "2":
                                result = calculadora.Multiplicar();
                                opera = "*";
                                break;
                            case "3":
                                result = calculadora.Dividir();
                                opera = "/";
                                break;
                            default:
                                Console.WriteLine("Saindo do programa.");
                                break;
                        }

                        if (opt != over)
                        {
                            Console.WriteLine($"{firstNumber} {opera} {secondNumber} = {result} ");
                            Console.WriteLine('\n' + "E agora, deseja fazer o quê?");
                            opt = Console.ReadLine();
                        }
                    }
                    else Console.WriteLine("Números inválidos!");
                }


            }
        }
    }
}