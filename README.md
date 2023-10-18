# Lista de Exercícios VII: Revisão

## UC - Estrutura de dados e análise de algoritmos -Pratica

**Pedro Antônio Esteves Silva - RA: 622122907**

1. Explique o que é uma lista e uma pilha em estrutura de dados. Escreva em C# exemplos de uma lista e uma pilha.

*Lista (ou lista encadeada):*

- *Uma lista é uma estrutura de dados linear que consiste em uma coleção de elementos, onde cada elemento (ou nó) contém dois campos: um campo de dados que armazena o valor do elemento e um campo de ponteiro (ou referência) que aponta para o próximo elemento da lista.*
- *As listas podem ser simplesmente encadeadas, onde cada elemento aponta apenas para o próximo, ou duplamente encadeadas, onde cada elemento aponta tanto para o próximo quanto para o anterior.*
- *As operações comuns em listas incluem a inserção e remoção de elementos em qualquer posição, percorrer a lista (iteração) e acessar elementos por posição.*
- *Listas são eficientes para operações de inserção e remoção no início ou meio da lista, mas podem ser menos eficientes para acessar elementos por índice direto, já que é necessário percorrê-los a partir do início ou do final.*

Exemplo de Lista em C#:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma lista de inteiros
        List<int> lista = new List<int>();

        // Inserindo elementos na lista
        lista.Add(1);
        lista.Add(2);
        lista.Add(3);

        // Acessando elementos por índice
        Console.WriteLine("Primeiro elemento: " + lista[0]);
        Console.WriteLine("Segundo elemento: " + lista[1]);

        // Iterando pela lista
        Console.WriteLine("Elementos da lista:");
        foreach (int item in lista)
        {
            Console.WriteLine(item);
        }
    }
}
```

*Pilha:*

- *Uma pilha é uma estrutura de dados que segue o princípio do "last in, first out" (LIFO), o que significa que o último elemento inserido é o primeiro a ser removido.*
- *As operações em uma pilha são principalmente a inserção de elementos (conhecida como "push") e a remoção de elementos (conhecida como "pop") no topo da pilha.*
- *Pilhas podem ser implementadas usando arrays ou listas encadeadas. Quando um elemento é empilhado (inserido), ele se torna o elemento no topo da pilha. Quando um elemento é desempilhado (removido), o elemento que estava abaixo dele se torna o novo topo.*
- *Pilhas são amplamente usadas para rastrear a execução de funções em programas (a chamada de funções é empilhada e desempilhada à medida que as funções são chamadas e retornam).*

Exemplo de Pilha em C#:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> pilha = new Stack<int>();

        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(3);

        // Removendo elementos da pilha (último inserido, primeiro removido)
        int elementoRemovido = pilha.Pop();
        Console.WriteLine("Elemento removido: " + elementoRemovido);

        // Acessando o elemento no topo da pilha sem removê-lo
        int elementoNoTopo = pilha.Peek();
        Console.WriteLine("Elemento no topo da pilha: " + elementoNoTopo);

        // Iterando pela pilha
        Console.WriteLine("Elementos da pilha:");
        foreach (int item in pilha)
        {
            Console.WriteLine(item);
        }
    }
}
```

2. Escreva um algoritmo em C# que implemente a lógica de ordenação por inserção do Insertion Sort.

Segue modelo de vetor para ser ordenado:

```csharp
int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };
```

```csharp
using System;
class HelloWorld {
  static void Main()
   {
        int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 }; // vetor

        Console.WriteLine("Vetor antes da ordenação:");
        ImprimirVet(vetor);

        OrdenarPorInsercao(vetor);

        Console.WriteLine("Vetor depois da ordenação:");
        ImprimirVet(vetor);
    }
    // ordena vetor
    static void OrdenarPorInsercao(int[] vetor)
    {
        int n = vetor.Length;

        for (int i = 1; i < n; i++)
        {
            int chave = vetor[i];
            int j = i - 1;

            // Mover os elementos do vetor[0..i-1] que são maiores que a chave
            while (j >= 0 && vetor[j] > chave)
            {
                vetor[j + 1] = vetor[j];
                j = j - 1;
            }

            vetor[j + 1] = chave;
        }
    }
    // imprime vetor
    static void ImprimirVet(int[] vetor)
    {
        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
```

3. Escreva um algoritmo em C# que implemente a lógica de ordenação por inserção do Shell Sort.

Segue modelo de vetor para ser ordenado:

```csharp
int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };
```

```csharp
using System;
class HelloWorld {
  static void Main() 
  {
        int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };// vetor

        Console.WriteLine("Vetor antes da ordenação:");
        ImprimirVet(vetor);

        ShellSort(vetor);

        Console.WriteLine("Vetor após a ordenação:");
        ImprimirVet(vetor);
    }
    // ordenação shell sort
    static void ShellSort(int[] vetor)
    {
        int n = vetor.Length;

        // Inicializa o intervalo com metade do tamanho do vetor
        int intervalo = n / 2;

        while (intervalo > 0)
        {
            for (int i = intervalo; i < n; i++)
            {
                int temp = vetor[i];
                int j = i;

                // Realiza a ordenação por inserção em subvetores
                while (j >= intervalo && vetor[j - intervalo] > temp)
                {
                    vetor[j] = vetor[j - intervalo];
                    j -= intervalo;
                }

                vetor[j] = temp;
            }

            // Reduz o intervalo
            intervalo /= 2;
        }
    }
    // imprime vetor
    static void ImprimirVet(int[] vetor)
    {
        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
```
