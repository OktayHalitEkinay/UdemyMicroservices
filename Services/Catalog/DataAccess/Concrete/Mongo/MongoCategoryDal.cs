using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.Mongo
{
    public class MongoCategoryDal : MongoDbRepositoryBase<Category>, ICategoryDal
    {
        public MongoCategoryDal(IMongoDbSettings settings) : base(settings)
        {
        }
    }
}
