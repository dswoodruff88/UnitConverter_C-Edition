﻿#pragma checksum "C:\Users\David\Documents\Development\UnitConverter_WindowsPhone7\Unit Converter\Unit Converter\UnitConverter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "48ACC61F46C11014ADD4865973DB4C72"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
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


namespace Unit_Converter {
    
    
    public partial class UnitConverter : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid TitleGrid;
        
        internal System.Windows.Controls.TextBlock textBlockPageTitle;
        
        internal System.Windows.Controls.TextBlock textBlockListTitle;
        
        internal System.Windows.Controls.Grid ContentGrid;
        
        internal System.Windows.Controls.TextBox convertFromBox;
        
        internal System.Windows.Controls.ListBox convertFromList;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.ListBox convertToList;
        
        internal System.Windows.Controls.TextBox convertToBox;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.Button convertButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Unit%20Converter;component/UnitConverter.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitleGrid = ((System.Windows.Controls.Grid)(this.FindName("TitleGrid")));
            this.textBlockPageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockPageTitle")));
            this.textBlockListTitle = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockListTitle")));
            this.ContentGrid = ((System.Windows.Controls.Grid)(this.FindName("ContentGrid")));
            this.convertFromBox = ((System.Windows.Controls.TextBox)(this.FindName("convertFromBox")));
            this.convertFromList = ((System.Windows.Controls.ListBox)(this.FindName("convertFromList")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.convertToList = ((System.Windows.Controls.ListBox)(this.FindName("convertToList")));
            this.convertToBox = ((System.Windows.Controls.TextBox)(this.FindName("convertToBox")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.convertButton = ((System.Windows.Controls.Button)(this.FindName("convertButton")));
        }
    }
}

