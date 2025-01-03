using llm_integrated.Models;
using llm_integrated.Data;
using System.Collections.Generic;
using System.Linq;
using llm_integrated.Interfaces;

namespace llm_integrated.Services
{
    public class InterestService : IInterestService
    {
        private readonly ApplicationDbContext _context;

        public InterestService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Interest> GetAllInterests()
        {
            return _context.Interests.ToList();
        }

        public Interest GetInterestById(int id)
        {
            return _context.Interests.Find(id);
        }

        public void AddInterest(Interest interest)
        {
            _context.Interests.Add(interest);
            _context.SaveChanges();
        }

        public void UpdateInterest(Interest interest)
        {
            _context.Interests.Update(interest);
            _context.SaveChanges();
        }

        public void DeleteInterest(int id)
        {
            var interest = _context.Interests.Find(id);
            if (interest != null)
            {
                _context.Interests.Remove(interest);
                _context.SaveChanges();
            }
        }
    }
}