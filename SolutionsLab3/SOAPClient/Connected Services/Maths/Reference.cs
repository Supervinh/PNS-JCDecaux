﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPClient.Maths {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Maths.IMathsOperations")]
    public interface IMathsOperations {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Add", ReplyAction="http://tempuri.org/IMathsOperations/AddResponse")]
        int Add(int left, int right);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Add", ReplyAction="http://tempuri.org/IMathsOperations/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int left, int right);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Subtract", ReplyAction="http://tempuri.org/IMathsOperations/SubtractResponse")]
        int Subtract(int left, int right);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Subtract", ReplyAction="http://tempuri.org/IMathsOperations/SubtractResponse")]
        System.Threading.Tasks.Task<int> SubtractAsync(int left, int right);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Multiply", ReplyAction="http://tempuri.org/IMathsOperations/MultiplyResponse")]
        int Multiply(int left, int right);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Multiply", ReplyAction="http://tempuri.org/IMathsOperations/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int left, int right);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathsOperationsChannel : SOAPClient.Maths.IMathsOperations, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathsOperationsClient : System.ServiceModel.ClientBase<SOAPClient.Maths.IMathsOperations>, SOAPClient.Maths.IMathsOperations {
        
        public MathsOperationsClient() {
        }
        
        public MathsOperationsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathsOperationsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathsOperationsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathsOperationsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int left, int right) {
            return base.Channel.Add(left, right);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int left, int right) {
            return base.Channel.AddAsync(left, right);
        }
        
        public int Subtract(int left, int right) {
            return base.Channel.Subtract(left, right);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int left, int right) {
            return base.Channel.SubtractAsync(left, right);
        }
        
        public int Multiply(int left, int right) {
            return base.Channel.Multiply(left, right);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int left, int right) {
            return base.Channel.MultiplyAsync(left, right);
        }
    }
}
