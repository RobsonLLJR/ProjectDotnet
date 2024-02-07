using ProjectDotnet.Core.Data;
using ProjectDotnet.Core.Dto.PointSaleDtos;
using ProjectDotnet.Core.Filter.PointSaleFilter;
using ProjectDotnet.Core.Repository.PointSaleRepository;

namespace ProjectDotnet.Core.Service.PointSaleService
{
    public class PointSaleService(DataContext context) : IPointSaleService
    {
        protected PointSaleRepository PointSaleRepository { get; init; } = new(context);
        public async Task<(int, List<GetPointSaleDto>)> CountList(PointSaleFilter filter) =>
            (await Count(filter), await List(filter));
        private async Task<int> Count(PointSaleFilter filter) =>
            await PointSaleRepository.Count(filter);
        private async Task<List<GetPointSaleDto>> List(PointSaleFilter filter) =>
            await PointSaleRepository.List(filter);
    }
}
