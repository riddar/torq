﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Torq.WPF.SalaryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Salary", Namespace="http://schemas.datacontract.org/2004/07/Torq.Models.Objects")]
    [System.SerializableAttribute()]
    public partial class Salary : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalaryTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SalaryType {
            get {
                return this.SalaryTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.SalaryTypeField, value) != true)) {
                    this.SalaryTypeField = value;
                    this.RaisePropertyChanged("SalaryType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SalaryService.ISalaryService")]
    public interface ISalaryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/CreateSalary", ReplyAction="http://tempuri.org/ISalaryService/CreateSalaryResponse")]
        Torq.WPF.SalaryService.Salary CreateSalary(Torq.WPF.SalaryService.Salary salary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/CreateSalary", ReplyAction="http://tempuri.org/ISalaryService/CreateSalaryResponse")]
        System.Threading.Tasks.Task<Torq.WPF.SalaryService.Salary> CreateSalaryAsync(Torq.WPF.SalaryService.Salary salary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/GetSalaries", ReplyAction="http://tempuri.org/ISalaryService/GetSalariesResponse")]
        Torq.WPF.SalaryService.Salary[] GetSalaries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/GetSalaries", ReplyAction="http://tempuri.org/ISalaryService/GetSalariesResponse")]
        System.Threading.Tasks.Task<Torq.WPF.SalaryService.Salary[]> GetSalariesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/GetSalaryById", ReplyAction="http://tempuri.org/ISalaryService/GetSalaryByIdResponse")]
        Torq.WPF.SalaryService.Salary GetSalaryById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/GetSalaryById", ReplyAction="http://tempuri.org/ISalaryService/GetSalaryByIdResponse")]
        System.Threading.Tasks.Task<Torq.WPF.SalaryService.Salary> GetSalaryByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/UpdateSalary", ReplyAction="http://tempuri.org/ISalaryService/UpdateSalaryResponse")]
        Torq.WPF.SalaryService.Salary UpdateSalary(Torq.WPF.SalaryService.Salary salary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/UpdateSalary", ReplyAction="http://tempuri.org/ISalaryService/UpdateSalaryResponse")]
        System.Threading.Tasks.Task<Torq.WPF.SalaryService.Salary> UpdateSalaryAsync(Torq.WPF.SalaryService.Salary salary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/RemoveSalary", ReplyAction="http://tempuri.org/ISalaryService/RemoveSalaryResponse")]
        void RemoveSalary(Torq.WPF.SalaryService.Salary salary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/RemoveSalary", ReplyAction="http://tempuri.org/ISalaryService/RemoveSalaryResponse")]
        System.Threading.Tasks.Task RemoveSalaryAsync(Torq.WPF.SalaryService.Salary salary);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISalaryServiceChannel : Torq.WPF.SalaryService.ISalaryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SalaryServiceClient : System.ServiceModel.ClientBase<Torq.WPF.SalaryService.ISalaryService>, Torq.WPF.SalaryService.ISalaryService {
        
        public SalaryServiceClient() {
        }
        
        public SalaryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SalaryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalaryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalaryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Torq.WPF.SalaryService.Salary CreateSalary(Torq.WPF.SalaryService.Salary salary) {
            return base.Channel.CreateSalary(salary);
        }
        
        public System.Threading.Tasks.Task<Torq.WPF.SalaryService.Salary> CreateSalaryAsync(Torq.WPF.SalaryService.Salary salary) {
            return base.Channel.CreateSalaryAsync(salary);
        }
        
        public Torq.WPF.SalaryService.Salary[] GetSalaries() {
            return base.Channel.GetSalaries();
        }
        
        public System.Threading.Tasks.Task<Torq.WPF.SalaryService.Salary[]> GetSalariesAsync() {
            return base.Channel.GetSalariesAsync();
        }
        
        public Torq.WPF.SalaryService.Salary GetSalaryById(int id) {
            return base.Channel.GetSalaryById(id);
        }
        
        public System.Threading.Tasks.Task<Torq.WPF.SalaryService.Salary> GetSalaryByIdAsync(int id) {
            return base.Channel.GetSalaryByIdAsync(id);
        }
        
        public Torq.WPF.SalaryService.Salary UpdateSalary(Torq.WPF.SalaryService.Salary salary) {
            return base.Channel.UpdateSalary(salary);
        }
        
        public System.Threading.Tasks.Task<Torq.WPF.SalaryService.Salary> UpdateSalaryAsync(Torq.WPF.SalaryService.Salary salary) {
            return base.Channel.UpdateSalaryAsync(salary);
        }
        
        public void RemoveSalary(Torq.WPF.SalaryService.Salary salary) {
            base.Channel.RemoveSalary(salary);
        }
        
        public System.Threading.Tasks.Task RemoveSalaryAsync(Torq.WPF.SalaryService.Salary salary) {
            return base.Channel.RemoveSalaryAsync(salary);
        }
    }
}
