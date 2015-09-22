using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Types
{
    public class CardAttributeValue : Observable
    {
        public CardAttributeValue(CardAttribute _cardAttribute, Card _card)
        {
            cardAttribute = _cardAttribute;
            card = _card;

            cardAttribute.AttributeValues.Add(this);
            card.AttributeValues.Add(this);
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { VerifyPropertyChange(ref id, ref value); }
        }
        private CardAttribute cardAttribute;
        public CardAttribute CardAttribute
        {
            get { return cardAttribute; }
            set
            {
                CardAttribute oldAttribute = cardAttribute;
                if (VerifyPropertyChange(ref cardAttribute, ref value))
                {
                    if (oldAttribute != null) { oldAttribute.AttributeValues.Remove(this); }
                    if (cardAttribute != null) { cardAttribute.AttributeValues.Add(this); }
                }
            }
        }
        private Card card;
        public Card Card
        {
            get { return card; }
            set
            {
                Card oldCard = card;
                if (VerifyPropertyChange(ref card, ref value))
                {
                    if (oldCard != null) { oldCard.AttributeValues.Remove(this); }
                    if (card != null) { card.AttributeValues.Add(this); }
                }
            }
        }

        private string _value;
        public string Value
        {
            get { return _value; }
            set { VerifyPropertyChange(ref _value, ref value); }
            
        }
    }
}
