#pragma checksum "..\..\SettingsScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E8DD85191A7A00C97D4A587A861D313F00287502405FCDD5171CE6E2D093BB8E"
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
    /// SettingsScreen
    /// </summary>
    public partial class SettingsScreen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\SettingsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle recColour;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\SettingsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDifficulty;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\SettingsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangeName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\SettingsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStats;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\SettingsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\SettingsScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReset;
        
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
            System.Uri resourceLocater = new System.Uri("/Tarneeb;component/settingsscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SettingsScreen.xaml"
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
            this.recColour = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 2:
            this.btnDifficulty = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\SettingsScreen.xaml"
            this.btnDifficulty.Click += new System.Windows.RoutedEventHandler(this.btnDifficulty_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnChangeName = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\SettingsScreen.xaml"
            this.btnChangeName.Click += new System.Windows.RoutedEventHandler(this.btnChangeName_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnStats = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\SettingsScreen.xaml"
            this.btnStats.Click += new System.Windows.RoutedEventHandler(this.btnStats_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\SettingsScreen.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnReset = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\SettingsScreen.xaml"
            this.btnReset.Click += new System.Windows.RoutedEventHandler(this.btnReset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

