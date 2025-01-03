using Microsoft.AspNetCore.Mvc;
using llm_integrated.Models;
using llm_integrated.Interfaces;

namespace llm_integrated.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpinionController : ControllerBase
    {
        private readonly IOpinionService _opinionService;

        public OpinionController(IOpinionService opinionService)
        {
            _opinionService = opinionService;
        }

        [HttpGet]
        public IEnumerable<Opinion> Get()
        {
            return _opinionService.GetAllOpinions();
        }

        [HttpGet("{id}")]
        public Opinion Get(int id)
        {
            return _opinionService.GetOpinionById(id);
        }

        [HttpPost]
        public void Post([FromBody] Opinion opinion)
        {
            _opinionService.AddOpinion(opinion);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Opinion opinion)
        {
            opinion.Id = id;
            _opinionService.UpdateOpinion(opinion);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _opinionService.DeleteOpinion(id);
        }
    }
}
