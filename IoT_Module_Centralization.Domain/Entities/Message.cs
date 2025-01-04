using IoT_Module_Centralization.Domain.Common;
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
        public string Content { get; protected set; } = string.Empty;

        /// <summary>
        /// Fecha y hora en que se generó
        /// </summary>
        public DateTime Timestamp { get; protected set; }

        /// <summary>
        /// Prioridad (baja, media, alta)
        /// </summary>
        public MessagePriority Priority { get; protected set; }


        // Relación: Un mensaje es generado por un módulo

        /// <summary>
        /// Clave foránea del módulo
        /// </summary>
        [NotMapped]
        public Guid ModuloId { get; protected set; }

        /// <summary>
        /// Propiedad de navegación al módulo
        /// </summary>
        [NotMapped]
        public Modulo Modulo { get; protected set; }
        #endregion

        #region Constructores

        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected Message() { }


        public Message(string content, DateTime timestamp, Modulo Modulo, MessagePriority priority = MessagePriority.Low)
        {
            Content = content;
            Timestamp = timestamp;
            Priority = priority;
            Modulo = Modulo;
        }
        #endregion
    }
}
