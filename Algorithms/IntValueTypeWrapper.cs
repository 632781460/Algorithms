using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
	public   class IntValueTypeWrapper : ValueTypeWrapper<int>
    {
        public IntValueTypeWrapper(int value)
            : base(value)
        {
        }

        public override ValueTypeWrapper<int> Add(ValueTypeWrapper<int> right)
        {
            return ValueTypeWrapper<int>.Create(right.Value + this.Value);
        }

        public override int CompareTo(ValueTypeWrapper<int> other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}
