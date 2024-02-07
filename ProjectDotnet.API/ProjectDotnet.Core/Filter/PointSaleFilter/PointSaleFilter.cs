using System.ComponentModel.DataAnnotations;

namespace ProjectDotnet.Core.Filter.PointSaleFilter
{
    public class PointSaleFilter : Filter
    {
        public DateTime? DateOpenStart { get; set; }
        public DateTime? DateOpenEnd { get; set; }
        [Display(Name = "Observação")]
        public string Observation { get; set; } = null;
    }
}
