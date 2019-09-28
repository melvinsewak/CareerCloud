using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    [ServiceContract]
    public interface IApplicant
    {
        [OperationContract]
        void AddApplicantEducation(ApplicantEducationPoco[] items);
        [OperationContract]
        void UpdateApplicantEducation(ApplicantEducationPoco[] items);
        [OperationContract]
        void RemoveApplicantEducation(ApplicantEducationPoco[] items);
        [OperationContract]
        ApplicantEducationPoco GetSingleApplicantEducation(string Id);
        [OperationContract]
        List<ApplicantEducationPoco> GetAllApplicantEducation();

        //---------------------ApplicantJobApplication

        [OperationContract]
        void AddApplicantJobApplication(ApplicantJobApplicationPoco[] items);
        [OperationContract]
        void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items);
        [OperationContract]
        void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] items);
        [OperationContract]
        ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id);
        [OperationContract]
        List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication();

        //----------ApplicantProfile--------------------

        [OperationContract]
        void AddApplicantProfile(ApplicantProfilePoco[] items);
        [OperationContract]
        void UpdateApplicantProfile(ApplicantProfilePoco[] items);
        [OperationContract]
        void RemoveApplicantProfile(ApplicantProfilePoco[] items);
        [OperationContract]
        ApplicantProfilePoco GetSingleApplicantProfile(string Id);
        [OperationContract]
        List<ApplicantProfilePoco> GetAllApplicantProfile();

        //-------------------------------ApplicantResume


        [OperationContract]
        void AddApplicantResume(ApplicantResumePoco[] items);
        [OperationContract]
        void UpdateApplicantResume(ApplicantResumePoco[] items);
        [OperationContract]
        void RemoveApplicantResume(ApplicantResumePoco[] items);
        [OperationContract]
        ApplicantResumePoco GetSingleApplicantResume(string Id);
        [OperationContract]
        List<ApplicantResumePoco> GetAllApplicantResume();

        //--------------------------------ApplicantSkill


        [OperationContract]
        void AddApplicantSkill(ApplicantSkillPoco[] items);
        [OperationContract]
        void UpdateApplicantSkill(ApplicantSkillPoco[] items);
        [OperationContract]
        void RemoveApplicantSkill(ApplicantSkillPoco[] items);
        [OperationContract]
        ApplicantSkillPoco GetSingleApplicantSkill(string Id);
        [OperationContract]
        List<ApplicantSkillPoco> GetAllApplicantSkill();

        //------------------------------------ApplicantWorkHistory----------
        [OperationContract]
        void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);
        [OperationContract]
        void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);
        [OperationContract]
        void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] items);
        [OperationContract]
        ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id);
        [OperationContract]
        List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory();
    }
}
