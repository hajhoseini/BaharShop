namespace BaharShop.Application.DTOs.Finances
{
    public class ResultRequestPayDTO
    {
        public Guid Guid { get; set; }

        public decimal Amount { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public int PayId { get; set; }
    }
}
