using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
	public  struct Range<T>
    {
        public int Low { get; set; }

        public int Middle { get; set; }

        public int High { get; set; }

        public T Sum { get; set; }
    }
}
