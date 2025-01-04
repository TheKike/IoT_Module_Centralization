using IoT_Module_Centralization.Domain.Enums;
using IoT_Module_Centralization.Domain.ValueObjects;

namespace IoT_Module_Centralization.Domain.Entities
{
    public class Module : BaseEntity
    {
        #region Propiedades

        /// <summary>
        /// Nombre del Módulo
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Dirección IP del Módulo
        /// </summary>
        public IpAddress IpAddress { get; private set; }

        /// <summary>
        /// Puerto del Módulo
        /// </summary>
        public Port Port { get; private set; }

        /// <summary>
        /// Estado del Módulo
        /// </summary>
        public ModuleStatus Status { get; private set; }

        /// <summary>
        /// Lista de Unidades del Módulo
        /// </summary>
        public ICollection<Unit> Units { get; private set; } = [];
        #endregion

        #region Constructores

        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
#pragma warning disable CS8618
        // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        protected Module() { }
#pragma warning restore CS8618

        public Module(string name, IpAddress ipAddress, Port port, ModuleStatus status)
        {
            Name = name;
            IpAddress = ipAddress;
            Port = port;
            Status = status;
        }
        #endregion
    }
}
