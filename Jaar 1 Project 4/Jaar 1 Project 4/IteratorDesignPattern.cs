using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Iterator design pattern

namespace Jaar_1_Project_4 {
    class IteratorDesignPattern {
    }
    public interface Iterator<T> {
        T GetNext();
        void Add(T element);
        void Reset();
        void RemoveElement();
        bool IsNotEmpty();
        int Count();
        T GetCurrent();

    }
    public class ListIterator<T> : Iterator<T> {
        int current = -1;
        int elements = 0;
        List<T> list;
        public ListIterator() {
            this.list = new List<T>();
        }
        public T GetNext() {
            if (current <= list.Count - 1) {
                current++;
                return list[current];
            }
            else {
                return default(T);
            }
        }
        public void Add(T element) {
            this.current++;
            this.elements++;
            this.list[current] = element;
        }
        public void Reset() {
            this.current = -1;
        }
        public bool IsNotEmpty() {
            return this.current < this.list.Count - 1;
        }
        public T GetCurrent() {
            return list[current];
        }

        public void RemoveElement() {
            elements--;
            list.RemoveAt(current);
          
        }
        public int Count() {
            return elements;
        }
    }
}
