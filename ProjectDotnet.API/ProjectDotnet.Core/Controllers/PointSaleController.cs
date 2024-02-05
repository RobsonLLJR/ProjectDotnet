using ProjectDotnet.Core.Service.CaixaService;

namespace ProjectDotnet.Core.Controllers
{
    public class PointSaleController : ControllerBase
    {
        private readonly IPointSaleService _caixaService;
        public PointSaleController(IPointSaleService caixaService)
        {
            _caixaService = caixaService;
        }
    }
}
