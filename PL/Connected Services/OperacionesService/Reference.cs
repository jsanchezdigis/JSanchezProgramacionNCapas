﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.OperacionesService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OperacionesService.IOperaciones")]
    public interface IOperaciones {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/DoWork", ReplyAction="http://tempuri.org/IOperaciones/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/DoWork", ReplyAction="http://tempuri.org/IOperaciones/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Suma", ReplyAction="http://tempuri.org/IOperaciones/SumaResponse")]
        int Suma(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Suma", ReplyAction="http://tempuri.org/IOperaciones/SumaResponse")]
        System.Threading.Tasks.Task<int> SumaAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Resta", ReplyAction="http://tempuri.org/IOperaciones/RestaResponse")]
        int Resta(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Resta", ReplyAction="http://tempuri.org/IOperaciones/RestaResponse")]
        System.Threading.Tasks.Task<int> RestaAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Multiplicar", ReplyAction="http://tempuri.org/IOperaciones/MultiplicarResponse")]
        int Multiplicar(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Multiplicar", ReplyAction="http://tempuri.org/IOperaciones/MultiplicarResponse")]
        System.Threading.Tasks.Task<int> MultiplicarAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Dividir", ReplyAction="http://tempuri.org/IOperaciones/DividirResponse")]
        double Dividir(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Dividir", ReplyAction="http://tempuri.org/IOperaciones/DividirResponse")]
        System.Threading.Tasks.Task<double> DividirAsync(double a, double b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOperacionesChannel : PL.OperacionesService.IOperaciones, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OperacionesClient : System.ServiceModel.ClientBase<PL.OperacionesService.IOperaciones>, PL.OperacionesService.IOperaciones {
        
        public OperacionesClient() {
        }
        
        public OperacionesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OperacionesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperacionesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperacionesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public int Suma(int a, int b) {
            return base.Channel.Suma(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SumaAsync(int a, int b) {
            return base.Channel.SumaAsync(a, b);
        }
        
        public int Resta(int a, int b) {
            return base.Channel.Resta(a, b);
        }
        
        public System.Threading.Tasks.Task<int> RestaAsync(int a, int b) {
            return base.Channel.RestaAsync(a, b);
        }
        
        public int Multiplicar(int a, int b) {
            return base.Channel.Multiplicar(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicarAsync(int a, int b) {
            return base.Channel.MultiplicarAsync(a, b);
        }
        
        public double Dividir(double a, double b) {
            return base.Channel.Dividir(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DividirAsync(double a, double b) {
            return base.Channel.DividirAsync(a, b);
        }
    }
}
