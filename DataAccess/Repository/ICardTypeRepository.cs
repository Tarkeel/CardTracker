using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ICardTypeRepository
    {
        CardType GetCardType(int id);
        CardType GetCardType(Game game, string title);
        CardType CreateOrGetCardType(Game game, string title, bool persist = true);
        void UpdateCardType(CardType updated, bool persist = true);
        void DeleteCardType(CardType deleted, bool cascade = false);
    }
}