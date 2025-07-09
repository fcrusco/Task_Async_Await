using System;
using System.Threading.Tasks;

namespace TaskAsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine($"Início do programa principal (Thread ID: {Environment.CurrentManagedThreadId})");

            // Inicia três tarefas assíncronas
            Task tarefa1 = ExecutaTarefaAssincrona("Tarefa 1", 2000);
            Task tarefa2 = ExecutaTarefaAssincrona("Tarefa 2", 1500);
            Task tarefa3 = ExecutaTarefaAssincrona("Tarefa 3", 1000);

            // Aguarda todas as tarefas terminarem
            await Task.WhenAll(tarefa1, tarefa2, tarefa3);

            Console.WriteLine("Todas as tarefas assíncronas foram concluídas!");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        // Método assíncrono simula uma operação demorada
        static async Task ExecutaTarefaAssincrona(string nomeTarefa, int tempoMs)
        {
            Console.WriteLine($"{nomeTarefa} iniciada (Thread ID: {Environment.CurrentManagedThreadId})");
            await Task.Delay(tempoMs); // Simula operação assíncrona
            Console.WriteLine($"{nomeTarefa} finalizada (Thread ID: {Environment.CurrentManagedThreadId})");
        }
    }
}
