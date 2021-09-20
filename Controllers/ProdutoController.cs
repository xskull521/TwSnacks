using CadastroProdutoDAO;
using CadastroProdutoEntidade;
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
    public class ProdutoController : ControllerBase
    {
        // GET: api/<EnderecoController>
        [HttpGet]
        public IEnumerable<CadProdutoEntidade> Get()
        {
            var repository = new CadastroDAO();
            return repository.SelectAllProdutos();
        }

        // GET api/<EnderecoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EnderecoController>
        [HttpPost]
        public void Post(string NomeDoProduto, int Valor)
        {

            var repository = new CadastroDAO();
            repository.InsertData(NomeDoProduto, Valor);
        }

        // PUT api/<EnderecoController>/5
        [HttpPut]
        public void Put(CadProdutoEntidade CadProdutoEntidade)
        {
            var repository = new CadastroDAO();
            repository.UpdateData(CadProdutoEntidade);
        }

        // DELETE api/<EnderecoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var repository = new CadastroDAO();
            repository.DeleteData(id);
        }
    }
}

