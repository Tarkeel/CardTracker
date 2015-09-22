using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface IRarityRepository
    {
        Rarity GetRarity(int id);
        Rarity GetRarity(Game game, string title);
        Rarity CreateOrGetRarity(Game game, string title, bool persist = true);
        void UpdateRarity(Rarity updated, bool persist = true);
        void DeleteRarity(Rarity deleted, bool cascade = false);
    }
}