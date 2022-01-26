using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilhaLivros = new Stack<string>();

            pilhaLivros.Push(".Net");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Código limpo");

            System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

            while (pilhaLivros.Count > 0)
            {
                System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
                System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso!");
            }

             System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Eduardo");
            // fila.Enqueue("André");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>();
            // estados.Add("SP");
            // estados.Add("MG");
            // estados.Add("BA");

            // List<string> estados = new List<string> {"SP", "MG", "BA"}; // lista já inicializada
            // string[] estadosArray = new string[2] {"SC", "MT"}; 

            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");

            //estados.AddRange(estadosArray);
           // estados.Insert(1, "RJ");

            //opLista.ImprimirListaString(estados);

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }            

            // OperacoesArray op = new OperacoesArray();

            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // //int valorProcurado = 12;

            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine("O indíce do elemento {0} é: {1}", valorProcurado, indice);
            //     //System.Console.WriteLine($"O indíce do elemento {valorProcurado} é: {indice}");
            // }
            // else{
            //     System.Console.WriteLine("Valor não existente no array!");
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if (valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor!");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor!");
            // }

            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if (todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            // }

            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }

            //System.Console.WriteLine("Array original:");
            //op.ImprimirArray(array);

            //op.OrdernarBubleSort(ref array);
            //op.Ordenar(ref array);

            //System.Console.WriteLine("Array ordenado:");
            //op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia:");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia:");
            // op.ImprimirArray(arrayCopia);

            // Array multidimensional
            // int [,] matriz = new int[4, 2]
            // {
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200 }
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            //arrayInteiros[2] = int.Parse("30");  //Conversão de uma string para int

            //arrayInteiros[3] = 30; //Vai dar um erro de exceção, pois não consegue acessar um elemento que não existe

            // System.Console.WriteLine("Percorrendo o array pelo For");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo ForEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);                
            // }
        }
    }
}


