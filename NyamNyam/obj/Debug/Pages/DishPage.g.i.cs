﻿#pragma checksum "..\..\..\Pages\DishPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "36182AC02F24B6041AD71C77C8874072D0423BBB4A6031071B4C4B40F9582D26"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NyamNyam.Pages;
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


namespace NyamNyam.Pages {
    
    
    /// <summary>
    /// DishPage
    /// </summary>
    public partial class DishPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\DishPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CMBcategory;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\DishPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\DishPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderPrice;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\DishPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVDishes;
        
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
            System.Uri resourceLocater = new System.Uri("/NyamNyam;component/pages/dishpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DishPage.xaml"
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
            this.CMBcategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Pages\DishPage.xaml"
            this.CMBcategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CMBcategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBName = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\Pages\DishPage.xaml"
            this.TBName.SelectionChanged += new System.Windows.RoutedEventHandler(this.TBName_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SliderPrice = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.LVDishes = ((System.Windows.Controls.ListView)(target));
            
            #line 31 "..\..\..\Pages\DishPage.xaml"
            this.LVDishes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LVDishes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

