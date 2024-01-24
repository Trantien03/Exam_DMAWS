using System.ComponentModel.DataAnnotations;

namespace baithiDMAWS.Models
{
    public class CreateOrder
    {
        [Required(ErrorMessage = "Please Enter Code")]
        public string ItemCode { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Please Enter Quantity")]
        public int ItemQty { get; set; }

        [Required(ErrorMessage = "Please Enter Delivery Time")]
        public DateTime OrderDelivery { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string OrderAddress { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
