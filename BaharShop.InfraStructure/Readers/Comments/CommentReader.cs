using BaharShop.Domain.Entities.Comments;
using BaharShop.Domain.IReaders.Comments;
using BaharShop.InfraStructure.DBContext;

namespace BaharShop.InfraStructure.Readers.Comments
{
    public class CommentReader : GenericReader<Comment>, ICommentReader
    {
        public CommentReader(BaharShopDBContext dbContext) : base(dbContext)
        {
        }
    }
}