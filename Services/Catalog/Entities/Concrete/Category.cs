using Core.Attributes;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [BsonCollection("Categories")]
    public class Category:MongoDbEntity
    {
        public string Name { get; set; }
    }
}
