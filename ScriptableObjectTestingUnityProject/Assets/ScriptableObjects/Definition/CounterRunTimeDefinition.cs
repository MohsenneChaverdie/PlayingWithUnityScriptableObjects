using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Definition
{
    /// <summary>
    /// this class is helper method for another scriptable object class that will inherit from this class.
    /// It makes it possible that scriptable object can be of any type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class CounterRunTimeDefinition<T> : ScriptableObject
    {
        public List<T> items = new List<T>();

        public void Add(T item)
        {
            if (!items.Contains(item)) items.Add(item);
        }

        public void Remove(T item)
        {
            if (items.Contains(item)) items.Remove(item);
        }
    }
}