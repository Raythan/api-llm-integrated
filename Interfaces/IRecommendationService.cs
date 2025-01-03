using llm_integrated.Models;
using System.Collections.Generic;

namespace llm_integrated.Interfaces
{
    public interface IRecommendationService
    {
        IEnumerable<Recommendation> GetAllRecommendations();
        Recommendation GetRecommendationById(int id);
        void AddRecommendation(Recommendation recommendation);
        void UpdateRecommendation(Recommendation recommendation);
        void DeleteRecommendation(int id);
    }
}