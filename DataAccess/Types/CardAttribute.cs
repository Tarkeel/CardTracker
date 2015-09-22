using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class CardAttribute : Observable
    {
        public CardAttribute(Game _game)
        {
            game = _game;
            if (game != null) { game.Attributes.Add(this); }

            attributeValues = new ObservableAttributeValueCollection();
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
                    if (oldGame != null) { oldGame.Attributes.Remove(this); }
                    if (game != null) { game.Attributes.Add(this); }
                }
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { VerifyPropertyChange(ref name, ref value); }
        }
        private ObservableAttributeValueCollection attributeValues;
        public ObservableAttributeValueCollection AttributeValues { get { return attributeValues; } }
    }
}
