using System;

namespace SortedPair
{
    public class Sorted_Pair<T> where T : IComparable<T>
    {
        public T First { get; private set; }
        public T Second { get; private set; }

        /// <summary>
        /// Arrange the objects so that the smallest is first
        /// and the largest is second
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <exception cref="IllegalPairException"></exception>
        public Sorted_Pair(T item1, T item2)
        {
            int ans = item1.CompareTo(item2);
            if (ans == 0)
                throw new IllegalPairException($"The items are equal {item1} : {item2}");
            else if (ans > 0)
            {
                First = item2;
                Second = item1;
            }
            else if (ans < 0)
            {
                First = item1;
                Second = item2;
            }
        }

        /// <summary>
        /// Compares the objects according to the property
        /// so that only if this.First is equal to other.First
        /// and this.Second is equal to other.Second
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True if equals, otherwise False</returns>
        public override bool Equals(object obj)
        {
            Sorted_Pair<T> aObj = obj as Sorted_Pair<T>;
            if (aObj == null)
                return false;
            if (this.Second.Equals(aObj.Second) && this.First.Equals(aObj.First))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Textually represents the objects 
        /// so that the first is the smallest 
        /// and the second is the largest
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{First} : {Second}";
        }
    }
}
