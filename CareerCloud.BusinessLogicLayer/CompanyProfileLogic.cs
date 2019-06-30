using System;
using System.Collections.Generic;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic : BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic(IDataRepository<CompanyProfilePoco> repository) : base(repository)
        {
        }

        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override CompanyProfilePoco Get(Guid id)
        {
            return base.Get(id);
        }

        public override List<CompanyProfilePoco> GetAll()
        {
            return base.GetAll();
        }

        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (string.IsNullOrWhiteSpace(poco.CompanyWebsite))
                    exceptions.Add(new ValidationException(600, $"CompanyWebsite for CompanyProfile {poco.Id} cannot be null or empty"));
                else if (!poco.CompanyWebsite.EndsWith(".ca") && !poco.CompanyWebsite.EndsWith(".com") && !poco.CompanyWebsite.EndsWith(".biz"))
                    exceptions.Add(new ValidationException(600, $"CompanyWebsite for CompanyProfile {poco.Id} must end with the following extensions – '.ca', '.com', '.biz'"));

                if (string.IsNullOrWhiteSpace(poco.ContactPhone))
                    exceptions.Add(new ValidationException(601, $"ContactPhone for CompanyProfile {poco.Id} cannot be null or empty"));
                else
                {
                    string[] phoneComponents = poco.ContactPhone.Split('-');
                    if (phoneComponents.Length != 3)
                    {
                        exceptions.Add(new ValidationException(601, $"ContactPhone for CompanyProfile {poco.Id} is not in the required format."));
                    }
                    else
                    {
                        if (phoneComponents[0].Length != 3)
                        {
                            exceptions.Add(new ValidationException(601, $"ContactPhone for CompanyProfile {poco.Id} is not in the required format."));
                        }
                        else if (phoneComponents[1].Length != 3)
                        {
                            exceptions.Add(new ValidationException(601, $"ContactPhone for CompanyProfile {poco.Id} is not in the required format."));
                        }
                        else if (phoneComponents[2].Length != 4)
                        {
                            exceptions.Add(new ValidationException(601, $"ContactPhone for CompanyProfile {poco.Id} is not in the required format."));
                        }
                    }
                }
            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }
    }

}
