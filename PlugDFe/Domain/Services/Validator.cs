using PlugDFe.Domain.Entities;
using PlugDFe.Domain.ValueObjects;

namespace PlugDFe.Domain.Services
{
    public abstract class Validator<T> : Notifiable<Notification>
    {
        public Validator<T> IsNull(string value)
        {
            if (string.IsNullOrEmpty(value)) { AddNotification("Valor Nulo", "O Valor não deve ser nulo!"); }

            return this;
        }

        public Validator<T> IsLowerThen(string value, int minValue)
        {
            if (value.Length < minValue) { AddNotification("Valor Pequeno", $"O Valor não deve conter menos que {minValue} caracteres!"); }

            return this;
        }

        public Validator<T> IsBiggerThen(string value, int maxValue)
        {
            if (value.Length < maxValue) { AddNotification("Valor Pequeno", $"O Valor não deve conter mais que {maxValue} caracteres!"); }

            return this;
        }

        public Validator<T> IsNumber(string value)
        {            
            bool isNumeric = int.TryParse(value, out int n);

            if (!isNumeric) { AddNotification("Não é Numero", "O Valor informado não é um número!"); }

            return this;
        }
    }
}
