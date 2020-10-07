using System.Threading.Tasks;
using KafkaProducerDemo.DTO.Order;
using Microsoft.AspNetCore.Mvc;

namespace KafkaProducerDemo.Controllers {
    
    [Route("[controller]")]
    public class OrderController : ControllerBase {

        [HttpPost]
        public IActionResult CreateOrderAsync(CreateOrderDto order) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            return Created("TransactionId", "Your order is in progress");
        }
        
    }
}
