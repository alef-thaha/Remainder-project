﻿#pragma checksum "C:\Users\alef-pt4023\source\repos\App22\App22\RemainderPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "16F9B99BE215A5D7F293204E2D6FB3CA46310D1D5E6600C39D868F372726AC1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App22
{
    partial class RemainderPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class RemainderPage_obj5_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IRemainderPage_Bindings
        {
            private global::App22.Model.Remainder dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj8VisibilityDisabled = false;

            private RemainderPage_obj5_BindingsTracking bindingsTracking;

            public RemainderPage_obj5_Bindings()
            {
                this.bindingsTracking = new RemainderPage_obj5_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 148 && columnNumber == 44)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 151 && columnNumber == 40)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 151 && columnNumber == 75)
                {
                    isobj8VisibilityDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // RemainderPage.xaml line 133
                        this.obj5 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 7: // RemainderPage.xaml line 148
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // RemainderPage.xaml line 151
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj5.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::App22.Model.Remainder) item, 1 << phase);
            }

            public void Recycle()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IRemainderPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::App22.Model.Remainder)newDataRoot;
                    return true;
                }
                return false;
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::App22.Model.Remainder obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_RemainderDate(obj.RemainderDate, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ReminaderUser(obj.ReminaderUser, phase);
                    }
                }
            }
            private void Update_RemainderDate(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // RemainderPage.xaml line 148
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, (global::System.String)this.LookupConverter("DateTimetoString").Convert(obj, typeof(global::System.String), "{0:dd/MMM/yyyy hh:mm:ss tt}", null), null);
                    }
                }
            }
            private void Update_ReminaderUser(global::App22.Model.User obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ReminaderUser_Name(obj.Name, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // RemainderPage.xaml line 151
                    if (!isobj8VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj8, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("StringtoCollapse").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                    }
                }
            }
            private void Update_ReminaderUser_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // RemainderPage.xaml line 151
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class RemainderPage_obj5_BindingsTracking
            {
                private global::System.WeakReference<RemainderPage_obj5_Bindings> weakRefToBindingObj; 

                public RemainderPage_obj5_BindingsTracking(RemainderPage_obj5_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<RemainderPage_obj5_Bindings>(obj);
                }

                public RemainderPage_obj5_Bindings TryGetBindingObject()
                {
                    RemainderPage_obj5_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    RemainderPage_obj5_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::App22.Model.Remainder obj = sender as global::App22.Model.Remainder;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_RemainderDate(obj.RemainderDate, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "RemainderDate":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_RemainderDate(obj.RemainderDate, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::App22.Model.Remainder obj)
                {
                    RemainderPage_obj5_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class RemainderPage_obj26_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IRemainderPage_Bindings
        {
            private global::App22.Model.User dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj26;
            private global::Windows.UI.Xaml.Controls.TextBlock obj27;
            private global::Windows.UI.Xaml.Controls.TextBlock obj28;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj27TextDisabled = false;
            private static bool isobj28TextDisabled = false;

            public RemainderPage_obj26_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 81 && columnNumber == 60)
                {
                    isobj27TextDisabled = true;
                }
                else if (lineNumber == 82 && columnNumber == 60)
                {
                    isobj28TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 26: // RemainderPage.xaml line 79
                        this.obj26 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Border)target);
                        break;
                    case 27: // RemainderPage.xaml line 81
                        this.obj27 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 28: // RemainderPage.xaml line 82
                        this.obj28 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj26.Target as global::Windows.UI.Xaml.Controls.Border).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::App22.Model.User) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IRemainderPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::App22.Model.User)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::App22.Model.User obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Name(obj.Name, phase);
                        this.Update_Position(obj.Position, phase);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // RemainderPage.xaml line 81
                    if (!isobj27TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj27, obj, null);
                    }
                }
            }
            private void Update_Position(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // RemainderPage.xaml line 82
                    if (!isobj28TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj28, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class RemainderPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IRemainderPage_Bindings
        {
            private global::App22.RemainderPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj3;
            private global::Windows.UI.Xaml.Controls.ListView obj22;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3ItemsSourceDisabled = false;
            private static bool isobj22ItemsSourceDisabled = false;

            public RemainderPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 130 && columnNumber == 46)
                {
                    isobj3ItemsSourceDisabled = true;
                }
                else if (lineNumber == 76 && columnNumber == 39)
                {
                    isobj22ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // RemainderPage.xaml line 130
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 22: // RemainderPage.xaml line 76
                        this.obj22 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IRemainderPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::App22.RemainderPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::App22.RemainderPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Remainders(obj.Remainders, phase);
                        this.Update_Userfiltered(obj.Userfiltered, phase);
                    }
                }
            }
            private void Update_Remainders(global::System.Collections.ObjectModel.ObservableCollection<global::App22.Model.Remainder> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // RemainderPage.xaml line 130
                    if (!isobj3ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
                    }
                }
            }
            private void Update_Userfiltered(global::System.Collections.ObjectModel.ObservableCollection<global::App22.Model.User> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // RemainderPage.xaml line 76
                    if (!isobj22ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj22, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // RemainderPage.xaml line 110
                {
                    this.RemaindSplitview = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // RemainderPage.xaml line 130
                {
                    this.RemaindListview = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.RemaindListview).ItemClick += this.RemaindListview_ItemClick;
                }
                break;
            case 9: // RemainderPage.xaml line 113
                {
                    this.SplitviewTextbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // RemainderPage.xaml line 116
                {
                    this.SplitviewTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // RemainderPage.xaml line 119
                {
                    this.SplitCalendarview = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                }
                break;
            case 12: // RemainderPage.xaml line 120
                {
                    this.SplitTimePicker = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 13: // RemainderPage.xaml line 122
                {
                    this.SplitButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SplitButton).Click += this.SplitButton_Click;
                }
                break;
            case 14: // RemainderPage.xaml line 123
                {
                    this.SplitcancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SplitcancelButton).Click += this.SplitcancelButton_Click;
                }
                break;
            case 15: // RemainderPage.xaml line 43
                {
                    this.MytextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16: // RemainderPage.xaml line 44
                {
                    this.ClockButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 17: // RemainderPage.xaml line 60
                {
                    this.AtButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AtButton).Click += this.AtButton_Click;
                }
                break;
            case 18: // RemainderPage.xaml line 99
                {
                    this.SetButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SetButton).Click += this.SetButton_Click;
                }
                break;
            case 19: // RemainderPage.xaml line 63
                {
                    this.AtFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 20: // RemainderPage.xaml line 73
                {
                    this.Myuserbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Myuserbutton).Click += this.Myuserbutton_Click;
                }
                break;
            case 21: // RemainderPage.xaml line 74
                {
                    this.MyUserTextbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.MyUserTextbox).TextChanged += this.MyUserTextbox_TextChanged;
                }
                break;
            case 22: // RemainderPage.xaml line 76
                {
                    this.Mylistview = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 23: // RemainderPage.xaml line 90
                {
                    this.AtSaveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AtSaveButton).Click += this.AtSaveButton_Click;
                }
                break;
            case 24: // RemainderPage.xaml line 91
                {
                    this.AtCancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AtCancelButton).Click += this.AtCancelButton_Click;
                }
                break;
            case 29: // RemainderPage.xaml line 47
                {
                    this.ClockFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 30: // RemainderPage.xaml line 49
                {
                    this.Mycalenderview = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                }
                break;
            case 31: // RemainderPage.xaml line 50
                {
                    this.MyTimepicker = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 32: // RemainderPage.xaml line 52
                {
                    this.ClockSaveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ClockSaveButton).Click += this.ClockSaveButton_Click;
                }
                break;
            case 33: // RemainderPage.xaml line 53
                {
                    this.ClockCancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ClockCancelButton).Click += this.ClockCancelButton_Click;
                }
                break;
            case 34: // RemainderPage.xaml line 27
                {
                    this.Mytextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 35: // RemainderPage.xaml line 28
                {
                    this.MyCancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MyCancelButton).Click += this.MyCancelButton_Click;
                }
                break;
            case 36: // RemainderPage.xaml line 29
                {
                    this.FormeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.FormeButton).Click += this.FormeButton_Click;
                }
                break;
            case 37: // RemainderPage.xaml line 30
                {
                    this.AssignButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AssignButton).Click += this.AssignButton_Click;
                }
                break;
            case 38: // RemainderPage.xaml line 31
                {
                    this.MyChangeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MyChangeButton).Click += this.MyChangeButton_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // RemainderPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    RemainderPage_obj1_Bindings bindings = new RemainderPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 5: // RemainderPage.xaml line 133
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element5 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    RemainderPage_obj5_Bindings bindings = new RemainderPage_obj5_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element5.DataContext);
                    bindings.SetConverterLookupRoot(this);
                    element5.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element5, bindings);
                }
                break;
            case 26: // RemainderPage.xaml line 79
                {                    
                    global::Windows.UI.Xaml.Controls.Border element26 = (global::Windows.UI.Xaml.Controls.Border)target;
                    RemainderPage_obj26_Bindings bindings = new RemainderPage_obj26_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element26.DataContext);
                    element26.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element26, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element26, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

