using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PlatformCourse.WebApi.Models;

namespace PlatformCourse.WebApi.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class CartaoController : ControllerBase{

        public List<Cartao> cartoes = new List<Cartao>(){
            new Cartao(){
                Id = 1,
                numero = "65161616",
                vencimento = "12/12/5616"
            } 

        };

        public CartaoController(){ }

        [HttpGet]
        public IActionResult Get(){
        
            return Ok(cartoes); 
            
        }


   // http://localhost:5000/api/numero/byId?id="id"
        [HttpGet("byId")]
        public IActionResult GetById(int id){
            var cartao = cartoes.FirstOrDefault(cart => cart.Id == id);
            if(cartao == null) return BadRequest("Sem registro");
            else return Ok(cartao); 
            
        }
        // http://localhost:5000/api/cartao/byNumero?Nome="numero"
        [HttpGet("byNumero")]
        public IActionResult GetByNome(string numero){
            var cartao = cartoes.FirstOrDefault(cart => cart.numero.Contains(numero));
            if(cartao == null) return BadRequest("Sem registro");
            else return Ok(cartao);
            
        }

        // http://localhost:5000/api/cartao
        [HttpPost]
        public IActionResult Post(Cartao cartao){
            
            return Ok(cartao);
            
        }
        // http://localhost:5000/api/cartao/"id"
        [HttpPut("{id}")]
        public IActionResult Put(int id, Cartao cartao){
            
            return Ok(cartao);
            
        }

        // http://localhost:5000/api/cartao/"id"
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Cartao cartao){
            
            return Ok(cartao);
            
        }

        // http://localhost:5000/api/cartao/"id"
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            
            return Ok();
            
        }

    }
}