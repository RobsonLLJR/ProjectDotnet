using Microsoft.AspNetCore.Mvc;
using ProjectDotnet.Core.Dto.PointSaleDtos;
using ProjectDotnet.Core.Filter.PointSaleFilter;
using ProjectDotnet.Core.Service.CaixaService;

namespace ProjectDotnet.Core.Controllers
{
    public class PointSaleController(IPointSaleService caixaService) : ControllerBase
    {
        private readonly IPointSaleService _pointSaleService = caixaService;
        [HttpGet]
        public IActionResult Index() => View();

        [HttpGet("Get")]
        [AutoValidateAntiforgeryToken]
        public async Task<ActionResult<List<GetPointSaleDto>>> Get([FromQuery] PointSaleFilter filter)
        {
            (int totalRgister, List<GetPointSaleDto> objectsModel) = await _pointSaleService.CountList(filter);
            return PartialView("_List", objectsModel);
        }
        
    }
}
