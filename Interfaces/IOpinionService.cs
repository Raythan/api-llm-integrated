using llm_integrated.Models;
using System.Collections.Generic;

namespace llm_integrated.Interfaces
{
    public interface IOpinionService
    {
        IEnumerable<Opinion> GetAllOpinions();
        Opinion GetOpinionById(int id);
        void AddOpinion(Opinion opinion);
        void UpdateOpinion(Opinion opinion);
        void DeleteOpinion(int id);
    }
}