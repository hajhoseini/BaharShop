using Microsoft.EntityFrameworkCore;

namespace BaharShop.InfraStructure.DBContext
{
    public class BaharShopDBContext : DbContext
    {
        public BaharShopDBContext(DbContextOptions<BaharShopDBContext> options) : base(options)
        {
        }
    }
}
