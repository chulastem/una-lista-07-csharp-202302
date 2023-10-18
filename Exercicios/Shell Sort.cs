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