using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _17_CRUD.Models;

namespace _17_CRUD.Controllers
{
//Criando a classe TarefaControler e herdando seus métedos de Controller
    public class TarefaController : Controller
    {
        //Criando um objeto_tarefas que armazenará uma lista de tarefas 
        private static List<Tarefa> _tarefas = new List<Tarefa>();
        public IActionResult Index()
        {
            return View(_tarefas);
        }  

//Criando o métedo GET para carregar a tela de Adicionar
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Tarefa novaTarefa)
        {
            //Verificandoo total de tarefas da lista e somando mais 1 para o ID
            novaTarefa.Id = _tarefas.Count + 1;
            //Adicionando minha nova tarefa á minha lista
            _tarefas.Add(novaTarefa);
            //Redirecionar para a página com a lista de tarefas
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int Id)
        {
            //Estou buscando na minha lista a tarefa que desejo alterar
            Tarefa tarefaBD = _tarefas.FirstOrDefault( t => t.Id == Id);
            //Verificando se encontrou a tarefa, se ela não e null
              if(tarefaBD == null)
                    return NotFound();
                    //Enviando para View a tarefa encontrada que queremos alterar
              return View (tarefaBD);
        }
  [HttpPost]
  public IActionResult Editar (Tarefa tarefaEditando)
  {
    Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaEditando.Id);
    if (tarefaDB == null)
          return  NotFound();

          //Atualizando os dados da tarefa que já está na lista
          tarefaDB.Descricao = tarefaEditando.Descricao;
          tarefaDB.Concluida = tarefaEditando.Concluida;
          //Redirecionando para a lista de tarefas 
          return RedirectToAction("Index");
  }
   public IActionResult Deletar (int Id)
        {
            
            Tarefa tarefaBD = _tarefas.FirstOrDefault( t => t.Id == Id);
            
              if(tarefaBD == null)
                    return NotFound();
              return View (tarefaBD);
        }
  [HttpPost]
  public IActionResult Deletar (Tarefa tarefaEditando)
  {
    Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaEditando.Id);
    if (tarefaDB == null)
          return  NotFound();
             _tarefas.Remove(tarefaDB);

          return RedirectToAction("Index");
  }
    }
}