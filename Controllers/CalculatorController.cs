using Microsoft.AspNetCore.Mvc;
using CalculatorAPI.Interfaces;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService<decimal> _calculatorService;

        public CalculatorController(ICalculatorService<decimal> calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("add")]
        public ActionResult<decimal> Add([FromBody] OperationRequest request)
        {
            try
            {
                var result = _calculatorService.Add(request.A, request.B);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("subtract")]
        public ActionResult<decimal> Subtract([FromBody] OperationRequest request)
        {
            try
            {
                var result = _calculatorService.Subtract(request.A, request.B);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

    public class OperationRequest
    {
        public decimal A { get; set; }
        public decimal B { get; set; }
    }
}