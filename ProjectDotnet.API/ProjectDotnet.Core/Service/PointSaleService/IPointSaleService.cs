using ProjectDotnet.Core.Dto.PointSaleDtos;
using ProjectDotnet.Core.Filter.PointSaleFilter;

namespace ProjectDotnet.Core.Service.PointSaleService
{
    public interface IPointSaleService
    {
        Task<(int, List<GetPointSaleDto>)> CountList(PointSaleFilter filter);
    }
}
