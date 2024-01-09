using AulaAPI.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks.Sources;

namespace AulaAPI.Controllers
{
    [Authorize]
    [Route("api/entity")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly IJWTAuthenticationManager _jwt;

        public EntityController(IJWTAuthenticationManager jwt)
        {
            this._jwt = jwt;
        }
        //[AllowAnonymous]
        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> getPessoas(
            [FromServices] Contexto contexto
            )
        {
            var pessoas = await contexto.Pessoas
                .AsNoTracking()
                .ToListAsync();

            return pessoas == null ? NoContent() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> getPessoas(
            [FromServices] Contexto contexto,
            [FromRoute] int id
            )
        {
            var pessoas = await contexto.Pessoas
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.id == id);

            return pessoas == null ? NoContent() : Ok(pessoas);
        }

        [HttpPost]
        [Route("pessoas")]
        public async Task<IActionResult> postPessoa(
  [FromServices] Contexto contexto,
  [FromBody] Pessoa pessoa
  )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }



            try
            {
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();



                return Created("api/pessoas/" + pessoa.id, pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] Contexto contexto,
            [FromRoute] int id)
        {
            var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.id == id);
            if (p == null)
                return NotFound("Pessoa não encontrada");
            try
            {
                contexto.Pessoas.Remove(p);
                await contexto.SaveChangesAsync();
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] Contexto contexto,
            [FromBody] Pessoa pessoa,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest();

            var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.id == id);

            if (p == null) return NotFound("Pessoa não encontrada!");

            try
            {
                p.nome = pessoa.nome;
                contexto.Pessoas.Update(p);
                await contexto.SaveChangesAsync();
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("emails")]
        public async Task<IActionResult> getEmails(
            [FromServices] Contexto contexto)
        {
            var emails = await contexto.Emails.AsNoTracking().ToListAsync();

            return emails == null ? NoContent() : Ok(emails);

            //if (emails == null)
            //{
            //    return NoContent();
            //}
            //else
            //{
            //    return Ok(emails);
            //}
            //return emails == null ? NoContent() : Ok(emails);
        }

        [HttpPost]
        [Route("emails/{id}")]
        public async Task<IActionResult> PostEmailInPessoa(
            [FromServices] Contexto contexto,
            [FromBody] Email email,
            [FromRoute] int id)
        {
            var pessoa = await contexto.Pessoas.AsNoTracking().FirstOrDefaultAsync(x => x.id == id);

            email.pessoa = pessoa;

            try
            {
                contexto.Set<Email>().Add(email);
                contexto.Entry(email.pessoa).State = EntityState.Unchanged;
                await contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Created($"api/emails/{pessoa.id}", email);
        }

        [AllowAnonymous]
        [HttpPost("autenticar")]
        public IActionResult Autenticar([FromBody] Usuario usuario)
        {
            var token = _jwt.Authenticate(usuario.login, usuario.senha);

            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }
}
