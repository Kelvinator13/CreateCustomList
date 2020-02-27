using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomListProject
{
    public class CustomList<T>
    {

        //member variable
        int count;
        int capacity;
        T[] items;
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        //Construct
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count > capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {
                int capacity1 = capacity;
                int counter = 0; T[] items1 = new T[capacity * 2];
                while (counter < capacity1)
                {
                    items1[counter] = items[counter];
                    counter++;
                }

                items1[count] = item;
                items = items1; count++;
            }
        }
        public bool Remove(T value)
        {
            bool isRemoved = false;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(value))
                {
                    if (count == 1)
                    {
                        items = new T[4];
                        isRemoved = true;
                        break;
                    }
                    isRemoved = true;
                    break; 
                }
            }
            if (isRemoved)
            {
                count--;
                return true; 
            }
            else
            {
                return false; 
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(items[i].ToString());
            }
            return stringBuilder.ToString();
        }
        public static CustomList<T> operator +(CustomList<T> valueOne, CustomList<T> add)
        {
            CustomList<T> tempList = new CustomList<T>();
            foreach (T value in valueOne)
            {
                tempList.Add(value);
            }
            foreach (T value in add)
            {
                tempList.Add(value);
            }
            return tempList;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
    }
}


 
