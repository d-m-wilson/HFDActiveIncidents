﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HFDActiveIncidents.HFDApp {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HFDApp.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        HFDActiveIncidents.HFDApp.HelloWorldResponse HelloWorld(HFDActiveIncidents.HFDApp.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.HelloWorldResponse> HelloWorldAsync(HFDActiveIncidents.HFDApp.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name HelloPersonResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloPerson", ReplyAction="*")]
        HFDActiveIncidents.HFDApp.HelloPersonResponse HelloPerson(HFDActiveIncidents.HFDApp.HelloPersonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloPerson", ReplyAction="*")]
        System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.HelloPersonResponse> HelloPersonAsync(HFDActiveIncidents.HFDApp.HelloPersonRequest request);
        
        // CODEGEN: Generating message contract since element name GetIncidentsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIncidents", ReplyAction="*")]
        HFDActiveIncidents.HFDApp.GetIncidentsResponse GetIncidents(HFDActiveIncidents.HFDApp.GetIncidentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIncidents", ReplyAction="*")]
        System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.GetIncidentsResponse> GetIncidentsAsync(HFDActiveIncidents.HFDApp.GetIncidentsRequest request);
        
        // CODEGEN: Generating message contract since element name GetIncidentsPOSTResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIncidentsPOST", ReplyAction="*")]
        HFDActiveIncidents.HFDApp.GetIncidentsPOSTResponse GetIncidentsPOST(HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIncidentsPOST", ReplyAction="*")]
        System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.GetIncidentsPOSTResponse> GetIncidentsPOSTAsync(HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public HFDActiveIncidents.HFDApp.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(HFDActiveIncidents.HFDApp.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public HFDActiveIncidents.HFDApp.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(HFDActiveIncidents.HFDApp.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloPersonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloPerson", Namespace="http://tempuri.org/", Order=0)]
        public HFDActiveIncidents.HFDApp.HelloPersonRequestBody Body;
        
        public HelloPersonRequest() {
        }
        
        public HelloPersonRequest(HFDActiveIncidents.HFDApp.HelloPersonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloPersonRequestBody {
        
        public HelloPersonRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloPersonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloPersonResponse", Namespace="http://tempuri.org/", Order=0)]
        public HFDActiveIncidents.HFDApp.HelloPersonResponseBody Body;
        
        public HelloPersonResponse() {
        }
        
        public HelloPersonResponse(HFDActiveIncidents.HFDApp.HelloPersonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloPersonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public object HelloPersonResult;
        
        public HelloPersonResponseBody() {
        }
        
        public HelloPersonResponseBody(object HelloPersonResult) {
            this.HelloPersonResult = HelloPersonResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIncidentsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIncidents", Namespace="http://tempuri.org/", Order=0)]
        public HFDActiveIncidents.HFDApp.GetIncidentsRequestBody Body;
        
        public GetIncidentsRequest() {
        }
        
        public GetIncidentsRequest(HFDActiveIncidents.HFDApp.GetIncidentsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetIncidentsRequestBody {
        
        public GetIncidentsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIncidentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIncidentsResponse", Namespace="http://tempuri.org/", Order=0)]
        public HFDActiveIncidents.HFDApp.GetIncidentsResponseBody Body;
        
        public GetIncidentsResponse() {
        }
        
        public GetIncidentsResponse(HFDActiveIncidents.HFDApp.GetIncidentsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIncidentsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetIncidentsResult;
        
        public GetIncidentsResponseBody() {
        }
        
        public GetIncidentsResponseBody(string GetIncidentsResult) {
            this.GetIncidentsResult = GetIncidentsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIncidentsPOSTRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIncidentsPOST", Namespace="http://tempuri.org/", Order=0)]
        public HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequestBody Body;
        
        public GetIncidentsPOSTRequest() {
        }
        
        public GetIncidentsPOSTRequest(HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetIncidentsPOSTRequestBody {
        
        public GetIncidentsPOSTRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetIncidentsPOSTResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetIncidentsPOSTResponse", Namespace="http://tempuri.org/", Order=0)]
        public HFDActiveIncidents.HFDApp.GetIncidentsPOSTResponseBody Body;
        
        public GetIncidentsPOSTResponse() {
        }
        
        public GetIncidentsPOSTResponse(HFDActiveIncidents.HFDApp.GetIncidentsPOSTResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetIncidentsPOSTResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetIncidentsPOSTResult;
        
        public GetIncidentsPOSTResponseBody() {
        }
        
        public GetIncidentsPOSTResponseBody(string GetIncidentsPOSTResult) {
            this.GetIncidentsPOSTResult = GetIncidentsPOSTResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : HFDActiveIncidents.HFDApp.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<HFDActiveIncidents.HFDApp.WebService1Soap>, HFDActiveIncidents.HFDApp.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HFDActiveIncidents.HFDApp.HelloWorldResponse HFDActiveIncidents.HFDApp.WebService1Soap.HelloWorld(HFDActiveIncidents.HFDApp.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            HFDActiveIncidents.HFDApp.HelloWorldRequest inValue = new HFDActiveIncidents.HFDApp.HelloWorldRequest();
            inValue.Body = new HFDActiveIncidents.HFDApp.HelloWorldRequestBody();
            HFDActiveIncidents.HFDApp.HelloWorldResponse retVal = ((HFDActiveIncidents.HFDApp.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.HelloWorldResponse> HFDActiveIncidents.HFDApp.WebService1Soap.HelloWorldAsync(HFDActiveIncidents.HFDApp.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.HelloWorldResponse> HelloWorldAsync() {
            HFDActiveIncidents.HFDApp.HelloWorldRequest inValue = new HFDActiveIncidents.HFDApp.HelloWorldRequest();
            inValue.Body = new HFDActiveIncidents.HFDApp.HelloWorldRequestBody();
            return ((HFDActiveIncidents.HFDApp.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HFDActiveIncidents.HFDApp.HelloPersonResponse HFDActiveIncidents.HFDApp.WebService1Soap.HelloPerson(HFDActiveIncidents.HFDApp.HelloPersonRequest request) {
            return base.Channel.HelloPerson(request);
        }
        
        public object HelloPerson() {
            HFDActiveIncidents.HFDApp.HelloPersonRequest inValue = new HFDActiveIncidents.HFDApp.HelloPersonRequest();
            inValue.Body = new HFDActiveIncidents.HFDApp.HelloPersonRequestBody();
            HFDActiveIncidents.HFDApp.HelloPersonResponse retVal = ((HFDActiveIncidents.HFDApp.WebService1Soap)(this)).HelloPerson(inValue);
            return retVal.Body.HelloPersonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.HelloPersonResponse> HFDActiveIncidents.HFDApp.WebService1Soap.HelloPersonAsync(HFDActiveIncidents.HFDApp.HelloPersonRequest request) {
            return base.Channel.HelloPersonAsync(request);
        }
        
        public System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.HelloPersonResponse> HelloPersonAsync() {
            HFDActiveIncidents.HFDApp.HelloPersonRequest inValue = new HFDActiveIncidents.HFDApp.HelloPersonRequest();
            inValue.Body = new HFDActiveIncidents.HFDApp.HelloPersonRequestBody();
            return ((HFDActiveIncidents.HFDApp.WebService1Soap)(this)).HelloPersonAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HFDActiveIncidents.HFDApp.GetIncidentsResponse HFDActiveIncidents.HFDApp.WebService1Soap.GetIncidents(HFDActiveIncidents.HFDApp.GetIncidentsRequest request) {
            return base.Channel.GetIncidents(request);
        }
        
        public string GetIncidents() {
            HFDActiveIncidents.HFDApp.GetIncidentsRequest inValue = new HFDActiveIncidents.HFDApp.GetIncidentsRequest();
            inValue.Body = new HFDActiveIncidents.HFDApp.GetIncidentsRequestBody();
            HFDActiveIncidents.HFDApp.GetIncidentsResponse retVal = ((HFDActiveIncidents.HFDApp.WebService1Soap)(this)).GetIncidents(inValue);
            return retVal.Body.GetIncidentsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.GetIncidentsResponse> HFDActiveIncidents.HFDApp.WebService1Soap.GetIncidentsAsync(HFDActiveIncidents.HFDApp.GetIncidentsRequest request) {
            return base.Channel.GetIncidentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.GetIncidentsResponse> GetIncidentsAsync() {
            HFDActiveIncidents.HFDApp.GetIncidentsRequest inValue = new HFDActiveIncidents.HFDApp.GetIncidentsRequest();
            inValue.Body = new HFDActiveIncidents.HFDApp.GetIncidentsRequestBody();
            return ((HFDActiveIncidents.HFDApp.WebService1Soap)(this)).GetIncidentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HFDActiveIncidents.HFDApp.GetIncidentsPOSTResponse HFDActiveIncidents.HFDApp.WebService1Soap.GetIncidentsPOST(HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequest request) {
            return base.Channel.GetIncidentsPOST(request);
        }
        
        public string GetIncidentsPOST() {
            HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequest inValue = new HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequest();
            inValue.Body = new HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequestBody();
            HFDActiveIncidents.HFDApp.GetIncidentsPOSTResponse retVal = ((HFDActiveIncidents.HFDApp.WebService1Soap)(this)).GetIncidentsPOST(inValue);
            return retVal.Body.GetIncidentsPOSTResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.GetIncidentsPOSTResponse> HFDActiveIncidents.HFDApp.WebService1Soap.GetIncidentsPOSTAsync(HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequest request) {
            return base.Channel.GetIncidentsPOSTAsync(request);
        }
        
        public System.Threading.Tasks.Task<HFDActiveIncidents.HFDApp.GetIncidentsPOSTResponse> GetIncidentsPOSTAsync() {
            HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequest inValue = new HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequest();
            inValue.Body = new HFDActiveIncidents.HFDApp.GetIncidentsPOSTRequestBody();
            return ((HFDActiveIncidents.HFDApp.WebService1Soap)(this)).GetIncidentsPOSTAsync(inValue);
        }
    }
}