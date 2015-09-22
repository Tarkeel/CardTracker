using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ICardAttributeRepository
    {
        CardAttribute GetCardAttribute(int id);
        CardAttribute GetCardAttribute(Game game, string title);
        CardAttribute CreateOrGetCardAttribute(Game game, string title, bool persist = true);
        void UpdateCardAttribute(CardAttribute updated, bool persist = true);
        void DeleteCardAttribute(CardAttribute deleted, bool cascade = false);
    }
}