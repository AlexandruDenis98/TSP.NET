﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceClientWeb
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/MemoriesManager", IsReference=true)]
    public partial class Person : object
    {
        
        private ServiceReferenceClientWeb.File[] FilesField;
        
        private string First_nameField;
        
        private int IdField;
        
        private string Last_nameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceClientWeb.File[] Files
        {
            get
            {
                return this.FilesField;
            }
            set
            {
                this.FilesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string First_name
        {
            get
            {
                return this.First_nameField;
            }
            set
            {
                this.First_nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Last_name
        {
            get
            {
                return this.Last_nameField;
            }
            set
            {
                this.Last_nameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="File", Namespace="http://schemas.datacontract.org/2004/07/MemoriesManager", IsReference=true)]
    public partial class File : object
    {
        
        private System.DateTime Created_atField;
        
        private int FileIdField;
        
        private ServiceReferenceClientWeb.Keyword[] KeywordsField;
        
        private string LocationField;
        
        private string PathField;
        
        private bool Path_changedField;
        
        private ServiceReferenceClientWeb.Person[] PeopleField;
        
        private string TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Created_at
        {
            get
            {
                return this.Created_atField;
            }
            set
            {
                this.Created_atField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FileId
        {
            get
            {
                return this.FileIdField;
            }
            set
            {
                this.FileIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceClientWeb.Keyword[] Keywords
        {
            get
            {
                return this.KeywordsField;
            }
            set
            {
                this.KeywordsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Path_changed
        {
            get
            {
                return this.Path_changedField;
            }
            set
            {
                this.Path_changedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceClientWeb.Person[] People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Keyword", Namespace="http://schemas.datacontract.org/2004/07/MemoriesManager", IsReference=true)]
    public partial class Keyword : object
    {
        
        private ServiceReferenceClientWeb.File[] FilesField;
        
        private int IdField;
        
        private string KwordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceClientWeb.File[] Files
        {
            get
            {
                return this.FilesField;
            }
            set
            {
                this.FilesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Kword
        {
            get
            {
                return this.KwordField;
            }
            set
            {
                this.KwordField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceClientWeb.IFilePersonKeyword")]
    public interface IFilePersonKeyword
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePerson/CreatePerson", ReplyAction="http://tempuri.org/InterfacePerson/CreatePersonResponse")]
        System.Threading.Tasks.Task<bool> CreatePersonAsync(ServiceReferenceClientWeb.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePerson/DeletePerson", ReplyAction="http://tempuri.org/InterfacePerson/DeletePersonResponse")]
        System.Threading.Tasks.Task<int> DeletePersonAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePerson/GetAllPeople", ReplyAction="http://tempuri.org/InterfacePerson/GetAllPeopleResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person[]> GetAllPeopleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePerson/GetPersonByName", ReplyAction="http://tempuri.org/InterfacePerson/GetPersonByNameResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person> GetPersonByNameAsync(string First_name, string Last_name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePerson/UpdatePerson", ReplyAction="http://tempuri.org/InterfacePerson/UpdatePersonResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person> UpdatePersonAsync(ServiceReferenceClientWeb.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePerson/UpdatePersonNameById", ReplyAction="http://tempuri.org/InterfacePerson/UpdatePersonNameByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person> UpdatePersonNameByIdAsync(int id, string First_name, string Last_name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceKeyword/CreateKeyword", ReplyAction="http://tempuri.org/InterfaceKeyword/CreateKeywordResponse")]
        System.Threading.Tasks.Task<bool> CreateKeywordAsync(ServiceReferenceClientWeb.Keyword keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceKeyword/DeleteKeyword", ReplyAction="http://tempuri.org/InterfaceKeyword/DeleteKeywordResponse")]
        System.Threading.Tasks.Task<int> DeleteKeywordAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceKeyword/GetAllKeywords", ReplyAction="http://tempuri.org/InterfaceKeyword/GetAllKeywordsResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.Keyword[]> GetAllKeywordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceKeyword/GetKeywordByKword", ReplyAction="http://tempuri.org/InterfaceKeyword/GetKeywordByKwordResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.Keyword> GetKeywordByKwordAsync(string Kword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceKeyword/UpdateKeywordKwordById", ReplyAction="http://tempuri.org/InterfaceKeyword/UpdateKeywordKwordByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.Keyword> UpdateKeywordKwordByIdAsync(int id, string Kword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/CreateFile", ReplyAction="http://tempuri.org/InterfaceFile/CreateFileResponse")]
        System.Threading.Tasks.Task<bool> CreateFileAsync(ServiceReferenceClientWeb.File file);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetAllFiles", ReplyAction="http://tempuri.org/InterfaceFile/GetAllFilesResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.File[]> GetAllFilesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/DeleteFileByPath", ReplyAction="http://tempuri.org/InterfaceFile/DeleteFileByPathResponse")]
        System.Threading.Tasks.Task<int> DeleteFileByPathAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFileByPath", ReplyAction="http://tempuri.org/InterfaceFile/GetFileByPathResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.File> GetFileByPathAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/InsertKeywordIntoFile", ReplyAction="http://tempuri.org/InterfaceFile/InsertKeywordIntoFileResponse")]
        System.Threading.Tasks.Task InsertKeywordIntoFileAsync(string kword, string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetKeywordsOfFile", ReplyAction="http://tempuri.org/InterfaceFile/GetKeywordsOfFileResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.Keyword[]> GetKeywordsOfFileAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/DeleteKeywordsFromFile", ReplyAction="http://tempuri.org/InterfaceFile/DeleteKeywordsFromFileResponse")]
        System.Threading.Tasks.Task DeleteKeywordsFromFileAsync(int[] keywordsIds, string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/InsertPersonIntoFile", ReplyAction="http://tempuri.org/InterfaceFile/InsertPersonIntoFileResponse")]
        System.Threading.Tasks.Task InsertPersonIntoFileAsync(int personId, string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetPeopleFile", ReplyAction="http://tempuri.org/InterfaceFile/GetPeopleFileResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person[]> GetPeopleFileAsync(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/DeletePeopleFromFile", ReplyAction="http://tempuri.org/InterfaceFile/DeletePeopleFromFileResponse")]
        System.Threading.Tasks.Task DeletePeopleFromFileAsync(int[] ids, string filePath);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IFilePersonKeywordChannel : ServiceReferenceClientWeb.IFilePersonKeyword, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class FilePersonKeywordClient : System.ServiceModel.ClientBase<ServiceReferenceClientWeb.IFilePersonKeyword>, ServiceReferenceClientWeb.IFilePersonKeyword
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FilePersonKeywordClient() : 
                base(FilePersonKeywordClient.GetDefaultBinding(), FilePersonKeywordClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPostComment.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FilePersonKeywordClient(EndpointConfiguration endpointConfiguration) : 
                base(FilePersonKeywordClient.GetBindingForEndpoint(endpointConfiguration), FilePersonKeywordClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FilePersonKeywordClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FilePersonKeywordClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FilePersonKeywordClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FilePersonKeywordClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FilePersonKeywordClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> CreatePersonAsync(ServiceReferenceClientWeb.Person person)
        {
            return base.Channel.CreatePersonAsync(person);
        }
        
        public System.Threading.Tasks.Task<int> DeletePersonAsync(int id)
        {
            return base.Channel.DeletePersonAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person[]> GetAllPeopleAsync()
        {
            return base.Channel.GetAllPeopleAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person> GetPersonByNameAsync(string First_name, string Last_name)
        {
            return base.Channel.GetPersonByNameAsync(First_name, Last_name);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person> UpdatePersonAsync(ServiceReferenceClientWeb.Person newPerson)
        {
            return base.Channel.UpdatePersonAsync(newPerson);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person> UpdatePersonNameByIdAsync(int id, string First_name, string Last_name)
        {
            return base.Channel.UpdatePersonNameByIdAsync(id, First_name, Last_name);
        }
        
        public System.Threading.Tasks.Task<bool> CreateKeywordAsync(ServiceReferenceClientWeb.Keyword keyword)
        {
            return base.Channel.CreateKeywordAsync(keyword);
        }
        
        public System.Threading.Tasks.Task<int> DeleteKeywordAsync(int id)
        {
            return base.Channel.DeleteKeywordAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.Keyword[]> GetAllKeywordsAsync()
        {
            return base.Channel.GetAllKeywordsAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.Keyword> GetKeywordByKwordAsync(string Kword)
        {
            return base.Channel.GetKeywordByKwordAsync(Kword);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.Keyword> UpdateKeywordKwordByIdAsync(int id, string Kword)
        {
            return base.Channel.UpdateKeywordKwordByIdAsync(id, Kword);
        }
        
        public System.Threading.Tasks.Task<bool> CreateFileAsync(ServiceReferenceClientWeb.File file)
        {
            return base.Channel.CreateFileAsync(file);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.File[]> GetAllFilesAsync()
        {
            return base.Channel.GetAllFilesAsync();
        }
        
        public System.Threading.Tasks.Task<int> DeleteFileByPathAsync(string filePath)
        {
            return base.Channel.DeleteFileByPathAsync(filePath);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.File> GetFileByPathAsync(string filePath)
        {
            return base.Channel.GetFileByPathAsync(filePath);
        }
        
        public System.Threading.Tasks.Task InsertKeywordIntoFileAsync(string kword, string filePath)
        {
            return base.Channel.InsertKeywordIntoFileAsync(kword, filePath);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.Keyword[]> GetKeywordsOfFileAsync(string filePath)
        {
            return base.Channel.GetKeywordsOfFileAsync(filePath);
        }
        
        public System.Threading.Tasks.Task DeleteKeywordsFromFileAsync(int[] keywordsIds, string filePath)
        {
            return base.Channel.DeleteKeywordsFromFileAsync(keywordsIds, filePath);
        }
        
        public System.Threading.Tasks.Task InsertPersonIntoFileAsync(int personId, string filePath)
        {
            return base.Channel.InsertPersonIntoFileAsync(personId, filePath);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClientWeb.Person[]> GetPeopleFileAsync(string filePath)
        {
            return base.Channel.GetPeopleFileAsync(filePath);
        }
        
        public System.Threading.Tasks.Task DeletePeopleFromFileAsync(int[] ids, string filePath)
        {
            return base.Channel.DeletePeopleFromFileAsync(ids, filePath);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPostComment))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPostComment))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return FilePersonKeywordClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPostComment);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return FilePersonKeywordClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPostComment);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPostComment,
        }
    }
}
