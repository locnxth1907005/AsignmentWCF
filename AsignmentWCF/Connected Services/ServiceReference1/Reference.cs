﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsignmentWCF.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IntroductionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((object.ReferenceEquals(this.BirthdayField, value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Introduction {
            get {
                return this.IntroductionField;
            }
            set {
                if ((object.ReferenceEquals(this.IntroductionField, value) != true)) {
                    this.IntroductionField = value;
                    this.RaisePropertyChanged("Introduction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoleNumber {
            get {
                return this.RoleNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleNumberField, value) != true)) {
                    this.RoleNumberField = value;
                    this.RaisePropertyChanged("RoleNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateStudent", ReplyAction="http://tempuri.org/IService/CreateStudentResponse")]
        AsignmentWCF.ServiceReference1.Student CreateStudent(AsignmentWCF.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateStudent", ReplyAction="http://tempuri.org/IService/CreateStudentResponse")]
        System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student> CreateStudentAsync(AsignmentWCF.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetListStudents", ReplyAction="http://tempuri.org/IService/GetListStudentsResponse")]
        AsignmentWCF.ServiceReference1.Student[] GetListStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetListStudents", ReplyAction="http://tempuri.org/IService/GetListStudentsResponse")]
        System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student[]> GetListStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStudent", ReplyAction="http://tempuri.org/IService/UpdateStudentResponse")]
        AsignmentWCF.ServiceReference1.Student UpdateStudent(int id, AsignmentWCF.ServiceReference1.Student newStudent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStudent", ReplyAction="http://tempuri.org/IService/UpdateStudentResponse")]
        System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student> UpdateStudentAsync(int id, AsignmentWCF.ServiceReference1.Student newStudent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteStudent", ReplyAction="http://tempuri.org/IService/DeleteStudentResponse")]
        AsignmentWCF.ServiceReference1.Student DeleteStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteStudent", ReplyAction="http://tempuri.org/IService/DeleteStudentResponse")]
        System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student> DeleteStudentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudentById", ReplyAction="http://tempuri.org/IService/GetStudentByIdResponse")]
        AsignmentWCF.ServiceReference1.Student GetStudentById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudentById", ReplyAction="http://tempuri.org/IService/GetStudentByIdResponse")]
        System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student> GetStudentByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : AsignmentWCF.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<AsignmentWCF.ServiceReference1.IService>, AsignmentWCF.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AsignmentWCF.ServiceReference1.Student CreateStudent(AsignmentWCF.ServiceReference1.Student student) {
            return base.Channel.CreateStudent(student);
        }
        
        public System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student> CreateStudentAsync(AsignmentWCF.ServiceReference1.Student student) {
            return base.Channel.CreateStudentAsync(student);
        }
        
        public AsignmentWCF.ServiceReference1.Student[] GetListStudents() {
            return base.Channel.GetListStudents();
        }
        
        public System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student[]> GetListStudentsAsync() {
            return base.Channel.GetListStudentsAsync();
        }
        
        public AsignmentWCF.ServiceReference1.Student UpdateStudent(int id, AsignmentWCF.ServiceReference1.Student newStudent) {
            return base.Channel.UpdateStudent(id, newStudent);
        }
        
        public System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student> UpdateStudentAsync(int id, AsignmentWCF.ServiceReference1.Student newStudent) {
            return base.Channel.UpdateStudentAsync(id, newStudent);
        }
        
        public AsignmentWCF.ServiceReference1.Student DeleteStudent(int id) {
            return base.Channel.DeleteStudent(id);
        }
        
        public System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student> DeleteStudentAsync(int id) {
            return base.Channel.DeleteStudentAsync(id);
        }
        
        public AsignmentWCF.ServiceReference1.Student GetStudentById(int id) {
            return base.Channel.GetStudentById(id);
        }
        
        public System.Threading.Tasks.Task<AsignmentWCF.ServiceReference1.Student> GetStudentByIdAsync(int id) {
            return base.Channel.GetStudentByIdAsync(id);
        }
    }
}