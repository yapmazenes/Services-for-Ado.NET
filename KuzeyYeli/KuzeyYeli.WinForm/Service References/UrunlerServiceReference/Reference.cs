﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KuzeyYeli.WinForm.UrunlerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UrunDTO", Namespace="http://schemas.datacontract.org/2004/07/KuzeyYeli.DTO")]
    [System.SerializableAttribute()]
    public partial class UrunDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> BirimFiyatiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirimdekiMiktarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> EnAzYenidenSatisMikatariField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> HedefStokDuzeyiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> KategoriIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SonlandiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TedarikciIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrunAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UrunIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> YeniSatisField;
        
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
        public System.Nullable<decimal> BirimFiyati {
            get {
                return this.BirimFiyatiField;
            }
            set {
                if ((this.BirimFiyatiField.Equals(value) != true)) {
                    this.BirimFiyatiField = value;
                    this.RaisePropertyChanged("BirimFiyati");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BirimdekiMiktar {
            get {
                return this.BirimdekiMiktarField;
            }
            set {
                if ((object.ReferenceEquals(this.BirimdekiMiktarField, value) != true)) {
                    this.BirimdekiMiktarField = value;
                    this.RaisePropertyChanged("BirimdekiMiktar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> EnAzYenidenSatisMikatari {
            get {
                return this.EnAzYenidenSatisMikatariField;
            }
            set {
                if ((this.EnAzYenidenSatisMikatariField.Equals(value) != true)) {
                    this.EnAzYenidenSatisMikatariField = value;
                    this.RaisePropertyChanged("EnAzYenidenSatisMikatari");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> HedefStokDuzeyi {
            get {
                return this.HedefStokDuzeyiField;
            }
            set {
                if ((this.HedefStokDuzeyiField.Equals(value) != true)) {
                    this.HedefStokDuzeyiField = value;
                    this.RaisePropertyChanged("HedefStokDuzeyi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> KategoriID {
            get {
                return this.KategoriIDField;
            }
            set {
                if ((this.KategoriIDField.Equals(value) != true)) {
                    this.KategoriIDField = value;
                    this.RaisePropertyChanged("KategoriID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Sonlandi {
            get {
                return this.SonlandiField;
            }
            set {
                if ((this.SonlandiField.Equals(value) != true)) {
                    this.SonlandiField = value;
                    this.RaisePropertyChanged("Sonlandi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TedarikciID {
            get {
                return this.TedarikciIDField;
            }
            set {
                if ((this.TedarikciIDField.Equals(value) != true)) {
                    this.TedarikciIDField = value;
                    this.RaisePropertyChanged("TedarikciID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UrunAdi {
            get {
                return this.UrunAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.UrunAdiField, value) != true)) {
                    this.UrunAdiField = value;
                    this.RaisePropertyChanged("UrunAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UrunID {
            get {
                return this.UrunIDField;
            }
            set {
                if ((this.UrunIDField.Equals(value) != true)) {
                    this.UrunIDField = value;
                    this.RaisePropertyChanged("UrunID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> YeniSatis {
            get {
                return this.YeniSatisField;
            }
            set {
                if ((this.YeniSatisField.Equals(value) != true)) {
                    this.YeniSatisField = value;
                    this.RaisePropertyChanged("YeniSatis");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UrunlerServiceReference.IServiceOf_UrunDTO")]
    public interface IServiceOf_UrunDTO {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Listele", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/ListeleResponse")]
        System.Collections.Generic.List<KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO> Listele();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Listele", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/ListeleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO>> ListeleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Ekle", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/EkleResponse")]
        bool Ekle(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Ekle", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/EkleResponse")]
        System.Threading.Tasks.Task<bool> EkleAsync(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Guncelle", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/GuncelleResponse")]
        bool Guncelle(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Guncelle", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/GuncelleResponse")]
        System.Threading.Tasks.Task<bool> GuncelleAsync(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Sil", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/SilResponse")]
        bool Sil(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Sil", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/SilResponse")]
        System.Threading.Tasks.Task<bool> SilAsync(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceOf_UrunDTOChannel : KuzeyYeli.WinForm.UrunlerServiceReference.IServiceOf_UrunDTO, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceOf_UrunDTOClient : System.ServiceModel.ClientBase<KuzeyYeli.WinForm.UrunlerServiceReference.IServiceOf_UrunDTO>, KuzeyYeli.WinForm.UrunlerServiceReference.IServiceOf_UrunDTO {
        
        public ServiceOf_UrunDTOClient() {
        }
        
        public ServiceOf_UrunDTOClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceOf_UrunDTOClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOf_UrunDTOClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOf_UrunDTOClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO> Listele() {
            return base.Channel.Listele();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO>> ListeleAsync() {
            return base.Channel.ListeleAsync();
        }
        
        public bool Ekle(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto) {
            return base.Channel.Ekle(dto);
        }
        
        public System.Threading.Tasks.Task<bool> EkleAsync(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto) {
            return base.Channel.EkleAsync(dto);
        }
        
        public bool Guncelle(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto) {
            return base.Channel.Guncelle(dto);
        }
        
        public System.Threading.Tasks.Task<bool> GuncelleAsync(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto) {
            return base.Channel.GuncelleAsync(dto);
        }
        
        public bool Sil(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto) {
            return base.Channel.Sil(dto);
        }
        
        public System.Threading.Tasks.Task<bool> SilAsync(KuzeyYeli.WinForm.UrunlerServiceReference.UrunDTO dto) {
            return base.Channel.SilAsync(dto);
        }
    }
}