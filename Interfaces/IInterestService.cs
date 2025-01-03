using llm_integrated.Models;
using System.Collections.Generic;

namespace llm_integrated.Interfaces
{
    public interface IInterestService
    {
        IEnumerable<Interest> GetAllInterests();
        Interest GetInterestById(int id);
        void AddInterest(Interest interest);
        void UpdateInterest(Interest interest);
        void DeleteInterest(int id);
    }
}