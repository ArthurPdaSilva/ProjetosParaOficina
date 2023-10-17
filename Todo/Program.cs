namespace Todo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string isOver = "4";
            string task;
            string message = "";
            string menu = @"
                0-Adicionar Tarefa
                1-Remover uma tarefa
                2-Listar Tarefas
                3-Mostrar menu novamente
                4-Fechar Programa
            ";

            ListaDeTarefas listaDeTarefas = new ListaDeTarefas();

            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine(menu);
            string opt = Console.ReadLine();

            while (opt != isOver)
            {
                switch (opt)
                {
                    case "0":
                        Console.WriteLine("Qual tarefa será adicionada?");
                        task = Console.ReadLine();
                        if (listaDeTarefas.AdicionarTarefa(task)) message = "Item adicionado com sucesso";
                        else message = "Item já encontrado na lista";
                        break;
                    case "1":
                        Console.WriteLine("Qual tarefa será removida?");
                        task = Console.ReadLine();
                        if (listaDeTarefas.RemoverTarefa(task)) message = "Item removido com sucesso";
                        else message = "Item não encontrado na lista";
                        break;
                    case "2":
                        listaDeTarefas.ListarTarefas();
                        break;
                    case "3":
                        Console.WriteLine(menu);
                        break;
                    case "4":
                        Console.WriteLine("Saindo do programa.");

                        break;
                    default:
                        Console.WriteLine("Opção inválida, selecione opção coerente a lista");
                        Console.WriteLine(menu);
                        break;

                }

                if (opt != isOver)
                {
                    if(opt == "0" || opt == "1") Console.WriteLine(message);
                    Console.WriteLine();
                    Console.WriteLine("E agora, deseja fazer o quê?");
                    opt = Console.ReadLine();
                }


            }

        }
    }
}