﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JustWcfServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FigureContract", Namespace="http://schemas.datacontract.org/2004/07/JustWcfServiceCalc")]
    public partial class FigureContract : object
    {
        
        private string ColorField;
        
        private int HeightField;
        
        private int OffsetLeftField;
        
        private int OffsetTopField;
        
        private int WidthField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color
        {
            get
            {
                return this.ColorField;
            }
            set
            {
                this.ColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Height
        {
            get
            {
                return this.HeightField;
            }
            set
            {
                this.HeightField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OffsetLeft
        {
            get
            {
                return this.OffsetLeftField;
            }
            set
            {
                this.OffsetLeftField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OffsetTop
        {
            get
            {
                return this.OffsetTopField;
            }
            set
            {
                this.OffsetTopField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Width
        {
            get
            {
                return this.WidthField;
            }
            set
            {
                this.WidthField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JustWcfServiceReference.IFigureService")]
    public interface IFigureService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFigureService/Save", ReplyAction="http://tempuri.org/IFigureService/SaveResponse")]
        void Save(JustWcfServiceReference.FigureContract figure);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFigureService/Save", ReplyAction="http://tempuri.org/IFigureService/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync(JustWcfServiceReference.FigureContract figure);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFigureService/Load", ReplyAction="http://tempuri.org/IFigureService/LoadResponse")]
        JustWcfServiceReference.FigureContract Load();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFigureService/Load", ReplyAction="http://tempuri.org/IFigureService/LoadResponse")]
        System.Threading.Tasks.Task<JustWcfServiceReference.FigureContract> LoadAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IFigureServiceChannel : JustWcfServiceReference.IFigureService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class FigureServiceClient : System.ServiceModel.ClientBase<JustWcfServiceReference.IFigureService>, JustWcfServiceReference.IFigureService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FigureServiceClient() : 
                base(FigureServiceClient.GetDefaultBinding(), FigureServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IFigureService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FigureServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(FigureServiceClient.GetBindingForEndpoint(endpointConfiguration), FigureServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FigureServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FigureServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FigureServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FigureServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FigureServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void Save(JustWcfServiceReference.FigureContract figure)
        {
            base.Channel.Save(figure);
        }
        
        public System.Threading.Tasks.Task SaveAsync(JustWcfServiceReference.FigureContract figure)
        {
            return base.Channel.SaveAsync(figure);
        }
        
        public JustWcfServiceReference.FigureContract Load()
        {
            return base.Channel.Load();
        }
        
        public System.Threading.Tasks.Task<JustWcfServiceReference.FigureContract> LoadAsync()
        {
            return base.Channel.LoadAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFigureService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFigureService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/Design_Time_Addresses/JustWcfServiceCalc/Figure/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return FigureServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IFigureService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return FigureServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IFigureService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IFigureService,
        }
    }
}
