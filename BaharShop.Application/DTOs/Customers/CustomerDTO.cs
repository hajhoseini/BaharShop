using BaharShop.Common.Enums;
using System.ComponentModel;

namespace BaharShop.Application.DTOs.Customers
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Description("کاربر")]
        public int UserId { get; set; }

        [Description("نام")]
        public string FirstName { get; set; }

        [Description("نام خانوادگی")]
        public string LastName { get; set; }

        [Description("پست الکترونیک")]
        public string Email { get; set; }

        [Description("شماره همراه")]
        public string MobileNumber { get; set; }

        [Description("تلفن ثابت")]
        public string? PhoneNumber { get; set; }

        [Description("جنسیت")]
        public GenderEnum? Gender { get; set; }

        [Description("تاریخ تولد")]
        public DateTime? BirthDate { get; set; }
    }
}
