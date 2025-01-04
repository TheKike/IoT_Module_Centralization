using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IoT_Module_Centralization.Domain.Common
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Identificador único
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; protected set; } = Guid.NewGuid();

        // Método para comparar entidades por su ID
        public override bool Equals(object? obj)
        {
            if (obj is not BaseEntity other)
                return false;

            return Id == other.Id;
        }

        // Generar un hash basado en el ID
        public override int GetHashCode() => Id.GetHashCode();

        // Operadores de igualdad y desigualdad para comparar entidades
        public static bool operator ==(BaseEntity? a, BaseEntity? b)
        {
            if (a is null && b is null) return true;
            if (a is null || b is null) return false;
            return a.Equals(b);
        }

        public static bool operator !=(BaseEntity? a, BaseEntity? b) => !(a == b);
    }
}
