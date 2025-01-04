using Condominio.DataAccess.Abstract;
using IoT_Module_Centralization.Domain.Entities;

namespace IoT_Module_Centralization.DataAccess.Abstract
{
    public interface IModuloRepository : IRepository
    {
        public bool IsModuloConnected(Modulo Modulo);
        public Modulo GetById(Guid id);
        public IEnumerable<Modulo> GetAll();
        public void Add(Modulo Modulo);
        public void Update(Modulo Modulo);
        public void Delete(Guid id);
    }
}
