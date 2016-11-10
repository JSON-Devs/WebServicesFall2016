﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestStore.NEITStoreOrdersService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Information", Namespace="http://schemas.datacontract.org/2004/07/Problem2")]
    [System.SerializableAttribute()]
    public partial class Information : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestStore.NEITStoreOrdersService.Account[] AccountsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OwnerNameField;
        
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
        public string AccountID {
            get {
                return this.AccountIDField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountIDField, value) != true)) {
                    this.AccountIDField = value;
                    this.RaisePropertyChanged("AccountID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestStore.NEITStoreOrdersService.Account[] Accounts {
            get {
                return this.AccountsField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountsField, value) != true)) {
                    this.AccountsField = value;
                    this.RaisePropertyChanged("Accounts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OwnerName {
            get {
                return this.OwnerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerNameField, value) != true)) {
                    this.OwnerNameField = value;
                    this.RaisePropertyChanged("OwnerName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/Problem2")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestStore.NEITStoreOrdersService.Option OptionsField;
        
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
        public string AccountType {
            get {
                return this.AccountTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountTypeField, value) != true)) {
                    this.AccountTypeField = value;
                    this.RaisePropertyChanged("AccountType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestStore.NEITStoreOrdersService.Option Options {
            get {
                return this.OptionsField;
            }
            set {
                if ((object.ReferenceEquals(this.OptionsField, value) != true)) {
                    this.OptionsField = value;
                    this.RaisePropertyChanged("Options");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Option", Namespace="http://schemas.datacontract.org/2004/07/Problem2")]
    [System.SerializableAttribute()]
    public partial class Option : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FreeCheckingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OverDraftProtectionField;
        
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
        public string FreeChecking {
            get {
                return this.FreeCheckingField;
            }
            set {
                if ((object.ReferenceEquals(this.FreeCheckingField, value) != true)) {
                    this.FreeCheckingField = value;
                    this.RaisePropertyChanged("FreeChecking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OverDraftProtection {
            get {
                return this.OverDraftProtectionField;
            }
            set {
                if ((object.ReferenceEquals(this.OverDraftProtectionField, value) != true)) {
                    this.OverDraftProtectionField = value;
                    this.RaisePropertyChanged("OverDraftProtection");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NEITStoreOrdersService.INEITStoreOrdersService")]
    public interface INEITStoreOrdersService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/returnAmountEarned", ReplyAction="http://tempuri.org/INEITStoreOrdersService/returnAmountEarnedResponse")]
        float returnAmountEarned(float balance, float interest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/returnAmountEarned", ReplyAction="http://tempuri.org/INEITStoreOrdersService/returnAmountEarnedResponse")]
        System.Threading.Tasks.Task<float> returnAmountEarnedAsync(float balance, float interest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/getBankInformation", ReplyAction="http://tempuri.org/INEITStoreOrdersService/getBankInformationResponse")]
        TestStore.NEITStoreOrdersService.Information getBankInformation(string accountID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/getBankInformation", ReplyAction="http://tempuri.org/INEITStoreOrdersService/getBankInformationResponse")]
        System.Threading.Tasks.Task<TestStore.NEITStoreOrdersService.Information> getBankInformationAsync(string accountID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INEITStoreOrdersServiceChannel : TestStore.NEITStoreOrdersService.INEITStoreOrdersService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NEITStoreOrdersServiceClient : System.ServiceModel.ClientBase<TestStore.NEITStoreOrdersService.INEITStoreOrdersService>, TestStore.NEITStoreOrdersService.INEITStoreOrdersService {
        
        public NEITStoreOrdersServiceClient() {
        }
        
        public NEITStoreOrdersServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NEITStoreOrdersServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NEITStoreOrdersServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NEITStoreOrdersServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float returnAmountEarned(float balance, float interest) {
            return base.Channel.returnAmountEarned(balance, interest);
        }
        
        public System.Threading.Tasks.Task<float> returnAmountEarnedAsync(float balance, float interest) {
            return base.Channel.returnAmountEarnedAsync(balance, interest);
        }
        
        public TestStore.NEITStoreOrdersService.Information getBankInformation(string accountID) {
            return base.Channel.getBankInformation(accountID);
        }
        
        public System.Threading.Tasks.Task<TestStore.NEITStoreOrdersService.Information> getBankInformationAsync(string accountID) {
            return base.Channel.getBankInformationAsync(accountID);
        }
    }
}