using System;
using System.Collections.Generic;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobEducationLogic : BaseLogic<CompanyJobEducationPoco>
    {
        public CompanyJobEducationLogic(IDataRepository<CompanyJobEducationPoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyJobEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override CompanyJobEducationPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<CompanyJobEducationPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(CompanyJobEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyJobEducationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (string.IsNullOrWhiteSpace(poco.Major))
                    exceptions.Add(new ValidationException(200, $"Major for CompanyJobEducation {poco.Id} cannot be null or empty"));
                else if (poco.Major.Length < 2)
                    exceptions.Add(new ValidationException(200, $"Major for CompanyJobEducation {poco.Id} cannot be less than 2 characters"));

                if (poco.Importance < 0)
                    exceptions.Add(new ValidationException(201, $"Major for CompanyJobEducation {poco.Id} cannot be negative"));
            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }
    }

}
