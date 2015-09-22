using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Faction : Observable
    {
        public Faction(Game _game)
        {
            game = _game;

            if (game != null) { game.Factions.Add(this); }

            cards = new ObservableCardCollection();
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { VerifyPropertyChange(ref id, ref value); }
        }
        private Game game;
        public Game Game
        {
            get { return game; }
            set
            {
                Game oldGame = game;
                if (VerifyPropertyChange(ref game, ref value))
                {
                    if (oldGame != null) { oldGame.Factions.Remove(this); }
                    if (game != null) { game.Factions.Add(this); }
                }
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { VerifyPropertyChange(ref name, ref value); }
        }
        private string iconPath;
        public string IconPath
        {
            get { return iconPath; }
            set { VerifyPropertyChange(ref iconPath, ref value); }
        }

        private ObservableCardCollection cards;
        public ObservableCardCollection Cards { get { return cards; } }
    }
}
