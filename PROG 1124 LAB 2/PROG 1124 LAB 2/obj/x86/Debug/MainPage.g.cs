﻿#pragma checksum "C:\Users\jpwax\source\repos\PROG 1124 LAB 2\PROG 1124 LAB 2\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "56918E3C25292503FEB95DC859FB8DE4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROG_1124_LAB_2
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 19
                {
                    this.titleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.titleTextBlock).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 3: // MainPage.xaml line 20
                {
                    this.inchesInputLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.inchesInputLabel).SelectionChanged += this.inchesInputLabel_SelectionChanged;
                }
                break;
            case 4: // MainPage.xaml line 21
                {
                    this.cmInputLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.cmInputLabel).SelectionChanged += this.inchesInputLabel_SelectionChanged;
                }
                break;
            case 5: // MainPage.xaml line 22
                {
                    this.inputInch = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.inputInch).TextChanged += this.inputInches_TextChanged;
                }
                break;
            case 6: // MainPage.xaml line 23
                {
                    this.inputCm = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.inputCm).TextChanged += this.inputCentimeter_TextChanged;
                }
                break;
            case 7: // MainPage.xaml line 24
                {
                    this.convertButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.convertButton).Click += this.convertButton_Click;
                }
                break;
            case 8: // MainPage.xaml line 29
                {
                    this.outputText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // MainPage.xaml line 30
                {
                    this.instructionText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 31
                {
                    this.footerText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

