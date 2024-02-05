namespace ProjectDotnet.Core.Models.Domain.POS
{
    public class PointSale
    {
        public int Id { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime? DateClose { get; set; }
        public string Observation { get; set; } = string.Empty;
    }
}
