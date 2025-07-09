# TaskAsyncAwait

Sobre o projeto: Demonstração de Task, async e await em C#
Este projeto é um aplicativo de console em C# (.NET 8, Visual Studio 2022) que demonstra o uso de tarefas assíncronas com Task, async e await. O objetivo é mostrar como executar operações potencialmente demoradas de forma não bloqueante, permitindo melhor performance e experiência do usuário, mesmo em aplicativos de linha de comando.

![image](https://github.com/user-attachments/assets/904a6454-938c-4be8-b3e6-b3bde4fd42fe)

O que o programa faz?
O método principal (Main) é declarado como assíncrono, permitindo o uso de await diretamente nele.

Três tarefas assíncronas são iniciadas quase ao mesmo tempo, cada uma simulando uma operação demorada (Task.Delay) com diferentes tempos de espera.

O programa utiliza Task.WhenAll para aguardar que todas as tarefas terminem, demonstrando como coordenar várias operações assíncronas em paralelo.

Durante a execução, são exibidas mensagens informando o início e o término de cada tarefa, além do Thread ID responsável, facilitando a visualização do paralelismo.

Ao final, o usuário é convidado a pressionar uma tecla para encerrar.

Quando usar Task, async e await?
Para operações I/O-bound (leitura/escrita em arquivos, chamadas HTTP, acesso a banco de dados) onde a thread pode aguardar sem bloqueio.

Para melhorar a escalabilidade e responsividade de aplicações, especialmente interfaces gráficas (UI) e servidores web.

Quando você precisa executar múltiplas operações em paralelo e aguardar a conclusão de todas ou de algumas delas.

Quando não usar Task, async e await?
Em operações puramente computacionais (CPU-bound) de longa duração — nesses casos, é melhor usar threads dedicadas ou paralelismo explícito (Parallel, Thread, ThreadPool).

Para tarefas muito curtas e simples, onde a sobrecarga do mecanismo assíncrono não traz ganhos reais.

------------------------------------------------------------------------------------------------------------------

English
About the project: Demonstrating Task, async, and await in C#
This project is a C# console application (.NET 8, Visual Studio 2022) that demonstrates the use of asynchronous tasks with Task, async, and await. The goal is to show how to execute potentially time-consuming operations in a non-blocking manner, providing better performance and user experience even in command-line applications.

What does the program do?
The main method (Main) is declared as asynchronous, allowing the use of await directly.

Three asynchronous tasks are started almost simultaneously, each simulating a time-consuming operation (Task.Delay) with different waiting times.

The program uses Task.WhenAll to wait until all tasks have completed, showing how to coordinate multiple asynchronous operations in parallel.

During execution, messages are displayed indicating the start and end of each task, along with the responsible Thread ID, making parallelism easy to observe.

At the end, the user is prompted to press any key to exit.

When should you use Task, async, and await?
For I/O-bound operations (file access, HTTP requests, database queries) where the thread can wait asynchronously without being blocked.

To improve scalability and responsiveness of applications, especially in UI apps and web servers.

When you need to execute multiple operations in parallel and wait for all or some to complete.

When not to use Task, async, and await?
For purely computational (CPU-bound) long-running operations — in such cases, prefer dedicated threads or explicit parallelism (Parallel, Thread, ThreadPool).

For very short and simple tasks, where the overhead of asynchronous mechanisms brings no real benefit.

------------------------------------------------------------------------------------------------------------------

Español
Sobre el proyecto: Demostración de Task, async y await en C#
Este proyecto es una aplicación de consola en C# (.NET 8, Visual Studio 2022) que demuestra el uso de tareas asíncronas con Task, async y await. El objetivo es mostrar cómo ejecutar operaciones potencialmente lentas de manera no bloqueante, mejorando el rendimiento y la experiencia del usuario, incluso en aplicaciones de consola.

¿Qué hace el programa?
El método principal (Main) se declara como asíncrono, permitiendo el uso directo de await.

Se inician tres tareas asíncronas casi al mismo tiempo, cada una simulando una operación demorada (Task.Delay) con distintos tiempos de espera.

El programa utiliza Task.WhenAll para esperar hasta que todas las tareas se completen, demostrando cómo coordinar varias operaciones asíncronas en paralelo.

Durante la ejecución, se muestran mensajes indicando el inicio y final de cada tarea, junto con el ID del hilo responsable, facilitando la observación del paralelismo.

Al final, se pide al usuario que presione una tecla para salir.

¿Cuándo usar Task, async y await?
Para operaciones I/O-bound (acceso a archivos, solicitudes HTTP, consultas a bases de datos) donde el hilo puede esperar sin bloqueo.

Para mejorar la escalabilidad y la capacidad de respuesta de aplicaciones, especialmente en interfaces gráficas y servidores web.

Cuando necesitas ejecutar múltiples operaciones en paralelo y esperar a que todas o algunas terminen.

¿Cuándo no usar Task, async y await?
Para operaciones puramente computacionales (CPU-bound) de larga duración — en esos casos, es mejor usar hilos dedicados o paralelismo explícito (Parallel, Thread, ThreadPool).

Para tareas muy cortas y simples, donde la sobrecarga del mecanismo asíncrono no aporta beneficios reales.
