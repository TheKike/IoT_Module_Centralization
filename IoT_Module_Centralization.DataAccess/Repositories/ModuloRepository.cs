using IoT_Module_Centralization.DataAccess.Abstract;
using IoT_Module_Centralization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_Module_Centralization.DataAccess.Repositories
{
    internal class ModuloRepository : IModuloRepository
    {
        public bool IsInTransaction => throw new NotImplementedException();

        public void Add(Modulo Modulo)
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

        public IEnumerable<Modulo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Modulo GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IsModuloConnected(Modulo Modulo)
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

        public void Update(Modulo Modulo)
        {
            throw new NotImplementedException();
        }
    }
}
