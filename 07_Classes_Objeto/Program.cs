using Sesi.Model;

class Program
{
    public static void Main ()
    {
        //criando uma variavel e instanciando da classe Aluno
        //Criando nosso objeto
      var aluno1 = new Aluno();
      aluno1.nome = "Gabriella";
      aluno1.idade = 16;
      aluno1.turma = "2° M";
      //Chamando o métedo da classe aluno
      aluno1.Apresentar();

      Aluno aluno2 = new Aluno();
      aluno2.nome = "Fiordelice";
      aluno2.idade = 23;
      aluno2.turma = "3° EM";

      aluno2.Apresentar();
      aluno2.AdicionarFaltas(40);
      aluno2.Apresentar();
      
       aluno2.ResumoFaltas();

    }
}