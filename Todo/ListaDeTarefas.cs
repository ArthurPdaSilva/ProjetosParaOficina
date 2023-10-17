using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    internal class ListaDeTarefas
    {
        private List<string> _itens;

        public ListaDeTarefas()
        {
            _itens = new List<string>();
        }

        public bool AdicionarTarefa(string tarefa)
        {
            if (IsTarefaEncontrada(tarefa)) return false;

            _itens.Add(tarefa);
            return true;
        }

        public bool RemoverTarefa(string tarefa)
        {
            if (!IsTarefaEncontrada(tarefa))return false;

            _itens.Remove(tarefa);
            return true;
        }

        private bool IsTarefaEncontrada(string tarefa)
        {
            return _itens.Contains(tarefa);
        }

        public void ListarTarefas()
        {
            if (_itens.Count == 0) Console.WriteLine("Lista vazia.");
            else
            {
                Console.WriteLine("Lista de Tarefas:");
                foreach (var t in _itens)
                {
                    Console.WriteLine(t);
                }
            }

        }


    }
}
