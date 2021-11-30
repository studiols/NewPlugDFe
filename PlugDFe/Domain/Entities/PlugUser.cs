using PlugDFe.Domain.Services;
using PlugDFe.Domain.ValueObjects;
using System;

namespace PlugDFe.Domain.Entities
{
    public class PlugUser : Notifiable<Notification>
    {
        public PlugUser(string email, string password, int idCompany, string unitCode) : base()
        {
            this.Email = email;
            this.Password = password;
            this.IdCompany = idCompany;
            this.UnitCode = unitCode;
        }

        public int Id { get; private set; }
        public string UnitCode { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public int IdCompany { get; private set; }
        public string Token { get; private set; }
        public DateTime Validate { get; private set; }

        public void SetToken(string token)
        {
            this.Token = token;
        }

        public void SetValidate(DateTime validate)
        {
            this.Validate = validate;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public void SetUnitCode(string unitCode)
        {
            this.UnitCode = unitCode;
        }
    }
}
