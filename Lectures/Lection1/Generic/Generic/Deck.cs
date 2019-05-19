using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{
    public class Deck<T> where T : ICard, IComparable
    {
        private List<T> _items = new List<T>();

        public void Add(T card)
        {
            _items.Add(card);
        }

        public void Remove(T card) => _items.Remove(card);

        public void Sort()
        {
            var comparer = Comparer<T>.Default;
            _items.Sort();
        }

        public void Shuffle()
        {
            var elementsCount = _items.Count;
            var random = new Random();
            _items = _items.OrderBy(x => random.Next(0, elementsCount)).ToList();
        }
    }
}
