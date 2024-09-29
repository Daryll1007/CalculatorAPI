using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CalculatorController : ControllerBase
	{
		// Add method
		[HttpGet("add")]
		public IActionResult Add(decimal number1, decimal number2)
		{
			var result = number1 + number2;
			return Ok(result);
		}

		// Subtract method
		[HttpGet("subtract")]
		public IActionResult Subtract(decimal number1, decimal number2)
		{
			var result = number1 - number2;
			return Ok(result);
		}

		// Multiply method
		[HttpGet("multiply")]
		public IActionResult Multiply(decimal number1, decimal number2)
		{
			var result = number1 * number2;
			return Ok(result);
		}

		// Divide method
		[HttpGet("divide")]
		public IActionResult Divide(decimal number1, decimal number2)
		{
			if (number2 == 0)
			{
				return BadRequest("Division by zero is not allowed.");
			}
			var result = number1 / number2;
			return Ok(result);
		}

		// Modulo method
		[HttpGet("modulo")]
		public IActionResult Modulo(decimal number1, decimal number2)
		{
			if (number2 == 0)
			{
				return BadRequest("Modulo by zero is not allowed.");
			}
			var result = number1 % number2;
			return Ok(result);
		}
	}
}
