using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PlatformCourse.WebApi.Data;
using PlatformCourse.WebApi.Models;

namespace PlatformCourse.WebApi.Controllers{
    [ApiController]
    [Route("api/[controller]")]

    public class AlunoController : ControllerBase{
        private readonly DataContext _context;

        public AlunoController(DataContext context){
            _context = context;
        }



        [HttpGet]
        public IActionResult Get(){
            return Ok(_context.Alunos);
        }

        // http://localhost:5000/api/aluno/byId?id="id"
        [HttpGet("byId")]
        public IActionResult GetById(int id){
            var aluno = _context.Alunos.FirstOrDefault(alu => alu.id == id);
            if(aluno == null) return BadRequest("Sem registro");
            else return Ok(aluno); 
            
        }
        // http://localhost:5000/api/aluno/byName?Nome="nome"&Sobrenome="sobrenome"
        [HttpGet("byName")]
        public IActionResult GetByNome(string Nome, string Sobrenome){
            var aluno = _context.Alunos.FirstOrDefault(alu => 
                alu.Nome.Contains(Nome) && alu.Sobrenome.Contains(Sobrenome)
            );
            if(aluno == null) return BadRequest("Sem registro");
            else return Ok(aluno);
            
        }

        // http://localhost:5000/api/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno){
            _context.Add(aluno);
            _context.SaveChanges();
            return Ok(aluno);
            
        }
        // http://localhost:5000/api/aluno/"id"
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno){
        
            var alu = _context.Alunos.FirstOrDefault(a => a.id == id);
             if(alu == null){
                 return BadRequest("Sem registro");
             }else{
                _context.Update(aluno);
                _context.SaveChanges();
                return Ok(aluno);
             }
            
        }

        // http://localhost:5000/api/aluno/"id"
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno){
           var alu = _context.Alunos.FirstOrDefault(a => a.id == id);
             if(alu == null){
                 return BadRequest("Sem registro");
             }else{
                _context.Update(aluno);
                _context.SaveChanges();
                return Ok(aluno);
             }
            
        }

        // http://localhost:5000/api/aluno/"id"
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
             var aluno = _context.Alunos.FirstOrDefault(alu => alu.id == id);
             if(aluno == null){
                 return BadRequest("Sem registro");
             }else{
                _context.Remove(aluno);
                _context.SaveChanges();
                return Ok();
             }
            
            
        }


    }
}