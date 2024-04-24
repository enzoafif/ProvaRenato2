Console.WriteLine("1- A pilha pode ser utilizada em um contexto de pilha de livros, onde o último a ser colocado é o primeiro a ser retirado ou em um contexto, outro contexto possível seria onde temos um copo com bolinhas dentro onde a lógica é a mesma da pilha de livros");

Console.WriteLine("2- A fila pode ser utilizada em um contexto onde o primeiro a entrar é o primeiro a sair, como em uma fila de banco ou hospital");

Console.WriteLine("--------EXERCICIO 3---------");

try
{
    string[,] alunos = new string[32, 4];

    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine($"Digite o RA do aluno {i + 1}");
        string RA = Console.ReadLine();

        alunos[i, 0] = RA;

        Console.WriteLine($"Digite a nota da prova 1 do aluno {i + 1}");
        string P1 = Console.ReadLine();

        alunos[i, 1] = P1;

        Console.WriteLine($"Digite a nota do trabalho 1 do aluno {i + 1}");
        string T1 = Console.ReadLine();

        alunos[i, 2] = T1;
    }

    for (int i = 0; i < 32; i++)
    {
        if (Convert.ToInt32(alunos[i, 1]) + Convert.ToInt32(alunos[i, 2]) >= 5)
        {
            alunos[i, 3] = "1 - Aprovado";
        }
        else
        {
            alunos[i, 3] = "0 - Reprovado";
        }

    }

    Console.WriteLine("-------MATRIZ ATUAL-------");

    for (int i = 0; i < 32; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(alunos[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine("--------EXERCICIO 4---------");

Stack<int> pilha = new Stack<int>(5);

try
{
    for(int i = 0; i < 5; i++)
    {
        Console.Write($"Digite o numero na posicao {i + 1} da pilha: ");
        int num = Convert.ToInt32(Console.ReadLine());

        pilha.Push(num);

    }

    Console.WriteLine("--------PILHA ATUAL---------");

    foreach (int item in pilha)
    {
        Console.WriteLine(item);
    }
 
    Console.Write("\nDigite a quantidade de item a serem removidos: ");

    int qtdNumerosRemovidos = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < qtdNumerosRemovidos; i++)
    {
        pilha.Pop();
    }

    Console.WriteLine("--------PILHA ATUAL---------");

    for (int i = pilha.Count - 1; i >= 0; i--)
    {
        Console.WriteLine(pilha.ElementAt(i));
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine("--------EXERCICIO 5---------");
Console.WriteLine("Eu existo porque eu sou o Enzo");