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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CarbonFootprintClientApp.CarbonRef {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CarbonServiceSoap", Namespace="http://tempuri.org/")]
    public partial class CarbonService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CalculateEnergyFootprintOperationCompleted;
        
        private System.Threading.SendOrPostCallback CalculateTransportFootprintOperationCompleted;
        
        private System.Threading.SendOrPostCallback CalculateWasteFootprintOperationCompleted;
        
        private System.Threading.SendOrPostCallback CalculateTotalFootprintOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CarbonService() {
            this.Url = global::CarbonFootprintClientApp.Properties.Settings.Default.CarbonFootprintClientApp_CarbonRef_CarbonService;
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
        public event CalculateEnergyFootprintCompletedEventHandler CalculateEnergyFootprintCompleted;
        
        /// <remarks/>
        public event CalculateTransportFootprintCompletedEventHandler CalculateTransportFootprintCompleted;
        
        /// <remarks/>
        public event CalculateWasteFootprintCompletedEventHandler CalculateWasteFootprintCompleted;
        
        /// <remarks/>
        public event CalculateTotalFootprintCompletedEventHandler CalculateTotalFootprintCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalculateEnergyFootprint", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double CalculateEnergyFootprint(double energyKWh, double emissionFactor) {
            object[] results = this.Invoke("CalculateEnergyFootprint", new object[] {
                        energyKWh,
                        emissionFactor});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void CalculateEnergyFootprintAsync(double energyKWh, double emissionFactor) {
            this.CalculateEnergyFootprintAsync(energyKWh, emissionFactor, null);
        }
        
        /// <remarks/>
        public void CalculateEnergyFootprintAsync(double energyKWh, double emissionFactor, object userState) {
            if ((this.CalculateEnergyFootprintOperationCompleted == null)) {
                this.CalculateEnergyFootprintOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalculateEnergyFootprintOperationCompleted);
            }
            this.InvokeAsync("CalculateEnergyFootprint", new object[] {
                        energyKWh,
                        emissionFactor}, this.CalculateEnergyFootprintOperationCompleted, userState);
        }
        
        private void OnCalculateEnergyFootprintOperationCompleted(object arg) {
            if ((this.CalculateEnergyFootprintCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalculateEnergyFootprintCompleted(this, new CalculateEnergyFootprintCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalculateTransportFootprint", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double CalculateTransportFootprint(double distanceKm, double emissionFactor) {
            object[] results = this.Invoke("CalculateTransportFootprint", new object[] {
                        distanceKm,
                        emissionFactor});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void CalculateTransportFootprintAsync(double distanceKm, double emissionFactor) {
            this.CalculateTransportFootprintAsync(distanceKm, emissionFactor, null);
        }
        
        /// <remarks/>
        public void CalculateTransportFootprintAsync(double distanceKm, double emissionFactor, object userState) {
            if ((this.CalculateTransportFootprintOperationCompleted == null)) {
                this.CalculateTransportFootprintOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalculateTransportFootprintOperationCompleted);
            }
            this.InvokeAsync("CalculateTransportFootprint", new object[] {
                        distanceKm,
                        emissionFactor}, this.CalculateTransportFootprintOperationCompleted, userState);
        }
        
        private void OnCalculateTransportFootprintOperationCompleted(object arg) {
            if ((this.CalculateTransportFootprintCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalculateTransportFootprintCompleted(this, new CalculateTransportFootprintCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalculateWasteFootprint", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double CalculateWasteFootprint(double wasteTonnes, double emissionFactor) {
            object[] results = this.Invoke("CalculateWasteFootprint", new object[] {
                        wasteTonnes,
                        emissionFactor});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void CalculateWasteFootprintAsync(double wasteTonnes, double emissionFactor) {
            this.CalculateWasteFootprintAsync(wasteTonnes, emissionFactor, null);
        }
        
        /// <remarks/>
        public void CalculateWasteFootprintAsync(double wasteTonnes, double emissionFactor, object userState) {
            if ((this.CalculateWasteFootprintOperationCompleted == null)) {
                this.CalculateWasteFootprintOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalculateWasteFootprintOperationCompleted);
            }
            this.InvokeAsync("CalculateWasteFootprint", new object[] {
                        wasteTonnes,
                        emissionFactor}, this.CalculateWasteFootprintOperationCompleted, userState);
        }
        
        private void OnCalculateWasteFootprintOperationCompleted(object arg) {
            if ((this.CalculateWasteFootprintCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalculateWasteFootprintCompleted(this, new CalculateWasteFootprintCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalculateTotalFootprint", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double CalculateTotalFootprint(double energyFootprint, double transportFootprint, double wasteFootprint) {
            object[] results = this.Invoke("CalculateTotalFootprint", new object[] {
                        energyFootprint,
                        transportFootprint,
                        wasteFootprint});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void CalculateTotalFootprintAsync(double energyFootprint, double transportFootprint, double wasteFootprint) {
            this.CalculateTotalFootprintAsync(energyFootprint, transportFootprint, wasteFootprint, null);
        }
        
        /// <remarks/>
        public void CalculateTotalFootprintAsync(double energyFootprint, double transportFootprint, double wasteFootprint, object userState) {
            if ((this.CalculateTotalFootprintOperationCompleted == null)) {
                this.CalculateTotalFootprintOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalculateTotalFootprintOperationCompleted);
            }
            this.InvokeAsync("CalculateTotalFootprint", new object[] {
                        energyFootprint,
                        transportFootprint,
                        wasteFootprint}, this.CalculateTotalFootprintOperationCompleted, userState);
        }
        
        private void OnCalculateTotalFootprintOperationCompleted(object arg) {
            if ((this.CalculateTotalFootprintCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalculateTotalFootprintCompleted(this, new CalculateTotalFootprintCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void CalculateEnergyFootprintCompletedEventHandler(object sender, CalculateEnergyFootprintCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalculateEnergyFootprintCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalculateEnergyFootprintCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void CalculateTransportFootprintCompletedEventHandler(object sender, CalculateTransportFootprintCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalculateTransportFootprintCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalculateTransportFootprintCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void CalculateWasteFootprintCompletedEventHandler(object sender, CalculateWasteFootprintCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalculateWasteFootprintCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalculateWasteFootprintCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void CalculateTotalFootprintCompletedEventHandler(object sender, CalculateTotalFootprintCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalculateTotalFootprintCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalculateTotalFootprintCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591