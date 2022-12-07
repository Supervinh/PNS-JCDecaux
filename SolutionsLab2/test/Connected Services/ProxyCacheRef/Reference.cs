﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test.ProxyCacheRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JCDecauxItem", Namespace="http://schemas.datacontract.org/2004/07/GenericProxyCache")]
    [System.SerializableAttribute()]
    public partial class JCDecauxItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string queryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string responseField;
        
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
        public string query {
            get {
                return this.queryField;
            }
            set {
                if ((object.ReferenceEquals(this.queryField, value) != true)) {
                    this.queryField = value;
                    this.RaisePropertyChanged("query");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string response {
            get {
                return this.responseField;
            }
            set {
                if ((object.ReferenceEquals(this.responseField, value) != true)) {
                    this.responseField = value;
                    this.RaisePropertyChanged("response");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyCacheRef.IProxyCache")]
    public interface IProxyCache {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyCache/getContractsList", ReplyAction="http://tempuri.org/IProxyCache/getContractsListResponse")]
        test.ProxyCacheRef.JCDecauxItem getContractsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyCache/getContractsList", ReplyAction="http://tempuri.org/IProxyCache/getContractsListResponse")]
        System.Threading.Tasks.Task<test.ProxyCacheRef.JCDecauxItem> getContractsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyCache/getStationsList", ReplyAction="http://tempuri.org/IProxyCache/getStationsListResponse")]
        test.ProxyCacheRef.JCDecauxItem getStationsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyCache/getStationsList", ReplyAction="http://tempuri.org/IProxyCache/getStationsListResponse")]
        System.Threading.Tasks.Task<test.ProxyCacheRef.JCDecauxItem> getStationsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyCache/getStationsListWithContractName", ReplyAction="http://tempuri.org/IProxyCache/getStationsListWithContractNameResponse")]
        test.ProxyCacheRef.JCDecauxItem getStationsListWithContractName(string contractName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxyCache/getStationsListWithContractName", ReplyAction="http://tempuri.org/IProxyCache/getStationsListWithContractNameResponse")]
        System.Threading.Tasks.Task<test.ProxyCacheRef.JCDecauxItem> getStationsListWithContractNameAsync(string contractName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProxyCacheChannel : test.ProxyCacheRef.IProxyCache, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProxyCacheClient : System.ServiceModel.ClientBase<test.ProxyCacheRef.IProxyCache>, test.ProxyCacheRef.IProxyCache {
        
        public ProxyCacheClient() {
        }
        
        public ProxyCacheClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProxyCacheClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProxyCacheClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProxyCacheClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public test.ProxyCacheRef.JCDecauxItem getContractsList() {
            return base.Channel.getContractsList();
        }
        
        public System.Threading.Tasks.Task<test.ProxyCacheRef.JCDecauxItem> getContractsListAsync() {
            return base.Channel.getContractsListAsync();
        }
        
        public test.ProxyCacheRef.JCDecauxItem getStationsList() {
            return base.Channel.getStationsList();
        }
        
        public System.Threading.Tasks.Task<test.ProxyCacheRef.JCDecauxItem> getStationsListAsync() {
            return base.Channel.getStationsListAsync();
        }
        
        public test.ProxyCacheRef.JCDecauxItem getStationsListWithContractName(string contractName) {
            return base.Channel.getStationsListWithContractName(contractName);
        }
        
        public System.Threading.Tasks.Task<test.ProxyCacheRef.JCDecauxItem> getStationsListWithContractNameAsync(string contractName) {
            return base.Channel.getStationsListWithContractNameAsync(contractName);
        }
    }
}