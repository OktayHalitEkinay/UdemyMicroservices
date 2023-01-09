using Core.Entities.Abstract;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class Document : IDocument
    {

        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
