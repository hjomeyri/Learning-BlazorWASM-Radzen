using System.Collections.Generic;
using Gmx.FilterUtility;
using Gmx.SortingUtility;

namespace Gmx
{
    public class PaginatedInputModel : object
    {
        public PaginatedInputModel()
        {
            _pageNumber = 1;
            _pageSize = 25;
        }
        private int _pageNumber;

        private int _pageSize;
        public IEnumerable<SortingParams> SortingParams { set; get; }
        public IEnumerable<FilterParams> FilterParam { get; set; }
        public IEnumerable<string> GroupingColumns { get; set; } = null;

        public int PageNumber
        {
            get => _pageNumber;
            set
            {
                if (value > 1) _pageNumber = value;
            }
        }

        public int PageSize
        {
            get => _pageSize;
            set
            {
                if (value > 1) _pageSize = value;
            }
        }
    }
}