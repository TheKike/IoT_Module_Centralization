using IoT_Module_Centralization.DataAccess.Abstract;
using IoT_Module_Centralization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_Module_Centralization.DataAccess.Repositories
{
    internal class UnitRepository : IUnitRepository
    {
        public bool IsInTransaction => throw new NotImplementedException();

        public void Add(Unit unit)
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

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Unit> GetAll()
        {
            throw new NotImplementedException();
        }

        public Unit GetById(Guid id)
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

        public void Update(Unit unit)
        {
            throw new NotImplementedException();
        }
    }
}
