
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Xamarin.form.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            //LoadApplication(new Xamarin.form.App());
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
        
            MessageDialog message_dialog = new MessageDialog("当前还在运行，确定退出", "Message");
            message_dialog.Commands.Add(new UICommand("确定", cmd => { }, "退出"));
            message_dialog.Commands.Add(new UICommand("取消", cmd => { }));
            message_dialog.DefaultCommandIndex = 0;
            message_dialog.CancelCommandIndex = 1;
            IUICommand result = await message_dialog.ShowAsync();
        }
    }
}
