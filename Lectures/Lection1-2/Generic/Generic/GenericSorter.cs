using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{

    public class GenericSorter<T, V> where T : IEnumerable<V> where V : IComparable
    {
        public void FindMinMax(T collection)
        {
            var min = FindMin(collection);
            var max = FindMax(collection);
        }

        private void Quadratic(T collection)
        {
            foreach(var item in collection)
            {
                foreach(var something in collection)
                {

                }
            }
        }

        private V FindMin(T collection)
        {
            var result = default(V);
            var enumerator = collection.GetEnumerator();
            if(enumerator.MoveNext())
            {
                result = enumerator.Current;
            }
            foreach(var item in collection)
            {
                if (result.CompareTo(item) < 0)
                    result = item;
            }
            return result;
        }

        private V FindMax(T collection)
        {
            var result = default(V);
            var enumerator = collection.GetEnumerator();
            if (enumerator.MoveNext())
            {
                result = enumerator.Current;
            }
            foreach (var item in collection)
            {
                if (result.CompareTo(item) > 0)
                    result = item;
            }
            return result;
        }

    }
}
