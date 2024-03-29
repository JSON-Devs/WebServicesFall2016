﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestOrders.ServiceOrders {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/NEITStoreOrdersService")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestOrders.ServiceOrders.Item[] ItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShopperAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShopperNameField;
        
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
        public TestOrders.ServiceOrders.Item[] Items {
            get {
                return this.ItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemsField, value) != true)) {
                    this.ItemsField = value;
                    this.RaisePropertyChanged("Items");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OrderID {
            get {
                return this.OrderIDField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderIDField, value) != true)) {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShopperAddress {
            get {
                return this.ShopperAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.ShopperAddressField, value) != true)) {
                    this.ShopperAddressField = value;
                    this.RaisePropertyChanged("ShopperAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShopperName {
            get {
                return this.ShopperNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ShopperNameField, value) != true)) {
                    this.ShopperNameField = value;
                    this.RaisePropertyChanged("ShopperName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/NEITStoreOrdersService")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestOrders.ServiceOrders.CustomerOptions OptionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkuField;
        
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
        public string Cost {
            get {
                return this.CostField;
            }
            set {
                if ((object.ReferenceEquals(this.CostField, value) != true)) {
                    this.CostField = value;
                    this.RaisePropertyChanged("Cost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestOrders.ServiceOrders.CustomerOptions Options {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sku {
            get {
                return this.SkuField;
            }
            set {
                if ((object.ReferenceEquals(this.SkuField, value) != true)) {
                    this.SkuField = value;
                    this.RaisePropertyChanged("Sku");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerOptions", Namespace="http://schemas.datacontract.org/2004/07/NEITStoreOrdersService")]
    [System.SerializableAttribute()]
    public partial class CustomerOptions : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SizeField;
        
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
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Size {
            get {
                return this.SizeField;
            }
            set {
                if ((object.ReferenceEquals(this.SizeField, value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceOrders.INEITStoreOrdersService")]
    public interface INEITStoreOrdersService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/ReturnDoubeOrderID", ReplyAction="http://tempuri.org/INEITStoreOrdersService/ReturnDoubeOrderIDResponse")]
        double ReturnDoubeOrderID(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/ReturnDoubeOrderID", ReplyAction="http://tempuri.org/INEITStoreOrdersService/ReturnDoubeOrderIDResponse")]
        System.Threading.Tasks.Task<double> ReturnDoubeOrderIDAsync(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/GetOrder", ReplyAction="http://tempuri.org/INEITStoreOrdersService/GetOrderResponse")]
        TestOrders.ServiceOrders.Order GetOrder(int OrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/GetOrder", ReplyAction="http://tempuri.org/INEITStoreOrdersService/GetOrderResponse")]
        System.Threading.Tasks.Task<TestOrders.ServiceOrders.Order> GetOrderAsync(int OrderID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INEITStoreOrdersServiceChannel : TestOrders.ServiceOrders.INEITStoreOrdersService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NEITStoreOrdersServiceClient : System.ServiceModel.ClientBase<TestOrders.ServiceOrders.INEITStoreOrdersService>, TestOrders.ServiceOrders.INEITStoreOrdersService {
        
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
        
        public double ReturnDoubeOrderID(int OrderID) {
            return base.Channel.ReturnDoubeOrderID(OrderID);
        }
        
        public System.Threading.Tasks.Task<double> ReturnDoubeOrderIDAsync(int OrderID) {
            return base.Channel.ReturnDoubeOrderIDAsync(OrderID);
        }
        
        public TestOrders.ServiceOrders.Order GetOrder(int OrderID) {
            return base.Channel.GetOrder(OrderID);
        }
        
        public System.Threading.Tasks.Task<TestOrders.ServiceOrders.Order> GetOrderAsync(int OrderID) {
            return base.Channel.GetOrderAsync(OrderID);
        }
    }
}
