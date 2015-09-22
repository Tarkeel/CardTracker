using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Rarity : Observable
    {
        public Rarity(Game _game)
        {
            game = _game;

            if (game != null) { game.Rarities.Add(this); }

            prints = new ObservablePrintCollection();
            randomContent = new ObservableBoosterRandomContentCollection();
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
                    if (oldGame != null) { oldGame.Rarities.Remove(this); }
                    if (game != null) { game.Rarities.Add(this); }
                }
            }
        }
        private string code;
        public string Code
        {
            get { return code; }
            set { VerifyPropertyChange(ref code, ref value); }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { VerifyPropertyChange(ref title, ref value); }
        }

        private ObservablePrintCollection prints;
        public ObservablePrintCollection Prints { get { return prints; } }
        private ObservableBoosterRandomContentCollection randomContent;
        public ObservableBoosterRandomContentCollection RandomContent { get { return randomContent; } }
    }
}
