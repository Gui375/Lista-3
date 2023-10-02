using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
       
        
            private readonly ICategoriaServices _categoriaService;
            public CategoriaController(ICategoriaServices categoriaService)
            {
                _categoriaService = categoriaService;
            }

            [HttpGet]
            public IActionResult ObterCrianca()
            {
                IEnumerable<CategoriaViewModel> categorias = _categoriaService.ObterTodos();
                return Ok(categorias);
            }

            [HttpPost(Name = "Adicionar")]
            public IActionResult Post(NovaCategoriaViewModel novaCategoriaViewModel)
            {
                _categoriaService.Adicionar(novaCategoriaViewModel);

                return Ok();
            }
        
    }
}
