using Microsoft.AspNetCore.Mvc;
using llm_integrated.Models;
using llm_integrated.Interfaces;

namespace llm_integrated.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecommendationController : ControllerBase
    {
        private readonly IRecommendationService _recommendationService;

        public RecommendationController(IRecommendationService recommendationService)
        {
            _recommendationService = recommendationService;
        }

        [HttpGet]
        public IEnumerable<Recommendation> Get()
        {
            return _recommendationService.GetAllRecommendations();
        }

        [HttpGet("{id}")]
        public Recommendation Get(int id)
        {
            return _recommendationService.GetRecommendationById(id);
        }

        [HttpPost]
        public void Post([FromBody] Recommendation recommendation)
        {
            _recommendationService.AddRecommendation(recommendation);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recommendation recommendation)
        {
            recommendation.Id = id;
            _recommendationService.UpdateRecommendation(recommendation);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _recommendationService.DeleteRecommendation(id);
        }
    }
}
