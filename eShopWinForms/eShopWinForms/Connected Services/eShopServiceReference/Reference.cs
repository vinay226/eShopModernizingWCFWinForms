﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eShopWinForms.eShopServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogItem", Namespace="http://schemas.datacontract.org/2004/07/eShopWCFService.Models")]
    [System.SerializableAttribute()]
    public partial class CatalogItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private eShopWinForms.eShopServiceReference.CatalogBrand CatalogBrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CatalogBrandIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private eShopWinForms.eShopServiceReference.CatalogType CatalogTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CatalogTypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PicturefilenameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public eShopWinForms.eShopServiceReference.CatalogBrand CatalogBrand {
            get {
                return this.CatalogBrandField;
            }
            set {
                if ((object.ReferenceEquals(this.CatalogBrandField, value) != true)) {
                    this.CatalogBrandField = value;
                    this.RaisePropertyChanged("CatalogBrand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CatalogBrandId {
            get {
                return this.CatalogBrandIdField;
            }
            set {
                if ((this.CatalogBrandIdField.Equals(value) != true)) {
                    this.CatalogBrandIdField = value;
                    this.RaisePropertyChanged("CatalogBrandId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public eShopWinForms.eShopServiceReference.CatalogType CatalogType {
            get {
                return this.CatalogTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.CatalogTypeField, value) != true)) {
                    this.CatalogTypeField = value;
                    this.RaisePropertyChanged("CatalogType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CatalogTypeId {
            get {
                return this.CatalogTypeIdField;
            }
            set {
                if ((this.CatalogTypeIdField.Equals(value) != true)) {
                    this.CatalogTypeIdField = value;
                    this.RaisePropertyChanged("CatalogTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
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
        public string Picturefilename {
            get {
                return this.PicturefilenameField;
            }
            set {
                if ((object.ReferenceEquals(this.PicturefilenameField, value) != true)) {
                    this.PicturefilenameField = value;
                    this.RaisePropertyChanged("Picturefilename");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogBrand", Namespace="http://schemas.datacontract.org/2004/07/eShopWCFService.Models")]
    [System.SerializableAttribute()]
    public partial class CatalogBrand : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogType", Namespace="http://schemas.datacontract.org/2004/07/eShopWCFService.Models")]
    [System.SerializableAttribute()]
    public partial class CatalogType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogItemsStock", Namespace="http://schemas.datacontract.org/2004/07/eShopWCFService")]
    [System.SerializableAttribute()]
    public partial class CatalogItemsStock : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AvailableStockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CatalogItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockIdField;
        
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
        public int AvailableStock {
            get {
                return this.AvailableStockField;
            }
            set {
                if ((this.AvailableStockField.Equals(value) != true)) {
                    this.AvailableStockField = value;
                    this.RaisePropertyChanged("AvailableStock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CatalogItemId {
            get {
                return this.CatalogItemIdField;
            }
            set {
                if ((this.CatalogItemIdField.Equals(value) != true)) {
                    this.CatalogItemIdField = value;
                    this.RaisePropertyChanged("CatalogItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StockId {
            get {
                return this.StockIdField;
            }
            set {
                if ((this.StockIdField.Equals(value) != true)) {
                    this.StockIdField = value;
                    this.RaisePropertyChanged("StockId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="eShopServiceReference.ICatalogService")]
    public interface ICatalogService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/FindCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/FindCatalogItemResponse")]
        eShopWinForms.eShopServiceReference.CatalogItem FindCatalogItem(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/FindCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/FindCatalogItemResponse")]
        System.Threading.Tasks.Task<eShopWinForms.eShopServiceReference.CatalogItem> FindCatalogItemAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogBrands", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogBrandsResponse")]
        eShopWinForms.eShopServiceReference.CatalogBrand[] GetCatalogBrands();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogBrands", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogBrandsResponse")]
        System.Threading.Tasks.Task<eShopWinForms.eShopServiceReference.CatalogBrand[]> GetCatalogBrandsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogItems", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogItemsResponse")]
        eShopWinForms.eShopServiceReference.CatalogItem[] GetCatalogItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogItems", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogItemsResponse")]
        System.Threading.Tasks.Task<eShopWinForms.eShopServiceReference.CatalogItem[]> GetCatalogItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogTypes", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogTypesResponse")]
        eShopWinForms.eShopServiceReference.CatalogType[] GetCatalogTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetCatalogTypes", ReplyAction="http://tempuri.org/ICatalogService/GetCatalogTypesResponse")]
        System.Threading.Tasks.Task<eShopWinForms.eShopServiceReference.CatalogType[]> GetCatalogTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/GetAvailableStockResponse")]
        int GetAvailableStock(System.DateTime date, int catalogItemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/GetAvailableStockResponse")]
        System.Threading.Tasks.Task<int> GetAvailableStockAsync(System.DateTime date, int catalogItemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/CreateAvailableStockResponse")]
        void CreateAvailableStock(eShopWinForms.eShopServiceReference.CatalogItemsStock catalogItemsStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/CreateAvailableStockResponse")]
        System.Threading.Tasks.Task CreateAvailableStockAsync(eShopWinForms.eShopServiceReference.CatalogItemsStock catalogItemsStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/GetAvailableStockResponse")]
        int GetAvailableStock(System.DateTime date, int catalogItemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/GetAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/GetAvailableStockResponse")]
        System.Threading.Tasks.Task<int> GetAvailableStockAsync(System.DateTime date, int catalogItemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/CreateAvailableStockResponse")]
        void CreateAvailableStock(eShopServiceLibrary.CatalogItemsStock catalogItemsStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateAvailableStock", ReplyAction="http://tempuri.org/ICatalogService/CreateAvailableStockResponse")]
        System.Threading.Tasks.Task CreateAvailableStockAsync(eShopServiceLibrary.CatalogItemsStock catalogItemsStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/CreateCatalogItemResponse")]
        void CreateCatalogItem(eShopWinForms.eShopServiceReference.CatalogItem catalogItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/CreateCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/CreateCatalogItemResponse")]
        System.Threading.Tasks.Task CreateCatalogItemAsync(eShopWinForms.eShopServiceReference.CatalogItem catalogItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/UpdateCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/UpdateCatalogItemResponse")]
        void UpdateCatalogItem(eShopWinForms.eShopServiceReference.CatalogItem catalogItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/UpdateCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/UpdateCatalogItemResponse")]
        System.Threading.Tasks.Task UpdateCatalogItemAsync(eShopWinForms.eShopServiceReference.CatalogItem catalogItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/RemoveCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/RemoveCatalogItemResponse")]
        void RemoveCatalogItem(eShopWinForms.eShopServiceReference.CatalogItem catalogItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/RemoveCatalogItem", ReplyAction="http://tempuri.org/ICatalogService/RemoveCatalogItemResponse")]
        System.Threading.Tasks.Task RemoveCatalogItemAsync(eShopWinForms.eShopServiceReference.CatalogItem catalogItem);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICatalogServiceChannel : eShopWinForms.eShopServiceReference.ICatalogService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CatalogServiceClient : System.ServiceModel.ClientBase<eShopWinForms.eShopServiceReference.ICatalogService>, eShopWinForms.eShopServiceReference.ICatalogService {
        
        public CatalogServiceClient() {
        }
        
        public CatalogServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CatalogServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CatalogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CatalogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public eShopWinForms.eShopServiceReference.CatalogItem FindCatalogItem(int id) {
            return base.Channel.FindCatalogItem(id);
        }
        
        public System.Threading.Tasks.Task<eShopWinForms.eShopServiceReference.CatalogItem> FindCatalogItemAsync(int id) {
            return base.Channel.FindCatalogItemAsync(id);
        }
        
        public eShopWinForms.eShopServiceReference.CatalogBrand[] GetCatalogBrands() {
            return base.Channel.GetCatalogBrands();
        }
        
        public System.Threading.Tasks.Task<eShopWinForms.eShopServiceReference.CatalogBrand[]> GetCatalogBrandsAsync() {
            return base.Channel.GetCatalogBrandsAsync();
        }
        
        public eShopWinForms.eShopServiceReference.CatalogItem[] GetCatalogItems() {
            return base.Channel.GetCatalogItems();
        }
        
        public System.Threading.Tasks.Task<eShopWinForms.eShopServiceReference.CatalogItem[]> GetCatalogItemsAsync() {
            return base.Channel.GetCatalogItemsAsync();
        }
        
        public eShopWinForms.eShopServiceReference.CatalogType[] GetCatalogTypes() {
            return base.Channel.GetCatalogTypes();
        }
        
        public System.Threading.Tasks.Task<eShopWinForms.eShopServiceReference.CatalogType[]> GetCatalogTypesAsync() {
            return base.Channel.GetCatalogTypesAsync();
        }
        
        public int GetAvailableStock(System.DateTime date, int catalogItemId) {
            return base.Channel.GetAvailableStock(date, catalogItemId);
        }
        
        public System.Threading.Tasks.Task<int> GetAvailableStockAsync(System.DateTime date, int catalogItemId) {
            return base.Channel.GetAvailableStockAsync(date, catalogItemId);
        }
        
        public void CreateAvailableStock(eShopWinForms.eShopServiceReference.CatalogItemsStock catalogItemsStock) {
            base.Channel.CreateAvailableStock(catalogItemsStock);
        }
        
        public System.Threading.Tasks.Task CreateAvailableStockAsync(eShopWinForms.eShopServiceReference.CatalogItemsStock catalogItemsStock) {
            return base.Channel.CreateAvailableStockAsync(catalogItemsStock);
        }
        
        public void CreateCatalogItem(eShopWinForms.eShopServiceReference.CatalogItem catalogItem) {
            base.Channel.CreateCatalogItem(catalogItem);
        }
        
        public System.Threading.Tasks.Task CreateCatalogItemAsync(eShopWinForms.eShopServiceReference.CatalogItem catalogItem) {
            return base.Channel.CreateCatalogItemAsync(catalogItem);
        }
        
        public void UpdateCatalogItem(eShopWinForms.eShopServiceReference.CatalogItem catalogItem) {
            base.Channel.UpdateCatalogItem(catalogItem);
        }
        
        public System.Threading.Tasks.Task UpdateCatalogItemAsync(eShopWinForms.eShopServiceReference.CatalogItem catalogItem) {
            return base.Channel.UpdateCatalogItemAsync(catalogItem);
        }
        
        public void RemoveCatalogItem(eShopWinForms.eShopServiceReference.CatalogItem catalogItem) {
            base.Channel.RemoveCatalogItem(catalogItem);
        }
        
        public System.Threading.Tasks.Task RemoveCatalogItemAsync(eShopWinForms.eShopServiceReference.CatalogItem catalogItem) {
            return base.Channel.RemoveCatalogItemAsync(catalogItem);
        }
    }
}
