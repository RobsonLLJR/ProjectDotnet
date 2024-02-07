namespace ProjectDotnet.Core.Filter
{
    public class Filter
    {
        public int PageSize { get; set; } = 10;
        public int Page { get; set; } = 1;
        public string[] ClassificationCriteria { get; set; } = [];
    }
}
