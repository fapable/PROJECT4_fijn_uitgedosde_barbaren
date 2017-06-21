using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaar_1_Project_4 {
    class VisitorDesignPattern {
    }
    public interface IOption<T> {
        U Visit<U>(Func<T, U> someLambda, Func<U> noneLambda);
    }
    public class Some<T> : IOption<T> {
        T value;
        public Some(T value) {
            this.value = value;
        }

        public U Visit<U>(Func<T, U> someLambda, Func<U> noneLambda) {
            return someLambda(this.value);
        }
        
    }
    public class None<T> : IOption<T> {
        public U Visit<U>(Func<T, U> someLambda, Func<U> noneLambda) {
            return noneLambda();
        }
    }
}
