using System.ComponentModel.DataAnnotations;

namespace KafkaProducerDemo.DTO.Order {
    
    public class CreateOrderDto {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}