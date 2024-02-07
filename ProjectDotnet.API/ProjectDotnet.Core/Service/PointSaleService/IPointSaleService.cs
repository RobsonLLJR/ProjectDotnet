using ProjectDotnet.Core.Dto.PointSaleDtos;
using ProjectDotnet.Core.Filter.PointSaleFilter;

namespace ProjectDotnet.Core.Service.CaixaService
{
    public interface IPointSaleService
    {
        Task<(int, List<GetPointSaleDto>)> CountList(PointSaleFilter filter);
    }
}
