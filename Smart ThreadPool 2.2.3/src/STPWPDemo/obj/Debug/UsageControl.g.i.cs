﻿#pragma checksum "C:\Users\AMT\Documents\GitHub\AMpd\Tips\Trick---Tips\Smart ThreadPool 2.2.3\src\STPWPDemo\UsageControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A91B56ADD980F3F26FFB4E08B376E4DE"
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


namespace STPWPDemo {
    
    
    public partial class UsageControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Media.ImageBrush EmptyCell;
        
        internal System.Windows.Media.ImageBrush GreenCell;
        
        internal System.Windows.Media.ImageBrush RedCell;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/STPWPDemo;component/UsageControl.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.EmptyCell = ((System.Windows.Media.ImageBrush)(this.FindName("EmptyCell")));
            this.GreenCell = ((System.Windows.Media.ImageBrush)(this.FindName("GreenCell")));
            this.RedCell = ((System.Windows.Media.ImageBrush)(this.FindName("RedCell")));
        }
    }
}

