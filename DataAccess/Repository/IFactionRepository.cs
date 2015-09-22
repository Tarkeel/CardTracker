using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface IFactionRepository
    {
        Faction GetFaction(int id);
        Faction GetFaction(Game game, string title);
        Faction CreateOrGetFaction(Game game, string title, bool persist = true);
        void UpdateFaction(Faction updated, bool persist = true);
        void DeleteFaction(Faction deleted, bool cascade = false);
    }
}