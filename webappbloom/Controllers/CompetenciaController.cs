using Microsoft.AspNetCore.Mvc;
using WebAppBloom.models;
namespace WebAppBloom.Controllers;
public class CompetenciaController : Controller{
    public IActionResult Index(){

        Competencia competencia = new Competencia();
        competencia.ColunaBloom = "Memorizar";
        competencia.LinhaBloom = "Listar";
       /* competencia.ColunaBloom = "Aplicar";
        competencia.ColunaBloom = "Avaliar";
        competencia.ColunaBloom = "Criar";*/
        ViewData["titulo"] = "Compreemder o funcionamento do Razor";
        ViewData["tablebloom"] = competencia;
        return View(); 
    }

}