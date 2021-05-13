using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gmx.PaginatedUtility
{
    public class PaginatedList<T> : List<T>
    {
        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalItems = count;
            TotalPages = (int) Math.Ceiling(count / (double) pageSize);

            AddRange(items);
        }

        public int PageIndex { get; }
        public int TotalPages { get; }
        public int TotalItems { get; }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;

        public static async Task<PaginatedList<T>> CreateAsync(IList<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count;
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return await Task.Run(() =>
                new PaginatedList<T>(items, count, pageIndex, pageSize));
        }
    }
}