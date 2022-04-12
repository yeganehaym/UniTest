using System.Threading.Tasks;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using TestApp.Domains;

namespace TestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IUnitOfWork _uow;
        private IPersonService _personService;

        public PersonController(IUnitOfWork uow, IPersonService personService)
        {
            _uow = uow;
            _personService = personService;
        }

        [HttpPost]
        public async Task<IActionResult> PostPerson([FromBody]PersonPost model)
        {

            var person = model.Adapt<Person>();
            await  _personService.AddPerson(person);
            var rows =await _uow.SaveChangesAsync();

            if (rows > 0)
                return Ok(new {id=person.Id});
            
            return BadRequest();
        }

        [HttpGet]
        public async Task<Person> Get(int id)
        {
            return await _personService.FindPersonAsync(id);
        }
    }
}