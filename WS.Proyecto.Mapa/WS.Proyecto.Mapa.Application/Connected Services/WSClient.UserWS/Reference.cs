﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSClient.UserWS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservice.tienda.proyecto.ws/", ConfigurationName="WSClient.UserWS.IUserWS")]
    public interface IUserWS
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.tienda.proyecto.ws/IUserWS/createUserRequest", ReplyAction="http://webservice.tienda.proyecto.ws/IUserWS/createUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WSClient.UserWS.createUserResponse> createUserAsync(WSClient.UserWS.createUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.tienda.proyecto.ws/IUserWS/findByUsernameRequest", ReplyAction="http://webservice.tienda.proyecto.ws/IUserWS/findByUsernameResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WSClient.UserWS.findByUsernameResponse> findByUsernameAsync(WSClient.UserWS.findByUsernameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.tienda.proyecto.ws/IUserWS/readAllUsersRequest", ReplyAction="http://webservice.tienda.proyecto.ws/IUserWS/readAllUsersResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WSClient.UserWS.readAllUsersResponse> readAllUsersAsync(WSClient.UserWS.readAllUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.tienda.proyecto.ws/IUserWS/updateUserRequest", ReplyAction="http://webservice.tienda.proyecto.ws/IUserWS/updateUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WSClient.UserWS.updateUserResponse> updateUserAsync(WSClient.UserWS.updateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.tienda.proyecto.ws/IUserWS/deleteUserRequest", ReplyAction="http://webservice.tienda.proyecto.ws/IUserWS/deleteUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WSClient.UserWS.deleteUserResponse> deleteUserAsync(WSClient.UserWS.deleteUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.tienda.proyecto.ws/IUserWS/readUserRequest", ReplyAction="http://webservice.tienda.proyecto.ws/IUserWS/readUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WSClient.UserWS.readUserResponse> readUserAsync(WSClient.UserWS.readUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.tienda.proyecto.ws/IUserWS/findByUsernamePasswordRequest", ReplyAction="http://webservice.tienda.proyecto.ws/IUserWS/findByUsernamePasswordResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WSClient.UserWS.findByUsernamePasswordResponse> findByUsernamePasswordAsync(WSClient.UserWS.findByUsernamePasswordRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.tienda.proyecto.ws/")]
    public partial class user
    {
        
        private int idField;
        
        private string nameField;
        
        private string passwordField;
        
        private string roleField;
        
        private string surnameField;
        
        private string usernameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createUser", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class createUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSClient.UserWS.user arg0;
        
        public createUserRequest()
        {
        }
        
        public createUserRequest(WSClient.UserWS.user arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createUserResponse", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class createUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public createUserResponse()
        {
        }
        
        public createUserResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findByUsername", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class findByUsernameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public findByUsernameRequest()
        {
        }
        
        public findByUsernameRequest(string arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findByUsernameResponse", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class findByUsernameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSClient.UserWS.user[] @return;
        
        public findByUsernameResponse()
        {
        }
        
        public findByUsernameResponse(WSClient.UserWS.user[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="readAllUsers", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class readAllUsersRequest
    {
        
        public readAllUsersRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="readAllUsersResponse", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class readAllUsersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSClient.UserWS.user[] @return;
        
        public readAllUsersResponse()
        {
        }
        
        public readAllUsersResponse(WSClient.UserWS.user[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateUser", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class updateUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSClient.UserWS.user arg0;
        
        public updateUserRequest()
        {
        }
        
        public updateUserRequest(WSClient.UserWS.user arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateUserResponse", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class updateUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public updateUserResponse()
        {
        }
        
        public updateUserResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteUser", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class deleteUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public deleteUserRequest()
        {
        }
        
        public deleteUserRequest(string arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteUserResponse", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class deleteUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public deleteUserResponse()
        {
        }
        
        public deleteUserResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="readUser", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class readUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public readUserRequest()
        {
        }
        
        public readUserRequest(string arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="readUserResponse", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class readUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSClient.UserWS.user @return;
        
        public readUserResponse()
        {
        }
        
        public readUserResponse(WSClient.UserWS.user @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findByUsernamePassword", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class findByUsernamePasswordRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        public findByUsernamePasswordRequest()
        {
        }
        
        public findByUsernamePasswordRequest(string arg0, string arg1)
        {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findByUsernamePasswordResponse", WrapperNamespace="http://webservice.tienda.proyecto.ws/", IsWrapped=true)]
    public partial class findByUsernamePasswordResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.tienda.proyecto.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSClient.UserWS.user[] @return;
        
        public findByUsernamePasswordResponse()
        {
        }
        
        public findByUsernamePasswordResponse(WSClient.UserWS.user[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IUserWSChannel : WSClient.UserWS.IUserWS, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class UserWSClient : System.ServiceModel.ClientBase<WSClient.UserWS.IUserWS>, WSClient.UserWS.IUserWS
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserWSClient() : 
                base(UserWSClient.GetDefaultBinding(), UserWSClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.UserWSPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserWSClient(EndpointConfiguration endpointConfiguration) : 
                base(UserWSClient.GetBindingForEndpoint(endpointConfiguration), UserWSClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserWSClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserWSClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserWSClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserWSClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.UserWS.createUserResponse> WSClient.UserWS.IUserWS.createUserAsync(WSClient.UserWS.createUserRequest request)
        {
            return base.Channel.createUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.UserWS.createUserResponse> createUserAsync(WSClient.UserWS.user arg0)
        {
            WSClient.UserWS.createUserRequest inValue = new WSClient.UserWS.createUserRequest();
            inValue.arg0 = arg0;
            return ((WSClient.UserWS.IUserWS)(this)).createUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.UserWS.findByUsernameResponse> WSClient.UserWS.IUserWS.findByUsernameAsync(WSClient.UserWS.findByUsernameRequest request)
        {
            return base.Channel.findByUsernameAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.UserWS.findByUsernameResponse> findByUsernameAsync(string arg0)
        {
            WSClient.UserWS.findByUsernameRequest inValue = new WSClient.UserWS.findByUsernameRequest();
            inValue.arg0 = arg0;
            return ((WSClient.UserWS.IUserWS)(this)).findByUsernameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.UserWS.readAllUsersResponse> WSClient.UserWS.IUserWS.readAllUsersAsync(WSClient.UserWS.readAllUsersRequest request)
        {
            return base.Channel.readAllUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.UserWS.readAllUsersResponse> readAllUsersAsync()
        {
            WSClient.UserWS.readAllUsersRequest inValue = new WSClient.UserWS.readAllUsersRequest();
            return ((WSClient.UserWS.IUserWS)(this)).readAllUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.UserWS.updateUserResponse> WSClient.UserWS.IUserWS.updateUserAsync(WSClient.UserWS.updateUserRequest request)
        {
            return base.Channel.updateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.UserWS.updateUserResponse> updateUserAsync(WSClient.UserWS.user arg0)
        {
            WSClient.UserWS.updateUserRequest inValue = new WSClient.UserWS.updateUserRequest();
            inValue.arg0 = arg0;
            return ((WSClient.UserWS.IUserWS)(this)).updateUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.UserWS.deleteUserResponse> WSClient.UserWS.IUserWS.deleteUserAsync(WSClient.UserWS.deleteUserRequest request)
        {
            return base.Channel.deleteUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.UserWS.deleteUserResponse> deleteUserAsync(string arg0)
        {
            WSClient.UserWS.deleteUserRequest inValue = new WSClient.UserWS.deleteUserRequest();
            inValue.arg0 = arg0;
            return ((WSClient.UserWS.IUserWS)(this)).deleteUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.UserWS.readUserResponse> WSClient.UserWS.IUserWS.readUserAsync(WSClient.UserWS.readUserRequest request)
        {
            return base.Channel.readUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.UserWS.readUserResponse> readUserAsync(string arg0)
        {
            WSClient.UserWS.readUserRequest inValue = new WSClient.UserWS.readUserRequest();
            inValue.arg0 = arg0;
            return ((WSClient.UserWS.IUserWS)(this)).readUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.UserWS.findByUsernamePasswordResponse> WSClient.UserWS.IUserWS.findByUsernamePasswordAsync(WSClient.UserWS.findByUsernamePasswordRequest request)
        {
            return base.Channel.findByUsernamePasswordAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.UserWS.findByUsernamePasswordResponse> findByUsernamePasswordAsync(string arg0, string arg1)
        {
            WSClient.UserWS.findByUsernamePasswordRequest inValue = new WSClient.UserWS.findByUsernamePasswordRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((WSClient.UserWS.IUserWS)(this)).findByUsernamePasswordAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.UserWSPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.UserWSPort))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8080/WS.Proyecto.Tienda/soapws/user");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserWSClient.GetBindingForEndpoint(EndpointConfiguration.UserWSPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserWSClient.GetEndpointAddress(EndpointConfiguration.UserWSPort);
        }
        
        public enum EndpointConfiguration
        {
            
            UserWSPort,
        }
    }
}