using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Types;

namespace DataAccess.Repository
{
    public interface IGameRepository
    {
        IList<Game> GetAll();
        Game GetGame(int id);
        Game GetGame(string title);
        Game CreateOrGetGame(string title, bool persist = true);
        void UpdateGame(Game updated, bool persist = true);
        void DeleteGame(Game deleted, bool cascade = false);
    }
}