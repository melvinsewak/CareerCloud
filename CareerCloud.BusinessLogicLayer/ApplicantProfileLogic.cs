using System;
using System.Collections.Generic;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantProfileLogic : BaseLogic<ApplicantProfilePoco>
    {
        public ApplicantProfileLogic(IDataRepository<ApplicantProfilePoco> repository) : base(repository)
        {
        }

        public override void Add(ApplicantProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override ApplicantProfilePoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<ApplicantProfilePoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(ApplicantProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(ApplicantProfilePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (poco.CurrentSalary <0)
                    exceptions.Add(new ValidationException(111, $"CurrentSalary for ApplicantProfile {poco.Id} cannot be negative"));
                if (poco.CurrentRate <0)
                    exceptions.Add(new ValidationException(112, $"CurrentRate for ApplicantProfile {poco.Id} cannot be negative"));
            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }
    }

}
