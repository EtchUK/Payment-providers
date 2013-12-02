﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34003.
// 
#pragma warning disable 1591

namespace TeaCommerce.PaymentProviders.wannafindService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="pgwapiBinding", Namespace="urn:pgwapi")]
    public partial class pgwapi : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback captureTransactionOperationCompleted;
        
        private System.Threading.SendOrPostCallback cancelTransactionOperationCompleted;
        
        private System.Threading.SendOrPostCallback releaseSubscriptionOperationCompleted;
        
        private System.Threading.SendOrPostCallback changeAmountOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkTransactionOperationCompleted;
        
        private System.Threading.SendOrPostCallback renewTransactionOperationCompleted;
        
        private System.Threading.SendOrPostCallback authSubscribeOperationCompleted;
        
        private System.Threading.SendOrPostCallback creditTransactionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public pgwapi() {
            this.Url = "https://betaling.wannafind.dk/api/customerAPI.php";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event captureTransactionCompletedEventHandler captureTransactionCompleted;
        
        /// <remarks/>
        public event cancelTransactionCompletedEventHandler cancelTransactionCompleted;
        
        /// <remarks/>
        public event releaseSubscriptionCompletedEventHandler releaseSubscriptionCompleted;
        
        /// <remarks/>
        public event changeAmountCompletedEventHandler changeAmountCompleted;
        
        /// <remarks/>
        public event checkTransactionCompletedEventHandler checkTransactionCompleted;
        
        /// <remarks/>
        public event renewTransactionCompletedEventHandler renewTransactionCompleted;
        
        /// <remarks/>
        public event authSubscribeCompletedEventHandler authSubscribeCompleted;
        
        /// <remarks/>
        public event creditTransactionCompletedEventHandler creditTransactionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:pgwapi#captureTransaction", RequestNamespace="urn:pgwapi", ResponseNamespace="urn:pgwapi")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public int captureTransaction(int transactnum, int amount) {
            object[] results = this.Invoke("captureTransaction", new object[] {
                        transactnum,
                        amount});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void captureTransactionAsync(int transactnum, int amount) {
            this.captureTransactionAsync(transactnum, amount, null);
        }
        
        /// <remarks/>
        public void captureTransactionAsync(int transactnum, int amount, object userState) {
            if ((this.captureTransactionOperationCompleted == null)) {
                this.captureTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncaptureTransactionOperationCompleted);
            }
            this.InvokeAsync("captureTransaction", new object[] {
                        transactnum,
                        amount}, this.captureTransactionOperationCompleted, userState);
        }
        
        private void OncaptureTransactionOperationCompleted(object arg) {
            if ((this.captureTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.captureTransactionCompleted(this, new captureTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:pgwapi#cancelTransaction", RequestNamespace="urn:pgwapi", ResponseNamespace="urn:pgwapi")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public int cancelTransaction(int transactnum) {
            object[] results = this.Invoke("cancelTransaction", new object[] {
                        transactnum});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void cancelTransactionAsync(int transactnum) {
            this.cancelTransactionAsync(transactnum, null);
        }
        
        /// <remarks/>
        public void cancelTransactionAsync(int transactnum, object userState) {
            if ((this.cancelTransactionOperationCompleted == null)) {
                this.cancelTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncancelTransactionOperationCompleted);
            }
            this.InvokeAsync("cancelTransaction", new object[] {
                        transactnum}, this.cancelTransactionOperationCompleted, userState);
        }
        
        private void OncancelTransactionOperationCompleted(object arg) {
            if ((this.cancelTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.cancelTransactionCompleted(this, new cancelTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:pgwapi#releaseSubscription", RequestNamespace="urn:pgwapi", ResponseNamespace="urn:pgwapi")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public int releaseSubscription(int transactnum) {
            object[] results = this.Invoke("releaseSubscription", new object[] {
                        transactnum});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void releaseSubscriptionAsync(int transactnum) {
            this.releaseSubscriptionAsync(transactnum, null);
        }
        
        /// <remarks/>
        public void releaseSubscriptionAsync(int transactnum, object userState) {
            if ((this.releaseSubscriptionOperationCompleted == null)) {
                this.releaseSubscriptionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnreleaseSubscriptionOperationCompleted);
            }
            this.InvokeAsync("releaseSubscription", new object[] {
                        transactnum}, this.releaseSubscriptionOperationCompleted, userState);
        }
        
        private void OnreleaseSubscriptionOperationCompleted(object arg) {
            if ((this.releaseSubscriptionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.releaseSubscriptionCompleted(this, new releaseSubscriptionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:pgwapi#changeAmount", RequestNamespace="urn:pgwapi", ResponseNamespace="urn:pgwapi")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public int changeAmount(int transactnum, int amount) {
            object[] results = this.Invoke("changeAmount", new object[] {
                        transactnum,
                        amount});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void changeAmountAsync(int transactnum, int amount) {
            this.changeAmountAsync(transactnum, amount, null);
        }
        
        /// <remarks/>
        public void changeAmountAsync(int transactnum, int amount, object userState) {
            if ((this.changeAmountOperationCompleted == null)) {
                this.changeAmountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnchangeAmountOperationCompleted);
            }
            this.InvokeAsync("changeAmount", new object[] {
                        transactnum,
                        amount}, this.changeAmountOperationCompleted, userState);
        }
        
        private void OnchangeAmountOperationCompleted(object arg) {
            if ((this.changeAmountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.changeAmountCompleted(this, new changeAmountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:pgwapi#checkTransaction", RequestNamespace="urn:pgwapi", ResponseNamespace="urn:pgwapi")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public returnArray checkTransaction(int transactnum, string type, string orderid, string bankMerchantID, string boNo) {
            object[] results = this.Invoke("checkTransaction", new object[] {
                        transactnum,
                        type,
                        orderid,
                        bankMerchantID,
                        boNo});
            return ((returnArray)(results[0]));
        }
        
        /// <remarks/>
        public void checkTransactionAsync(int transactnum, string type, string orderid, string bankMerchantID, string boNo) {
            this.checkTransactionAsync(transactnum, type, orderid, bankMerchantID, boNo, null);
        }
        
        /// <remarks/>
        public void checkTransactionAsync(int transactnum, string type, string orderid, string bankMerchantID, string boNo, object userState) {
            if ((this.checkTransactionOperationCompleted == null)) {
                this.checkTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckTransactionOperationCompleted);
            }
            this.InvokeAsync("checkTransaction", new object[] {
                        transactnum,
                        type,
                        orderid,
                        bankMerchantID,
                        boNo}, this.checkTransactionOperationCompleted, userState);
        }
        
        private void OncheckTransactionOperationCompleted(object arg) {
            if ((this.checkTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkTransactionCompleted(this, new checkTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:pgwapi#renewTransaction", RequestNamespace="urn:pgwapi", ResponseNamespace="urn:pgwapi")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public int renewTransaction(int transactnum) {
            object[] results = this.Invoke("renewTransaction", new object[] {
                        transactnum});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void renewTransactionAsync(int transactnum) {
            this.renewTransactionAsync(transactnum, null);
        }
        
        /// <remarks/>
        public void renewTransactionAsync(int transactnum, object userState) {
            if ((this.renewTransactionOperationCompleted == null)) {
                this.renewTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrenewTransactionOperationCompleted);
            }
            this.InvokeAsync("renewTransaction", new object[] {
                        transactnum}, this.renewTransactionOperationCompleted, userState);
        }
        
        private void OnrenewTransactionOperationCompleted(object arg) {
            if ((this.renewTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.renewTransactionCompleted(this, new renewTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:pgwapi#authSubscribe", RequestNamespace="urn:pgwapi", ResponseNamespace="urn:pgwapi")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public subscriber_returnArray authSubscribe(int transactnum, int amount, string orderid, string orderidprefix) {
            object[] results = this.Invoke("authSubscribe", new object[] {
                        transactnum,
                        amount,
                        orderid,
                        orderidprefix});
            return ((subscriber_returnArray)(results[0]));
        }
        
        /// <remarks/>
        public void authSubscribeAsync(int transactnum, int amount, string orderid, string orderidprefix) {
            this.authSubscribeAsync(transactnum, amount, orderid, orderidprefix, null);
        }
        
        /// <remarks/>
        public void authSubscribeAsync(int transactnum, int amount, string orderid, string orderidprefix, object userState) {
            if ((this.authSubscribeOperationCompleted == null)) {
                this.authSubscribeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnauthSubscribeOperationCompleted);
            }
            this.InvokeAsync("authSubscribe", new object[] {
                        transactnum,
                        amount,
                        orderid,
                        orderidprefix}, this.authSubscribeOperationCompleted, userState);
        }
        
        private void OnauthSubscribeOperationCompleted(object arg) {
            if ((this.authSubscribeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.authSubscribeCompleted(this, new authSubscribeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:pgwapi#creditTransaction", RequestNamespace="urn:pgwapi", ResponseNamespace="urn:pgwapi")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public int creditTransaction(int transactnum, int amount) {
            object[] results = this.Invoke("creditTransaction", new object[] {
                        transactnum,
                        amount});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void creditTransactionAsync(int transactnum, int amount) {
            this.creditTransactionAsync(transactnum, amount, null);
        }
        
        /// <remarks/>
        public void creditTransactionAsync(int transactnum, int amount, object userState) {
            if ((this.creditTransactionOperationCompleted == null)) {
                this.creditTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreditTransactionOperationCompleted);
            }
            this.InvokeAsync("creditTransaction", new object[] {
                        transactnum,
                        amount}, this.creditTransactionOperationCompleted, userState);
        }
        
        private void OncreditTransactionOperationCompleted(object arg) {
            if ((this.creditTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.creditTransactionCompleted(this, new creditTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:pgwapi")]
    public partial class returnArray {
        
        private int returncodeField;
        
        private string transactnumField;
        
        private string currencyField;
        
        private int amountField;
        
        private string cardtypeField;
        
        private string orderidprefixField;
        
        private string orderidField;
        
        /// <remarks/>
        public int returncode {
            get {
                return this.returncodeField;
            }
            set {
                this.returncodeField = value;
            }
        }
        
        /// <remarks/>
        public string transactnum {
            get {
                return this.transactnumField;
            }
            set {
                this.transactnumField = value;
            }
        }
        
        /// <remarks/>
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        public int amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public string cardtype {
            get {
                return this.cardtypeField;
            }
            set {
                this.cardtypeField = value;
            }
        }
        
        /// <remarks/>
        public string orderidprefix {
            get {
                return this.orderidprefixField;
            }
            set {
                this.orderidprefixField = value;
            }
        }
        
        /// <remarks/>
        public string orderid {
            get {
                return this.orderidField;
            }
            set {
                this.orderidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:pgwapi")]
    public partial class subscriber_returnArray {
        
        private int returncodeField;
        
        private string transactnumField;
        
        private int amountField;
        
        private string orderidprefixField;
        
        private string orderidField;
        
        private int acquirerstatusField;
        
        /// <remarks/>
        public int returncode {
            get {
                return this.returncodeField;
            }
            set {
                this.returncodeField = value;
            }
        }
        
        /// <remarks/>
        public string transactnum {
            get {
                return this.transactnumField;
            }
            set {
                this.transactnumField = value;
            }
        }
        
        /// <remarks/>
        public int amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public string orderidprefix {
            get {
                return this.orderidprefixField;
            }
            set {
                this.orderidprefixField = value;
            }
        }
        
        /// <remarks/>
        public string orderid {
            get {
                return this.orderidField;
            }
            set {
                this.orderidField = value;
            }
        }
        
        /// <remarks/>
        public int acquirerstatus {
            get {
                return this.acquirerstatusField;
            }
            set {
                this.acquirerstatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void captureTransactionCompletedEventHandler(object sender, captureTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class captureTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal captureTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void cancelTransactionCompletedEventHandler(object sender, cancelTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cancelTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal cancelTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void releaseSubscriptionCompletedEventHandler(object sender, releaseSubscriptionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class releaseSubscriptionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal releaseSubscriptionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void changeAmountCompletedEventHandler(object sender, changeAmountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class changeAmountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal changeAmountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void checkTransactionCompletedEventHandler(object sender, checkTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public returnArray Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((returnArray)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void renewTransactionCompletedEventHandler(object sender, renewTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class renewTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal renewTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void authSubscribeCompletedEventHandler(object sender, authSubscribeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class authSubscribeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal authSubscribeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public subscriber_returnArray Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((subscriber_returnArray)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void creditTransactionCompletedEventHandler(object sender, creditTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class creditTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal creditTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591