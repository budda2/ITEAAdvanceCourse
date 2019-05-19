using System;
using System.Collections.Generic;

namespace Generic.Generics.GenerixExtension
{
    internal static class ListExtension
    {
        private static Random _random = new Random();

        /// <summary>
        /// Reorders elements in list in random (presudo) manner.
        /// </summary>
        /// <param name="collection">Collection that will be reordered in random (pseudo0 manner.</param>
        public static void Shuffle<T> (IList<T> collection)
        {
            var listCount = collection.Count;
            for (int i = 0; i < listCount; i++)
            {
                var randomPosition = _random.Next(0, listCount);

                var currentElement = collection[i];
                collection[i] = collection[randomPosition];
                collection[randomPosition] = currentElement;
            }
        }
    }
}
