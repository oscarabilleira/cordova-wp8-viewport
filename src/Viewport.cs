using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
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


using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Core;
using Windows.ApplicationModel;
using Microsoft.Phone.Tasks;


using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


    



    
    
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
            


var scaleFactor = DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
string width = Window.Current.Bounds.Width * scaleFactor;
string height= Window.Current.Bounds.Height * scaleFactor;

 
          var result = "{\"width\":\"" + width + "\",\"height\":\"" + height + "\"}";
          
          

            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, result));
        }
    }
}



