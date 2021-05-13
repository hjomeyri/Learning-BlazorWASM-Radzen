using Gmx.Enums;

namespace Gmx.SortingUtility
{
    public class SortingParams : object
    {
        public SortingParams()
        {
            SortOrder = SortOrders.Asc;
        }

        public SortOrders SortOrder { get; set; }
        public string ColumnName { get; set; }
    }
}