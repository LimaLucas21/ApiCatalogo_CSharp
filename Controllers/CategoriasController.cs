using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("UsandoFromServices/{nome}")]
        public ActionResult<string> GetSaudacaoFromServices([FromServices] IMeuServico meuServico, string nome)
        {
            return meuServico.Saudacao(nome);
        }

          [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            try
            {
                return _context.Categorias.Include(p=> p.Produtos).ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação.");
                throw;
            }
        }


          [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {   
            try
            {
                var categorias = _context.Categorias.AsNoTracking().ToList();
                if (categorias is  null) 
                {
                    return NotFound();
                }
                return categorias;
                
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação.");
                throw;
            }
        }

        [HttpGet("{id:int}", Name="ObterCategoria")]
        public ActionResult<Categoria> Get(int id)
        {
            try
            {
                var categoria = _context.Categorias.FirstOrDefault(p => p.CategoriaId == id);
                if (categoria == null) 
                {
                    return NotFound("Categoria não encontrada");
                }
                return categoria;

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação.");
                throw;
            }
        }

        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {
            try
            {

                if (categoria == null)
                    return BadRequest();
                
                _context.Categorias.Add(categoria);
                _context.SaveChanges();
                return new CreatedAtRouteResult("ObterCategoria", new {id = categoria.CategoriaId}, categoria);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação.");
                throw;
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categoria categoria) 
        {
            try
            {
                if(id != categoria.CategoriaId)
                    return BadRequest();

                _context.Entry(categoria).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok(categoria);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação.");
                throw;
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) 
        {
            try
            {
                var categoria = _context.Categorias.FirstOrDefault(p => p.CategoriaId == id);

                if (categoria == null)
                    return NotFound("Produto não Localizado");

                _context.Categorias.Remove(categoria);
                _context.SaveChanges();

                return Ok(categoria);         
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um problema ao tratar a sua solicitação.");
                throw;
            }
        }

    }
}
