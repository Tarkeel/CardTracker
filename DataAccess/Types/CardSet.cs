using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class CardSet : Observable
    {
        public CardSet(Game _game)
        {
            game = _game;

            if (game != null) { game.CardSets.Add(this); }

            cardSeries = new ObservableCardSeriesCollection();
            boosters = new ObservableBoosterCollection();
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
                    if (oldGame != null) { oldGame.CardSets.Remove(this); }
                    if (game != null) { game.CardSets.Add(this); }
                }
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { VerifyPropertyChange(ref name, ref value); }
        }

        private ObservableCardSeriesCollection cardSeries;
        public ObservableCardSeriesCollection CardSeries { get { return cardSeries; } }
        private ObservableBoosterCollection boosters;
        public ObservableBoosterCollection Boosters { get { return boosters; } }
    }
}
