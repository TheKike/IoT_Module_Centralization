using IoT_Module_Centralization.Domain.Common;
using IoT_Module_Centralization.Domain.ValueObject;
using System.ComponentModel.DataAnnotations.Schema;

namespace IoT_Module_Centralization.Domain.Entities
{
    public class Unit : BaseEntity
    {
        #region Propiedades

        [NotMapped]
        public CodigoUnidad Code { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Area { get; private set; } = string.Empty;

        /// <summary>
        /// Identificador del módulo al que hace referencia
        /// </summary>
        public Guid ModuloId { get; private set; }
        /// <summary>
        /// Módulo al que hace referencia
        /// </summary>
        [NotMapped]
        public Modulo Modulo { get; private set; }
        #endregion

        #region Constructores

        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected Unit() { }
 
        public Unit(CodigoUnidad code, string name, string area, Modulo Modulo)
        {
            Code = code;
            Name = name;
            Area = area;
            Modulo = Modulo;
            ModuloId = Modulo.Id;
        }
        #endregion
    }
}
