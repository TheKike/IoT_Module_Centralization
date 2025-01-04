using Condominio.DataAccess.Abstract;
using IoT_Module_Centralization.Domain.Entities;

namespace IoT_Module_Centralization.DataAccess.Abstract
{
    public interface IMessageRepository : IRepository
    {
        public Message GetById(Guid id);
        public IEnumerable<Message> GetAll();
        public IEnumerable<Message> GetByPriority(string priority);
        public void Add(Message message);
    }
}
