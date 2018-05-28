using System;

namespace DataStructures
{
    public class List<T>
    {
        private T[] items;
        private int count;

        public List()
        {
            items = new T[5];
            count = 0;
        }
        public List(int someItem)
        {
            items = new T[0];
            count = 0;
        }
        public void Add(T item)
        {
            if (count == items.Length)
            {
                IncrementList(items);
            }
            items[count] = item;
            count++;

        }

        private void IncrementList(T[] listToIncrement)
        {
            T[] longList = new T[listToIncrement.Length + 5];
            Array.Copy(listToIncrement, longList, listToIncrement.Length);
            items = longList;
        }

        public void Remove(T item)
        {
            T[] AuxList = items;
            for (int i = 0; i < items.Length; i++)
            {
                if (Equals(items[i], item))
                {
                    Array.Copy(AuxList, i + 1, items, i, count - i);
                    count--;
                    break;
                }

            }
        }
        public void RemoveAt(int index)
        {
            if (index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }
            T[] AuxList = items;
            Array.Copy(AuxList, index + 1, items, index, count - index);
            count--;
        }
        public T Get(int position)
        {
            return items[position];
        }

        public int Count()
        {
            return count;
        }

        public void Insert(T item, int index)
        {
            T[] AuxList = items;
            Array.Copy(AuxList, index, items, index + 1, count - index + 1);
            items[index] = item;
            count++;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (Equals(items[i], item))
                {
                    return i;
                }

            }
            return -1;
        }

        public override bool Equals(object obj)
        {
            List<T> list = obj as List<T>;
            if (list != null)
            {

                if (count != list.count)
                {
                    return false;
                }

                for (int i = 0; i < Count(); i++)
                {
                    if (!Get(i).Equals(list.Get(i)))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

    }
}
