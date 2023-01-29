using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Mongo
{
    public class MongoCourseDal : MongoDbRepositoryBase<Course>,ICourseDal
    {
        public MongoCourseDal(IMongoDbSettings settings) : base(settings)
        {
        }
    }
}
