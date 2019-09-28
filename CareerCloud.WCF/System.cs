using System;
using System.Collections.Generic;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    class System : ISystem
    {
        public void AddSystemCountryCode(SystemCountryCodePoco[] items)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>());

            logic.Add(items);
        }

        public void AddSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>());

            logic.Add(items);
        }

        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));

            return logic.GetAll();
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));

            return logic.GetAll();
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string Id)
        {
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));

            return logic.Get(Id);
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id)
        {
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));

            return logic.Get(Id);
        }

        public void RemoveSystemCountryCode(SystemCountryCodePoco[] items)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>());
            logic.Delete(items);
        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>());
            logic.Delete(items);
        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] items)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>());

            logic.Update(items);
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>());

            logic.Update(items);
        }
    }
}
