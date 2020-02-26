using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {

            //member variable
            int count;
            int capacity;
            T[] items;

        //Construct
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }
        private class custom<T1>
        {
            private int number;
            private int addNumber;
            private string value;
            private int removeNumber;
            private int value1;

            public custom (string value, int number, int addNumber, int removeNumber, int value1)
            {
                this.value = value;
                this.number = number;
                this.addNumber = addNumber;
                this.removeNumber = removeNumber;
                this.value1 = value1;
            }
            public int Value
            {
                get { return  value; }
                set { value = number; }
            }
            public int Number
            {
                get { return number; }
                set { number = value; }
            }
            public int AddNumber
            {
                get { return addNumber; }
                set { addNumber = value; }
            }
            public int RemoveNumber
            {
                get { return removeNumber; }
                set { removeNumber = value; }
            }
            public int Value1
            {
                get { return value1; }
                set { value1 = value; }
            }
        }


    }

    }
}
