﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.17929
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSPingPongCSClient.WSPingPongJavaService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.test.com", ConfigurationName="WSPingPongJavaService.WSPingPongJavaService")]
    public interface WSPingPongJavaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.test.com/WSPingPongJavaService/Ball_InRequest", ReplyAction="http://www.test.com/WSPingPongJavaService/Ball_InResponse")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        void Ball_In(string arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.test.com/WSPingPongJavaService/Ball_InRequest", ReplyAction="http://www.test.com/WSPingPongJavaService/Ball_InResponse")]
        System.Threading.Tasks.Task Ball_InAsync(string arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.test.com/WSPingPongJavaService/Ball_OutRequest", ReplyAction="http://www.test.com/WSPingPongJavaService/Ball_OutResponse")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string Ball_Out();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.test.com/WSPingPongJavaService/Ball_OutRequest", ReplyAction="http://www.test.com/WSPingPongJavaService/Ball_OutResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> Ball_OutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.test.com/WSPingPongJavaService/Ball_CheckRequest", ReplyAction="http://www.test.com/WSPingPongJavaService/Ball_CheckResponse")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool Ball_Check();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.test.com/WSPingPongJavaService/Ball_CheckRequest", ReplyAction="http://www.test.com/WSPingPongJavaService/Ball_CheckResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> Ball_CheckAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSPingPongJavaServiceChannel : WSPingPongCSClient.WSPingPongJavaService.WSPingPongJavaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSPingPongJavaServiceClient : System.ServiceModel.ClientBase<WSPingPongCSClient.WSPingPongJavaService.WSPingPongJavaService>, WSPingPongCSClient.WSPingPongJavaService.WSPingPongJavaService {
        
        public WSPingPongJavaServiceClient() {
        }
        
        public WSPingPongJavaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSPingPongJavaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPingPongJavaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPingPongJavaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Ball_In(string arg0) {
            base.Channel.Ball_In(arg0);
        }
        
        public System.Threading.Tasks.Task Ball_InAsync(string arg0) {
            return base.Channel.Ball_InAsync(arg0);
        }
        
        public string Ball_Out() {
            return base.Channel.Ball_Out();
        }
        
        public System.Threading.Tasks.Task<string> Ball_OutAsync() {
            return base.Channel.Ball_OutAsync();
        }
        
        public bool Ball_Check() {
            return base.Channel.Ball_Check();
        }
        
        public System.Threading.Tasks.Task<bool> Ball_CheckAsync() {
            return base.Channel.Ball_CheckAsync();
        }
    }
}