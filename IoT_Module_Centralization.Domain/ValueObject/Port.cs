namespace IoT_Module_Centralization.Domain.ValueObject
{
    public class Port
    {
        public readonly int Value;

        // Constructor que valida el puerto
        private Port(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Metodo fábrica para crear un puerto de forma segura: entre 1 y 65535.
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see cref="null"/> si el puerto esta fuera de rango. Un <see cref="Port"/> en caso contrario.</returns>
        public static Port? CreatePort(int value)
            => value < 1 || value > 65535 ? null : new Port(value);
        //TODO: aconsejo remplazar esta lógica de creacion de forma segura a otro metodo donde se aplique la lógica del negocio y se valide el dato por el metodo de ingreso del puerto. De todas formas esto es seguro a nivel de backend pero complejiza su utilización innecesariamente...


        /// <summary>
        /// Método que compara dos puertos para la igualdad
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Port other && other.Value == Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(Port left, Port right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Port left, Port right)
        {
            return !(left == right);
        }

        public override string ToString() => Value.ToString();
    }
}
