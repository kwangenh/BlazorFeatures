using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICardRepository : IRepositoryBase<Card>
    {
        IEnumerable<Card> GetAllCards();
        Card GetCardById(Guid id);
        Task<List<Card>> GetCardsTask();
    }
}
