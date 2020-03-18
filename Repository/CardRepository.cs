using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public CardRepository(RepositoryContext repoContext) : base(repoContext)
        {

        }

        public IEnumerable<Card> GetAllCards()
        {
            return FindAll().OrderBy(card => card.CardName).ToList();
        }

        public Card GetCardById(Guid id)
        {
            return FindByCondition(card => card.CardId.Equals(id)).FirstOrDefault();
        }

        public async Task<List<Card>> GetCardsTask()
        {
            return await FindAll().ToListAsync();
        }
    }
}
