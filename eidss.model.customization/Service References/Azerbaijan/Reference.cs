﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eidss.model.customization.Azerbaijan {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/EHealthSurrogateLibrary.Catalogs")]
    [System.SerializableAttribute()]
    internal partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirthCountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirthPlaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> BloodTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> CitizenshipField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FactAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> FactCountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal FactDistrictIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal FactSetelmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FatherNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> MaritalStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> NationalityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PersonUniqueKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegisterAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegisterApartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegisterBuildingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegisterCountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal RegisterDistrictIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal RegisterSetelmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegisterStreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurNameField;
        
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
        internal System.Nullable<decimal> Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string BirthCountryId {
            get {
                return this.BirthCountryIdField;
            }
            set {
                if ((object.ReferenceEquals(this.BirthCountryIdField, value) != true)) {
                    this.BirthCountryIdField = value;
                    this.RaisePropertyChanged("BirthCountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string BirthPlace {
            get {
                return this.BirthPlaceField;
            }
            set {
                if ((object.ReferenceEquals(this.BirthPlaceField, value) != true)) {
                    this.BirthPlaceField = value;
                    this.RaisePropertyChanged("BirthPlace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<decimal> BloodType {
            get {
                return this.BloodTypeField;
            }
            set {
                if ((this.BloodTypeField.Equals(value) != true)) {
                    this.BloodTypeField = value;
                    this.RaisePropertyChanged("BloodType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<decimal> Citizenship {
            get {
                return this.CitizenshipField;
            }
            set {
                if ((this.CitizenshipField.Equals(value) != true)) {
                    this.CitizenshipField = value;
                    this.RaisePropertyChanged("Citizenship");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<System.DateTime> DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string FactAddress {
            get {
                return this.FactAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.FactAddressField, value) != true)) {
                    this.FactAddressField = value;
                    this.RaisePropertyChanged("FactAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<decimal> FactCountryId {
            get {
                return this.FactCountryIdField;
            }
            set {
                if ((this.FactCountryIdField.Equals(value) != true)) {
                    this.FactCountryIdField = value;
                    this.RaisePropertyChanged("FactCountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal decimal FactDistrictId {
            get {
                return this.FactDistrictIdField;
            }
            set {
                if ((this.FactDistrictIdField.Equals(value) != true)) {
                    this.FactDistrictIdField = value;
                    this.RaisePropertyChanged("FactDistrictId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal decimal FactSetelmentId {
            get {
                return this.FactSetelmentIdField;
            }
            set {
                if ((this.FactSetelmentIdField.Equals(value) != true)) {
                    this.FactSetelmentIdField = value;
                    this.RaisePropertyChanged("FactSetelmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string FatherName {
            get {
                return this.FatherNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FatherNameField, value) != true)) {
                    this.FatherNameField = value;
                    this.RaisePropertyChanged("FatherName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<decimal> MaritalStatus {
            get {
                return this.MaritalStatusField;
            }
            set {
                if ((this.MaritalStatusField.Equals(value) != true)) {
                    this.MaritalStatusField = value;
                    this.RaisePropertyChanged("MaritalStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Name {
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
        internal System.Nullable<decimal> Nationality {
            get {
                return this.NationalityField;
            }
            set {
                if ((this.NationalityField.Equals(value) != true)) {
                    this.NationalityField = value;
                    this.RaisePropertyChanged("Nationality");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string PersonUniqueKey {
            get {
                return this.PersonUniqueKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonUniqueKeyField, value) != true)) {
                    this.PersonUniqueKeyField = value;
                    this.RaisePropertyChanged("PersonUniqueKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Pin {
            get {
                return this.PinField;
            }
            set {
                if ((object.ReferenceEquals(this.PinField, value) != true)) {
                    this.PinField = value;
                    this.RaisePropertyChanged("Pin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string RegisterAddress {
            get {
                return this.RegisterAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.RegisterAddressField, value) != true)) {
                    this.RegisterAddressField = value;
                    this.RaisePropertyChanged("RegisterAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string RegisterApartment {
            get {
                return this.RegisterApartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.RegisterApartmentField, value) != true)) {
                    this.RegisterApartmentField = value;
                    this.RaisePropertyChanged("RegisterApartment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string RegisterBuilding {
            get {
                return this.RegisterBuildingField;
            }
            set {
                if ((object.ReferenceEquals(this.RegisterBuildingField, value) != true)) {
                    this.RegisterBuildingField = value;
                    this.RaisePropertyChanged("RegisterBuilding");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string RegisterCountryId {
            get {
                return this.RegisterCountryIdField;
            }
            set {
                if ((object.ReferenceEquals(this.RegisterCountryIdField, value) != true)) {
                    this.RegisterCountryIdField = value;
                    this.RaisePropertyChanged("RegisterCountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal decimal RegisterDistrictId {
            get {
                return this.RegisterDistrictIdField;
            }
            set {
                if ((this.RegisterDistrictIdField.Equals(value) != true)) {
                    this.RegisterDistrictIdField = value;
                    this.RaisePropertyChanged("RegisterDistrictId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal decimal RegisterSetelmentId {
            get {
                return this.RegisterSetelmentIdField;
            }
            set {
                if ((this.RegisterSetelmentIdField.Equals(value) != true)) {
                    this.RegisterSetelmentIdField = value;
                    this.RaisePropertyChanged("RegisterSetelmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string RegisterStreet {
            get {
                return this.RegisterStreetField;
            }
            set {
                if ((object.ReferenceEquals(this.RegisterStreetField, value) != true)) {
                    this.RegisterStreetField = value;
                    this.RaisePropertyChanged("RegisterStreet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Sex {
            get {
                return this.SexField;
            }
            set {
                if ((object.ReferenceEquals(this.SexField, value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string SurName {
            get {
                return this.SurNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurNameField, value) != true)) {
                    this.SurNameField = value;
                    this.RaisePropertyChanged("SurName");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IdentityService.DocumentType", Namespace="http://schemas.datacontract.org/2004/07/EHealthModelWcf")]
    internal enum IdentityServiceDocumentType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TemporaryResidencePermit = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PermanentResidencePermit = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Passport = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IDCardForAdult = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IDcardForChild = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BirthCertificate = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Azerbaijan.IIdentityService")]
    internal interface IIdentityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIdentityService/GetPersonByPin", ReplyAction="http://tempuri.org/IIdentityService/GetPersonByPinResponse")]
        eidss.model.customization.Azerbaijan.Person GetPersonByPin(string pin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIdentityService/GetPersonByDocumentNumber", ReplyAction="http://tempuri.org/IIdentityService/GetPersonByDocumentNumberResponse")]
        eidss.model.customization.Azerbaijan.Person GetPersonByDocumentNumber(string documentnumber, System.Nullable<eidss.model.customization.Azerbaijan.IdentityServiceDocumentType> documenttype, System.Nullable<System.DateTime> dateOfBirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIdentityService/GetPersonByParams", ReplyAction="http://tempuri.org/IIdentityService/GetPersonByParamsResponse")]
        System.Collections.Generic.List<eidss.model.customization.Azerbaijan.Person> GetPersonByParams(string name, string surname, string fathername, System.Nullable<System.DateTime> dateofbirth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIdentityService/InsertPersonGetUniqueCode", ReplyAction="http://tempuri.org/IIdentityService/InsertPersonGetUniqueCodeResponse")]
        eidss.model.customization.Azerbaijan.Person InsertPersonGetUniqueCode(eidss.model.customization.Azerbaijan.Person person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface IIdentityServiceChannel : eidss.model.customization.Azerbaijan.IIdentityService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class IdentityServiceClient : System.ServiceModel.ClientBase<eidss.model.customization.Azerbaijan.IIdentityService>, eidss.model.customization.Azerbaijan.IIdentityService {
        
        public IdentityServiceClient() {
        }
        
        public IdentityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IdentityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IdentityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IdentityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public eidss.model.customization.Azerbaijan.Person GetPersonByPin(string pin) {
            return base.Channel.GetPersonByPin(pin);
        }
        
        public eidss.model.customization.Azerbaijan.Person GetPersonByDocumentNumber(string documentnumber, System.Nullable<eidss.model.customization.Azerbaijan.IdentityServiceDocumentType> documenttype, System.Nullable<System.DateTime> dateOfBirth) {
            return base.Channel.GetPersonByDocumentNumber(documentnumber, documenttype, dateOfBirth);
        }
        
        public System.Collections.Generic.List<eidss.model.customization.Azerbaijan.Person> GetPersonByParams(string name, string surname, string fathername, System.Nullable<System.DateTime> dateofbirth) {
            return base.Channel.GetPersonByParams(name, surname, fathername, dateofbirth);
        }
        
        public eidss.model.customization.Azerbaijan.Person InsertPersonGetUniqueCode(eidss.model.customization.Azerbaijan.Person person) {
            return base.Channel.InsertPersonGetUniqueCode(person);
        }
    }
}