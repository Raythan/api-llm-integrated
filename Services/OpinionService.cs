using llm_integrated.Models;
using llm_integrated.Data;
using System.Collections.Generic;
using System.Linq;
using llm_integrated.Interfaces;

namespace llm_integrated.Services
{
    public class OpinionService : IOpinionService
    {
        private readonly ApplicationDbContext _context;

        public OpinionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Opinion> GetAllOpinions()
        {
            return _context.Opinions.ToList();
        }

        public Opinion GetOpinionById(int id)
        {
            return _context.Opinions.Find(id);
        }

        public void AddOpinion(Opinion opinion)
        {
            _context.Opinions.Add(opinion);
            _context.SaveChanges();
        }

        public void UpdateOpinion(Opinion opinion)
        {
            _context.Opinions.Update(opinion);
            _context.SaveChanges();
        }

        public void DeleteOpinion(int id)
        {
            var opinion = _context.Opinions.Find(id);
            if (opinion != null)
            {
                _context.Opinions.Remove(opinion);
                _context.SaveChanges();
            }
        }
    }
}