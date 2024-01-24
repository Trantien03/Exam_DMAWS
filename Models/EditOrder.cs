using System.ComponentModel.DataAnnotations;

namespace baithiDMAWS.Models
{
    public class EditOrder
    {
        [Required(ErrorMessage = "Please Enter Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Delivery Time")]

        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "{0:YY-MM-DD}", ApplyFormatInEditMode = true)]
        public DateTime OrderDelivery { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string OrderAddress { get; set; }
    }
}
