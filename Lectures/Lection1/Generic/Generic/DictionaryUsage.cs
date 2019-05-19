using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class DictionaryUsage
    {
        public void Use()
        {
            var cards = new Dictionary<Guid, ICard>();

            var pokerCard = new PokerCard() { Id = Guid.NewGuid() };
            var taroCard = new TaroCard() { Id = Guid.NewGuid() };

            var pokerCardId = pokerCard.Id;
            var taroCardId = taroCard.Id;

            cards.Add(pokerCardId, pokerCard);
            cards.Add(taroCardId, taroCard);

            cards.TryGetValue(pokerCardId, out var retrievedPokerCard);
            cards.TryGetValue(taroCardId, out var retirevedTaroCard);

        }
    }
}
