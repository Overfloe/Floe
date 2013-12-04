﻿#pragma checksum "..\..\..\..\ChannelWindow\ChannelWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C373776C4202DEA6CFA624A464535A8A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Floe.UI;
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


namespace Floe.UI {
    
    
    /// <summary>
    /// ChannelWindow
    /// </summary>
    public partial class ChannelWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Floe.UI.ChannelWindow window;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdRoot;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReattach;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSettings;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaximize;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/Floe;component/channelwindow/channelwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
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
            this.window = ((Floe.UI.ChannelWindow)(target));
            return;
            case 2:
            
            #line 10 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteChat);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 11 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteSettings);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 12 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteReattach);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 13 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteMinimize);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 14 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteMaximize);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 15 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteClose);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\ChannelWindow\ChannelWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteClose);
            
            #line default
            #line hidden
            return;
            case 8:
            this.grdRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.btnReattach = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.btnSettings = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.btnMaximize = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

