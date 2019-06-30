using System;
using System.Collections.Generic;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyLocationLogic : BaseLogic<CompanyLocationPoco>
    {
        public CompanyLocationLogic(IDataRepository<CompanyLocationPoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyLocationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override CompanyLocationPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<CompanyLocationPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(CompanyLocationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyLocationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (string.IsNullOrWhiteSpace(poco.CountryCode))
                    exceptions.Add(new ValidationException(500, $"CountryCode for CompanyLocation {poco.Id} cannot be null or empty"));
                if (string.IsNullOrWhiteSpace(poco.Province))
                    exceptions.Add(new ValidationException(501, $"Province for CompanyLocation {poco.Id} cannot be null or empty"));
                if (string.IsNullOrWhiteSpace(poco.Street))
                    exceptions.Add(new ValidationException(502, $"Street for CompanyLocation {poco.Id} cannot be null or empty"));
                if (string.IsNullOrWhiteSpace(poco.City))
                    exceptions.Add(new ValidationException(503, $"City for CompanyLocation {poco.Id} cannot be null or empty"));
                if (string.IsNullOrWhiteSpace(poco.PostalCode))
                    exceptions.Add(new ValidationException(504, $"PostalCode for CompanyLocation {poco.Id} cannot be null or empty"));
            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }
    }

}
