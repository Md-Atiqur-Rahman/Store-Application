﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 12.0.21005.1
// 
namespace App1.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://tempuri.org/")]
    public partial class Customer : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int CIDField;
        
        private string CNameField;
        
        private string AddresssField;
        
        private string CityField;
        
        private string PinCodeField;
        
        private string CountryField;
        
        private int phone_NumberField;
        
        private string EmailField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int CID {
            get {
                return this.CIDField;
            }
            set {
                if ((this.CIDField.Equals(value) != true)) {
                    this.CIDField = value;
                    this.RaisePropertyChanged("CID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CName {
            get {
                return this.CNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CNameField, value) != true)) {
                    this.CNameField = value;
                    this.RaisePropertyChanged("CName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Addresss {
            get {
                return this.AddresssField;
            }
            set {
                if ((object.ReferenceEquals(this.AddresssField, value) != true)) {
                    this.AddresssField = value;
                    this.RaisePropertyChanged("Addresss");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string PinCode {
            get {
                return this.PinCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PinCodeField, value) != true)) {
                    this.PinCodeField = value;
                    this.RaisePropertyChanged("PinCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int phone_Number {
            get {
                return this.phone_NumberField;
            }
            set {
                if ((this.phone_NumberField.Equals(value) != true)) {
                    this.phone_NumberField = value;
                    this.RaisePropertyChanged("phone_Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Service1Soap")]
    public interface Service1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<App1.ServiceReference1.InsertResponse> InsertAsync(App1.ServiceReference1.InsertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<App1.ServiceReference1.UpdateResponse> UpdateAsync(App1.ServiceReference1.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DeleteAsync(int contactd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Search", ReplyAction="*")]
        System.Threading.Tasks.Task<App1.ServiceReference1.SearchResponse> SearchAsync(App1.ServiceReference1.SearchRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert", Namespace="http://tempuri.org/", Order=0)]
        public App1.ServiceReference1.InsertRequestBody Body;
        
        public InsertRequest() {
        }
        
        public InsertRequest(App1.ServiceReference1.InsertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public App1.ServiceReference1.Customer Cus;
        
        public InsertRequestBody() {
        }
        
        public InsertRequestBody(App1.ServiceReference1.Customer Cus) {
            this.Cus = Cus;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertResponse", Namespace="http://tempuri.org/", Order=0)]
        public App1.ServiceReference1.InsertResponseBody Body;
        
        public InsertResponse() {
        }
        
        public InsertResponse(App1.ServiceReference1.InsertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int InsertResult;
        
        public InsertResponseBody() {
        }
        
        public InsertResponseBody(int InsertResult) {
            this.InsertResult = InsertResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public App1.ServiceReference1.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(App1.ServiceReference1.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public App1.ServiceReference1.Customer Cus;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int id;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(App1.ServiceReference1.Customer Cus, int id) {
            this.Cus = Cus;
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public App1.ServiceReference1.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(App1.ServiceReference1.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int UpdateResult;
        
        public UpdateResponseBody() {
        }
        
        public UpdateResponseBody(int UpdateResult) {
            this.UpdateResult = UpdateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Search", Namespace="http://tempuri.org/", Order=0)]
        public App1.ServiceReference1.SearchRequestBody Body;
        
        public SearchRequest() {
        }
        
        public SearchRequest(App1.ServiceReference1.SearchRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public SearchRequestBody() {
        }
        
        public SearchRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SearchResponse", Namespace="http://tempuri.org/", Order=0)]
        public App1.ServiceReference1.SearchResponseBody Body;
        
        public SearchResponse() {
        }
        
        public SearchResponse(App1.ServiceReference1.SearchResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public App1.ServiceReference1.Customer SearchResult;
        
        public SearchResponseBody() {
        }
        
        public SearchResponseBody(App1.ServiceReference1.Customer SearchResult) {
            this.SearchResult = SearchResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : App1.ServiceReference1.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<App1.ServiceReference1.Service1Soap>, App1.ServiceReference1.Service1Soap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1SoapClient() : 
                base(Service1SoapClient.GetDefaultBinding(), Service1SoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.Service1Soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(Service1SoapClient.GetBindingForEndpoint(endpointConfiguration), Service1SoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<App1.ServiceReference1.InsertResponse> App1.ServiceReference1.Service1Soap.InsertAsync(App1.ServiceReference1.InsertRequest request) {
            return base.Channel.InsertAsync(request);
        }
        
        public System.Threading.Tasks.Task<App1.ServiceReference1.InsertResponse> InsertAsync(App1.ServiceReference1.Customer Cus) {
            App1.ServiceReference1.InsertRequest inValue = new App1.ServiceReference1.InsertRequest();
            inValue.Body = new App1.ServiceReference1.InsertRequestBody();
            inValue.Body.Cus = Cus;
            return ((App1.ServiceReference1.Service1Soap)(this)).InsertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<App1.ServiceReference1.UpdateResponse> App1.ServiceReference1.Service1Soap.UpdateAsync(App1.ServiceReference1.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<App1.ServiceReference1.UpdateResponse> UpdateAsync(App1.ServiceReference1.Customer Cus, int id) {
            App1.ServiceReference1.UpdateRequest inValue = new App1.ServiceReference1.UpdateRequest();
            inValue.Body = new App1.ServiceReference1.UpdateRequestBody();
            inValue.Body.Cus = Cus;
            inValue.Body.id = id;
            return ((App1.ServiceReference1.Service1Soap)(this)).UpdateAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAsync(int contactd) {
            return base.Channel.DeleteAsync(contactd);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<App1.ServiceReference1.SearchResponse> App1.ServiceReference1.Service1Soap.SearchAsync(App1.ServiceReference1.SearchRequest request) {
            return base.Channel.SearchAsync(request);
        }
        
        public System.Threading.Tasks.Task<App1.ServiceReference1.SearchResponse> SearchAsync(int id) {
            App1.ServiceReference1.SearchRequest inValue = new App1.ServiceReference1.SearchRequest();
            inValue.Body = new App1.ServiceReference1.SearchRequestBody();
            inValue.Body.id = id;
            return ((App1.ServiceReference1.Service1Soap)(this)).SearchAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.Service1Soap)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.Service1Soap)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:22154/Service1.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return Service1SoapClient.GetBindingForEndpoint(EndpointConfiguration.Service1Soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return Service1SoapClient.GetEndpointAddress(EndpointConfiguration.Service1Soap);
        }
        
        public enum EndpointConfiguration {
            
            Service1Soap,
        }
    }
}