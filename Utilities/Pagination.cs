using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleAPI.Utilities
{
    public static class Pagination
    {
        public static IEnumerable<TSource> ToPaged<TSource>(this IEnumerable<TSource> source, int page, int pageSize, out int totalCount)
        {
            totalCount = source.Count();
            if (totalCount == 0)
                return null;
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
