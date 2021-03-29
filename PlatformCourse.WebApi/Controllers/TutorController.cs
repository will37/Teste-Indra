using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PlatformCourse.WebApi.Data;
using PlatformCourse.WebApi.Models;

namespace PlatformCourse.WebApi.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class TutorController : ControllerBase{
        private readonly DataContext _context;
        public TutorController(DataContext context){
            _context = context;
         }

        [HttpGet]
        public IActionResult Get(){
            return Ok(_context.Tutores);
        }

        // http://localhost:5000/api/tutor/byId?id="id"
        [HttpGet("byId")]
        public IActionResult GetById(int id){
            var tutor = _context.Tutores.FirstOrDefault(tut => tut.Id == id);
            if(tutor == null) return BadRequest("Sem registro");
            else return Ok(tutor); 
            
        }
        // http://localhost:5000/api/tutor/byName?Nome="nome"
        [HttpGet("byName")]
        public IActionResult GetByNome(string Nome){
            var tutor = _context.Alunos.FirstOrDefault(tut => 
                tut.Nome.Contains(Nome)
            );
            if(tutor == null) return BadRequest("Sem registro");
            else return Ok(tutor);
            
        }

        // http://localhost:5000/api/tutor
        [HttpPost]
        public IActionResult Post(Tutor tutor){
            _context.Add(tutor);
            _context.SaveChanges();
            return Ok(tutor);
            
        }
        // http://localhost:5000/api/tutor/"id"
        [HttpPut("{id}")]
        public IActionResult Put(int id, Tutor tutor){
        
            var tut = _context.Tutores.FirstOrDefault(t => t.Id == id);
             if(tut == null){
                 return BadRequest("Sem registro");
             }else{
                _context.Update(tutor);
                _context.SaveChanges();
                return Ok(tutor);
             }
            
        }

        // http://localhost:5000/api/tutor/"id"
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Tutor tutor){
           var tut = _context.Alunos.FirstOrDefault(t => t.id == id);
             if(tut == null){
                 return BadRequest("Sem registro");
             }else{
                _context.Update(tutor);
                _context.SaveChanges();
                return Ok(tutor);
             }
            
        }

        // http://localhost:5000/api/tutor/"id"
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
             var tutor = _context.Alunos.FirstOrDefault(tut => tut.id == id);
             if(tutor == null){
                 return BadRequest("Sem registro");
             }else{
                _context.Remove(tutor);
                _context.SaveChanges();
                return Ok();
             }
            
            
        }

    }
}