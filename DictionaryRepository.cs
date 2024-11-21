using System;
using System.Collections.Generic;

namespace Generics_Activity
{
    public class DictionaryRepository<TKey, TProduct> where TKey : IComparable<TKey>
    {
       public Dictionary<TKey, TProduct> _dictionary;

        public DictionaryRepository()
        {
            _dictionary = new Dictionary<TKey, TProduct>();

        }

        public void Add(TKey id, TProduct value)
        {
           
            
            if (_dictionary.ContainsKey(id))
            {
                throw new ArgumentException("An item with this key already exists.");
            }
            _dictionary[id] = value;
            
        }
        public TProduct Get (TKey id)
        {
            if (!_dictionary.TryGetValue(id, out TProduct value))
            {
                throw new KeyNotFoundException("The specified key does not exist.");
            }
            return value;
        }
        public void Update(TKey id, TProduct newValue)
        {
            if (!_dictionary.ContainsKey(id))
            {
                throw new KeyNotFoundException("The Entered Key does not exist.");
            }
            _dictionary[id] = newValue;
        }
        public void Delete(TKey id)
        {
            if ( !_dictionary.ContainsKey(id))
            {
                throw new KeyNotFoundException("The entered key does not exist.");
            }
            _dictionary.Remove(id);
        }
        public void DisplayAllItems()
        {
            foreach (var item in _dictionary)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }
        }
    }
}
