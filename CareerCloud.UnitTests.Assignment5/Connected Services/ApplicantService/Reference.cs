﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CareerCloud.UnitTests.Assignment5.ApplicantService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ApplicantService.IApplicant")]
    public interface IApplicant {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/AddApplicantEducationResponse")]
        void AddApplicantEducation(CareerCloud.Pocos.ApplicantEducationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/AddApplicantEducationResponse")]
        System.Threading.Tasks.Task AddApplicantEducationAsync(CareerCloud.Pocos.ApplicantEducationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantEducationResponse")]
        void UpdateApplicantEducation(CareerCloud.Pocos.ApplicantEducationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantEducationResponse")]
        System.Threading.Tasks.Task UpdateApplicantEducationAsync(CareerCloud.Pocos.ApplicantEducationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantEducationResponse")]
        void RemoveApplicantEducation(CareerCloud.Pocos.ApplicantEducationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantEducationResponse")]
        System.Threading.Tasks.Task RemoveApplicantEducationAsync(CareerCloud.Pocos.ApplicantEducationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantEducationResponse")]
        CareerCloud.Pocos.ApplicantEducationPoco GetSingleApplicantEducation(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantEducationResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantEducationPoco> GetSingleApplicantEducationAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantEducationResponse")]
        CareerCloud.Pocos.ApplicantEducationPoco[] GetAllApplicantEducation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantEducation", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantEducationResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantEducationPoco[]> GetAllApplicantEducationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/AddApplicantJobApplicationResponse")]
        void AddApplicantJobApplication(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/AddApplicantJobApplicationResponse")]
        System.Threading.Tasks.Task AddApplicantJobApplicationAsync(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantJobApplicationResponse")]
        void UpdateApplicantJobApplication(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantJobApplicationResponse")]
        System.Threading.Tasks.Task UpdateApplicantJobApplicationAsync(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantJobApplicationResponse")]
        void RemoveApplicantJobApplication(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantJobApplicationResponse")]
        System.Threading.Tasks.Task RemoveApplicantJobApplicationAsync(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantJobApplicationResponse")]
        CareerCloud.Pocos.ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantJobApplicationResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantJobApplicationPoco> GetSingleApplicantJobApplicationAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantJobApplicationResponse")]
        CareerCloud.Pocos.ApplicantJobApplicationPoco[] GetAllApplicantJobApplication();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantJobApplication", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantJobApplicationResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantJobApplicationPoco[]> GetAllApplicantJobApplicationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/AddApplicantProfileResponse")]
        void AddApplicantProfile(CareerCloud.Pocos.ApplicantProfilePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/AddApplicantProfileResponse")]
        System.Threading.Tasks.Task AddApplicantProfileAsync(CareerCloud.Pocos.ApplicantProfilePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantProfileResponse")]
        void UpdateApplicantProfile(CareerCloud.Pocos.ApplicantProfilePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantProfileResponse")]
        System.Threading.Tasks.Task UpdateApplicantProfileAsync(CareerCloud.Pocos.ApplicantProfilePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantProfileResponse")]
        void RemoveApplicantProfile(CareerCloud.Pocos.ApplicantProfilePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantProfileResponse")]
        System.Threading.Tasks.Task RemoveApplicantProfileAsync(CareerCloud.Pocos.ApplicantProfilePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantProfileResponse")]
        CareerCloud.Pocos.ApplicantProfilePoco GetSingleApplicantProfile(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantProfileResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantProfilePoco> GetSingleApplicantProfileAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantProfileResponse")]
        CareerCloud.Pocos.ApplicantProfilePoco[] GetAllApplicantProfile();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantProfile", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantProfileResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantProfilePoco[]> GetAllApplicantProfileAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantResume", ReplyAction="http://tempuri.org/IApplicant/AddApplicantResumeResponse")]
        void AddApplicantResume(CareerCloud.Pocos.ApplicantResumePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantResume", ReplyAction="http://tempuri.org/IApplicant/AddApplicantResumeResponse")]
        System.Threading.Tasks.Task AddApplicantResumeAsync(CareerCloud.Pocos.ApplicantResumePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantResume", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantResumeResponse")]
        void UpdateApplicantResume(CareerCloud.Pocos.ApplicantResumePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantResume", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantResumeResponse")]
        System.Threading.Tasks.Task UpdateApplicantResumeAsync(CareerCloud.Pocos.ApplicantResumePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantResume", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantResumeResponse")]
        void RemoveApplicantResume(CareerCloud.Pocos.ApplicantResumePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantResume", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantResumeResponse")]
        System.Threading.Tasks.Task RemoveApplicantResumeAsync(CareerCloud.Pocos.ApplicantResumePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantResume", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantResumeResponse")]
        CareerCloud.Pocos.ApplicantResumePoco GetSingleApplicantResume(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantResume", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantResumeResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantResumePoco> GetSingleApplicantResumeAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantResume", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantResumeResponse")]
        CareerCloud.Pocos.ApplicantResumePoco[] GetAllApplicantResume();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantResume", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantResumeResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantResumePoco[]> GetAllApplicantResumeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/AddApplicantSkillResponse")]
        void AddApplicantSkill(CareerCloud.Pocos.ApplicantSkillPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/AddApplicantSkillResponse")]
        System.Threading.Tasks.Task AddApplicantSkillAsync(CareerCloud.Pocos.ApplicantSkillPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantSkillResponse")]
        void UpdateApplicantSkill(CareerCloud.Pocos.ApplicantSkillPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantSkillResponse")]
        System.Threading.Tasks.Task UpdateApplicantSkillAsync(CareerCloud.Pocos.ApplicantSkillPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantSkillResponse")]
        void RemoveApplicantSkill(CareerCloud.Pocos.ApplicantSkillPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantSkillResponse")]
        System.Threading.Tasks.Task RemoveApplicantSkillAsync(CareerCloud.Pocos.ApplicantSkillPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantSkillResponse")]
        CareerCloud.Pocos.ApplicantSkillPoco GetSingleApplicantSkill(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantSkillResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantSkillPoco> GetSingleApplicantSkillAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantSkillResponse")]
        CareerCloud.Pocos.ApplicantSkillPoco[] GetAllApplicantSkill();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantSkill", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantSkillResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantSkillPoco[]> GetAllApplicantSkillAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/AddApplicantWorkHistoryResponse")]
        void AddApplicantWorkHistory(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/AddApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/AddApplicantWorkHistoryResponse")]
        System.Threading.Tasks.Task AddApplicantWorkHistoryAsync(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantWorkHistoryResponse")]
        void UpdateApplicantWorkHistory(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/UpdateApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/UpdateApplicantWorkHistoryResponse")]
        System.Threading.Tasks.Task UpdateApplicantWorkHistoryAsync(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantWorkHistoryResponse")]
        void RemoveApplicantWorkHistory(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/RemoveApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/RemoveApplicantWorkHistoryResponse")]
        System.Threading.Tasks.Task RemoveApplicantWorkHistoryAsync(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantWorkHistoryResponse")]
        CareerCloud.Pocos.ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetSingleApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/GetSingleApplicantWorkHistoryResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantWorkHistoryPoco> GetSingleApplicantWorkHistoryAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantWorkHistoryResponse")]
        CareerCloud.Pocos.ApplicantWorkHistoryPoco[] GetAllApplicantWorkHistory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicant/GetAllApplicantWorkHistory", ReplyAction="http://tempuri.org/IApplicant/GetAllApplicantWorkHistoryResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantWorkHistoryPoco[]> GetAllApplicantWorkHistoryAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplicantChannel : CareerCloud.UnitTests.Assignment5.ApplicantService.IApplicant, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicantClient : System.ServiceModel.ClientBase<CareerCloud.UnitTests.Assignment5.ApplicantService.IApplicant>, CareerCloud.UnitTests.Assignment5.ApplicantService.IApplicant {
        
        public ApplicantClient() {
        }
        
        public ApplicantClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicantClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicantClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicantClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddApplicantEducation(CareerCloud.Pocos.ApplicantEducationPoco[] items) {
            base.Channel.AddApplicantEducation(items);
        }
        
        public System.Threading.Tasks.Task AddApplicantEducationAsync(CareerCloud.Pocos.ApplicantEducationPoco[] items) {
            return base.Channel.AddApplicantEducationAsync(items);
        }
        
        public void UpdateApplicantEducation(CareerCloud.Pocos.ApplicantEducationPoco[] items) {
            base.Channel.UpdateApplicantEducation(items);
        }
        
        public System.Threading.Tasks.Task UpdateApplicantEducationAsync(CareerCloud.Pocos.ApplicantEducationPoco[] items) {
            return base.Channel.UpdateApplicantEducationAsync(items);
        }
        
        public void RemoveApplicantEducation(CareerCloud.Pocos.ApplicantEducationPoco[] items) {
            base.Channel.RemoveApplicantEducation(items);
        }
        
        public System.Threading.Tasks.Task RemoveApplicantEducationAsync(CareerCloud.Pocos.ApplicantEducationPoco[] items) {
            return base.Channel.RemoveApplicantEducationAsync(items);
        }
        
        public CareerCloud.Pocos.ApplicantEducationPoco GetSingleApplicantEducation(string Id) {
            return base.Channel.GetSingleApplicantEducation(Id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantEducationPoco> GetSingleApplicantEducationAsync(string Id) {
            return base.Channel.GetSingleApplicantEducationAsync(Id);
        }
        
        public CareerCloud.Pocos.ApplicantEducationPoco[] GetAllApplicantEducation() {
            return base.Channel.GetAllApplicantEducation();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantEducationPoco[]> GetAllApplicantEducationAsync() {
            return base.Channel.GetAllApplicantEducationAsync();
        }
        
        public void AddApplicantJobApplication(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items) {
            base.Channel.AddApplicantJobApplication(items);
        }
        
        public System.Threading.Tasks.Task AddApplicantJobApplicationAsync(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items) {
            return base.Channel.AddApplicantJobApplicationAsync(items);
        }
        
        public void UpdateApplicantJobApplication(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items) {
            base.Channel.UpdateApplicantJobApplication(items);
        }
        
        public System.Threading.Tasks.Task UpdateApplicantJobApplicationAsync(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items) {
            return base.Channel.UpdateApplicantJobApplicationAsync(items);
        }
        
        public void RemoveApplicantJobApplication(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items) {
            base.Channel.RemoveApplicantJobApplication(items);
        }
        
        public System.Threading.Tasks.Task RemoveApplicantJobApplicationAsync(CareerCloud.Pocos.ApplicantJobApplicationPoco[] items) {
            return base.Channel.RemoveApplicantJobApplicationAsync(items);
        }
        
        public CareerCloud.Pocos.ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id) {
            return base.Channel.GetSingleApplicantJobApplication(Id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantJobApplicationPoco> GetSingleApplicantJobApplicationAsync(string Id) {
            return base.Channel.GetSingleApplicantJobApplicationAsync(Id);
        }
        
        public CareerCloud.Pocos.ApplicantJobApplicationPoco[] GetAllApplicantJobApplication() {
            return base.Channel.GetAllApplicantJobApplication();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantJobApplicationPoco[]> GetAllApplicantJobApplicationAsync() {
            return base.Channel.GetAllApplicantJobApplicationAsync();
        }
        
        public void AddApplicantProfile(CareerCloud.Pocos.ApplicantProfilePoco[] items) {
            base.Channel.AddApplicantProfile(items);
        }
        
        public System.Threading.Tasks.Task AddApplicantProfileAsync(CareerCloud.Pocos.ApplicantProfilePoco[] items) {
            return base.Channel.AddApplicantProfileAsync(items);
        }
        
        public void UpdateApplicantProfile(CareerCloud.Pocos.ApplicantProfilePoco[] items) {
            base.Channel.UpdateApplicantProfile(items);
        }
        
        public System.Threading.Tasks.Task UpdateApplicantProfileAsync(CareerCloud.Pocos.ApplicantProfilePoco[] items) {
            return base.Channel.UpdateApplicantProfileAsync(items);
        }
        
        public void RemoveApplicantProfile(CareerCloud.Pocos.ApplicantProfilePoco[] items) {
            base.Channel.RemoveApplicantProfile(items);
        }
        
        public System.Threading.Tasks.Task RemoveApplicantProfileAsync(CareerCloud.Pocos.ApplicantProfilePoco[] items) {
            return base.Channel.RemoveApplicantProfileAsync(items);
        }
        
        public CareerCloud.Pocos.ApplicantProfilePoco GetSingleApplicantProfile(string Id) {
            return base.Channel.GetSingleApplicantProfile(Id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantProfilePoco> GetSingleApplicantProfileAsync(string Id) {
            return base.Channel.GetSingleApplicantProfileAsync(Id);
        }
        
        public CareerCloud.Pocos.ApplicantProfilePoco[] GetAllApplicantProfile() {
            return base.Channel.GetAllApplicantProfile();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantProfilePoco[]> GetAllApplicantProfileAsync() {
            return base.Channel.GetAllApplicantProfileAsync();
        }
        
        public void AddApplicantResume(CareerCloud.Pocos.ApplicantResumePoco[] items) {
            base.Channel.AddApplicantResume(items);
        }
        
        public System.Threading.Tasks.Task AddApplicantResumeAsync(CareerCloud.Pocos.ApplicantResumePoco[] items) {
            return base.Channel.AddApplicantResumeAsync(items);
        }
        
        public void UpdateApplicantResume(CareerCloud.Pocos.ApplicantResumePoco[] items) {
            base.Channel.UpdateApplicantResume(items);
        }
        
        public System.Threading.Tasks.Task UpdateApplicantResumeAsync(CareerCloud.Pocos.ApplicantResumePoco[] items) {
            return base.Channel.UpdateApplicantResumeAsync(items);
        }
        
        public void RemoveApplicantResume(CareerCloud.Pocos.ApplicantResumePoco[] items) {
            base.Channel.RemoveApplicantResume(items);
        }
        
        public System.Threading.Tasks.Task RemoveApplicantResumeAsync(CareerCloud.Pocos.ApplicantResumePoco[] items) {
            return base.Channel.RemoveApplicantResumeAsync(items);
        }
        
        public CareerCloud.Pocos.ApplicantResumePoco GetSingleApplicantResume(string Id) {
            return base.Channel.GetSingleApplicantResume(Id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantResumePoco> GetSingleApplicantResumeAsync(string Id) {
            return base.Channel.GetSingleApplicantResumeAsync(Id);
        }
        
        public CareerCloud.Pocos.ApplicantResumePoco[] GetAllApplicantResume() {
            return base.Channel.GetAllApplicantResume();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantResumePoco[]> GetAllApplicantResumeAsync() {
            return base.Channel.GetAllApplicantResumeAsync();
        }
        
        public void AddApplicantSkill(CareerCloud.Pocos.ApplicantSkillPoco[] items) {
            base.Channel.AddApplicantSkill(items);
        }
        
        public System.Threading.Tasks.Task AddApplicantSkillAsync(CareerCloud.Pocos.ApplicantSkillPoco[] items) {
            return base.Channel.AddApplicantSkillAsync(items);
        }
        
        public void UpdateApplicantSkill(CareerCloud.Pocos.ApplicantSkillPoco[] items) {
            base.Channel.UpdateApplicantSkill(items);
        }
        
        public System.Threading.Tasks.Task UpdateApplicantSkillAsync(CareerCloud.Pocos.ApplicantSkillPoco[] items) {
            return base.Channel.UpdateApplicantSkillAsync(items);
        }
        
        public void RemoveApplicantSkill(CareerCloud.Pocos.ApplicantSkillPoco[] items) {
            base.Channel.RemoveApplicantSkill(items);
        }
        
        public System.Threading.Tasks.Task RemoveApplicantSkillAsync(CareerCloud.Pocos.ApplicantSkillPoco[] items) {
            return base.Channel.RemoveApplicantSkillAsync(items);
        }
        
        public CareerCloud.Pocos.ApplicantSkillPoco GetSingleApplicantSkill(string Id) {
            return base.Channel.GetSingleApplicantSkill(Id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantSkillPoco> GetSingleApplicantSkillAsync(string Id) {
            return base.Channel.GetSingleApplicantSkillAsync(Id);
        }
        
        public CareerCloud.Pocos.ApplicantSkillPoco[] GetAllApplicantSkill() {
            return base.Channel.GetAllApplicantSkill();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantSkillPoco[]> GetAllApplicantSkillAsync() {
            return base.Channel.GetAllApplicantSkillAsync();
        }
        
        public void AddApplicantWorkHistory(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items) {
            base.Channel.AddApplicantWorkHistory(items);
        }
        
        public System.Threading.Tasks.Task AddApplicantWorkHistoryAsync(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items) {
            return base.Channel.AddApplicantWorkHistoryAsync(items);
        }
        
        public void UpdateApplicantWorkHistory(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items) {
            base.Channel.UpdateApplicantWorkHistory(items);
        }
        
        public System.Threading.Tasks.Task UpdateApplicantWorkHistoryAsync(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items) {
            return base.Channel.UpdateApplicantWorkHistoryAsync(items);
        }
        
        public void RemoveApplicantWorkHistory(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items) {
            base.Channel.RemoveApplicantWorkHistory(items);
        }
        
        public System.Threading.Tasks.Task RemoveApplicantWorkHistoryAsync(CareerCloud.Pocos.ApplicantWorkHistoryPoco[] items) {
            return base.Channel.RemoveApplicantWorkHistoryAsync(items);
        }
        
        public CareerCloud.Pocos.ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id) {
            return base.Channel.GetSingleApplicantWorkHistory(Id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantWorkHistoryPoco> GetSingleApplicantWorkHistoryAsync(string Id) {
            return base.Channel.GetSingleApplicantWorkHistoryAsync(Id);
        }
        
        public CareerCloud.Pocos.ApplicantWorkHistoryPoco[] GetAllApplicantWorkHistory() {
            return base.Channel.GetAllApplicantWorkHistory();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.ApplicantWorkHistoryPoco[]> GetAllApplicantWorkHistoryAsync() {
            return base.Channel.GetAllApplicantWorkHistoryAsync();
        }
    }
}
