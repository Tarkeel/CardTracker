using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ICardSetRepository
    {
        CardSet GetCardSet(int id);
        CardSet GetCardSet(Game game, string title);
        CardSet CreateOrGetCardSet(Game game, string title, bool persist = true);
        void UpdateCardSet(CardSet updated, bool persist = true);
        void DeleteCardSet(CardSet deleted, bool cascade = false);
    }
}