namespace ProjectDotnet.Core.Models.Domain.POS
{
    public class PointSale
    {
        public virtual int Id { get; set; }
        public virtual DateTime DateOpen { get; set; }
        public virtual DateTime? DateClose { get; set; }
        public virtual string Observation { get; set; } = string.Empty;
    }
}
