﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloClient.RemoteHelloReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RemoteHelloReference.IHelloService")]
    public interface IHelloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/SayHello", ReplyAction="http://tempuri.org/IHelloService/SayHelloResponse")]
        string SayHello();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/SayHello", ReplyAction="http://tempuri.org/IHelloService/SayHelloResponse")]
        System.Threading.Tasks.Task<string> SayHelloAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloServiceChannel : HelloClient.RemoteHelloReference.IHelloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloServiceClient : System.ServiceModel.ClientBase<HelloClient.RemoteHelloReference.IHelloService>, HelloClient.RemoteHelloReference.IHelloService {
        
        public HelloServiceClient() {
        }
        
        public HelloServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHello() {
            return base.Channel.SayHello();
        }
        
        public System.Threading.Tasks.Task<string> SayHelloAsync() {
            return base.Channel.SayHelloAsync();
        }
    }
}
