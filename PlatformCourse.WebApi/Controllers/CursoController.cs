using Microsoft.AspNetCore.Mvc;

namespace PlatformCourse.WebApi.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase{
        public CursoController(){ }

        [HttpGet]
        public IActionResult Get(){
            return Ok("Cursos: MVC, .NET, CORE .NET, PHP COMPLETO");
        }

    }
}