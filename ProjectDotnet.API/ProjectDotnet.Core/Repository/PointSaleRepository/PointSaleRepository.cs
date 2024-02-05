using ProjectDotnet.Core.Data;
using ProjectDotnet.Core.Models.Domain.POS;

namespace ProjectDotnet.Core.Repository.PointSaleRepository
{
    public class PointSaleRepository : RepositoryBase<PointSale>
    {
        public PointSaleRepository(DataContext context) : base(context) { }
    }
}
