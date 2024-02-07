using ProjectDotnet.Core.Dto.PointSaleDtos;
using ProjectDotnet.Core.Filter.PointSaleFilter;
using ProjectDotnet.Core.Repository.PointSaleRepository;

namespace ProjectDotnet.Core.Service.CaixaService
{
    public class PointSaleService(PointSaleRepository pointSaleRepository) : IPointSaleService
    {
        protected PointSaleRepository PointSaleRepository { get; init; } = pointSaleRepository;
        public async Task<(int, List<GetPointSaleDto>)> CountList(PointSaleFilter filter) =>
            (await Count(filter), await List(filter));
        private async Task<int> Count(PointSaleFilter filter) =>
            await PointSaleRepository.Count(filter);
        private async Task<List<GetPointSaleDto>> List(PointSaleFilter filter) =>
            await PointSaleRepository.List(filter);
    }
}
