using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class Card : Observable
    {
        public Card(Game _game, Faction _faction, CardType _type)
        {
            game = _game;
            faction = _faction;
            cardType = _type;

            if (game != null) { game.Cards.Add(this); }
            if (faction != null) { faction.Cards.Add(this); }
            if (cardType != null) { cardType.Cards.Add(this); }

            attributeValues = new ObservableAttributeValueCollection();
            prints = new ObservablePrintCollection();
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
                    if (oldGame != null) { oldGame.Cards.Remove(this); }
                    if (game != null) { game.Cards.Add(this); }
                }
            }
        }
        private Faction faction;
        public Faction Faction
        {
            get { return faction; }
            set
            {
                Faction oldFaction = faction;
                if (VerifyPropertyChange(ref faction, ref value))
                {
                    if (oldFaction != null) { oldFaction.Cards.Remove(this); }
                    if (faction != null) { faction.Cards.Add(this); }
                }
            }
        }
        private CardType cardType;
        public CardType CardType
        {
            get { return cardType; }
            set
            {
                CardType oldType = cardType;
                if (VerifyPropertyChange(ref cardType, ref value))
                {
                    if (oldType != null) { oldType.Cards.Remove(this); }
                    if (cardType != null) { cardType.Cards.Add(this); }
                }
            }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { VerifyPropertyChange(ref title, ref value); }
        }
        private string code;
        public string Code
        {
            get { return code; }
            set { VerifyPropertyChange(ref code, ref value); }
        }

        private ObservableAttributeValueCollection attributeValues;
        public ObservableAttributeValueCollection AttributeValues { get { return attributeValues; } }
        private ObservablePrintCollection prints;
        public ObservablePrintCollection Prints { get { return prints; } }
    }
}
