﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M4.ValidacaoAcesso {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ValidacaoAcesso.ValidacaoAcessoSoap")]
    public interface ValidacaoAcessoSoap {
        
        // CODEGEN: Generating message contract since element name codigoSessao from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FinalizarSessao", ReplyAction="*")]
        M4.ValidacaoAcesso.FinalizarSessaoResponse FinalizarSessao(M4.ValidacaoAcesso.FinalizarSessaoRequest request);
        
        // CODEGEN: Generating message contract since element name login from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidarUsuario", ReplyAction="*")]
        M4.ValidacaoAcesso.ValidarUsuarioResponse ValidarUsuario(M4.ValidacaoAcesso.ValidarUsuarioRequest request);
        
        // CODEGEN: Generating message contract since element name login from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RevalidarUsuario", ReplyAction="*")]
        M4.ValidacaoAcesso.RevalidarUsuarioResponse RevalidarUsuario(M4.ValidacaoAcesso.RevalidarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FinalizarSessaoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FinalizarSessao", Namespace="http://tempuri.org/", Order=0)]
        public M4.ValidacaoAcesso.FinalizarSessaoRequestBody Body;
        
        public FinalizarSessaoRequest() {
        }
        
        public FinalizarSessaoRequest(M4.ValidacaoAcesso.FinalizarSessaoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FinalizarSessaoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string codigoSessao;
        
        public FinalizarSessaoRequestBody() {
        }
        
        public FinalizarSessaoRequestBody(string codigoSessao) {
            this.codigoSessao = codigoSessao;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FinalizarSessaoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FinalizarSessaoResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.ValidacaoAcesso.FinalizarSessaoResponseBody Body;
        
        public FinalizarSessaoResponse() {
        }
        
        public FinalizarSessaoResponse(M4.ValidacaoAcesso.FinalizarSessaoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FinalizarSessaoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement FinalizarSessaoResult;
        
        public FinalizarSessaoResponseBody() {
        }
        
        public FinalizarSessaoResponseBody(System.Xml.Linq.XElement FinalizarSessaoResult) {
            this.FinalizarSessaoResult = FinalizarSessaoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public M4.ValidacaoAcesso.ValidarUsuarioRequestBody Body;
        
        public ValidarUsuarioRequest() {
        }
        
        public ValidarUsuarioRequest(M4.ValidacaoAcesso.ValidarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string login;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string senha;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string codigoSessao;
        
        public ValidarUsuarioRequestBody() {
        }
        
        public ValidarUsuarioRequestBody(string login, string senha, string codigoSessao) {
            this.login = login;
            this.senha = senha;
            this.codigoSessao = codigoSessao;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.ValidacaoAcesso.ValidarUsuarioResponseBody Body;
        
        public ValidarUsuarioResponse() {
        }
        
        public ValidarUsuarioResponse(M4.ValidacaoAcesso.ValidarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement ValidarUsuarioResult;
        
        public ValidarUsuarioResponseBody() {
        }
        
        public ValidarUsuarioResponseBody(System.Xml.Linq.XElement ValidarUsuarioResult) {
            this.ValidarUsuarioResult = ValidarUsuarioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RevalidarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RevalidarUsuario", Namespace="http://tempuri.org/", Order=0)]
        public M4.ValidacaoAcesso.RevalidarUsuarioRequestBody Body;
        
        public RevalidarUsuarioRequest() {
        }
        
        public RevalidarUsuarioRequest(M4.ValidacaoAcesso.RevalidarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RevalidarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string login;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string senha;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string codigoSessao;
        
        public RevalidarUsuarioRequestBody() {
        }
        
        public RevalidarUsuarioRequestBody(string login, string senha, string codigoSessao) {
            this.login = login;
            this.senha = senha;
            this.codigoSessao = codigoSessao;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RevalidarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RevalidarUsuarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public M4.ValidacaoAcesso.RevalidarUsuarioResponseBody Body;
        
        public RevalidarUsuarioResponse() {
        }
        
        public RevalidarUsuarioResponse(M4.ValidacaoAcesso.RevalidarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RevalidarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement RevalidarUsuarioResult;
        
        public RevalidarUsuarioResponseBody() {
        }
        
        public RevalidarUsuarioResponseBody(System.Xml.Linq.XElement RevalidarUsuarioResult) {
            this.RevalidarUsuarioResult = RevalidarUsuarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ValidacaoAcessoSoapChannel : M4.ValidacaoAcesso.ValidacaoAcessoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ValidacaoAcessoSoapClient : System.ServiceModel.ClientBase<M4.ValidacaoAcesso.ValidacaoAcessoSoap>, M4.ValidacaoAcesso.ValidacaoAcessoSoap {
        
        public ValidacaoAcessoSoapClient() {
        }
        
        public ValidacaoAcessoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ValidacaoAcessoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidacaoAcessoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidacaoAcessoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.ValidacaoAcesso.FinalizarSessaoResponse M4.ValidacaoAcesso.ValidacaoAcessoSoap.FinalizarSessao(M4.ValidacaoAcesso.FinalizarSessaoRequest request) {
            return base.Channel.FinalizarSessao(request);
        }
        
        public System.Xml.Linq.XElement FinalizarSessao(string codigoSessao) {
            M4.ValidacaoAcesso.FinalizarSessaoRequest inValue = new M4.ValidacaoAcesso.FinalizarSessaoRequest();
            inValue.Body = new M4.ValidacaoAcesso.FinalizarSessaoRequestBody();
            inValue.Body.codigoSessao = codigoSessao;
            M4.ValidacaoAcesso.FinalizarSessaoResponse retVal = ((M4.ValidacaoAcesso.ValidacaoAcessoSoap)(this)).FinalizarSessao(inValue);
            return retVal.Body.FinalizarSessaoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.ValidacaoAcesso.ValidarUsuarioResponse M4.ValidacaoAcesso.ValidacaoAcessoSoap.ValidarUsuario(M4.ValidacaoAcesso.ValidarUsuarioRequest request) {
            return base.Channel.ValidarUsuario(request);
        }
        
        public System.Xml.Linq.XElement ValidarUsuario(string login, string senha, string codigoSessao) {
            M4.ValidacaoAcesso.ValidarUsuarioRequest inValue = new M4.ValidacaoAcesso.ValidarUsuarioRequest();
            inValue.Body = new M4.ValidacaoAcesso.ValidarUsuarioRequestBody();
            inValue.Body.login = login;
            inValue.Body.senha = senha;
            inValue.Body.codigoSessao = codigoSessao;
            M4.ValidacaoAcesso.ValidarUsuarioResponse retVal = ((M4.ValidacaoAcesso.ValidacaoAcessoSoap)(this)).ValidarUsuario(inValue);
            return retVal.Body.ValidarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        M4.ValidacaoAcesso.RevalidarUsuarioResponse M4.ValidacaoAcesso.ValidacaoAcessoSoap.RevalidarUsuario(M4.ValidacaoAcesso.RevalidarUsuarioRequest request) {
            return base.Channel.RevalidarUsuario(request);
        }
        
        public System.Xml.Linq.XElement RevalidarUsuario(string login, string senha, string codigoSessao) {
            M4.ValidacaoAcesso.RevalidarUsuarioRequest inValue = new M4.ValidacaoAcesso.RevalidarUsuarioRequest();
            inValue.Body = new M4.ValidacaoAcesso.RevalidarUsuarioRequestBody();
            inValue.Body.login = login;
            inValue.Body.senha = senha;
            inValue.Body.codigoSessao = codigoSessao;
            M4.ValidacaoAcesso.RevalidarUsuarioResponse retVal = ((M4.ValidacaoAcesso.ValidacaoAcessoSoap)(this)).RevalidarUsuario(inValue);
            return retVal.Body.RevalidarUsuarioResult;
        }
    }
}
