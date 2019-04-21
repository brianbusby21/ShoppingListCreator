using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace ShoppingListSoftware.DataClasses
{
    public abstract class Enumeration : IComparable
    {
        public int Value { get; private set; }
        public string DisplayName { get; private set; }

        protected Enumeration(int value, string displayName)
        {
            Value = value;
            DisplayName = displayName;
        }

        public override string ToString()
        {
            return DisplayName;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration, new()
        {           
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        public override bool Equals(object obj)
        {

            if (!(obj is Enumeration otherValue))
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public int CompareTo(object other) => Value.CompareTo(((Enumeration)other).Value);
    }
}
