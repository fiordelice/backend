using System.IO;

public class Program 
{
    public static void Main()
    {
       GravarArquivo();
    }
    
    public static void GravarArquivo()
    {
          try 
         {
            //Gravando no arquivo de texto
            using (StreamWriter arquirvo = new StreamWriter("arquivo.txt", true))
            {
                arquirvo.WriteLine("Texto 1");
             }
         }
         catch(Exception erro)
         {
            Console.WriteLine($"Ocorreu um erro no arquivo {erro.Message}");
         }
    }

    public static void LerArquivo()
    {
         using (StreamReader arquirvo = new StreamWriter("arquivo.txt", true))
         {
            string linha;
            while (linha = arquirvo.ReadLine() != null)
            {
                Console.WriteLine(linha);
            }
         }
    }
}
