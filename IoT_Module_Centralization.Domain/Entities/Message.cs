using IoT_Module_Centralization.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace IoT_Module_Centralization.Domain.Entities
{
    public class Message : BaseEntity
    {
        #region Propiedades

        /// <summary>
        /// Texto del mensaje
        /// </summary>
        public string Content { get; private set; } = string.Empty;

        /// <summary>
        /// Fecha y hora en que se generó
        /// </summary>
        public DateTime Timestamp { get; private set; }

        /// <summary>
        /// Prioridad (baja, media, alta)
        /// </summary>
        public MessagePriority Priority { get; private set; }


        // Relación: Un mensaje es generado por un módulo

        /// <summary>
        /// Clave foránea del módulo
        /// </summary>
        [NotMapped]
        public Guid ModuleId { get; private set; }

        /// <summary>
        /// Propiedad de navegación al módulo
        /// </summary>
        [NotMapped]
        public Module Module { get; private set; }
        #endregion

        #region Constructores

        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
#pragma warning disable CS8618
        // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        protected Message() { }
#pragma warning restore CS8618

        public Message(string content, DateTime timestamp, Module module, MessagePriority priority = MessagePriority.Low)
        {
            Content = content;
            Timestamp = timestamp;
            Priority = priority;
            Module = module;
        }
        #endregion
    }
}
