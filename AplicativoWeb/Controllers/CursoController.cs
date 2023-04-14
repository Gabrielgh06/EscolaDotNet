using AplicativoWeb.Models; //Camada Model
using Microsoft.AspNetCore.Mvc; //Microsoft
namespace AplicativoWeb.Controllers;  //Definindo

//Criando a Classe Controller
public class CursoController : Controller {
    public IActionResult Index(){
        Curso c1 = new Curso ();
        // set
        c1.TituloMarketing = "Crie Aplicativos incríveis";
        c1.TituloInterno = "Desenvolvedor C#";
        c1.Descricao = "Primeiros passos no ASP.NET Core";
        // get
        ViewData["curso"] = c1; //Passando o objeto inteiro
        return View();

    }
    //Action
    public IActionResult Create(){
        ViewData["titulo"]="Cadastro de Cursos";
        ViewBag.DataHora = DateTime.Now;

        return View();
    }

}