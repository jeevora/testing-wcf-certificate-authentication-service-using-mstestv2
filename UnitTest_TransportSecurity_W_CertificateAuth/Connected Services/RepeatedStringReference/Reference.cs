﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTest_TransportSecurity_W_CertificateAuth.RepeatedStringReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RepeatedStringReference.IRepeatedString")]
    public interface IRepeatedString {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepeatedString/RepeatedString", ReplyAction="http://tempuri.org/IRepeatedString/RepeatedStringResponse")]
        long RepeatedString([System.ServiceModel.MessageParameterAttribute(Name="repeatedString")] string repeatedString1, long number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepeatedString/RepeatedString", ReplyAction="http://tempuri.org/IRepeatedString/RepeatedStringResponse")]
        System.Threading.Tasks.Task<long> RepeatedStringAsync(string repeatedString, long number);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRepeatedStringChannel : UnitTest_TransportSecurity_W_CertificateAuth.RepeatedStringReference.IRepeatedString, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RepeatedStringClient : System.ServiceModel.ClientBase<UnitTest_TransportSecurity_W_CertificateAuth.RepeatedStringReference.IRepeatedString>, UnitTest_TransportSecurity_W_CertificateAuth.RepeatedStringReference.IRepeatedString {
        
        public RepeatedStringClient() {
        }
        
        public RepeatedStringClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RepeatedStringClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RepeatedStringClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RepeatedStringClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long RepeatedString(string repeatedString1, long number) {
            return base.Channel.RepeatedString(repeatedString1, number);
        }
        
        public System.Threading.Tasks.Task<long> RepeatedStringAsync(string repeatedString, long number) {
            return base.Channel.RepeatedStringAsync(repeatedString, number);
        }
    }
}
