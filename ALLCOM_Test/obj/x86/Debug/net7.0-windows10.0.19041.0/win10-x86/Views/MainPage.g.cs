﻿#pragma checksum "C:\Users\80520\source\repos\ALLCOM_Test\ALLCOM_Test\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E943146E7DDF381786819C6C96E062B509BD15843E0FD3AF6B408689CE02F2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ALLCOM_Test.Views
{
    partial class MainPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_FrameworkElement_Tag(global::Microsoft.UI.Xaml.FrameworkElement obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Tag = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBox_Text(global::Microsoft.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj9_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::ALLCOM_Test.Views.DataListDatas dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj9;
            private global::Microsoft.UI.Xaml.Controls.AppBarButton obj10;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj11;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj9TagDisabled = false;
            private static bool isobj10TagDisabled = false;
            private static bool isobj11TextDisabled = false;

            public MainPage_obj9_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 44 && columnNumber == 108)
                {
                    isobj9TagDisabled = true;
                }
                else if (lineNumber == 52 && columnNumber == 37)
                {
                    isobj10TagDisabled = true;
                }
                else if (lineNumber == 61 && columnNumber == 44)
                {
                    isobj11TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9: // Views\MainPage.xaml line 44
                        this.obj9 = new global::System.WeakReference(global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target));
                        break;
                    case 10: // Views\MainPage.xaml line 51
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                        break;
                    case 11: // Views\MainPage.xaml line 61
                        this.obj11 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            public void DataContextChangedHandler(global::Microsoft.UI.Xaml.FrameworkElement sender, global::Microsoft.UI.Xaml.DataContextChangedEventArgs args)
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

            public int ProcessBindings(global::Microsoft.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
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
                        nextPhase = 1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj9.Target as global::Microsoft.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                    case 1:
                        global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ResumeRendering(this.obj11);
                        nextPhase = -1;
                        break;
                }
                this.Update_(global::WinRT.CastExtensions.As<global::ALLCOM_Test.Views.DataListDatas>(item), 1 << phase);
            }

            public void Recycle()
            {
                global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SuspendRendering(this.obj11);
            }

            // IMainPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::ALLCOM_Test.Views.DataListDatas>(newDataRoot);
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ALLCOM_Test.Views.DataListDatas obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ID(obj.ID, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0) | (1 << 1))) != 0)
                    {
                        this.Update_DataName(obj.DataName, phase);
                    }
                }
            }
            private void Update_ID(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MainPage.xaml line 44
                    if (!isobj9TagDisabled)
                    {
                        if ((this.obj9.Target as global::Microsoft.UI.Xaml.Controls.Grid) != null)
                        {
                            XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((this.obj9.Target as global::Microsoft.UI.Xaml.Controls.Grid), obj, null);
                        }
                    }
                    // Views\MainPage.xaml line 51
                    if (!isobj10TagDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag(this.obj10, obj, null);
                    }
                }
            }
            private void Update_DataName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 1) | NOT_PHASED )) != 0)
                {
                    // Views\MainPage.xaml line 61
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::ALLCOM_Test.Views.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj12;
            private global::Microsoft.UI.Xaml.Controls.TextBox obj15;
            private global::Microsoft.UI.Xaml.Controls.ListView obj18;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj12TagDisabled = false;
            private static bool isobj15TextDisabled = false;
            private static bool isobj18ItemsSourceDisabled = false;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 33 && columnNumber == 43)
                {
                    isobj12TagDisabled = true;
                }
                else if (lineNumber == 25 && columnNumber == 26)
                {
                    isobj15TextDisabled = true;
                }
                else if (lineNumber == 110 && columnNumber == 25)
                {
                    isobj18ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 12: // Views\MainPage.xaml line 33
                        this.obj12 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 15: // Views\MainPage.xaml line 25
                        this.obj15 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                        break;
                    case 18: // Views\MainPage.xaml line 105
                        this.obj18 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
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

            // IMainPage_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::ALLCOM_Test.Views.MainPage>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            private delegate void InvokeFunctionDelegate(int phase);
            private global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();

            private void Invoke_myColorPicker_Color_M_ToString_371857150(int phase)
            {
                global::System.String result = this.dataRoot.myColorPicker.Color.ToString();
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MainPage.xaml line 25
                    if (!isobj15TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBox_Text(this.obj15, result, null);
                    }
                }
            }

            private void CompleteUpdate(int phase)
            {
                var functions = this.PendingFunctionBindings;
                this.PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();
                foreach (var function in functions.Values)
                {
                    function.Invoke(phase);
                }
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ALLCOM_Test.Views.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_mainPage_Singleton(obj.mainPage_Singleton, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_myColorPicker(obj.myColorPicker, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_dateSource(obj.dateSource, phase);
                    }
                }
                this.CompleteUpdate(phase);
            }
            private void Update_mainPage_Singleton(global::ALLCOM_Test.Views.MainPage_Singleton obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_mainPage_Singleton_DataList_ID(obj.DataList_ID, phase);
                    }
                }
            }
            private void Update_mainPage_Singleton_DataList_ID(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MainPage.xaml line 33
                    if (!isobj12TagDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag(this.obj12, obj, null);
                    }
                }
            }
            private void Update_myColorPicker(global::Microsoft.UI.Xaml.Controls.ColorPicker obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_myColorPicker(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_myColorPicker_Color(obj.Color, phase);
                    }
                }
            }
            private void Update_myColorPicker_Color(global::Windows.UI.Color obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_myColorPicker_Color_M_ToString_371857150(phase);
                }
            }
            private void Update_myColorPicker_Color_M_ToString_371857150(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    if (!isobj15TextDisabled)
                    {
                        this.PendingFunctionBindings["myColorPicker_Color_M_ToString_371857150"] = new InvokeFunctionDelegate(this.Invoke_myColorPicker_Color_M_ToString_371857150); 
                    }
                }
            }
            private void Update_dateSource(global::System.Collections.ObjectModel.ObservableCollection<global::ALLCOM_Test.Views.DataListDatas> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\MainPage.xaml line 105
                    if (!isobj18ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj18, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj1_Bindings> weakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public MainPage_obj1_Bindings TryGetBindingObject()
                {
                    MainPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_myColorPicker(null);
                }

                public void DependencyPropertyChanged_myColorPicker_Color(global::Microsoft.UI.Xaml.DependencyObject sender, global::Microsoft.UI.Xaml.DependencyProperty prop)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Microsoft.UI.Xaml.Controls.ColorPicker obj = sender as global::Microsoft.UI.Xaml.Controls.ColorPicker;
                        if (obj != null)
                        {
                            bindings.Update_myColorPicker_Color(obj.Color, DATA_CHANGED);
                        }
                        bindings.CompleteUpdate(DATA_CHANGED);
                    }
                }
                private global::Microsoft.UI.Xaml.Controls.ColorPicker cache_myColorPicker = null;
                private long tokenDPC_myColorPicker_Color = 0;
                public void UpdateChildListeners_myColorPicker(global::Microsoft.UI.Xaml.Controls.ColorPicker obj)
                {
                    if (obj != cache_myColorPicker)
                    {
                        if (cache_myColorPicker != null)
                        {
                            cache_myColorPicker.UnregisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ColorPicker.ColorProperty, tokenDPC_myColorPicker_Color);
                            cache_myColorPicker = null;
                        }
                        if (obj != null)
                        {
                            cache_myColorPicker = obj;
                            tokenDPC_myColorPicker_Color = obj.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.ColorPicker.ColorProperty, DependencyPropertyChanged_myColorPicker_Color);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 66
                {
                    this.CommandBarFlyout1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBarFlyout>(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 68
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element3).Click += this.AppBarButton_Click;
                }
                break;
            case 4: // Views\MainPage.xaml line 71
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element4).Click += this.AppBarButton_Click;
                }
                break;
            case 5: // Views\MainPage.xaml line 72
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element5).Click += this.AppBarButton_Click;
                }
                break;
            case 6: // Views\MainPage.xaml line 75
                {
                    this.ResizeButton1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.ResizeButton1).Click += this.AppBarButton_Click;
                }
                break;
            case 7: // Views\MainPage.xaml line 76
                {
                    this.MoveButton1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.MoveButton1).Click += this.AppBarButton_Click;
                }
                break;
            case 9: // Views\MainPage.xaml line 44
                {
                    global::Microsoft.UI.Xaml.Controls.Grid element9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Grid)element9).ContextRequested += this.DataList_ContextRequested;
                    ((global::Microsoft.UI.Xaml.Controls.Grid)element9).ContextCanceled += this.DataList_ContextCanceled;
                }
                break;
            case 10: // Views\MainPage.xaml line 51
                {
                    global::Microsoft.UI.Xaml.Controls.AppBarButton element10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)element10).Click += this.HoverButton_Click;
                }
                break;
            case 13: // Views\MainPage.xaml line 34
                {
                    global::Microsoft.UI.Xaml.Controls.TextBox element13 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBox)element13).TextChanged += this.TextBox_TextChanged;
                }
                break;
            case 14: // Views\MainPage.xaml line 15
                {
                    this.myColorPicker = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ColorPicker>(target);
                }
                break;
            case 16: // Views\MainPage.xaml line 82
                {
                    this.ContentArea = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 17: // Views\MainPage.xaml line 169
                {
                    global::Microsoft.UI.Xaml.Controls.TabView element17 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TabView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TabView)element17).AddTabButtonClick += this.TabView_AddButtonClick;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)element17).TabCloseRequested += this.TabView_TabCloseRequested;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)element17).Loaded += this.TabView_Loaded;
                }
                break;
            case 18: // Views\MainPage.xaml line 105
                {
                    this.BaseExample = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\MainPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 9: // Views\MainPage.xaml line 44
                {                    
                    global::Microsoft.UI.Xaml.Controls.Grid element9 = (global::Microsoft.UI.Xaml.Controls.Grid)target;
                    MainPage_obj9_Bindings bindings = new MainPage_obj9_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element9.DataContext);
                    element9.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element9, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element9, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

