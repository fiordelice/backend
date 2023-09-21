using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
       //Criando uma lista de números inteiros
       List<int> listaNumeros = new List<int>();

       //Adicionando elementos á lista 
       listaNumeros.Add(10); //posição [0] 
       listaNumeros.Add(20); //posição [1]
       listaNumeros.Add(50); //posição [2]


       //Contando a quantidade de elementos em nossa lista
       Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");
       //Acessando os dados da lista pelo índice
       Console.WriteLine(listaNumeros[1]);

       listaNumeros.Add(7); //posição [3]
         Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");
       

       Console.WriteLine("----------------------------------");

       //Criem uma nova lista de nomes e adicionem alguns nomes a ela 
       //e exibam a quantidade de nomes que contém nessa lista

         List<string> listaNomes = new List<string>();

       listaNomes.Add("gabi"); //posição [0] 
       listaNomes.Add("julia"); //posição [1]
       listaNomes.Add("tezzon"); //posição [2]
       listaNomes.Add("fiordelice"); //posição [3]

                 foreach (string item in listaNomes) 
              {
                  Console.WriteLine(item);
              }

       //Contando a quantidade de elementos em nossa lista
       Console.WriteLine($"Neste momento temos {listaNomes.Count} nomes");

              Console.WriteLine("----------------------------------");

              //Criando uma lista já atribuindo valores
              List<int>  numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9,};
              numeros.Add(10);

              //Iterando sobre todos os itens da lista
              foreach (int item in numeros) 
              {
                  Console.WriteLine(item);
              }

              numeros.Remove(2); //Remove o elemento buscando pelo contéudo
              numeros.RemoveAt(4); //Remove o elemento pela posição (índice)
              numeros.RemoveRange(2, 2); //Remove o elemento da posição 2 e os próximas 2r
              foreach (int item in numeros) 
              {
                  Console.WriteLine(item);
              }

              //Criando uma nova lista com objetos da Classe Aluno
              List<Aluno> listaAlunos = new List<Aluno>();

              //Adicionando um novo aluno á listaAluno
              Aluno novoAluno = new Aluno ("Gabriella",16);
              listaAlunos.Add(novoAluno);

            listaAlunos.Add(new Aluno ("Geovanna", 8));
            listaAlunos.Add(new Aluno ("Daniela", 41));
            listaAlunos.Add(new Aluno ("Flávio", 42));
            listaAlunos.Add(new Aluno ("Guilherme", 11));


            Console.WriteLine("Lista de Alunos");
            foreach (Aluno item in listaAlunos)
            {
                Console.WriteLine ($"Nome aluno:{item.nome} idade {item.idade}");
            }

        //Criando uma nova lista, filtrando e ordenando por nome
        //LINQ utilizando Sintaxe de consulta
        var consulta = from aluno in listaAlunos
                          where aluno.idade > 18
                          orderby aluno.nome
                          select aluno;
            Console.WriteLine("Lista de alunos maiores de 18 anos ");
        foreach (var item in consulta)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
        }

        //LINQ utilizando Sintaxe de métedo 
        var metedo = listaAlunos
                      .Where(aluno => aluno.idade > 18)
                      .OrderBy(aluno => aluno.nome);
            foreach (var item in metedo)
            {
                Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
            }
    }
}                                                                                     -