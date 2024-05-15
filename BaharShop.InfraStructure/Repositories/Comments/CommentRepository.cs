using BaharShop.Domain.Entities.Comments;
using BaharShop.Domain.IRepositories.Comments;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Repositories.Comments
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}