﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CareerCloud.UnitTests.Assignment5.SystemService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SystemService.ISystem")]
    public interface ISystem {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/AddSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/AddSystemCountryCodeResponse")]
        void AddSystemCountryCode(CareerCloud.Pocos.SystemCountryCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/AddSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/AddSystemCountryCodeResponse")]
        System.Threading.Tasks.Task AddSystemCountryCodeAsync(CareerCloud.Pocos.SystemCountryCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/UpdateSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/UpdateSystemCountryCodeResponse")]
        void UpdateSystemCountryCode(CareerCloud.Pocos.SystemCountryCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/UpdateSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/UpdateSystemCountryCodeResponse")]
        System.Threading.Tasks.Task UpdateSystemCountryCodeAsync(CareerCloud.Pocos.SystemCountryCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/RemoveSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/RemoveSystemCountryCodeResponse")]
        void RemoveSystemCountryCode(CareerCloud.Pocos.SystemCountryCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/RemoveSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/RemoveSystemCountryCodeResponse")]
        System.Threading.Tasks.Task RemoveSystemCountryCodeAsync(CareerCloud.Pocos.SystemCountryCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/GetSingleSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/GetSingleSystemCountryCodeResponse")]
        CareerCloud.Pocos.SystemCountryCodePoco GetSingleSystemCountryCode(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/GetSingleSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/GetSingleSystemCountryCodeResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SystemCountryCodePoco> GetSingleSystemCountryCodeAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/GetAllSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/GetAllSystemCountryCodeResponse")]
        CareerCloud.Pocos.SystemCountryCodePoco[] GetAllSystemCountryCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/GetAllSystemCountryCode", ReplyAction="http://tempuri.org/ISystem/GetAllSystemCountryCodeResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SystemCountryCodePoco[]> GetAllSystemCountryCodeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/AddSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/AddSystemLanguageCodeResponse")]
        void AddSystemLanguageCode(CareerCloud.Pocos.SystemLanguageCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/AddSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/AddSystemLanguageCodeResponse")]
        System.Threading.Tasks.Task AddSystemLanguageCodeAsync(CareerCloud.Pocos.SystemLanguageCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/UpdateSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/UpdateSystemLanguageCodeResponse")]
        void UpdateSystemLanguageCode(CareerCloud.Pocos.SystemLanguageCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/UpdateSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/UpdateSystemLanguageCodeResponse")]
        System.Threading.Tasks.Task UpdateSystemLanguageCodeAsync(CareerCloud.Pocos.SystemLanguageCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/RemoveSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/RemoveSystemLanguageCodeResponse")]
        void RemoveSystemLanguageCode(CareerCloud.Pocos.SystemLanguageCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/RemoveSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/RemoveSystemLanguageCodeResponse")]
        System.Threading.Tasks.Task RemoveSystemLanguageCodeAsync(CareerCloud.Pocos.SystemLanguageCodePoco[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/GetSingleSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/GetSingleSystemLanguageCodeResponse")]
        CareerCloud.Pocos.SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/GetSingleSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/GetSingleSystemLanguageCodeResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SystemLanguageCodePoco> GetSingleSystemLanguageCodeAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/GetAllSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/GetAllSystemLanguageCodeResponse")]
        CareerCloud.Pocos.SystemLanguageCodePoco[] GetAllSystemLanguageCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystem/GetAllSystemLanguageCode", ReplyAction="http://tempuri.org/ISystem/GetAllSystemLanguageCodeResponse")]
        System.Threading.Tasks.Task<CareerCloud.Pocos.SystemLanguageCodePoco[]> GetAllSystemLanguageCodeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISystemChannel : CareerCloud.UnitTests.Assignment5.SystemService.ISystem, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SystemClient : System.ServiceModel.ClientBase<CareerCloud.UnitTests.Assignment5.SystemService.ISystem>, CareerCloud.UnitTests.Assignment5.SystemService.ISystem {
        
        public SystemClient() {
        }
        
        public SystemClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SystemClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddSystemCountryCode(CareerCloud.Pocos.SystemCountryCodePoco[] items) {
            base.Channel.AddSystemCountryCode(items);
        }
        
        public System.Threading.Tasks.Task AddSystemCountryCodeAsync(CareerCloud.Pocos.SystemCountryCodePoco[] items) {
            return base.Channel.AddSystemCountryCodeAsync(items);
        }
        
        public void UpdateSystemCountryCode(CareerCloud.Pocos.SystemCountryCodePoco[] items) {
            base.Channel.UpdateSystemCountryCode(items);
        }
        
        public System.Threading.Tasks.Task UpdateSystemCountryCodeAsync(CareerCloud.Pocos.SystemCountryCodePoco[] items) {
            return base.Channel.UpdateSystemCountryCodeAsync(items);
        }
        
        public void RemoveSystemCountryCode(CareerCloud.Pocos.SystemCountryCodePoco[] items) {
            base.Channel.RemoveSystemCountryCode(items);
        }
        
        public System.Threading.Tasks.Task RemoveSystemCountryCodeAsync(CareerCloud.Pocos.SystemCountryCodePoco[] items) {
            return base.Channel.RemoveSystemCountryCodeAsync(items);
        }
        
        public CareerCloud.Pocos.SystemCountryCodePoco GetSingleSystemCountryCode(string Id) {
            return base.Channel.GetSingleSystemCountryCode(Id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SystemCountryCodePoco> GetSingleSystemCountryCodeAsync(string Id) {
            return base.Channel.GetSingleSystemCountryCodeAsync(Id);
        }
        
        public CareerCloud.Pocos.SystemCountryCodePoco[] GetAllSystemCountryCode() {
            return base.Channel.GetAllSystemCountryCode();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SystemCountryCodePoco[]> GetAllSystemCountryCodeAsync() {
            return base.Channel.GetAllSystemCountryCodeAsync();
        }
        
        public void AddSystemLanguageCode(CareerCloud.Pocos.SystemLanguageCodePoco[] items) {
            base.Channel.AddSystemLanguageCode(items);
        }
        
        public System.Threading.Tasks.Task AddSystemLanguageCodeAsync(CareerCloud.Pocos.SystemLanguageCodePoco[] items) {
            return base.Channel.AddSystemLanguageCodeAsync(items);
        }
        
        public void UpdateSystemLanguageCode(CareerCloud.Pocos.SystemLanguageCodePoco[] items) {
            base.Channel.UpdateSystemLanguageCode(items);
        }
        
        public System.Threading.Tasks.Task UpdateSystemLanguageCodeAsync(CareerCloud.Pocos.SystemLanguageCodePoco[] items) {
            return base.Channel.UpdateSystemLanguageCodeAsync(items);
        }
        
        public void RemoveSystemLanguageCode(CareerCloud.Pocos.SystemLanguageCodePoco[] items) {
            base.Channel.RemoveSystemLanguageCode(items);
        }
        
        public System.Threading.Tasks.Task RemoveSystemLanguageCodeAsync(CareerCloud.Pocos.SystemLanguageCodePoco[] items) {
            return base.Channel.RemoveSystemLanguageCodeAsync(items);
        }
        
        public CareerCloud.Pocos.SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id) {
            return base.Channel.GetSingleSystemLanguageCode(Id);
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SystemLanguageCodePoco> GetSingleSystemLanguageCodeAsync(string Id) {
            return base.Channel.GetSingleSystemLanguageCodeAsync(Id);
        }
        
        public CareerCloud.Pocos.SystemLanguageCodePoco[] GetAllSystemLanguageCode() {
            return base.Channel.GetAllSystemLanguageCode();
        }
        
        public System.Threading.Tasks.Task<CareerCloud.Pocos.SystemLanguageCodePoco[]> GetAllSystemLanguageCodeAsync() {
            return base.Channel.GetAllSystemLanguageCodeAsync();
        }
    }
}
