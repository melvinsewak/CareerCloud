using System;
using CareerCloud.Pocos;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    [ServiceContract]
    public interface ISystem
    {
        [OperationContract]
        void AddSystemCountryCode(SystemCountryCodePoco[] items);
        [OperationContract]
        void UpdateSystemCountryCode(SystemCountryCodePoco[] items);
        [OperationContract]
        void RemoveSystemCountryCode(SystemCountryCodePoco[] items);
        [OperationContract]
        SystemCountryCodePoco GetSingleSystemCountryCode(string Id);
        [OperationContract]
        List<SystemCountryCodePoco> GetAllSystemCountryCode();
        [OperationContract]
        void AddSystemLanguageCode(SystemLanguageCodePoco[] items);
        [OperationContract]
        void UpdateSystemLanguageCode(SystemLanguageCodePoco[] items);
        [OperationContract]
        void RemoveSystemLanguageCode(SystemLanguageCodePoco[] items);
        [OperationContract]
        SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id);
        [OperationContract]
        List<SystemLanguageCodePoco> GetAllSystemLanguageCode();
    }
}
