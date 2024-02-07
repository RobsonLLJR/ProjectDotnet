using ProjectDotnet.Core.Extensions;
using ProjectDotnet.Core.Models.Domain.PointSale;
using System.ComponentModel.DataAnnotations;

namespace ProjectDotnet.Core.Dto.PointSaleDtos
{
    public class GetPointSaleDto : PointSale
    {
        [Display(Name = "ID")]
        public override int Id { get => base.Id; set => base.Id = value; }
        [Display(Name = "Data Abertura")]
        [DisplayFormat(DataFormatString = Constants.DDMMYYYY)]
        public override DateTime DateOpen { get => base.DateOpen; set => base.DateOpen = value; }
        [Display(Name = "Data Fechamento")]
        [DisplayFormat(DataFormatString = Constants.DDMMYYYY)]
        public override DateTime? DateClose { get => base.DateClose; set => base.DateClose = value; }
        [Display(Name = "Observação")]
        public override string Observation { get => base.Observation; set => base.Observation = value; }
    }
}
