﻿#pragma checksum "C:\Users\Gitanjali\WindowsPhone\MotherCare\WindowsPhonePrototype1\WindowsPhonePrototype1\WindowsPhonePrototype1Screens\Diet.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6EF78B5B3528EA90BDD3DC93BBF5DCEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Expression.Prototyping.WindowsPhone.Mockups;
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


namespace WindowsPhonePrototype1Screens {
    
    
    public partial class Diet : Microsoft.Expression.Prototyping.WindowsPhone.Mockups.WindowsPhoneChrome {
        
        internal Microsoft.Expression.Prototyping.WindowsPhone.Mockups.WindowsPhoneChrome PhoneChrome;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.VisualStateGroup CommonStates;
        
        internal System.Windows.VisualState Portrait;
        
        internal System.Windows.VisualState Landscape;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WindowsPhonePrototype1.Screens;component/Diet.xaml", System.UriKind.Relative));
            this.PhoneChrome = ((Microsoft.Expression.Prototyping.WindowsPhone.Mockups.WindowsPhoneChrome)(this.FindName("PhoneChrome")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CommonStates = ((System.Windows.VisualStateGroup)(this.FindName("CommonStates")));
            this.Portrait = ((System.Windows.VisualState)(this.FindName("Portrait")));
            this.Landscape = ((System.Windows.VisualState)(this.FindName("Landscape")));
        }
    }
}

