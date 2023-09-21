using Models;

public class Program
{
    public static void Main()
    {
        //Criar um objeto da classe Pessoa
        /*
        //Instancio objeto sem métedo construtor
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Gabriella";
        pessoa1.idade = 16;

        //Alternativa de um objeto instanciado sem construtor 
        Pessoa pessoa1 = new Pessoa();{
            nome = "Gabriella",
            idade = 16;
        }
        */
        //Instancio objeto sem métedo de classe pessoa
        Pessoa pessoa1 = new Pessoa("Gabriella", 16); 

       //Chamando o métedo Cantar da classe Pessoa
        pessoa1.Cantar();

        Pessoa pessoa2 = new pessoa1 ("Fiordelice" , 19);
        pessoa2.Cantar();

        pessoa1 pessoa3 = new Pessoa {"Gabi", 13};
        pessoa3.Cantar();
    }
}