using System;
using System.Collections.Generic;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyDescriptionLogic : BaseLogic<CompanyDescriptionPoco>
    {
        public CompanyDescriptionLogic(IDataRepository<CompanyDescriptionPoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override CompanyDescriptionPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<CompanyDescriptionPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyDescriptionPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (string.IsNullOrWhiteSpace(poco.CompanyName))
                    exceptions.Add(new ValidationException(106, $"CompanyName for CompanyDescriptionPoco {poco.Id} cannot be null or empty"));
                else if (poco.CompanyName.Length <= 2)
                    exceptions.Add(new ValidationException(106, $"CompanyName for CompanyDescriptionPoco {poco.Id} must be greater than 2 characters"));

                if (string.IsNullOrWhiteSpace(poco.CompanyDescription))
                    exceptions.Add(new ValidationException(107, $"CompanyDescription for CompanyDescriptionPoco {poco.Id} can not be null or empty"));
                else if (poco.CompanyDescription.Length <= 2)
                    exceptions.Add(new ValidationException(107, $"CompanyDescription for CompanyDescriptionPoco {poco.Id} must be greater than 2 characters"));
            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }
    }

}
