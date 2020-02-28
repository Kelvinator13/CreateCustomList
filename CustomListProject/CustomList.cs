using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;

namespace CustomListProject
{
    public class Custom<T> : IEnumerable
    {

        //member variable
        public int index;
        public int count;
        public int capacity;
        public T[] items = new T[4];


        //Construct

        public Custom(int i)
        {
            index = 0;
            count = 0;
            capacity = 4;
        }
        public void Add(T item)
        {
          
            {
               int count = 0;
               int capacity = 4;
                List<T> customList = new List<T>();
            }
        }

        public void custo(T item)
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
                    items1[counter] = items1[counter];
                    counter++;
                }

                items1[count] = item;
                T[]items = items1; count++;
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
        public static List<T> operator +(List<T> one, List<T> two)
        {
            List<T> tempList = new List<T>();
            for (int i = 0; i < one.Count; i++)
            {
                tempList.Add(one[i]);
            }
            for (int i = 0; i < two.Count; i++)
            {
                tempList.Add(two[i]);
            }
            return tempList;
        }
        public static List<T> operator -(List<T> one, List<T> two)
        {
            List<T> tempList = one;
            foreach  (T item in tempList)
            {
                tempList.Remove(item);
            }
            return tempList; 
        }
        public static List<T> Zip(List<T> one, List<T> two)
        {
            List<T> temp = new List<T>();

            int count = 0;
            int counter = 0;

            while (count < two.Count + one.Count)
            {
                if (counter < one.Count)
                {
                    temp.Add(one.items[counter]);
                    count++;
                }
                if (counter < two.Count)
                {
                    temp.Add(two.items[counter]);
                    count++;
                }
                counter++;
            }
            return temp;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

    }

}


 
