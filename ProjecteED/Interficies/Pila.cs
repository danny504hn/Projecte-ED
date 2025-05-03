using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteED
{
   
    internal class Pila<T> : ICollection<T>, IEnumerable<T>
    {
        //atributs::
        private T [] data;
        private const int DEFAULT_SIZE = 5;
        private int top = -1;

        //Constructors::
        #region
        public Pila()
        {
            this.data = new T[DEFAULT_SIZE];
        }

        public Pila(IEnumerable<T> collection)
        {
            this.data = new T[collection.Count() * 2];
            IEnumerator<T> cursor = collection.GetEnumerator();
            
            while (cursor.MoveNext()) 
            {
                this.data[++top]= cursor.Current;
                
            }
            cursor.Dispose();
        }
        public Pila(int size)
        {
            this.data = new T[size];
        }

        //Propietats
        public T this[int index]
        {
            get { return data[index]; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public bool IsFull
        {
            get { return data.Length - 1 == top; }
        }
        public bool IsEmpty
        {
            get { return top == -1; }
        }
        public int Count
        {
            get { return top + 1; }
        }
        public int Capacity
        {
            get { return data.Length; }
        }
        // Metodes
        public T Pop()
        {
            if (top == -1) { throw new InvalidOperationException("Cap element a mostrar/eliminar"); }
            T item = data[top];
            data[top] = default;
            this.top--;
            return item;
        }
        public T Peek()
        {
            if (top == -1) { throw new InvalidOperationException("Cap element a mostrar");}
            return data[top];
        }
        public void Push (T item)
        {
            if(top == data.Length - 1) { throw new StackOverflowException("La pila es plena"); }
            data[++top] = item;
            
        }
        public T[] ToArray()
        {
            int i = 0;
            T[] newArray = new T[top + 1];
            IEnumerator<T> cursor = this.GetEnumerator();
            while (cursor.MoveNext())
            {
                newArray[i++] = cursor.Current; 
            }
            return newArray;
        }

        public int EnsureCapacity( int newCapacity)
        {
            if(Capacity < newCapacity)
            {
                T[] newData = new T[newCapacity];
                IEnumerator<T> cursor = this.GetEnumerator();
                int i = 0;
                while (cursor.MoveNext())
                {
                    newData[i++] = cursor.Current;
                }
                data = newData;
            }
            return Capacity;
        }
        // Metodes ICollection:
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
        public void Clear()
        {
            if (IsReadOnly) throw new Exception("ICollection<T> es només de lectura");
            top = -1;
        }

        public bool Contains(T item)
        {
            if(item == null) throw new ArgumentNullException($"{item} es null");
            bool found = false;
            IEnumerator<T> cursor = this.GetEnumerator();
            while(!found && cursor.MoveNext())
            {
                found = cursor.Current.Equals(item);
            }
            return found;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null) throw new ArgumentNullException("L'array es null");
            if (arrayIndex < 0) { throw new ArgumentOutOfRangeException("Index està fora de rang"); }
            if ((array.Length - arrayIndex) < top) { throw new ArgumentException("Espai insuficient per copiar els valors"); }
            IEnumerator<T> cursor = this.GetEnumerator();
            while (cursor.MoveNext()) {
                array[arrayIndex++] = cursor.Current;
            }
            
        }
        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            return new EnumeratorPila(this.data, this.top +1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //IENUMERABLE
        public class EnumeratorPila : IEnumerator<T>
        {
            private T[] data;
            private int limit;
            private int position;
            public EnumeratorPila(T[] values, int nElem)
            {
                this.data = values;
                this.position = -1;
                this.limit = nElem;
            }

            public T Current {
                get {
                    if (position == -1 || position >= limit) throw new ArgumentOutOfRangeException("OUT OF RANGE");
                    return data[position];
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                data = default;
            }
            public bool MoveNext()
            {
                bool movable = true;
                if (position < limit -1) position++;
                else movable = false;
                return movable;
            }
            public void Reset()
            {
                position = -1;
            }
        }
        public override string ToString()
        {
            StringBuilder sB = new StringBuilder("[");
            IEnumerator<T> cursor = this.GetEnumerator();
            int i = 0;
            while (cursor.MoveNext() && i< top)
            {
                sB.Append(cursor.Current + ", ");
                i++;
            }
            if(top != -1) sB.Append(cursor.Current + "]");
            else sB.Append("]");
            return sB.ToString();
        }
        public override bool Equals(object? obj)
        {
            return true;
        }
    }
}
