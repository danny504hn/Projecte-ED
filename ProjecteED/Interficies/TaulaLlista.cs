using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteED
{
    public class TaulaLlista<T> : ICollection<T>, IList<T>
    {
        public const int DEFAULT_SIZE = 5;
        private T[] dades;
        private int nElem;

        public int Count
        {
            get { return this.nElem; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public T this[int index]
        {
            get
            {
                return dades[index];
            }
            set
            {
                dades[index] = value;
            }
        }

        public TaulaLlista(int capacitatInicial)
        {
            this.dades = new T[capacitatInicial];
            this.nElem = 0;
        }

        public TaulaLlista() : this(DEFAULT_SIZE)
        {
        }
        /// <summary>
        /// Copia les dades de taulallista2 en la nostra taulallista
        /// </summary>
        /// <param name="TaulaLlista2">taulallista passada per parametre</param>
        public TaulaLlista(TaulaLlista<T> TaulaLlista2)
        {
            this.dades = new T[TaulaLlista2.dades.Length];
            this.nElem = TaulaLlista2.nElem;
            for (int i = 0; i < nElem; i++)
            {
                this.dades[i] = TaulaLlista2.dades[i];
            }

        }

        /// <summary>
        /// constructor que donat un array copia les dades de l'array en la taula llista
        /// </summary>
        /// <param name="array">array a copiar</param>
        public TaulaLlista(T [] array)
        {
            this.dades = new T[array.Length * 2];
            for(int i = 0; i< array.Length; i++)
            {
                this.dades[i] = array[i];
            }
            this.nElem = array.Length;
        }


        /// <summary>
        /// Obte el enumerador propi creat
        /// </summary>
        /// <returns>el enumerador</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new ElMeuEnumerator(this.dades, this.nElem);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class ElMeuEnumerator : IEnumerator<T>
        {
            private T[] dades;
            private int limit;
            private int position;

            public ElMeuEnumerator(T[] dades, int nElem)
            {
                this.dades = dades;
                this.position = -1;
                this.limit = nElem;
            }

            /// <summary>
            /// Retorna l'element actual, si no hi ha posicio genera una exception
            /// </summary>
            public T Current {
                get { 
                    if (position == -1 || position >= limit) throw new ArgumentOutOfRangeException("OUT OF RANGE");
                    return dades[position];
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            /// <summary>
            /// es desfa de les dades
            /// </summary>
            public void Dispose()
            {
                this.dades = default;
            }

            /// <summary>
            /// Comprova si la posicio es menor que el limit, si es aixi es moura
            /// </summary>
            /// <returns>true o fals depenent si s'ha pogut moure</returns>
            public bool MoveNext()
            {
                bool esPotMoure = true;
                if(position + 1 < limit) position++;
                else esPotMoure = false;
                return esPotMoure;
            }

            /// <summary>
            /// Reseteja el contador
            /// </summary>
            public void Reset()
            {
                position = -1;
            }
        }

        /// <summary>
        /// Modifica l'array "dades" duplicant el seu length
        /// i copiant els elements sobre l'array
        /// duplicat
        /// </summary>
        public void DoubleCapacity()
        {
            T[] dadesDoble = new T[dades.Length * 2];
            for (int i = 0; i < nElem; i++)
            {
                dadesDoble[i] = dades[i];
            }
            dades = dadesDoble;
        }

        /// <summary>
        /// Afegeix un item a la col·lecció
        /// </summary>
        /// <param name="item">item a ser afegit</param>
        /// <exception cref="NotSupportedException">la col·lecio es nomes de lectura per tant no es pot modificar</exception>
        public void Add(T item)
        {
            if (IsReadOnly) throw new NotSupportedException("LA COLLECIÓ ES DE NOMÉS LECTURA");
            if (nElem == dades.Length)
            {
                DoubleCapacity();
            }
            this.dades[nElem] = item;
            nElem++;
        }

        /// <summary>
        /// Elimina totes les dades de l'array
        /// i el  deixa en default
        /// </summary>
        public void Clear()
        {
            //int i = 0;
            //IEnumerator<T> cursor = this.GetEnumerator();
            //while (cursor.MoveNext())
            //{
            //    this.dades[i++] = default(T);
            //}
            nElem = 0;

        }

        /// <summary>
        /// Busca l'item en les dades si el troba retorna true, si no retorna fals
        /// </summary>
        /// <param name="item">item a buscar</param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            bool trobat = false;
            int i = IndexOf(item);
            if (i != -1) trobat = true;
            return trobat;
        }
        /// <summary>
        /// Copia els elements de la taulallista en un array passat com a parametre i comença la copia des de l'index passat com a paramatre
        /// </summary>
        /// <param name="array">array on copiar les dades</param>
        /// <param name="arrayIndex">index desde el cual començar a copiar les dades</param>
        /// <exception cref="ArgumentNullException">si l'array es null llança una exception</exception>
        /// <exception cref="ArgumentOutOfRangeException">si l'index esta fora de rang llança una exception</exception>
        /// <exception cref="ArgumentException">Si l'index desde on comença l'array no te la capacitat suficiente per guardar les dades es llança una exception</exception>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null) throw new ArgumentNullException("EL ARRAY ES NULL");
            if (arrayIndex < 0 || arrayIndex> array.Length) { throw new ArgumentOutOfRangeException("L'INDEX ESTA FORA DEL RANG"); }
            if ((array.Length - arrayIndex) < nElem) { throw new ArgumentException("NO ES POT COPIAR ELS ITEMS, ESPAI INSUFICIENT"); }

            for (int i = 0; i < nElem; i++)
            {
                array[arrayIndex++] = this.dades[i];
            }
        }
        /// <summary>
        /// Elimina el item passat com a parametre y retorna un true o fals depenenet de si l'ha pogut borrar o no
        /// </summary>
        /// <param name="item">Item a borrar</param>
        /// <returns>True o fals si ha pogut borrar</returns>
        /// <exception cref="Exception"></exception>
        public bool Remove(T item)
        {
            if (IsReadOnly) throw new Exception("ICollection<T> es només de lectura");
            bool found = false;
            int i = IndexOf(item);
            if (i != -1)
            {
                for (int index = i; index < nElem - 1; index++)
                {
                    dades[index] = dades[index + 1];
                }
                nElem--;
                found = true;
            }
            return found;
        }

        /// <summary>
        /// Retorna la posicio del index del item passar com a parametre
        /// </summary>
        /// <param name="item">item a buscar</param>
        /// <returns>la posicio del item, si no el troba retornara -1</returns>
        public int IndexOf(T item)
        {
            int index = 0;
            bool trobat = false;
            while (!trobat && index < nElem)
            {
                if (dades[index].Equals(item))
                {
                    trobat = true;
                }
                else index++;
            }
            if (!trobat) index = -1;
            return index;
        }

        /// <summary>
        /// Insereix l'item passat com a parametre en l'index passat com a parametre
        /// </summary>
        /// <param name="index">INDEX PASSAT COM A PARAMETRE</param>
        /// <param name="item"> ITEM PASSAT COM A PARAMETRE</param>
        /// <exception cref="ArgumentOutOfRangeException">si l'index passat esta fora de rang llança una excepcio</exception>
        /// <exception cref="NotSupportedException">Si la col·leció es nomes de lectura llançara una exception</exception>
        public void Insert(int index, T item)
        {
            if (index > nElem || index < 0) { throw new ArgumentOutOfRangeException("INDEX FORA DE RANG"); };
            if (IsReadOnly) throw new NotSupportedException("IList<T> ÉS NOMÉS DE LECTURA");
            if (nElem == dades.Length) DoubleCapacity();
            int i = nElem - 1;
            while (i >= index)
            {
                dades[i + 1] = dades[i];
                i--;
            }
            dades[index] = item;
            nElem++;
        }

        /// <summary>
        /// Elimina un item en un index passat com a parametre crida al metode remove per fer això
        /// </summary>
        /// <param name="index">index passat com a parametre </param>
        /// <exception cref="ArgumentOutOfRangeException">Si l'index esta fora de rang llança una exception</exception>
        /// <exception cref="NotSupportedException">Si la col·leció es només de lectura llança una excepcio</exception>
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= nElem) { throw new ArgumentOutOfRangeException("L'INDEX ESTÀ FORA DE RANG"); }
            if (IsReadOnly) throw new NotSupportedException("IList<T> ÉS NOMÉS DE LECTURA");
            Remove(dades[index]);
        }

        /// <summary>
        /// Override del toString per retornar les dades en en el seguen patro: [dada,dada,dada]
        /// </summary>
        /// <returns>les dades amb un patro</returns>
        public override string ToString()
        {
            StringBuilder sB = new StringBuilder("[ ");
            IEnumerator<T> cursor = this.GetEnumerator();
            int counter = 0;
            while (cursor.MoveNext() && counter < this.nElem - 1) 
            {
                sB.Append(cursor.Current + " ,");
                counter++;
            }
            if (nElem>0)sB.Append(cursor.Current + "]");
            else sB.Append( "]");
            return sB.ToString();
        }
    }
}
