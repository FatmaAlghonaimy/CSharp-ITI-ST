using RepoDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDP.Repository
{
    class GenericRepo<T> where T : BaseEntity
    {
        List<T> _items = new List<T>();

        public void Add(T item) 
        {
            _items.Add(item);
        }

        public T? GetByID(int id) {
            foreach (T item in _items)
            {
                if (item.Id == id) return item;
            }
            return null;
        }

        public T? Update(T item) 
        {
            for(int i =0; i< _items.Count; i++)
            {
                if (_items[i].Id == item.Id)
                {
                    _items[i] = item;
                    return item;
                }
            }
            return null;
        }
        public void Delete(T item)
        {
            int foundAt = -1;
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id == item.Id)
                {
                    foundAt = i;
                    break;
                }
            }
            if (foundAt > -1) {
                _items.RemoveAt(foundAt);
            }
        }
    }
}
