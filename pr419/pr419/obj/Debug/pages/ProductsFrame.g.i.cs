﻿#pragma checksum "..\..\..\pages\ProductsFrame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C5A14FA208AF3DD00675B97A598C286931E0A6116CFDD611FD0709B35C517C9E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using pr419.pages;


namespace pr419.pages {
    
    
    /// <summary>
    /// ProductsFrame
    /// </summary>
    public partial class ProductsFrame : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\pages\ProductsFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prev_page_btn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\pages\ProductsFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next_page_btn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\pages\ProductsFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_field;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\pages\ProductsFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filter_discont;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\pages\ProductsFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock count_products;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\pages\ProductsFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ProductsDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/pr419;component/pages/productsframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\ProductsFrame.xaml"
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
            this.prev_page_btn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\pages\ProductsFrame.xaml"
            this.prev_page_btn.Click += new System.Windows.RoutedEventHandler(this.prev_page_btn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.next_page_btn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\pages\ProductsFrame.xaml"
            this.next_page_btn.Click += new System.Windows.RoutedEventHandler(this.next_page_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.search_field = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\pages\ProductsFrame.xaml"
            this.search_field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.search_field_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.filter_discont = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\pages\ProductsFrame.xaml"
            this.filter_discont.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filter_discont_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.count_products = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ProductsDataGrid = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 45 "..\..\..\pages\ProductsFrame.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.add_product_to_order_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

