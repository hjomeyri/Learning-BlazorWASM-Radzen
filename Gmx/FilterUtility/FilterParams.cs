using Gmx.Enums;

namespace Gmx.FilterUtility
{
    public class FilterParams : object
    {
        public FilterParams()
        {
            ColumnName = string.Empty;
            FilterValue = string.Empty;
            FilterOption = FilterOptions.Contains;
        }

        public string ColumnName { get; set; }
        public string FilterValue { get; set; }
        public FilterOptions FilterOption { get; set; }
    }
}