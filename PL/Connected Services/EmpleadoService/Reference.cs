﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.EmpleadoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmpleadoService.IEmpleado")]
    public interface IEmpleado {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/Add", ReplyAction="http://tempuri.org/IEmpleado/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empresa))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empleado))]
        ML.Result Add(ML.Empleado empleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/Add", ReplyAction="http://tempuri.org/IEmpleado/AddResponse")]
        System.Threading.Tasks.Task<ML.Result> AddAsync(ML.Empleado empleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/Update", ReplyAction="http://tempuri.org/IEmpleado/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empresa))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empleado))]
        ML.Result Update(ML.Empleado empleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/Update", ReplyAction="http://tempuri.org/IEmpleado/UpdateResponse")]
        System.Threading.Tasks.Task<ML.Result> UpdateAsync(ML.Empleado empleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/Delete", ReplyAction="http://tempuri.org/IEmpleado/DeleteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empresa))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empleado))]
        ML.Result Delete(ML.Empleado empleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/Delete", ReplyAction="http://tempuri.org/IEmpleado/DeleteResponse")]
        System.Threading.Tasks.Task<ML.Result> DeleteAsync(ML.Empleado empleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/GetAll", ReplyAction="http://tempuri.org/IEmpleado/GetAllResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empresa))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empleado))]
        ML.Result GetAll(ML.Empleado empleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/GetAll", ReplyAction="http://tempuri.org/IEmpleado/GetAllResponse")]
        System.Threading.Tasks.Task<ML.Result> GetAllAsync(ML.Empleado empleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/GetById", ReplyAction="http://tempuri.org/IEmpleado/GetByIdResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empleado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Empresa))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        ML.Result GetById(string NumeroEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleado/GetById", ReplyAction="http://tempuri.org/IEmpleado/GetByIdResponse")]
        System.Threading.Tasks.Task<ML.Result> GetByIdAsync(string NumeroEmpleado);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpleadoChannel : PL.EmpleadoService.IEmpleado, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpleadoClient : System.ServiceModel.ClientBase<PL.EmpleadoService.IEmpleado>, PL.EmpleadoService.IEmpleado {
        
        public EmpleadoClient() {
        }
        
        public EmpleadoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpleadoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpleadoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpleadoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ML.Result Add(ML.Empleado empleado) {
            return base.Channel.Add(empleado);
        }
        
        public System.Threading.Tasks.Task<ML.Result> AddAsync(ML.Empleado empleado) {
            return base.Channel.AddAsync(empleado);
        }
        
        public ML.Result Update(ML.Empleado empleado) {
            return base.Channel.Update(empleado);
        }
        
        public System.Threading.Tasks.Task<ML.Result> UpdateAsync(ML.Empleado empleado) {
            return base.Channel.UpdateAsync(empleado);
        }
        
        public ML.Result Delete(ML.Empleado empleado) {
            return base.Channel.Delete(empleado);
        }
        
        public System.Threading.Tasks.Task<ML.Result> DeleteAsync(ML.Empleado empleado) {
            return base.Channel.DeleteAsync(empleado);
        }
        
        public ML.Result GetAll(ML.Empleado empleado) {
            return base.Channel.GetAll(empleado);
        }
        
        public System.Threading.Tasks.Task<ML.Result> GetAllAsync(ML.Empleado empleado) {
            return base.Channel.GetAllAsync(empleado);
        }
        
        public ML.Result GetById(string NumeroEmpleado) {
            return base.Channel.GetById(NumeroEmpleado);
        }
        
        public System.Threading.Tasks.Task<ML.Result> GetByIdAsync(string NumeroEmpleado) {
            return base.Channel.GetByIdAsync(NumeroEmpleado);
        }
    }
}
