using IoT_Module_Centralization.Domain.Common;
using IoT_Module_Centralization.Domain.ValueObjects;

namespace IoT_Module_Centralization.Domain.Entities
{
    public class Unit : BaseEntity
    {
        #region Propiedades
        
        ///
        public CodigoUnidad Code { get; private set; }
        public string Name { get; private set; }
        public string Area { get; private set; }

        public Guid ModuleId { get; private set; }
        public Module Module { get; private set; }
        #endregion

        #region Constructores

        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
#pragma warning disable CS8618
        // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        protected Unit() { }
#pragma warning restore 


        public Unit(CodigoUnidad code, string name, string area, Module module)
        {
            Code = code;
            Name = name;
            Area = area;
            Module = module;
            ModuleId = module.Id;
        }
        #endregion
    }
}
