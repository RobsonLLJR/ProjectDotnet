using ProjectDotnet.Core.Models.Domain.POS;

namespace ProjectDotnet.Core.Dto.PointSaleDtos
{
    public class GetPointSaleDto : PointSale
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override DateTime DateOpen { get => base.DateOpen; set => base.DateOpen = value; }
        public override DateTime? DateClose { get => base.DateClose; set => base.DateClose = value; }
        public override string Observation { get => base.Observation; set => base.Observation = value; }
    }
}
