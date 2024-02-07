namespace ProjectDotnet.Core.Filter.PointSaleFilter
{
    public class PointSaleFilter : Filter
    {
        public DateTime? DateOpenStart { get; set; }
        public DateTime? DateOpenEnd { get; set; }
        public bool? Open { get; set; }
        public string Observation { get; set; } = string.Empty;
    }
}
