using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface ICardRepository
    {
        Card GetCard(int id);
        Card GetCard(Game game, Faction faction, CardType type, string code);
        Card CreateOrGetCard(Game game, Faction faction, CardType type, string code, bool persist = true);
        void UpdateCard(Card updated, bool persist = true);
        void DeleteCard(Card deleted, bool cascade = false);
    }
}