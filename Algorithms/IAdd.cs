using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
	public  interface IAdd<T> : IComparable<T>
    {
        T Add( T right);
    }
}
