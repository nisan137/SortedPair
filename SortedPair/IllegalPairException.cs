using System;

namespace SortedPair
{
    public class IllegalPairException : Exception
    {
        public IllegalPairException() { }
        public IllegalPairException(string message) : base(message) { }
    }
}
