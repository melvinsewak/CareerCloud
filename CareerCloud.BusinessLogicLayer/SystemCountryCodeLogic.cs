using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemCountryCodeLogic 
    {
        protected IDataRepository<SystemCountryCodePoco> _repository;

        public SystemCountryCodeLogic(IDataRepository<SystemCountryCodePoco> repository) 
        {
            _repository = repository;
        }

        protected void Verify(SystemCountryCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (string.IsNullOrWhiteSpace(poco.Code))
                    exceptions.Add(new ValidationException(900, $"Code for SystemCountryCode {poco.Code} cannot be null or empty"));
                if (string.IsNullOrWhiteSpace(poco.Name))
                    exceptions.Add(new ValidationException(901, $"Name for SystemCountryCode {poco.Code} cannot be null or empty"));
            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }

        public virtual SystemCountryCodePoco Get(string code)
        {
            return _repository.GetSingle(c => c.Code == code);
        }

        public virtual List<SystemCountryCodePoco> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public virtual void Add(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            _repository.Add(pocos);
        }

        public void Update(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            _repository.Update(pocos);
        }

        public void Delete(SystemCountryCodePoco[] pocos)
        {
            _repository.Remove(pocos);
        }
    }

}
