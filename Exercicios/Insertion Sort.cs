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