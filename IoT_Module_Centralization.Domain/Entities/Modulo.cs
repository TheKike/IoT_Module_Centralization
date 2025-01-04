using IoT_Module_Centralization.Domain.Common;
using IoT_Module_Centralization.Domain.Enums;
using IoT_Module_Centralization.Domain.ValueObject;
using System.ComponentModel.DataAnnotations.Schema;

namespace IoT_Module_Centralization.Domain.Entities
{
    public class Modulo : BaseEntity
    {
        #region Propiedades

        /// <summary>
        /// Nombre del Módulo
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Dirección IP del Módulo
        /// </summary>
        [NotMapped]
        public IpAddress IpAddress { get; protected set; }

        /// <summary>
        /// Puerto del Módulo
        /// </summary>
        [NotMapped]
        public Port Port { get; protected set; }

        /// <summary>
        /// Estado del Módulo
        /// </summary>
        public ModuloStatus Status { get; protected set; }

        /// <summary>
        /// Lista de Unidades del Módulo
        /// </summary>
        [NotMapped]
        public ICollection<Unit> Units { get; protected set; } = new List<Unit>();
        #endregion

        #region Constructores

        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected Modulo() { }

        public Modulo(string name, IpAddress ipAddress, Port port, ModuloStatus status)
        {
            Name = name;
            IpAddress = ipAddress;
            Port = port;
            Status = status;
        }
        #endregion
    }
}
