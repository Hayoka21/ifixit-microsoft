﻿#pragma checksum "D:\Projects\iFixit\iFixit.NET\iFixit.NET\iFixit.WP8.UI\Views\SubCategory.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "421D1F5E2922123446978E40087C95E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using Telerik.Windows.Controls;
using iFixit.WP8.UI.Code;


namespace iFixit.WP8.UI.Views {
    
    
    public partial class SubCategory : iFixit.WP8.UI.Code.PageBase {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot MainPivot;
        
        internal Telerik.Windows.Controls.RadDataBoundListBox CategoryList;
        
        internal System.Windows.Controls.ProgressBar _performanceProgressBar;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/iFixit.WP8.UI;component/Views/SubCategory.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.MainPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("MainPivot")));
            this.CategoryList = ((Telerik.Windows.Controls.RadDataBoundListBox)(this.FindName("CategoryList")));
            this._performanceProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("_performanceProgressBar")));
        }
    }
}

