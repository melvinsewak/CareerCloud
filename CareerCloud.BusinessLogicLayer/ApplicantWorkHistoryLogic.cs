using System;
using System.Collections.Generic;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantWorkHistoryLogic : BaseLogic<ApplicantWorkHistoryPoco>
    {
        public ApplicantWorkHistoryLogic(IDataRepository<ApplicantWorkHistoryPoco> repository) : base(repository)
        {
        }

        public override void Add(ApplicantWorkHistoryPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override ApplicantWorkHistoryPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<ApplicantWorkHistoryPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(ApplicantWorkHistoryPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(ApplicantWorkHistoryPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (string.IsNullOrWhiteSpace(poco.CompanyName) || poco.CompanyName.Length <= 2)
                    exceptions.Add(new ValidationException(105, $"CompanyName for ApplicantWorkHistory {poco.Id} must be greater than 2 characters"));
            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }
    }

}
