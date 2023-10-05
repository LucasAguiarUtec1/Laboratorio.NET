using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Pagos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        [ProducesResponseType(typeof(String), 200)]
        [HttpPost]
        public IActionResult Post([FromBody] String numberCard)
        {
            String message = "";
            String lastDigit = numberCard.Substring(numberCard.Length - 1);
            if (lastDigit == "0")
            {
                message = "OK";
            }
            else if (lastDigit == "1")
            {
                message = "SALDO INSUFICIENTE";
            }
            else if (lastDigit == "2")
            {
                message = "TARJETA VENCIDA";
            }
            else if (lastDigit == "3")
            {
                message = "CODIGO VERIFICACION INCORRECTO";
            }
            else if (lastDigit == "4")
            {
                message = "TIMEOUT";
            }
            else if (lastDigit == "5")
            {
                message = "OK";
            }
            else if (lastDigit == "6")
            {
                message = "SALDO INSUFICIENTE";
            }
            else if (lastDigit == "7")
            {
                message = "TARJETA VENCIDA";
            }
            else if (lastDigit == "8")
            {
                message = "CODIGO VERIFICACION INCORRECTO";
            }
            else
            {
                message = "TIMEOUT";
            }
            return Ok(message);
        }
    }
}
