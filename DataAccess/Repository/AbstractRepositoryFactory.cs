using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public abstract class AbstractRepositoryFactory
    {
        public abstract IConfigurationRepository ConfigurationRepository { get; }
        public abstract IGameRepository GameRepository { get; }
        public abstract ICardTypeRepository CardTypeRepository { get; }
        public abstract IFactionRepository FactionRepository { get; }
        public abstract ICardRepository CardRepository { get; }
        public abstract ICardAttributeRepository CardAttributeRepository { get; }
        //AttributeValue
        public abstract IRarityRepository RarityRepository { get; }
        public abstract ICardSetRepository CardSetRepository { get; }
        public abstract ICardSeriesRepository CardSeriesRepository { get; }
        public abstract ICardPrintRepository CardPrintRepository { get; }
        //Booster
        //Fixed
        //Random
        public abstract void Persist();
    }
}
