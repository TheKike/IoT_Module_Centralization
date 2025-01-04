using Condominio.DataAccess.Abstract;
using IoT_Module_Centralization.Domain.Entities;

namespace IoT_Module_Centralization.DataAccess.Abstract
{
    public interface IUnitRepository : IRepository
    {
        public Unit GetById(Guid id);
        public IEnumerable<Unit> GetAll();
        public void Add(Unit unit);
        public void Update(Unit unit);
        public void Delete(Guid id);
    }
}
