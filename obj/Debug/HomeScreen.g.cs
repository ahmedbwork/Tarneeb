﻿#pragma checksum "..\..\HomeScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8D7D314F6E45710FCB7513C6E0F6F2AE550E9BB90F22E2FA9F459C4809C52D8D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tarneeb;


namespace Tarneeb {
    
    
    /// <summary>
    /// HomeScreen
    /// </summary>
    public partial class HomeScreen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\HomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridTable;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\HomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image titleAces;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\HomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image titleTarneeb;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\HomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlay;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\HomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHowTo;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\HomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseApp;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\HomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSettings;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tarneeb;component/homescreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HomeScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.gridTable = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.titleAces = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.titleTarneeb = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.btnPlay = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\HomeScreen.xaml"
            this.btnPlay.Click += new System.Windows.RoutedEventHandler(this.btnPlay_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnHowTo = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\HomeScreen.xaml"
            this.btnHowTo.Click += new System.Windows.RoutedEventHandler(this.btnHowTo_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCloseApp = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\HomeScreen.xaml"
            this.btnCloseApp.Click += new System.Windows.RoutedEventHandler(this.btnCloseApp_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSettings = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\HomeScreen.xaml"
            this.btnSettings.Click += new System.Windows.RoutedEventHandler(this.btnSettings_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
