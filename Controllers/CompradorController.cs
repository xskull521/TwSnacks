using CadastroProdutoEntidade;
using CadastroProdutoDAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompradorController : ControllerBase
    {
        // GET: api/<EnderecoController>
        [HttpGet]
        public IEnumerable<CompradorEntidade> Get()
        {
            var repository = new CompradorDAO();
            return repository.SelectAllComprador();
        }

        // GET api/<EnderecoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EnderecoController>
        [HttpPost]
        public void Post(int IdComprador, string NomeComprador)
        {

            var repository = new CompradorDAO();
            repository.InsertData(IdComprador, NomeComprador);
        }

        // PUT api/<EnderecoController>/5
        [HttpPut]
        public void Put(CompradorEntidade compradorEntidade)
        {
            var repository = new CompradorDAO();
            repository.UpdateData(compradorEntidade);
        }

        // DELETE api/<EnderecoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var repository = new CompradorDAO();
            repository.DeleteData(id);
        }
    }
}
