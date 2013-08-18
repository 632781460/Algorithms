using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public abstract class ValueTypeWrapper<T> : IAdd<ValueTypeWrapper<T>>  
    {

        protected ValueTypeWrapper(T value)
        {
            Value = value;
        }
        public  T Value { get; private set; }

        public static ValueTypeWrapper<T> Create(T value)
        {
            if (value is Int32)
            {
				
                return new IntValueTypeWrapper((dynamic)value) as ValueTypeWrapper<T>;
            }
            return null;
        }

        public abstract ValueTypeWrapper<T> Add(ValueTypeWrapper<T> right);
        public abstract int CompareTo(ValueTypeWrapper<T> other);
    }
}
