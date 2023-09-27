﻿using System.Collections.ObjectModel;
using ALLCOM_Test.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.VisualBasic;
using Windows.Foundation.Metadata;
using ICommand = System.Windows.Input.ICommand;
using System;
using System.Runtime.InteropServices;
using CommunityToolkit.WinUI.UI;
using Microsoft.Graphics.Canvas;
using Microsoft.UI.Xaml.Controls.Primitives;
using CommunityToolkit.Mvvm;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Xml.Linq;
using Windows.UI;
using Microsoft.UI;
//using System.Drawing;
//using Color = System.Drawing.Color;
//using SystemColors = System.Drawing.Color;

namespace ALLCOM_Test.Views;
/// <summary>
/// 单例模式的实现
/// </summary>
public class MainPage_Singleton : ObservableObject
{
    // 定义一个静态变量来保存类的实例
    private static MainPage_Singleton? uniqueInstance;

    // 定义一个标识确保线程同步
    private static readonly object locker = new();

    string _DataList_ID;
    public string DataList_ID
    {
        get => _DataList_ID;
        set => SetProperty(ref _DataList_ID, value);

    }

    // 定义私有构造函数，使外界不能创建该类实例
    private MainPage_Singleton()
    {
        DataList_ID = string.Empty;
    }

    /// <summary>
    /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
    /// </summary>
    /// <returns></returns>
    public static MainPage_Singleton GetInstance()
    {
        // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
        // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
        // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
        // 双重锁定只需要一句判断就可以了
        if (uniqueInstance == null)
        {
            lock (locker)
            {
                // 如果类的实例不存在则创建，否则直接返回
                uniqueInstance ??= new MainPage_Singleton();
            }
        }
        return uniqueInstance;
    }
}


public class DataListDatas : ObservableObject
{
    private string _DataName;
    public string DataName
    {
        get => _DataName;
        set => SetProperty(ref _DataName, value);
    }
    public string ID
    {
        get; private set;
    }
    private double _Data;
    public double Data
    {
        get => _Data;
        set => SetProperty(ref _Data, value);
    }
    private SolidColorBrush _DataColor;
    public SolidColorBrush DataColor
    {
        get => _DataColor;
        set => SetProperty(ref _DataColor, value);
    }
    public bool is_View
    {
        get; set;
    }
    public ICommand Command
    {
        get; set;
    }

    public DataListDatas(string dataName, double data, string id)
    {

        //DataColor = new SolidColorBrush(Colors.Salmon);
        DataColor = new SolidColorBrush(Colors.RoyalBlue);
        DataName = dataName;
        ID = id;
        Data = data;
        var deleteCommand = new StandardUICommand(StandardUICommandKind.Stop);
        // deleteCommand.ExecuteRequested += DeleteCommand_ExecuteRequested;
        Command = deleteCommand;
        is_View = true;
    }
    public DataListDatas(string dataName, double data, string id, Color color)
    {
        //DataColor = new SolidColorBrush(Colors.Salmon);
        DataColor = new SolidColorBrush(color);
        DataName = dataName;
        ID = id;
        Data = data;
        var deleteCommand = new StandardUICommand(StandardUICommandKind.Stop);
        // deleteCommand.ExecuteRequested += DeleteCommand_ExecuteRequested;
        Command = deleteCommand;
        is_View = true;
    }
    public bool is_equal(string id)
    {
        return ID == id; 
    }
}

// The ItemsSource for the ListView is generated by a method of the Contact class called
// GetContactsAsync().This method pulls data from an internal data source and creates
// Contact objects from that data. Those Contact objects are placed in a collection
// which is returned from the GetContactsAsync() function.

//BaseExample.ItemsSource = await Contact.GetContactsAsync();
public sealed partial class MainPage : Page
{
    public ObservableCollection<DataListDatas> dateSource = new(); //数据颜色
    public MainPage_Singleton mainPage_Singleton = MainPage_Singleton.GetInstance();
    public MainViewModel ViewModel
    {
        get;
    }







    Color ColorFromHSV(double hue, double saturation, double value)
    {
        double chroma = value * saturation;
        double huePrime = hue / 60.0;
        double x = chroma * (1 - Math.Abs(huePrime % 2 - 1));

        double red = 0, green = 0, blue = 0;

        if (huePrime >= 0 && huePrime <= 1)
        {
            red = chroma;
            green = x;
        }
        else if (huePrime > 1 && huePrime <= 2)
        {
            red = x;
            green = chroma;
        }
        else if (huePrime > 2 && huePrime <= 3)
        {
            green = chroma;
            blue = x;
        }
        else if (huePrime > 3 && huePrime <= 4)
        {
            green = x;
            blue = chroma;
        }
        else if (huePrime > 4 && huePrime <= 5)
        {
            red = x;
            blue = chroma;
        }
        else if (huePrime > 5 && huePrime <= 6)
        {
            red = chroma;
            blue = x;
        }

        double m = value - chroma;

        red += m;
        green += m;
        blue += m;

        byte redByte = (byte)(red * 255);
        byte greenByte = (byte)(green * 255);
        byte blueByte = (byte)(blue * 255);

        return Color.FromArgb(255, redByte, greenByte, blueByte);
    }

