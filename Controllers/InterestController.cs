using Microsoft.AspNetCore.Mvc;
using llm_integrated.Models;
using llm_integrated.Interfaces;
using System.Collections.Generic;

namespace llm_integrated.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterestController : ControllerBase
    {
        private readonly IInterestService _interestService;

        public InterestController(IInterestService interestService)
        {
            _interestService = interestService;
        }

        [HttpGet]
        public IEnumerable<Interest> Get()
        {
            return _interestService.GetAllInterests();
        }

        [HttpGet("{id}")]
        public Interest Get(int id)
        {
            return _interestService.GetInterestById(id);
        }

        [HttpPost]
        public void Post([FromBody] Interest interest)
        {
            _interestService.AddInterest(interest);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Interest interest)
        {
            interest.Id = id;
            _interestService.UpdateInterest(interest);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _interestService.DeleteInterest(id);
        }
    }
}
