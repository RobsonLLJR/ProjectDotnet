using Microsoft.EntityFrameworkCore;
using ProjectDotnet.Core.Data;
using ProjectDotnet.Core.Dto.PointSaleDtos;
using ProjectDotnet.Core.Filter.PointSaleFilter;
using ProjectDotnet.Core.Models.Domain.POS;
using System.Linq.Expressions;
namespace ProjectDotnet.Core.Repository.PointSaleRepository
{
    public class PointSaleRepository(DataContext context) : RepositoryBase<PointSale>(context)
    {
        public async Task<int> Count(PointSaleFilter filter) =>
            await _context.PointSale.CountAsync(Expresion(filter));
        public async Task<List<GetPointSaleDto>> List(PointSaleFilter filter)
        {
            IQueryable<PointSale> returnQuery = _context.PointSale.Where(Expresion(filter));
            if (filter.ClassificationCriteria != null)
                Order(returnQuery, filter.ClassificationCriteria);
            return await returnQuery.Skip(filter.PageSize * (filter.Page - 1)).Take(filter.PageSize).Select(x => new GetPointSaleDto()
            {
                Id = x.Id,
                DateOpen = x.DateOpen,
                DateClose = x.DateClose,
                Observation = x.Observation,
            }).ToListAsync();
        }
        private static Expression<Func<PointSale, bool>> Expresion(PointSaleFilter filter) =>
            x =>
            (
                filter.DateOpenStart == null || x.DateOpen >= filter.DateOpenStart
            )
            &&
            (
                filter.DateOpenEnd == null || x.DateOpen <= filter.DateOpenEnd
            )
            &&
            (
                filter.Open == null || x.DateClose.Equals(null)
            )
            &&
            (
                filter.Observation == null || x.Observation.Contains(filter.Observation)
            );
        private static IQueryable<PointSale> Order(IQueryable<PointSale> pointSales, string[] classificationCriteria)
        {
            for (int i = 0; i <= classificationCriteria.Length; i++)
            {
                _ = classificationCriteria[i] switch
                {
                    "DateOpen" => pointSales.OrderBy(x => x.DateOpen),
                    "DateOpen DESC" => pointSales.OrderByDescending(x => x.DateOpen),
                    "DateClose" => pointSales.OrderBy(x => x.DateClose),
                    "DateClose DESC" => pointSales.OrderByDescending(x => x.DateClose),
                    _ => throw new NotImplementedException()
                };
            }
            return pointSales;
        }
    }
}
