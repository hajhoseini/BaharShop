namespace BaharShop.Application.DTOs.Finances
{
    public class PayDTO
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public Guid Guid { get; set; }

        public string UserName { get; set; }

        public int UserId { get; set; }
        
        public bool IsPay { get; set; }

        public DateTime? PayDate { get; set; }

        public string Authority { get; set; }

        public long RefId { get; set; } = 0;
    }
}
