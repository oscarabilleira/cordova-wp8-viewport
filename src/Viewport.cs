using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows;
using Windows.Graphics.Display;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Info;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;

using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

    



    
    
namespace Cordova.Extension.Commands
{
    /// <summary>
    /// </summary>
    public class Viewport: BaseCommand
    {
        /// <summary>
        /// </summary>
        public void getViewport(string options)
        {
        
         var content = Application.Current.Host.Content;

double scale = (double)content.ScaleFactor / 100;

int height = (int)Math.Ceiling(content.ActualHeight * scale);

int width = (int)Math.Ceiling(content.ActualWidth * scale);


    
          var result = "{\"width\":\"" + width + "\",\"height\":\"" + height + "\"}";

            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, result));
        }
    }
}



