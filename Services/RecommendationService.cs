using llm_integrated.Models;
using llm_integrated.Data;
using System.Collections.Generic;
using System.Linq;
using llm_integrated.Interfaces;

namespace llm_integrated.Services
{
    public class RecommendationService : IRecommendationService
    {
        private readonly ApplicationDbContext _context;

        public RecommendationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Recommendation> GetAllRecommendations()
        {
            return _context.Recommendations.ToList();
        }

        public Recommendation GetRecommendationById(int id)
        {
            return _context.Recommendations.Find(id);
        }

        public void AddRecommendation(Recommendation recommendation)
        {
            _context.Recommendations.Add(recommendation);
            _context.SaveChanges();
        }

        public void UpdateRecommendation(Recommendation recommendation)
        {
            _context.Recommendations.Update(recommendation);
            _context.SaveChanges();
        }

        public void DeleteRecommendation(int id)
        {
            var recommendation = _context.Recommendations.Find(id);
            if (recommendation != null)
            {
                _context.Recommendations.Remove(recommendation);
                _context.SaveChanges();
            }
        }
    }
}