    public Color GenerateDistinctColor(int number)
    {
        if (number < 0 || number > 127)
        {
           number = 127;
        }

        double hue = (number * 2.83) % 360; // 将数字映射到色轮上

        return ColorFromHSV(hue, 1, 1);
    }






    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        for (int i = 0; i < 20; i++)
        {
            dateSource.Add(new DataListDatas("data"+ i.ToString(), 0, i.ToString()));
            dateSource[i].DataColor.Color = GenerateDistinctColor((i*78)%128);
        }

        InitializeComponent();
    }
    private void TabView_Loaded(object sender, RoutedEventArgs e)
    {
        for (int i = 0; i < 1; i++)
        {
            if (sender != null)
            {
                (sender as TabView).TabItems.Add(CreateNewTab(i));
            }
        }
    }

    private void TabView_AddButtonClick(TabView sender, object args)
    {
        sender.TabItems.Add(CreateNewTab(sender.TabItems.Count));
    }

    private void TabView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
    {
        sender.TabItems.Remove(args.Tab);
    }

    private TabViewItem CreateNewTab(int index)
    {
        TabViewItem newItem = new TabViewItem();

        newItem.Header = $"Document {index}";
        newItem.IconSource = new SymbolIconSource() { Symbol = Symbol.Document };

        // The content of the tab is often a frame that contains a page, though it could be any UIElement.
        Frame frame = new Frame();

        switch (index % 3)
        {
            case 0:
                frame.Navigate(typeof(MainCanvasPage));
                break;
            case 1:
                frame.Navigate(typeof(MainCanvasPage));
                break;
            case 2:
                frame.Navigate(typeof(MainCanvasPage));
                break;
        }

        newItem.Content = frame;

        return newItem;
    }

    private void HoverButton_Click(object sender, RoutedEventArgs e)
    {
        AppBarButton? button = sender as AppBarButton;
        Grid parent = button.FindParent<Grid>();
        foreach (var item in dateSource)
        {
            if (item.is_equal(parent.Tag as string) == true)
            {
                if (button != null)
                {
                    if (item.is_View == true)
                    {
                        FontIcon icon = new FontIcon();
                        icon.Glyph = "\uED1A";

                        button.Icon = icon;
                        item.is_View = false;
                    }
                    else
                    {
                        FontIcon icon = new FontIcon();
                        icon.Glyph = "\uE890";

                        button.Icon = icon;
                        item.is_View = true;
                    }

                }
            }
        }
    }

    private void ShowMenu(UIElement sender,bool isTransient )
    {
        FlyoutShowOptions myOption = new FlyoutShowOptions();
        myOption.ShowMode = isTransient ? FlyoutShowMode.Transient : FlyoutShowMode.Standard;
         CommandBarFlyout1.ShowAt(sender, myOption);
    }

    private void DataList_ContextRequested(UIElement sender, ContextRequestedEventArgs args)
    {
        Grid grid = sender as Grid;
        if (grid != null)
        {
            mainPage_Singleton.DataList_ID = grid.Tag as string;
            ShowMenu(sender, true);
        }
           
         
    }

    private void DataList_ContextCanceled(UIElement sender, RoutedEventArgs e)
    {
        // Show a context menu in transient mode
        // Focus will not move to the menu
       // ShowMenu(sender, true);
    }

    private void AppBarButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        var textBox = sender as TextBox;
        //textBox.Background = new SolidColorBrush(Colors.RoyalBlue);
        // string str = mainPage_Singleton.DataList_ID.ToString();
        if (textBox != null)
        {
            var str = textBox.Tag as string;
            dateSource[Convert.ToInt32(str)].DataName = textBox.Text;
        }
    }

    private void myColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
    {
        var str = sender.Tag as string;
        dateSource[Convert.ToInt32(str)].DataColor.Color = sender.Color;
        //dateSource[Convert.ToInt32(str)].DataColor = new SolidColorBrush(sender.Color);

    }

    private void ToggleMenuFlyoutItem_Click_Sort(object sender, RoutedEventArgs e)
    {
        
    }
    private void ToggleMenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
    {

    }
}
