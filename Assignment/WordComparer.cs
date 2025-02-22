using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class WordComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x == null || y == null) 
                return false;

            string X = string.Concat(x.OrderBy(C => C));
            string Y = string.Concat(y.OrderBy(C => C));

            return X == Y;

        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return string.Concat(obj.OrderBy(C => C)).GetHashCode();
        }
    }
}
