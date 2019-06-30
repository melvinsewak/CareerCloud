using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantEducationLogic : BaseLogic<ApplicantEducationPoco>
    {
        public ApplicantEducationLogic(IDataRepository<ApplicantEducationPoco> repository) : base(repository)
        {
        }

        public override void Add(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override ApplicantEducationPoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<ApplicantEducationPoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(ApplicantEducationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (string.IsNullOrWhiteSpace(poco.Major))
                    exceptions.Add(new ValidationException(107, $"Major for ApplicantEducation {poco.Id} cannot be null or empty"));
                else if (poco.Major.Length<3)
                    exceptions.Add(new ValidationException(107, $"Major for ApplicantEducation {poco.Id} cannot be less than 3 characters"));

                if (poco.StartDate > DateTime.Now)
                    exceptions.Add(new ValidationException(108, $"StartDate for ApplicantEducation {poco.Id} cannot be greater than today's date"));

                if (poco.CompletionDate < poco.StartDate)
                    exceptions.Add(new ValidationException(109, $"CompletionDate for ApplicantEducation {poco.Id} cannot be earlier than StartDate"));
            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }
    }

}
