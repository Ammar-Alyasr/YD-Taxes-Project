﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxesProjecte.GovernmentService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GovermentDebt", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Models")]
    [System.SerializableAttribute()]
    public partial class GovermentDebt : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isPayedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kindOfdebtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal paidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime paid_timeField;
        
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
        public decimal amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isPayed {
            get {
                return this.isPayedField;
            }
            set {
                if ((this.isPayedField.Equals(value) != true)) {
                    this.isPayedField = value;
                    this.RaisePropertyChanged("isPayed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kindOfdebt {
            get {
                return this.kindOfdebtField;
            }
            set {
                if ((object.ReferenceEquals(this.kindOfdebtField, value) != true)) {
                    this.kindOfdebtField = value;
                    this.RaisePropertyChanged("kindOfdebt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal paid {
            get {
                return this.paidField;
            }
            set {
                if ((this.paidField.Equals(value) != true)) {
                    this.paidField = value;
                    this.RaisePropertyChanged("paid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime paid_time {
            get {
                return this.paid_timeField;
            }
            set {
                if ((this.paid_timeField.Equals(value) != true)) {
                    this.paid_timeField = value;
                    this.RaisePropertyChanged("paid_time");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GovernmentService.IGV_Servis")]
    public interface IGV_Servis {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGV_Servis/Delete", ReplyAction="http://tempuri.org/IGV_Servis/DeleteResponse")]
        string Delete(string tc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGV_Servis/Delete", ReplyAction="http://tempuri.org/IGV_Servis/DeleteResponse")]
        System.Threading.Tasks.Task<string> DeleteAsync(string tc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGV_Servis/GetUsersDataByTcNo", ReplyAction="http://tempuri.org/IGV_Servis/GetUsersDataByTcNoResponse")]
        TaxesProjecte.GovernmentService.GovermentDebt[] GetUsersDataByTcNo(string tc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGV_Servis/GetUsersDataByTcNo", ReplyAction="http://tempuri.org/IGV_Servis/GetUsersDataByTcNoResponse")]
        System.Threading.Tasks.Task<TaxesProjecte.GovernmentService.GovermentDebt[]> GetUsersDataByTcNoAsync(string tc);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGV_ServisChannel : TaxesProjecte.GovernmentService.IGV_Servis, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GV_ServisClient : System.ServiceModel.ClientBase<TaxesProjecte.GovernmentService.IGV_Servis>, TaxesProjecte.GovernmentService.IGV_Servis {
        
        public GV_ServisClient() {
        }
        
        public GV_ServisClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GV_ServisClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GV_ServisClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GV_ServisClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Delete(string tc) {
            return base.Channel.Delete(tc);
        }
        
        public System.Threading.Tasks.Task<string> DeleteAsync(string tc) {
            return base.Channel.DeleteAsync(tc);
        }
        
        public TaxesProjecte.GovernmentService.GovermentDebt[] GetUsersDataByTcNo(string tc) {
            return base.Channel.GetUsersDataByTcNo(tc);
        }
        
        public System.Threading.Tasks.Task<TaxesProjecte.GovernmentService.GovermentDebt[]> GetUsersDataByTcNoAsync(string tc) {
            return base.Channel.GetUsersDataByTcNoAsync(tc);
        }
    }
}
