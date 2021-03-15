using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ForVacancy.Program;

namespace ForVacancy
{
    public interface ICircularList<T> : IList<T>
    {
        void MoveNext();
        void MoveBack();
        T Current { get; }
        T Previous { get; }
        T Next { get; }
    }
    
    public class MyCollection<T> : ICircularList<T>
    {
        private readonly IList<T> mylist = new List<T>();
        int position = 0;
     
        public T Current
        {
            get
            {
                if (mylist.Count != 0)
                {
                    return mylist[position];
                }
                else
                {
                    throw new Exception("Список MyCollection пуст");
                }
            }
        }
        
        public T Previous
        { 
            get
            {
                if(mylist.Count != 0)
                {
                    if (position == 0)
                    {
                        return mylist[mylist.Count - 1];
                    }
                    else
                    {
                        return mylist[position - 1];
                    }
                }
                else
                {
                    throw new Exception("Список MyCollection пуст");
                }
            }
        }
        public T Next
        {
            get
            {
                if(mylist.Count != 0)
                {
                    if (position == mylist.Count - 1)
                    {
                        return mylist[0];
                    }
                    else
                    {
                        return mylist[position + 1];
                    }
                }
                else
                {
                    throw new Exception("Список MyCollection пуст");
                }
            }
        }

        public void MoveNext()
        {
            if (mylist.Count != 0)
            {
                if (position == mylist.Count - 1)
                {
                    position = 0;
                }
                else
                {
                    position++;
                }
            }
            else
            {
                throw new Exception("Список MyCollection пуст");
            }
        }

        public void MoveBack()
        {
            if (mylist.Count != 0)
            {
                if (position == 0)
                {
                    position = mylist.Count - 1;
                }
                else
                {
                    position--;
                }
            }
            else
            {
                throw new Exception("Список MyCollection пуст");
            }
        }

        public int Count
        {
            get { return mylist.Count; }
        }

        public bool IsReadOnly
        {
            get { return mylist.IsReadOnly; }
        }


        public T this[int index]
        {
            get 
            {
                if (mylist.Count == 0)
                {
                    throw new Exception("Список MyCollection пуст");
                }
                else if (index < 0)
                {
                    throw new Exception("index должен быть больше или равен 0");
                }
                else if (index >= mylist.Count)
                {
                    throw new Exception($"index должен быть меньше или равен {mylist.Count - 1}");
                }
                else
                {
                    return mylist[index];
                }

            }

            set 
            {
                if (mylist.Count == 0)
                {
                    throw new Exception("Список MyCollection пуст");
                }
                else if (index < 0)
                {
                    throw new Exception("index должен быть больше или равен 0");
                }
                else if (index >= mylist.Count)
                {
                    throw new Exception($"index должен быть меньше или равен {mylist.Count-1}");
                }
                else
                {
                    mylist[index] = value;
                }
            }
        }



        public int IndexOf(T item)
        {
            if (mylist.Count != 0)
            {
                return mylist.IndexOf(item);
            }
            else
            {
                throw new Exception("Список MyCollection пуст");
            }
            
        }

        public void Insert(int index, T item)
        {
            if (mylist.Count == 0)
            {
                throw new Exception("Список MyCollection пуст");
            }
            else if (index < 0)
            {
                throw new Exception("index должен быть больше или равен 0");
            }
            else if (index >= mylist.Count)
            {
                throw new Exception($"index должен быть меньше или равен {mylist.Count - 1}");
            }
            else
            {
                mylist.Insert(index, item);
            }
            
        }

        public void RemoveAt(int index)
        {
            if (mylist.Count == 0)
            {
                throw new Exception("Список MyCollection пуст");
            }
            else if(index >= mylist.Count)
            {
                throw new Exception($"индекс не должен превышать размер списка {mylist.Count-1}");
            }
            else if (index < 0)
            {
                throw new Exception("индекс не может быть меньше 0");
            }
            else
            {
                if(position > index)
                {
                    position = position-1;
                }
                mylist.RemoveAt(index);
            }
        }

        public bool Remove(T item)
        {
            if (mylist.Count != 0)
            {
                if (mylist.Contains(item))
                {
                    var index = IndexOf(item);
                    if (position > index)
                    {
                        position = position - 1;
                        return mylist.Remove(item);
                    }
                }
                return mylist.Remove(item);
            }
            else
            {
                throw new Exception("Список MyCollection пуст");
            }

        }

        public void Add(T item)
        {
            mylist.Add(item);
        }

        public void Clear()
        {
            if (mylist.Count != 0)
            {
                mylist.Clear();
                position = 0;
            }
            else
            {
                throw new Exception("Список MyCollection пуст");
            }
           
        }

        public bool Contains(T item)
        {
            if (mylist.Count != 0)
            {
                return mylist.Contains(item);
            }
            else
            {
                throw new Exception("Список MyCollection пуст");
            }
            
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (mylist.Count == 0)
            {
                throw new Exception("Список MyCollection пуст");
            }
            else if (arrayIndex < 0)
            {
                throw new Exception("arrayIndex должен быть больше или равен 0");
            }
            else if (arrayIndex >= mylist.Count)
            {
                throw new Exception($"arrayIndex должен быть меньше или равен {mylist.Count - 1}");
            }
            else
            {
                mylist.CopyTo(array, arrayIndex);
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (mylist.Count != 0)
            {
                return mylist.GetEnumerator();
            }
            else
            {
                throw new Exception("Список MyCollection пуст");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (mylist.Count != 0)
            {
                return GetEnumerator();
            }
            else
            {
                throw new Exception("Список MyCollection пуст");
            }
            
        }
    }
 
    public class Person
    {
        //для проверки
        public int num { get; set; }
    }
    class Program
    {
              
        static void Main(string[] args)
        {
                   
        }

    }
        
}
