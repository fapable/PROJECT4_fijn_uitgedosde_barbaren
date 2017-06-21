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
        IClassicOption<T> GetNext();
    }
    public class ArrayIterator<T> : Iterator<T> {
        int current = -1;
        int elements = 0;
        T[] array;
        public ArrayIterator() {
            this.array = new T[2];
        }
        public IClassicOption<T> GetNext() {
            if (current < array.Length - 1) {
                return new NoneLogin<T>();
            }
            else {
                return new SomeLogin<T>(array[current]);
            }
        }
        public void Add(T element) {
            this.current++;
            this.elements++;
            this.array[current] = element;
        }
        public void Reset() {
            this.current = 1;
        }
        public bool Count() {
            return this.current < array.Length - 1;
        }
        public T GetCurrent() {
            return array[current];
        }
        public T Iterate() {
            if (this.Count()) {
                current++;
                return array[current];
            }
            else {
                return default(T);
            }
        }
    }
}
