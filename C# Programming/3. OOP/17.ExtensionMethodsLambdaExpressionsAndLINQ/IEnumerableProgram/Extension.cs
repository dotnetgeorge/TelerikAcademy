namespace IEnumerableProgram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Extension
    {
        public static decimal Sum<T>(this IEnumerable<T> enums)
        {
            if (enums.Count() == 0)
            {
                throw new ArgumentException("List must have at least one element!");
            }

            decimal result = 0;

            foreach (var item in enums)
            {
                result += Convert.ToDecimal(item);
            }

            return result;
        }

        public static decimal Average<T>(this IEnumerable<T> enums)
        {
            if (enums.Count() == 0)
            {
                throw new ArgumentException("List must have at least one element!");
            }

            decimal result = 0;
            foreach (var item in enums)
            {
                result += Convert.ToDecimal(item);
            }
            return result / enums.Count();
        }

        public static decimal Product<T>(this IEnumerable<T> enums)
        {
            if (enums.Count() == 0)
            {
                throw new ArgumentException("List must have at least one element!");
            }

            decimal result = 1;
            foreach (var item in enums)
            {
                result *= Convert.ToDecimal(item);
            }
            return result;
        }

        public static decimal Min<T>(this IEnumerable<T> enums)
        {
            if (enums.Count() == 0)
            {
                throw new ArgumentException("List must have at least one element!");
            }

            decimal min = decimal.MaxValue;
            foreach (var item in enums)
            {
                if (Convert.ToDecimal(item) < min)
                {
                    min = Convert.ToDecimal(item);
                }
            }
            return min;
        }

        public static decimal Max<T>(this IEnumerable<T> enums)
        {
            if (enums.Count() == 0)
            {
                throw new ArgumentException("List must have at least one element!");
            }

            decimal max = decimal.MinValue;
            foreach (var item in enums)
            {
                if (Convert.ToDecimal(item) > max)
                {
                    max = Convert.ToDecimal(item);
                }
            }
            return max;
        }
    }
}