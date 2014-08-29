namespace GenericListProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GenericList<T> 
    {
        private T[] items;
        private int count = 0;
        private int capacity;

        public GenericList(int capacity = 1000)
        {
            this.capacity = capacity;
            this.items = new T[capacity];
        }

        public int Count
        {
            get { return this.count; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity can't be under 0!");
                }
                this.capacity = value;
            }
        }

        public void Add(T item)
        {
            if (this.count == this.items.Length)
            {
                Grow();
            }
            if (this.count >= this.items.Length)
            {
                throw new IndexOutOfRangeException("List capacity was exceeded!");
            }
            this.items[count] = item;
            this.count++;
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException("Invalid index!");
                }
                T result = this.items[index];
                return result;
            }
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index can't be under 0!");
            }
            if (index <= this.count)
            {
                for (int i = index; i < this.count - 1; i++)
                {
                    this.items[i] = this.items[i + 1];
                }
                this.count--;
            }
            else
            {
                throw new ArgumentException("Position is empty!");
            }
        }

        public void Clear()
        {
            this.items = new T[this.items.Length];
            this.count = 0;
        }

        public void InsertAtPosition(int index, T item)
        {
            if (this.count == this.items.Length)
            {
                Grow();
            }
            for (int i = this.count; i >= index + 1; i++)
            {
                this.items[i] = this.items[i - 1];
            }
            this.items[index] = item;
            this.count++;
        }

        public int FindByValue(T item)
        {
            return Array.IndexOf(this.items, item);
        }

        private void Grow()
        {
            T[] temp = new T[this.items.Length * 2];
            Array.Copy(this.items, 0, temp, 0, this.items.Length);
            this.items = temp;
            Capacity *= 2;
        }

        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Doesn't have items.");
            }
            if (this.count == 1)
            {
                return this.items[0];
            }
            if (this.items[0] is IComparable<T>)
            {
                T max = this.items[0];

                for (int i = 1; i < this.count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(this.items[i]) < 0)
                    {
                        max = this.items[i];
                    }
                }

                return max;
            }
            else
            {
                throw new ArgumentException("Must implement IComparable.");
            }
        }

        public T Min()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Doesn't have items!");
            }
            if (this.count == 1)
            {
                return this.items[0];
            }
            if (this.items[0] is IComparable<T>)
            {
                T min = this.items[0];

                for (int i = 1; i < this.count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(this.items[i]) > 0)
                    {
                        min = this.items[i];
                    }
                }
                return min;
            }
            else
            {
                throw new ArgumentException("Must implement IComparable.");
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < this.count; i++)
            {
                result += this.items[i];
                if (i < this.count - 1)
                {
                    result += ", ";
                }
            }
            return result;
        }
    }
}
