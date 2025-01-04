using IoT_Module_Centralization.DataAccess.Abstract;
using IoT_Module_Centralization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_Module_Centralization.DataAccess.Repositories
{
    internal class MessageRepository : IMessageRepository
    {
        public bool IsInTransaction => throw new NotImplementedException();

        public void Add(Message message)
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetAll()
        {
            throw new NotImplementedException();
        }

        public Message GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetByPriority(string priority)
        {
            throw new NotImplementedException();
        }

        public void PartialCommit()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
